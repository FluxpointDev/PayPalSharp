using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Invoices.Test
{
    [Collection("Invoices")]
    public class InvoiceNextInvoiceNumberTest
    {

        public static async Task<HttpResponse> NextInvoiceNumber() {
            InvoiceNextInvoiceNumberRequest request = new InvoiceNextInvoiceNumberRequest();
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestInvoiceNextNumberRequest()
        {
            HttpResponse nextInvoiceNumberResponse = await NextInvoiceNumber();
            Assert.Equal(200, (int) nextInvoiceNumberResponse.StatusCode);
            Assert.NotNull(nextInvoiceNumberResponse.Result<InvoiceNumber>());
            var nextNumber = nextInvoiceNumberResponse.Result<InvoiceNumber>();
            Assert.NotNull(nextNumber.Number);
        }
    }
}
