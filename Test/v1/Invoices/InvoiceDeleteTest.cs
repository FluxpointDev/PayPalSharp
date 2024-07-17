using System;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Invoices.Test
{
    [Collection("Invoices")]
    public class InvoiceDeleteTest
    {

        public static async Task<HttpResponse> DeleteInvoice(String id) {
            InvoiceDeleteRequest request = new InvoiceDeleteRequest(id);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestInvoiceDeleteRequest()
        {
            HttpResponse createResponse = await InvoiceCreateTest.CreateInvoice();
            var expected = createResponse.Result<Invoice>();

            HttpResponse deleteResponse = await DeleteInvoice(expected.Id);
            Assert.Equal(204, (int) deleteResponse.StatusCode);
        }
    }
}
