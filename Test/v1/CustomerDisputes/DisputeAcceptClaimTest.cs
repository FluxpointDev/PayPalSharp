using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.CustomerDisputes.Test
{
    [Collection("Customer Disputes")]
    public class DisputeAcceptClaimTest
    {
        [Fact(Skip = "This test requires a dispute in the correct state.")]
        public async void TestDisputeAcceptClaimRequest()
        {
            AcceptClaimRequest acceptClaim = new AcceptClaimRequest() {
                Note = "Accepting claim"
            };
            DisputeAcceptClaimRequest request = new DisputeAcceptClaimRequest("PP-000-042-635-209");
            request.RequestBody(acceptClaim);

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal((int) response.StatusCode, 200);
            Assert.NotNull(response.Result<SubsequentActions>());
        }
    }
}
