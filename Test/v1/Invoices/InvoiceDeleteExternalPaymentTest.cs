using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Invoices.Test
{
    [Collection("Invoices")]
    public class InvoiceDeleteExternalPaymentTest
    {

        public static async Task<HttpResponse> DeleteExternalPayment(string id, string transactionId) {
            InvoiceDeleteExternalPaymentRequest request = new InvoiceDeleteExternalPaymentRequest(id, transactionId);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestInvoiceDeleteExternalPaymentRequest()
        {
            HttpResponse createResponse = await InvoiceCreateTest.CreateInvoice();
            var expected = createResponse.Result<Invoice>();

            HttpResponse sendResponse = await InvoiceSendTest.SendInvoice(expected.Id);
            Assert.Equal(202, (int) sendResponse.StatusCode);

            HttpResponse paidResponse = await InvoiceRecordPaymentTest.RecordPayment(expected.Id);
            Assert.Equal(204, (int) paidResponse.StatusCode);

            HttpResponse getResponse = await InvoiceGetTest.getInvoice(expected.Id);
            Assert.Equal(200, (int) getResponse.StatusCode);
            var invoice = getResponse.Result<Invoice>();

            Assert.NotNull(invoice.Payments);
            Assert.True(invoice.Payments.Count > 0);
            var payment = invoice.Payments[invoice.Payments.Count - 1];
            Assert.Equal("EXTERNAL", payment.Type);
            var transactionId = payment.TransactionId;

            HttpResponse deleteResponse = await DeleteExternalPayment(expected.Id, transactionId);
            Assert.Equal(204, (int) deleteResponse.StatusCode);
        }
    }
}
