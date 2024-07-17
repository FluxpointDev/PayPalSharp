using System.Threading.Tasks;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Payments.Test
{
    [Collection("Payments")]
    public class AuthorizationCaptureTest
    {
        private static Capture buildRequestBody()
        {
            return new Capture() 
            {
                Amount = new Amount()
                {
                    Total = "10",
                    Currency = "USD"
                },
                IsFinalCapture = true
            };
        }

        public async static Task<HttpResponse> CreateAuthCapture()
        {
            var client = TestHarness.client();
            var createResponse = await PaymentCreateTest.CreatePayment("authorize");
            var authId = createResponse.Result<Payment>()
                .Transactions[0]
                .RelatedResources[0]
                .Authorization.Id;
            var request = new AuthorizationCaptureRequest(authId);

            request.RequestBody(buildRequestBody());

            return await client.Execute(request);
        }

        [Fact]
        public async void TestAuthorizationCaptureRequest()
        {
            var response = await CreateAuthCapture();

            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<Capture>());
        }
    }
}
