using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Vault.Test
{
    [Collection("Credit Card")]
    public class CreditCardUpdateTest
    {
        private List<JsonPatch<string>> buildRequestBody()
        {
            var jsonContent = new StringContent("[ { \"op\": \"replace\", \"path\": \"/billing_address/line1\", \"value\": \"53 N Main St.\" }]", Encoding.UTF8, "application/json");
            return (List<JsonPatch<string>>) new JsonSerializer().Decode(jsonContent, typeof(List<JsonPatch<string>>));
        }

        [Fact]
        public async void TestCreditCardUpdateRequest()
        {
            // Create
            HttpResponse createResponse = await CreditCardCreateTest.createCreditCard();
            var expected = createResponse.Result<CreditCard>();

            //  Update
            CreditCardUpdateRequest<string> request = new CreditCardUpdateRequest<string>(expected.Id);
            request.RequestBody(buildRequestBody());
                
            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);

            // Get
            HttpResponse getResponse = await CreditCardGetTest.getCreditCard(expected.Id);
            Assert.Equal(200, (int) getResponse.StatusCode);
            var updated = getResponse.Result<CreditCard>();
            Assert.NotNull(updated);
            Assert.Equal("53 N Main St.", updated.BillingAddress.Line1);
        }
    }
}
