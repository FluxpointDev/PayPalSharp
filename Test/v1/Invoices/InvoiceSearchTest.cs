using System.Text;
using System.Net.Http;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Invoices.Test
{
    [Collection("Invoices")]
    public class InvoiceSearchTest
    {

        private static Search BuildRequestBody()
        {
            var jsonContent = new StringContent("{ \"start_invoice_date\": \"2014-01-01 PST\", \"end_invoice_date\": \"2014-03-26 PST\", \"page\": 0, \"page_size\": 3, \"total_count_required\": true }", Encoding.UTF8, "application/json");
            return (Search) new JsonSerializer().Decode(jsonContent, typeof(Search));
        }

        [Fact]
        public async void TestInvoiceSearchRequest()
        {
            HttpResponse createResponse = await InvoiceCreateTest.CreateInvoice();

            InvoiceSearchRequest invoiceSearchRequest = new InvoiceSearchRequest();
            invoiceSearchRequest.RequestBody(BuildRequestBody());

            HttpResponse searchResponse = await TestHarness.client().Execute(invoiceSearchRequest);

            Assert.Equal(200, (int) searchResponse.StatusCode);
            Assert.NotNull(searchResponse.Result<InvoiceList>());
            var invoices = searchResponse.Result<InvoiceList>();
            Assert.NotNull(invoices.Invoices);
            Assert.NotNull(invoices.TotalCount);
        }
    }
}
