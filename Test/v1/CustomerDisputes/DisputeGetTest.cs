using BraintreeHttp;
using Xunit;
using PayPal.Test;


namespace PayPal.v1.CustomerDisputes.Test
{
    [Collection("Customer Disputes")]
    public class DisputeGetTest
    {
        [Fact(Skip = "This test requires an active dispute.")]
        public async void TestDisputeGetRequest()
        {
            DisputeGetRequest request = new DisputeGetRequest("PP-000-042-636-306");

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal((int) response.StatusCode, 200);
            Assert.NotNull(response.Result<Dispute>());
            Assert.Equal("10.15", response.Result<Dispute>().DisputedTransactions[0].GrossAmount.Value);
            Assert.Equal("USD", response.Result<Dispute>().DisputedTransactions[0].GrossAmount.CurrencyCode);
            Assert.Equal("MERCHANDISE_OR_SERVICE_NOT_AS_DESCRIBED", response.Result<Dispute>().Reason);
        }
    }
}
