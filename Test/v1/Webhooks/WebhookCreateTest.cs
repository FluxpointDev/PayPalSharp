using System;
using System.Text;
using System.Net.Http;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Webhooks.Test
{
    [Collection("Webhooks")]
    public class WebhookCreateTest
    {
        private static Webhook buildRequestBody()
        {
            var url = "https://example.com/" + new Random().Next( int.MinValue, int.MaxValue );
            var jsonContent = new StringContent("{ \"url\": \"" + url + "\", \"event_types\": [{ \"name\": \"PAYMENT.AUTHORIZATION.CREATED\" }, { \"name\": \"PAYMENT.AUTHORIZATION.VOIDED\" } ] }", Encoding.UTF8, "application/json");
            return (Webhook) new JsonSerializer().Decode(jsonContent, typeof(Webhook));
        }

        protected async static void DeleteAllWebhooks()
        {
            HttpResponse getAllResponse = await WebhookListTest.GetAllWebhooks();
            Assert.Equal(200, (int) getAllResponse.StatusCode);
            var webhooks = getAllResponse.Result<WebhookList>();
            foreach (Webhook template in webhooks.Webhooks)
            {
                try 
                {
                    await WebhookDeleteTest.DeleteWebhook(template.Id);
                } 
                catch (HttpException) {}
            }
        }

        public static async Task<HttpResponse> createWebhook() {
            WebhookCreateRequest request = new WebhookCreateRequest();
            request.RequestBody(buildRequestBody());
            try {
                return await TestHarness.client().Execute(request);
            } catch(HttpException ex) {
                if (System.Net.HttpStatusCode.BadRequest.Equals(ex.StatusCode) && ex.Message.Contains("WEBHOOK_NUMBER_LIMIT_EXCEEDED"))  
                 {
                     // Delete all Templates
                     DeleteAllWebhooks();
                     return await createWebhook();
                 }
                 else 
                 {
                     throw ex;
                 }
            }
        }

        [Fact]
        public async void TestWebhookCreateRequest()
        {
            HttpResponse response = await createWebhook();
            Assert.Equal(201, (int) response.StatusCode);
            Assert.NotNull(response.Result<Webhook>());
        }
    }
}
