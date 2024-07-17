using System.Text;
using System.Net.Http;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Webhooks.Test
{
    [Collection("Webhooks")]
    public class SimulateEventTest
    {
        private static SimulateEvent buildRequestBody()
        {
            var jsonContent = new StringContent("{ \"url\": \"https://www.ebay.com/paypal_webhook\", \"event_type\": \"PAYMENT.AUTHORIZATION.CREATED\" }", Encoding.UTF8, "application/json");
            return (SimulateEvent) new JsonSerializer().Decode(jsonContent, typeof(SimulateEvent));
        }

        public static async Task<HttpResponse> simulateEvent() {
            SimulateEventRequest<object> request = new SimulateEventRequest<object>();
            request.RequestBody(buildRequestBody());

            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestSimulateEventRequest()
        {
            HttpResponse response = await simulateEvent();
            Assert.Equal(202, (int) response.StatusCode);
            Assert.NotNull(response.Result<Event<object>>());
            var simulatedEvent = response.Result<Event<object>>();
            Assert.Equal("PAYMENT.AUTHORIZATION.CREATED", simulatedEvent.EventType);
        }
    }
}
