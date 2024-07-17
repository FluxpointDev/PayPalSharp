using System;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Invoices.Test
{
    [Collection("Invoices")]
    public class TemplateGetTest
    {

        public static async Task<HttpResponse> getTemplate(String id) {
            TemplateGetRequest request = new TemplateGetRequest(id);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestTemplateGetRequest()
        {
            HttpResponse createResponse = await TemplateCreateTest.CreateTemplate();
            var expected = createResponse.Result<Template>();

            HttpResponse getResponse = await getTemplate(expected.TemplateId);
            Assert.Equal(200, (int) getResponse.StatusCode);

            var actual = getResponse.Result<Template>();
            Assert.NotNull(actual);
            Assert.Equal(expected.TemplateId, actual.TemplateId);
            Assert.Equal("HOURS", actual.UnitOfMeasure);
        }
    }
}
