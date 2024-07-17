using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Payments.Test
{
    [Collection("Payments")]
    public class AuthorizationGetTest
    {

        [Fact]
        public async void TestAuthorizationGetRequest()
        {
            var client = TestHarness.client();

            var paymentCreateReponse = await PaymentCreateTest.CreatePayment("authorize");
            var authId = paymentCreateReponse.Result<Payment>()
                .Transactions[0]
                .RelatedResources[0]
                .Authorization.Id;
            AuthorizationGetRequest request = new AuthorizationGetRequest(authId);

            HttpResponse response = await client.Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<Authorization>());
        }
    }
}
