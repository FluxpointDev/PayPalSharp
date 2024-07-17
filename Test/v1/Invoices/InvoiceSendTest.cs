using System;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Invoices.Test
{
    [Collection("Invoices")]
    public class InvoiceSendTest
    {

        public static async Task<HttpResponse> SendInvoice(String id) {
            InvoiceSendRequest request = new InvoiceSendRequest(id);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestInvoiceSendRequest()
        {
            HttpResponse createResponse = await InvoiceCreateTest.CreateInvoice();
            var expected = createResponse.Result<Invoice>();

            HttpResponse sendResponse = await SendInvoice(expected.Id);
            Assert.Equal(202, (int) sendResponse.StatusCode);
        }
    }
}
