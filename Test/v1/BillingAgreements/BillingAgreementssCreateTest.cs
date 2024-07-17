using System;
using System.Text;
using System.Net.Http;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;
using PayPal.v1.BillingPlans.Test;

namespace PayPal.v1.BillingAgreements.Test
{
    [Collection("Billing Agreement")]
    public class AgreementCreateTest
    {
        private static Agreement buildRequestBody(BillingPlans.Plan plan)
        {
            var date = DateTime.UtcNow.AddDays(1).ToString("yyyy-MM-ddTHH\\:mm\\:ssZ");
            var jsonContent = new StringContent("{ \"name\": \"Override Agreement\", \"description\": \"PayPal payment agreement that overrides merchant preferences and shipping fee and tax information.\", \"start_date\": \"" + date + "\", \"payer\": { \"payment_method\": \"paypal\", \"payer_info\": { \"email\": \"payer@example.com\" } }, \"plan\": { \"id\": \"" + plan.Id + "\" }, \"shipping_address\": { \"line1\": \"Hotel Staybridge\", \"line2\": \"Crooke Street\", \"city\": \"San Jose\", \"state\": \"CA\", \"postal_code\": \"95112\", \"country_code\": \"US\" }, \"override_merchant_preferences\": { \"setup_fee\": { \"value\": \"3\", \"currency\": \"USD\" }, \"return_url\": \"https://example.com/\", \"cancel_url\": \"https://example.com/cancel\", \"auto_bill_amount\": \"YES\", \"initial_fail_amount_action\": \"CONTINUE\", \"max_fail_attempts\": \"11\" } }", Encoding.UTF8, "application/json");
            return (Agreement)new JsonSerializer().Decode(jsonContent, typeof(Agreement));
        }

        public static async Task<HttpResponse> createAgreement()
        {
            HttpResponse activatePlanResponse = await PlanActivateTest.activateAndGetPlan();
            var plan = activatePlanResponse.Result<BillingPlans.Plan>();

            AgreementCreateRequest request = new AgreementCreateRequest();
            request.RequestBody(buildRequestBody(plan));

            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestAgreementCreateRequest()
        {
            HttpResponse response = await createAgreement();
            Assert.Equal(201, (int)response.StatusCode);
            Assert.NotNull(response.Result<Agreement>());
            var agreement = response.Result<Agreement>();
            Assert.NotNull(agreement.Plan);
            Assert.Equal("Override Agreement", agreement.Name);
            Assert.NotNull(agreement.Links);
            Assert.Equal(2, agreement.Links.Count);
        }
    }
}
