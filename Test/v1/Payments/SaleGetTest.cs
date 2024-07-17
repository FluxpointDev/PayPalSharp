using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Payments.Test
{
    [Collection("Payments")]
    public class SaleGetTest
    {

        [Fact]
        public async void TestSaleGetRequest()
        {
            var paymentCreateResponse = await PaymentCreateTest.CreatePayment("sale");
            var saleId = paymentCreateResponse.Result<Payment>()
                .Transactions[0]
                .RelatedResources[0]
                .Sale
                .Id;

            SaleGetRequest request = new SaleGetRequest(saleId);

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<Sale>());
        }
    }
}
