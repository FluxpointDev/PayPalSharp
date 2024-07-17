using System;
using System.Text;
using System.Net.Http;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Invoices.Test
{
    [Collection("Invoices")]
    public class TemplateUpdateTest
    {
        private static Template BuildRequestBody()
        {
            var templateName = "Test Template " + new Random().Next( int.MinValue, int.MaxValue );
            var jsonContent = new StringContent("{ \"name\": \"" + templateName +  "\", \"unit_of_measure\": \"HOURS\", \"template_data\": { \"items\": [{ \"name\": \"Nutri Bullet\", \"quantity\": 2, \"unit_price\": { \"currency\": \"USD\", \"value\": \"50.00\" } }], \"merchant_info\": { \"email\": \"team-dx-clients-facilitator@getbraintree.com\" }, \"tax_calculated_after_discount\": false, \"tax_inclusive\": false, \"note\": \"Updated Message\", \"logo_url\": \"https://pics.paypal.com/v1/images/redDot.jpeg\" }, \"settings\": [{ \"field_name\": \"items.date\", \"display_preference\": { \"hidden\": true } }, { \"field_name\": \"custom\", \"display_preference\": { \"hidden\": true } } ] }", Encoding.UTF8, "application/json");
            return (Template) new JsonSerializer().Decode(jsonContent, typeof(Template));
        }
        public static async Task<HttpResponse> Update(String id) {
            TemplateUpdateRequest request = new TemplateUpdateRequest(id);
            request.RequestBody(BuildRequestBody());
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestTemplateUpdateRequest()
        {
            HttpResponse createResponse = await TemplateCreateTest.CreateTemplate();
            var expected = createResponse.Result<Template>();

            HttpResponse updateResponse = await Update(expected.TemplateId);
            Assert.Equal(200, (int) updateResponse.StatusCode);

            var actual = updateResponse.Result<Template>();
            Assert.NotNull(actual);
            Assert.Equal(expected.TemplateId, actual.TemplateId);
            Assert.Equal("Updated Message", actual.TemplateData.Note);
        }
    }
}
