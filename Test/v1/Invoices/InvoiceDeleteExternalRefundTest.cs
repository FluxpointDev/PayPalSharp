using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Invoices.Test
{
    [Collection("Invoices")]
    public class InvoiceDeleteExternalRefundTest
    {

        public static async Task<HttpResponse> DeleteExternalRefund(string id, string transactionId) {
            InvoiceDeleteExternalRefundRequest request = new InvoiceDeleteExternalRefundRequest(id, transactionId);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestInvoiceDeleteExternalRefundRequest()
        {
            HttpResponse createResponse = await InvoiceCreateTest.CreateInvoice();
            var expected = createResponse.Result<Invoice>();

            HttpResponse sendResponse = await InvoiceSendTest.SendInvoice(expected.Id);
            Assert.Equal(202, (int) sendResponse.StatusCode);

            HttpResponse paidResponse = await InvoiceRecordPaymentTest.RecordPayment(expected.Id);
            Assert.Equal(204, (int) paidResponse.StatusCode);

            HttpResponse refundResponse = await InvoiceRecordRefundTest.RefundPayment(expected.Id);
            Assert.Equal(204, (int) refundResponse.StatusCode);

            HttpResponse getResponse = await InvoiceGetTest.getInvoice(expected.Id);
            Assert.Equal(200, (int) getResponse.StatusCode);
            var invoice = getResponse.Result<Invoice>();

            Assert.NotNull(invoice.Refunds);
            Assert.True(invoice.Refunds.Count > 0);
            var refund = invoice.Refunds[invoice.Refunds.Count - 1];
            Assert.Equal("EXTERNAL", refund.Type);
            var transactionId = refund.TransactionId;

            HttpResponse deleteResponse = await DeleteExternalRefund(expected.Id, transactionId);
            Assert.Equal(204, (int) deleteResponse.StatusCode);
        }
    }
}
