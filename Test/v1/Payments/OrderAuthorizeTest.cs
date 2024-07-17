using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Payments.Test
{
    [Collection("Payments")]
    public class OrderAuthorizeTest
    {
        private Order buildRequestBody()
        {
            return new Order() 
            {
                Amount = new Amount()
                {
                    Currency = "USD",
                    Total = "10"
                }
            };
        }

        [Fact(Skip="Tests that use this class must be ignored when run in an automated environment because executing an order will require approval via the executed payment\'s approval_url")]
        public async void TestOrderAuthorizeRequest()
        {
            OrderAuthorizeRequest request = new OrderAuthorizeRequest(OrderGetTest.FAKE_ID);
            request.RequestBody(buildRequestBody());

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<Authorization>());
        }
    }
}
