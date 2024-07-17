using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.BillingAgreements.Test
{
    [Collection("Billing Agreement")]
    public class AgreementUpdateTest
    {
        private List<JsonPatch<Agreement>> buildRequestBody()
        {
            var jsonContent = new StringContent("[ { \"op\": \"replace\", \"path\": \"/\", \"value\": { \"description\": \"Updated description.\", \"start_date\": \"2017-12-22T09:13:49Z\", \"shipping_address\": { \"line1\": \"Hotel Blue Diamond\", \"line2\": \"Church Street\", \"city\": \"San Jose\", \"state\": \"CA\", \"postal_code\": \"95112\", \"country_code\": \"US\" } } } ]", Encoding.UTF8, "application/json");
            return (List<JsonPatch<Agreement>>)new JsonSerializer().Decode(jsonContent, typeof(List<JsonPatch<Agreement>>));
        }

        [Fact(Skip = "This requires an executed agreement Id that is returned after manually approving the agreement on a web browser. This cannot be automated")]
        public async void TestAgreementUpdateRequest()
        {
            var executedAgreementId = "";

            //  Update
            AgreementUpdateRequest<Agreement> request = new AgreementUpdateRequest<Agreement>(executedAgreementId);
            request.RequestBody(buildRequestBody());

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int)response.StatusCode);
        }
    }
}
