using BraintreeHttp;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Text.Json;
using System.Net.Http.Headers;

namespace PayPal.Core
{
    public class CustomHttpClient
    {
        protected Environment environment;

        private System.Net.Http.HttpClient client;

        private List<IInjector> injectors;

        public BraintreeHttp.Encoder Encoder { get; }

        private JsonSerializerOptions Serializer;

        public CustomHttpClient(Environment environment)
        {
            this.environment = environment;
            injectors = new List<IInjector>();
            Encoder = new BraintreeHttp.Encoder();
            client = new System.Net.Http.HttpClient();
            client.BaseAddress = new System.Uri(environment.BaseUrl());
            client.DefaultRequestHeaders.Add("User-Agent", GetUserAgent());

            Serializer = new JsonSerializerOptions
            {
                IncludeFields = true
            };
            Serializer.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseUpper));

        }

        protected virtual string GetUserAgent()
        {
            return "BraintreeHttp-Dotnet HTTP/1.1";
        }

        public void AddInjector(IInjector injector)
        {
            if (injector != null)
            {
                injectors.Add(injector);
            }
        }

        public void SetConnectTimeout(System.TimeSpan timeout)
        {
            client.Timeout = timeout;
        }

        private byte[] Gzip(string source)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(source);
            using MemoryStream memoryStream2 = new MemoryStream(bytes);
            using MemoryStream memoryStream = new MemoryStream();
            using (GZipStream destination = new GZipStream(memoryStream, CompressionMode.Compress))
            {
                memoryStream2.CopyTo(destination);
            }

            return memoryStream.ToArray();
        }

        private string Gunzip(byte[] source)
        {
            using MemoryStream stream = new MemoryStream(source);
            using MemoryStream memoryStream = new MemoryStream();
            using (GZipStream src = new GZipStream(stream, CompressionMode.Decompress))
            {
                CopyTo(src, memoryStream);
            }

            return Encoding.UTF8.GetString(memoryStream.ToArray());
        }

        private void CopyTo(Stream src, Stream dest)
        {
            byte[] array = new byte[4096];
            int count;
            while ((count = src.Read(array, 0, array.Length)) != 0)
            {
                dest.Write(array, 0, count);
            }
        }

        public virtual async Task<HttpResponse> Execute<T>(T req) where T : HttpRequest
        {
            T request = req.Clone<T>();
            foreach (IInjector injector in injectors)
            {
                injector.Inject(request);
            }

            request.RequestUri = new System.Uri(environment.BaseUrl() + request.Path);
            if (request.Body != null)
            {
                if (request.ContentType == "application/json")
                {
                    HttpContent httpContent = JsonContent.Create(request.Body, new MediaTypeHeaderValue(request.ContentType), Serializer);
                    if ("gzip".Equals(request.ContentEncoding))
                    {
                        string result = httpContent.ReadAsStringAsync().Result;
                        httpContent = new ByteArrayContent(Gzip(result));
                    }
                    request.Content = httpContent;
                }
                else
                    request.Content = Encoder.SerializeRequest(request);
            }

            HttpResponseMessage response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                object responseBody = null;
                if (response.Content.Headers.ContentType != null)
                {
                    System.DateTime Now = System.DateTime.Now;
                    if (response.Content.Headers.ContentType.MediaType == "application/json")
                    {
                        HttpContent content = response.Content;
                        string value = content.Headers.ContentEncoding.FirstOrDefault();
                        if ("gzip".Equals(value))
                        {
                            byte[] result = content.ReadAsByteArrayAsync().Result;
                            content = new StringContent(Gunzip(result), Encoding.UTF8);
                        }
                        responseBody = await content.ReadFromJsonAsync(req.ResponseType, Serializer);
                    }
                    else
                        responseBody = Encoder.DeserializeResponse(response.Content, req.ResponseType);


                    var TS = System.DateTime.Now - Now;
                    System.Console.WriteLine($"{TS.Seconds}:{TS.Milliseconds}:{TS.Ticks}");
                }

                return new HttpResponse(response.Headers, response.StatusCode, responseBody);
            }

            throw new HttpException(message: await response.Content.ReadAsStringAsync(), statusCode: response.StatusCode, headers: response.Headers);
        }
    }
}
