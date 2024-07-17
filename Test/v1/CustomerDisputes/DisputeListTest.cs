using BraintreeHttp;
using Xunit;
using PayPal.Test;


namespace PayPal.v1.CustomerDisputes.Test
{
    [Collection("Customer Disputes")]
    public class DisputeListTest
    {
        [Fact(Skip = "This test requires a sandbox account with active disputes.")]
        public async void TestDisputeListRequest()
        {
            DisputeListRequest request = new DisputeListRequest();

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal((int) response.StatusCode, 200);
            Assert.NotNull(response.Result<DisputeSearchResponse>());
            Assert.True(response.Result<DisputeSearchResponse>().Items.Count > 0);
        }
    }
}
