using BraintreeHttp;
using Xunit;
using PayPal.Test;


namespace PayPal.v1.CustomerDisputes.Test
{
    [Collection("Customer Disputes")]
    public class DisputeRequireEvidenceTest
    {
        [Fact(Skip = "This test requires a dispute in the correct state.")]
        public async void TestDisputeRequireEvidenceRequest()
        {
            DisputeRequireEvidenceRequest request = new DisputeRequireEvidenceRequest("PP-000-042-636-306");
            RequireEvidenceRequest body = new RequireEvidenceRequest() {
                Action = "SELLER_EVIDENCE"
            };
            request.RequestBody(body);

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<SubsequentActions>());
        }
    }
}
