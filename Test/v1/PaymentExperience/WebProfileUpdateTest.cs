using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.PaymentExperience.Test
{
    [Collection("Web Profile")]
    public class WebProfileUpdateTest
    {

        [Fact]
        public async void TestWebProfileUpdateRequest()
        {
            // Create
            HttpResponse createResponse = await WebProfileCreateTest.createWebProfile();
            var expected = createResponse.Result<WebProfile>();
            expected.FlowConfig.BankTxnPendingUrl = "https://updated.com";

            // Update
            WebProfileUpdateRequest request = new WebProfileUpdateRequest(expected.Id);
            request.RequestBody(expected);

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(204, (int) response.StatusCode);
            
            // Get
            HttpResponse getResponse = await WebProfileGetTest.getWebProfile(expected.Id);
            Assert.Equal(200, (int) getResponse.StatusCode);
            var updated = getResponse.Result<WebProfile>();
            Assert.NotNull(updated);
            Assert.Equal(expected.FlowConfig.BankTxnPendingUrl, updated.FlowConfig.BankTxnPendingUrl);
        }
    }
}
