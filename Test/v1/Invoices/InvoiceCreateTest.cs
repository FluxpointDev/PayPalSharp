using System.Text;
using System.Net.Http;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Invoices.Test
{
    [Collection("Invoices")]
    public class InvoiceCreateTest
    {
        private static Invoice BuildRequestBody()
        {
            var jsonContent = new StringContent("{ \"merchant_info\": { \"email\": \"team-dx-clients-facilitator@getbraintree.com\", \"first_name\": \"Dennis\", \"last_name\": \"Doctor\", \"business_name\": \"Medical Professionals, LLC\", \"phone\": { \"country_code\": \"001\", \"national_number\": \"5032141716\" }, \"address\": { \"line1\": \"1234 Main St.\", \"city\": \"Portland\", \"state\": \"OR\", \"postal_code\": \"97217\", \"country_code\": \"US\" } }, \"billing_info\": [{ \"email\": \"example@sample.com\" }], \"items\": [{ \"name\": \"Sutures\", \"quantity\": 100.0, \"unit_price\": { \"currency\": \"USD\", \"value\": 5 } }], \"note\": \"Medical Invoice 16 Jul, 2018 PST\", \"payment_term\": { \"term_type\": \"NET_45\" }, \"shipping_info\": { \"first_name\": \"Sally\", \"last_name\": \"Patient\", \"business_name\": \"Not applicable\", \"phone\": { \"country_code\": \"001\", \"national_number\": \"5039871234\" }, \"address\": { \"line1\": \"1234 Broad St.\", \"city\": \"Portland\", \"state\": \"OR\", \"postal_code\": \"97216\", \"country_code\": \"US\" } }, \"tax_inclusive\": false, \"total_amount\": { \"currency\": \"USD\", \"value\": \"500.00\" } }", Encoding.UTF8, "application/json");
            return (Invoice) new JsonSerializer().Decode(jsonContent, typeof(Invoice));
        }

        public static async Task<HttpResponse> CreateInvoice() {
            InvoiceCreateRequest request = new InvoiceCreateRequest();
            request.RequestBody(BuildRequestBody());

            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestInvoiceCreateRequest()
        {
            HttpResponse createResponse = await CreateInvoice();
            Assert.Equal(201, (int) createResponse.StatusCode);
            Assert.NotNull(createResponse.Result<Invoice>());
            var actual = createResponse.Result<Invoice>();
            Assert.Equal("Dennis", actual.MerchantInfo.FirstName);
            Assert.NotNull(actual.Id);
        }
    }
}
