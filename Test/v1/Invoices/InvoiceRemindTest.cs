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
    public class InvoiceRemindTest
    {
        private static Notification BuildRequestBody()
        {
            var jsonContent = new StringContent("{ \"subject\": \"Past due\", \"note\": \"Please pay soon\", \"send_to_merchant\": true }", Encoding.UTF8, "application/json");
            return (Notification) new JsonSerializer().Decode(jsonContent, typeof(Notification));
        }
        public static async Task<HttpResponse> RemindInvoice(String id) {
            InvoiceRemindRequest request = new InvoiceRemindRequest(id);
            request.RequestBody(BuildRequestBody());
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestInvoiceRemindRequest()
        {
            HttpResponse createResponse = await InvoiceCreateTest.CreateInvoice();
            var expected = createResponse.Result<Invoice>();

            HttpResponse sendResponse = await InvoiceSendTest.SendInvoice(expected.Id);
            Assert.Equal(202, (int) sendResponse.StatusCode);

            HttpResponse remindResponse = await RemindInvoice(expected.Id);
            Assert.Equal(202, (int) remindResponse.StatusCode);
        }
    }
}
