using System;
using System.Text;
using System.Net.Http;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Invoices.Test
{
    [Collection("Templates")]
    public class TemplateCreateTest
    {
        private static Template BuildRequestBody()
        {
            var templateName = "Test Template " + new Random().Next( int.MinValue, int.MaxValue );
            var jsonContent = new StringContent("{ \"name\": \"" + templateName + "\", \"unit_of_measure\": \"Hours\", \"template_data\": { \"items\": [{ \"name\": \"Nutri Bullet\", \"quantity\": 1, \"unit_price\": { \"currency\": \"USD\", \"value\": \"50.00\" } }], \"merchant_info\": { \"email\": \"team-dx-clients-facilitator@getbraintree.com\" }, \"tax_calculated_after_discount\": false, \"tax_inclusive\": false, \"note\": \"Thank you for your business.\", \"logo_url\": \"https://pics.paypal.com/v1/images/redDot.jpeg\", \"allow_tip\": true }, \"settings\": [{ \"field_name\": \"items.date\", \"display_preference\": { \"hidden\": true } }, { \"field_name\": \"custom\", \"display_preference\": { \"hidden\": true } } ] }", Encoding.UTF8, "application/json");
            return (Template) new JsonSerializer().Decode(jsonContent, typeof(Template));
        }

        protected async static void DeleteAllTemplates()
        {
            HttpResponse getAllResponse = await TemplateListTest.GetAllTemplates();
            Assert.Equal(200, (int) getAllResponse.StatusCode);
            var templates = getAllResponse.Result<TemplateList>();
            foreach (Template template in templates.Templates)
            {
                try 
                {
                    await TemplateDeleteTest.Delete(template.TemplateId);
                } 
                catch (HttpException) {}
            }
        }

        public static async Task<HttpResponse> CreateTemplate() 
        {
            TemplateCreateRequest request = new TemplateCreateRequest();
            request.RequestBody(BuildRequestBody());
            try {
            return await TestHarness.client().Execute(request);
            } catch (HttpException ex) {
                if (System.Net.HttpStatusCode.BadRequest.Equals(ex.StatusCode) && ex.Message.Contains("Exceed maximum number of templates"))  
                {
                    // Delete all Templates
                    DeleteAllTemplates();
                    return await CreateTemplate();
                }
                else 
                {
                    throw ex;
                }
            }
        }

        [Fact]
        public async void TestTemplateCreateRequest()
        {
            HttpResponse createResponse = await CreateTemplate();
            Assert.Equal(201, (int) createResponse.StatusCode);
            Assert.NotNull(createResponse.Result<Template>());
            var actual = createResponse.Result<Template>();
            Assert.Equal("HOURS", actual.UnitOfMeasure);
        }
    }
}
