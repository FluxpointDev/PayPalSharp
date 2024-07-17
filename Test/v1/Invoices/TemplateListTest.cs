using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Invoices.Test
{
    [Collection("Invoices")]
    public class TemplateListTest
    {
        public static async Task<HttpResponse> GetAllTemplates() 
        {
            TemplateListRequest request = new TemplateListRequest();
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestTemplateListRequest()
        {
            HttpResponse createResponse = await TemplateCreateTest.CreateTemplate();

            TemplateListRequest request = new TemplateListRequest();
            HttpResponse listResponse = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) listResponse.StatusCode);
            Assert.NotNull(listResponse.Result<TemplateList>());
            var templates = listResponse.Result<TemplateList>();
            Assert.NotNull(templates.Templates);
        }
    }
}
