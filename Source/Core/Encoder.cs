using BraintreeHttp;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Text.Json;

namespace PayPal.Core
{
    public class CustomEncoder
    {
        private List<ISerializer> serializers;

        public CustomEncoder()
        {
            serializers = new List<ISerializer>();
            RegisterSerializer(new CustomJsonSerizalize());
            RegisterSerializer(new TextSerializer());
            RegisterSerializer(new MultipartSerializer());
            RegisterSerializer(new FormEncodedSerializer());
        }

        public void RegisterSerializer(ISerializer serializer)
        {
            if (serializer != null)
            {
                serializers.Add(serializer);
            }
        }

        public HttpContent SerializeRequest(HttpRequest request)
        {
            if (request.ContentType == null)
            {
                throw new IOException("HttpRequest did not have content-type header set");
            }

            ISerializer serializer = GetSerializer(request.ContentType);
            if (serializer == null)
            {
                throw new IOException($"Unable to serialize request with Content-Type {request.ContentType}. Supported encodings are {GetSupportedContentTypes()}");
            }

            System.Console.WriteLine("CUSTOM: " + serializer.GetType().Name);

            if (serializer is CustomJsonSerizalize)
            {
                System.Console.WriteLine("GOT CUSTOM JSON");
            }

            HttpContent httpContent = serializer.Encode(request);
            if ("gzip".Equals(request.ContentEncoding))
            {
                string result = httpContent.ReadAsStringAsync().Result;
                httpContent = new ByteArrayContent(Gzip(result));
            }

            return httpContent;
        }

        public object DeserializeResponse(HttpContent content, System.Type responseType)
        {
            if (content.Headers.ContentType == null)
            {
                throw new IOException("HTTP response did not have content-type header set");
            }

            string text = content.Headers.ContentType.ToString();
            ISerializer serializer = GetSerializer(text);
            if (serializer == null)
            {
                throw new IOException($"Unable to deserialize response with Content-Type {text}. Supported encodings are {GetSupportedContentTypes()}");
            }

            string value = content.Headers.ContentEncoding.FirstOrDefault();
            if ("gzip".Equals(value))
            {
                byte[] result = content.ReadAsByteArrayAsync().Result;
                content = new StringContent(Gunzip(result), Encoding.UTF8);
            }

            

            return serializer.Decode(content, responseType);
        }

        private ISerializer GetSerializer(string contentType)
        {
            foreach (ISerializer serializer in serializers)
            {
                Regex regex = new Regex(serializer.GetContentTypeRegexPattern());
                if (regex.Match(contentType).Success)
                {
                    return serializer;
                }
            }

            return null;
        }

        private string GetSupportedContentTypes()
        {
            List<string> list = new List<string>();
            foreach (ISerializer serializer in serializers)
            {
                list.Add(serializer.GetContentTypeRegexPattern());
            }

            return string.Join(", ", list);
        }

        private static byte[] Gzip(string source)
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

        public static string Gunzip(byte[] source)
        {
            using MemoryStream stream = new MemoryStream(source);
            using MemoryStream memoryStream = new MemoryStream();
            using (GZipStream src = new GZipStream(stream, CompressionMode.Decompress))
            {
                CopyTo(src, memoryStream);
            }

            return Encoding.UTF8.GetString(memoryStream.ToArray());
        }

        private static void CopyTo(Stream src, Stream dest)
        {
            byte[] array = new byte[4096];
            int count;
            while ((count = src.Read(array, 0, array.Length)) != 0)
            {
                dest.Write(array, 0, count);
            }
        }
    }

    public class CustomHttpClient
    {
        protected Environment environment;

        private System.Net.Http.HttpClient client;

        private List<IInjector> injectors;

        public CustomEncoder Encoder { get; }

        public CustomHttpClient(Environment environment)
        {
            this.environment = environment;
            injectors = new List<IInjector>();
            Encoder = new CustomEncoder();
            client = new System.Net.Http.HttpClient();
            client.BaseAddress = new System.Uri(environment.BaseUrl());
            client.DefaultRequestHeaders.Add("User-Agent", GetUserAgent());
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
                request.Content = Encoder.SerializeRequest(request);
            }

            HttpResponseMessage response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                object responseBody = null;
                if (response.Content.Headers.ContentType != null)
                {
                    System.Console.WriteLine("Type: " + response.Content.Headers.ContentType.MediaType);
                    System.DateTime Now = System.DateTime.Now;
                    if (response.Content.Headers.ContentType.MediaType == "application/json")
                    {
                        HttpContent content = response.Content;
                        string value = content.Headers.ContentEncoding.FirstOrDefault();
                        if ("gzip".Equals(value))
                        {
                            byte[] result = content.ReadAsByteArrayAsync().Result;
                            content = new StringContent(CustomEncoder.Gunzip(result), Encoding.UTF8);
                        }
                        responseBody =  await content.ReadFromJsonAsync(req.ResponseType, new JsonSerializerOptions
                        {
                            IncludeFields = true,
                        });
                    }
                    


                    var TS = System.DateTime.Now - Now;
                    System.Console.WriteLine($"{TS.Seconds}:{TS.Milliseconds}:{TS.Ticks}");
                }

                return new HttpResponse(response.Headers, response.StatusCode, responseBody);
            }

            throw new HttpException(message: await response.Content.ReadAsStringAsync(), statusCode: response.StatusCode, headers: response.Headers);
        }
    }
}
