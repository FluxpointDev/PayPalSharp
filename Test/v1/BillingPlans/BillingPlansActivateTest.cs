using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.BillingPlans.Test
{
    [Collection("Billing Plan")]
    public class PlanActivateTest
    {
        private static List<JsonPatch<Plan>> buildRequestBody()
        {
            var updates = new Plan()
            {
                State = "ACTIVE"
            };
            var patch = new JsonPatch<Plan>()
            {
                Op = "replace",
                Path = "/",
                Value = updates
            };
            return new List<JsonPatch<Plan>>() { patch };
        }

        public static async Task<HttpResponse> activateAndGetPlan()
        {
            // Create
            HttpResponse createResponse = await PlanCreateTest.createPlan();
            var expected = createResponse.Result<Plan>();

            //  Update
            PlanUpdateRequest<Plan> request = new PlanUpdateRequest<Plan>(expected.Id);
            request.RequestBody(buildRequestBody());

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int)response.StatusCode);

            // Get
            HttpResponse getResponse = await PlanGetTest.getPlan(expected.Id);
            Assert.Equal(200, (int)getResponse.StatusCode);
            return getResponse;
        }

        [Fact]
        public async void TestPlanActivate()
        {
            HttpResponse activateResponse = await activateAndGetPlan();

            var updated = activateResponse.Result<Plan>();
            Assert.NotNull(updated);
            Assert.Equal("ACTIVE", updated.State);
        }
    }
}
