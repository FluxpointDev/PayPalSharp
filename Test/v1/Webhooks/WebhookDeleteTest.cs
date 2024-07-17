using System;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Webhooks.Test
{
    [Collection("Webhooks")]
    public class WebhookDeleteTest
    {
        public static async Task<HttpResponse> DeleteWebhook(String id) {
            WebhookDeleteRequest request = new WebhookDeleteRequest(id);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestWebhookDeleteRequest()
        {
            HttpResponse createResponse = await WebhookCreateTest.createWebhook();
            var expected = createResponse.Result<Webhook>();

            HttpResponse response = await DeleteWebhook(expected.Id);
            Assert.Equal(204, (int) response.StatusCode);
        }
    }
}
