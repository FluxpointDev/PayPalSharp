using System;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Invoices.Test
{
    [Collection("Invoices")]
    public class TemplateDeleteTest
    {
        public static async Task<HttpResponse> Delete(String id) 
        {
            TemplateDeleteRequest request = new TemplateDeleteRequest(id);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestTemplateDeleteRequest()
        {
            HttpResponse createResponse = await TemplateCreateTest.CreateTemplate();
            var template = createResponse.Result<Template>();

            HttpResponse deleteResponse = await Delete(template.TemplateId);
            Assert.Equal(204, (int) deleteResponse.StatusCode);
        }
    }
}
