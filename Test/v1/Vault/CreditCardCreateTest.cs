using System.Text;
using System.Net.Http;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Vault.Test
{
    [Collection("Credit Card")]
    public class CreditCardCreateTest
    {
        private static CreditCard buildRequestBody()
        {
            var jsonContent = new StringContent("{ \"number\": \"4417119669820331\", \"type\": \"visa\", \"expire_month\": 11, \"expire_year\": 2055, \"first_name\": \"Joe\", \"last_name\": \"Shopper\", \"billing_address\": { \"line1\": \"52 N Main St.\", \"city\": \"Johnstown\", \"country_code\": \"US\", \"postal_code\": \"43210\", \"state\": \"OH\", \"phone\": \"408-334-8890\" } }", Encoding.UTF8, "application/json");
            return (CreditCard) new JsonSerializer().Decode(jsonContent, typeof(CreditCard));
        }

        public static async Task<HttpResponse> createCreditCard() {
            CreditCardCreateRequest request = new CreditCardCreateRequest();
            request.RequestBody(buildRequestBody());

            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestCreditCardCreateRequest()
        {
            HttpResponse response = await createCreditCard();
            Assert.Equal(201, (int) response.StatusCode);
            Assert.NotNull(response.Result<CreditCard>());
        }
    }
}
