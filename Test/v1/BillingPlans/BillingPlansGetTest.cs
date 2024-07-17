using System;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.BillingPlans.Test
{
    [Collection("Billing Plan")]
    public class PlanGetTest
    {

        public static async Task<HttpResponse> getPlan(String id) {
            PlanGetRequest request = new PlanGetRequest(id);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestPlanGetRequest()
        {
            HttpResponse createResponse = await PlanCreateTest.createPlan();
            var expected = createResponse.Result<Plan>();

            HttpResponse response = await getPlan(expected.Id);

            Assert.Equal(200, (int) response.StatusCode);
            var plan = response.Result<Plan>();
            Assert.NotNull(plan);
            Assert.Equal(expected.Id, plan.Id);
            Assert.Equal("T-Shirt of the Month Club Plan", plan.Name);
        }
    }
}
