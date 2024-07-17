using System.Text;
using System.Net.Http;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Invoices.Test
{
    [Collection("Invoices")]
    public class InvoiceRecordRefundTest
    {
        private static RefundDetail BuildRequestBody()
        {
            var jsonContent = new StringContent("{ \"date\": \"2019-11-06 03:30:00 PST\", \"note\": \"I refunded by cash!\", \"amount\": { \"currency\": \"USD\", \"value\": \"20.00\" } }", Encoding.UTF8, "application/json");
            return (RefundDetail) new JsonSerializer().Decode(jsonContent, typeof(RefundDetail));
        }

        public static async Task<HttpResponse> RefundPayment(string id) {
            InvoiceRecordRefundRequest request = new InvoiceRecordRefundRequest(id);
            request.RequestBody(BuildRequestBody());

            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestInvoiceRecordRefundRequest()
        {
            HttpResponse createResponse = await InvoiceCreateTest.CreateInvoice();
            var expected = createResponse.Result<Invoice>();

            HttpResponse sendResponse = await InvoiceSendTest.SendInvoice(expected.Id);
            Assert.Equal(202, (int) sendResponse.StatusCode);

            HttpResponse paidResponse = await InvoiceRecordPaymentTest.RecordPayment(expected.Id);
            Assert.Equal(204, (int) paidResponse.StatusCode);

            HttpResponse refundResponse = await RefundPayment(expected.Id);
            Assert.Equal(204, (int) refundResponse.StatusCode);
        }
    }
}
