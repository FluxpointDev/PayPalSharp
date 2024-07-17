using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.BillingPlans.Test
{
    [Collection("Billing Plan")]
    public class PlanUpdateTest
    {
        private List<JsonPatch<MerchantPreferences>> buildRequestBody()
        {
            var jsonContent = new StringContent("[ { \"op\": \"replace\", \"path\": \"/merchant-preferences\", \"value\": { \"cancel_url\": \"http://www.cancel.com\", \"setup_fee\": { \"value\": \"5\", \"currency\": \"USD\" } } } ]", Encoding.UTF8, "application/json");
            return (List<JsonPatch<MerchantPreferences>>) new JsonSerializer().Decode(jsonContent, typeof(List<JsonPatch<MerchantPreferences>>));
        }

        [Fact]
        public async void TestPlanUpdateRequest()
        {
            // Create
            HttpResponse createResponse = await PlanCreateTest.createPlan();
            var expected = createResponse.Result<Plan>();

            //  Update
            PlanUpdateRequest<MerchantPreferences> request = new PlanUpdateRequest<MerchantPreferences>(expected.Id);
            request.RequestBody(buildRequestBody());
                
            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);

            // Get
            HttpResponse getResponse = await PlanGetTest.getPlan(expected.Id);
            Assert.Equal(200, (int) getResponse.StatusCode);
            var updated = getResponse.Result<Plan>();
            Assert.NotNull(updated);
            Assert.Equal("5", updated.MerchantPreferences.SetupFee.Value);
            Assert.Equal("USD", updated.MerchantPreferences.SetupFee.CurrencyCode);
            Assert.Equal("http://www.cancel.com", updated.MerchantPreferences.CancelUrl);
        }
    }
}
