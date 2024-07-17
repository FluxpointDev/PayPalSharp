using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Webhooks.Test
{
    [Collection("Webhooks")]
    public class WebhookListTest
    {

        public static async Task<HttpResponse>  GetAllWebhooks()
        {
            WebhookListRequest request = new WebhookListRequest();
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestWebhookListRequest()
        {
            HttpResponse createResponse = await WebhookCreateTest.createWebhook();
            var response = await GetAllWebhooks();
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<WebhookList>());
        }
    }
}
