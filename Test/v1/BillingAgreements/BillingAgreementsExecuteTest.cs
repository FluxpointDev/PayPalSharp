using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.BillingAgreements.Test
{
    [Collection("Billing Agreement")]
    public class AgreementExecuteTest
    {

        [Fact(Skip = "This test requries an browser based customer's approval, which cannot be automated.")]
        public async void TestAgreementExecuteRequest()
        {
            var token = "EC-7A053355TB735301T"; // This will be returned as a url param when paypal redirect the user after giving us the approval.

            AgreementExecuteRequest request = new AgreementExecuteRequest(token);
            // NOTE: There is a known bug where this endpoint requires an empty JSON body.
            request.Body = "{}";

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int)response.StatusCode);
            Assert.NotNull(response.Result<Agreement>());
            var activatedAgreement = response.Result<Agreement>();
            Assert.NotNull(activatedAgreement.Id);
            Assert.Equal("Active", activatedAgreement.State);
        }
    }
}
