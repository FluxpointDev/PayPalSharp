using System;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Invoices.Test
{
    [Collection("Invoices")]
    public class InvoiceGetTest
    {

        public static async Task<HttpResponse> getInvoice(String id) {
            InvoiceGetRequest request = new InvoiceGetRequest(id);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestInvoiceGetRequest()
        {
            HttpResponse createResponse = await InvoiceCreateTest.CreateInvoice();
            var expected = createResponse.Result<Invoice>();

            HttpResponse getResponse = await getInvoice(expected.Id);

            Assert.Equal(200, (int) getResponse.StatusCode);
            var actual = getResponse.Result<Invoice>();
            Assert.NotNull(actual);
            Assert.Equal(expected.Id, actual.Id);
            Assert.Equal("Dennis", actual.MerchantInfo.FirstName);
        }
    }
}
