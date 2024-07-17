using System.Text;
using System.Net.Http;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Invoices.Test
{
    [Collection("Invoices")]
    public class InvoiceCancelTest
    {
        private static CancelNotification BuildRequestBody()
        {
            var jsonContent = new StringContent("{ \"subject\": \"Invoice canceled\", \"note\": \"Canceling this invoice per your request.\"}", Encoding.UTF8, "application/json");
            return (CancelNotification) new JsonSerializer().Decode(jsonContent, typeof(CancelNotification));
        }

        public static async Task<HttpResponse> CancelInvoice(string id) {
            InvoiceCancelRequest request = new InvoiceCancelRequest(id);
            request.RequestBody(BuildRequestBody());

            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestInvoiceCancelRequest()
        {
            HttpResponse createResponse = await InvoiceCreateTest.CreateInvoice();
            var expected = createResponse.Result<Invoice>();

            HttpResponse sendResponse = await InvoiceSendTest.SendInvoice(expected.Id);
            Assert.Equal(202, (int) sendResponse.StatusCode);

            HttpResponse cancelResponse = await CancelInvoice(expected.Id);
            Assert.Equal(204, (int) cancelResponse.StatusCode);
        }
    }
}
