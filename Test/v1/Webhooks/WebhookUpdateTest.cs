using System;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Webhooks.Test
{
    [Collection("Webhooks")]
    public class WebhookUpdateTest
    {
        private List<JsonPatch<string>> buildRequestBody(string url)
        {
            var jsonContent = new StringContent("[ { \"op\": \"replace\", \"path\": \"/url\", \"value\": \"" + url + "\" } ]", Encoding.UTF8, "application/json");
            return (List<JsonPatch<string>>) new JsonSerializer().Decode(jsonContent, typeof(List<JsonPatch<string>>));
        }

        [Fact]
        public async void TestWebhookUpdateRequest()
        {
            // Create
            HttpResponse createResponse = await WebhookCreateTest.createWebhook();
            var expected = createResponse.Result<Webhook>();

            //  Update
            var url = "https://example.com/" + new Random().Next( int.MinValue, int.MaxValue );
            WebhookUpdateRequest<string> request = new WebhookUpdateRequest<string>(expected.Id);
            request.RequestBody(buildRequestBody(url));
                
            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);

            // Get
            HttpResponse getResponse = await WebhookGetTest.getWebhook(expected.Id);
            Assert.Equal(200, (int) getResponse.StatusCode);
            var updated = getResponse.Result<Webhook>();
            Assert.NotNull(updated);
            Assert.Equal(url, updated.Url);
        }
    }
}
