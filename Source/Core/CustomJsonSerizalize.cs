using BraintreeHttp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PayPal.Core
{
    public class CustomJsonSerizalize : ISerializer
    {
        public string GetContentTypeRegexPattern()
        {
            return "application/json";
        }

        public object Decode(HttpContent content, Type responseType)
        {
            DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(responseType);
            string result = content.ReadAsStringAsync().Result;
            using MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(result));
            return dataContractJsonSerializer.ReadObject(stream);
        }

        public HttpContent Encode(HttpRequest request)
        {
            DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(request.Body.GetType());
            using MemoryStream memoryStream = new MemoryStream();
            dataContractJsonSerializer.WriteObject(memoryStream, request.Body);
            memoryStream.Position = 0L;
            using StreamReader streamReader = new StreamReader(memoryStream);
            return new StringContent(streamReader.ReadToEnd(), Encoding.UTF8, "application/json");
        }
    }
}
