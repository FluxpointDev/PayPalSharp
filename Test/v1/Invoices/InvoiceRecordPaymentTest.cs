using System.Text;
using System.Net.Http;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Invoices.Test
{
    [Collection("Invoices")]
    public class InvoiceRecordPaymentTest
    {
        private static PaymentDetail BuildRequestBody()
        {
            var jsonContent = new StringContent("{ \"method\": \"CASH\", \"date\": \"2019-11-06 03:30:00 PST\", \"note\": \"I got the payment by cash!\", \"amount\": { \"currency\": \"USD\", \"value\": \"20.00\" } }", Encoding.UTF8, "application/json");
            return (PaymentDetail) new JsonSerializer().Decode(jsonContent, typeof(PaymentDetail));
        }

        public static async Task<HttpResponse> RecordPayment(string id) {
            InvoiceRecordPaymentRequest request = new InvoiceRecordPaymentRequest(id);
            request.RequestBody(BuildRequestBody());

            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestInvoiceRecordRequest()
        {
            HttpResponse createResponse = await InvoiceCreateTest.CreateInvoice();
            var expected = createResponse.Result<Invoice>();

            HttpResponse sendResponse = await InvoiceSendTest.SendInvoice(expected.Id);
            Assert.Equal(202, (int) sendResponse.StatusCode);

            HttpResponse recordPaymentResponse = await RecordPayment(expected.Id);
            Assert.Equal(204, (int) recordPaymentResponse.StatusCode);
        }
    }
}
