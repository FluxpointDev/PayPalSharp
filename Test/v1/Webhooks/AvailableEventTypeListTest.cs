using BraintreeHttp;
using Xunit;
using PayPal.Test;


namespace PayPal.v1.Webhooks.Test
{
    [Collection("Webhooks")]
    public class AvailableEventTypeListTest
    {

        [Fact]
        public async void TestAvailableEventTypeListRequest()
        {
            AvailableEventTypeListRequest request = new AvailableEventTypeListRequest();

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<EventTypeList>());

            // Add your own checks here
        }
    }
}
