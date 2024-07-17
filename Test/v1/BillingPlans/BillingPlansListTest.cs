using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.BillingPlans.Test
{
    [Collection("Billing Plan")]
    public class PlanListTest
    {

        [Fact]
        public async void TestPlanListRequest()
        {
            HttpResponse createResponse = await PlanCreateTest.createPlan();
            PlanListRequest request = new PlanListRequest();

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<PlanList>());
        }
    }
}
