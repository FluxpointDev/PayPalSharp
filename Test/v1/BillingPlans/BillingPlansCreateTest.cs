using System.Text;
using System.Net.Http;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.BillingPlans.Test
{
    [Collection("Billing Plan")]
    public class PlanCreateTest
    {
        private static Plan buildRequestBody()
        {
            var jsonContent = new StringContent("{ \"payment_definitions\": [ { \"amount\": { \"value\": \"100\", \"currency\": \"USD\" }, \"frequency\": \"MONTH\", \"cycles\": \"12\", \"frequency_interval\": \"2\", \"type\": \"REGULAR\", \"name\": \"Regular Payments\", \"charge_models\": [ { \"type\": \"SHIPPING\", \"amount\": { \"value\": \"10\", \"currency\": \"USD\" } }, { \"type\": \"TAX\", \"amount\": { \"value\": \"12\", \"currency\": \"USD\" } } ] } ], \"merchant_preferences\": { \"return_url\": \"http://localhost:3000/subscription/success\", \"cancel_url\": \"http://localhost:3000/subscription/cancel\" }, \"name\": \"T-Shirt of the Month Club Plan\", \"description\": \"Template creation.\", \"type\": \"fixed\" }", Encoding.UTF8, "application/json");
            return (Plan) new JsonSerializer().Decode(jsonContent, typeof(Plan));
        }

        public static async Task<HttpResponse> createPlan() {
            PlanCreateRequest request = new PlanCreateRequest();
            request.RequestBody(buildRequestBody());

            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestPlanCreateRequest()
        {
            HttpResponse response = await createPlan();
            Assert.Equal(201, (int) response.StatusCode);
            Assert.NotNull(response.Result<Plan>());
            var plan = response.Result<Plan>();
            Assert.Equal("CREATED", plan.State);
            Assert.NotNull(plan.Id);
            Assert.Equal("T-Shirt of the Month Club Plan", plan.Name);
        }
    }
}
