using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Payments.Test
{
    [Collection("Payments")]
    public class AuthorizationVoidTest
    {

        [Fact(Skip="Tests that use this class must be ignored when run in an automated environment because executing an authorization will require approval via the executed payment\'s approval_url")] 
        public async void TestAuthorizationVoidRequest()
        {
            var paymentCreateResponse = await PaymentCreateTest.CreatePayment("authorize");

            var authId = paymentCreateResponse.Result<Payment>()
                .Transactions[0]
                .RelatedResources[0]
                .Authorization
                .Id;

            var request = new AuthorizationVoidRequest(authId);
            HttpResponse response = await TestHarness.client().Execute(request);

            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<Authorization>());
        }
    }
}
