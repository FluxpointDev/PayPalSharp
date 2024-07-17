using System;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Invoices.Test
{
    [Collection("Invoices")]
    public class InvoiceQrCodeTest
    {

        public static async Task<HttpResponse> getQRCode(String id) {
            InvoiceQrCodeRequest request = new InvoiceQrCodeRequest(id);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestInvoiceQrCodeRequest()
        {
            HttpResponse createResponse = await InvoiceCreateTest.CreateInvoice();
            var expected = createResponse.Result<Invoice>();

            HttpResponse getQRResponse = await getQRCode(expected.Id);
            Assert.Equal(200, (int) getQRResponse.StatusCode);

            var qrCode = getQRResponse.Result<QrCode>();
            Assert.NotNull(qrCode);
            Assert.NotNull(qrCode.Image);
        }
    }
}
