using System;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Webhooks.Test
{
    [Collection("Webhooks")]
    public class WebhookGetTest
    {

        public static async Task<HttpResponse> getWebhook(String id) {
            WebhookGetRequest request = new WebhookGetRequest(id);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestWebhookGetRequest()
        {
            HttpResponse createResponse = await WebhookCreateTest.createWebhook();
            var expected = createResponse.Result<Webhook>();

            HttpResponse response = await getWebhook(expected.Id);

            Assert.Equal(200, (int) response.StatusCode);
            var webhook = response.Result<Webhook>();
            Assert.NotNull(webhook);
            Assert.Equal(expected.Id, webhook.Id);
            Assert.Equal("PAYMENT.AUTHORIZATION.CREATED", webhook.EventTypes[0].Name);
        }
    }
}
