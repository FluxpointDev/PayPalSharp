using System.Threading.Tasks;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Payments.Test
{
    [Collection("Payments")]
    public class SaleRefundTest
    {
        private static RefundRequest buildRequestBody()
        {
            return new RefundRequest();
        }

        public static async Task<HttpResponse> RefundSale(string saleId)
        {
            var request = new SaleRefundRequest(saleId);
            request.RequestBody(buildRequestBody());

            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestSaleRefundRequest()
        {
            var paymentCreateResponse = await PaymentCreateTest.CreatePayment("sale");
            var saleId = paymentCreateResponse.Result<Payment>()
                .Transactions[0]
                .RelatedResources[0]
                .Sale
                .Id;

            HttpResponse response = await RefundSale(saleId);
            Assert.Equal(201, (int) response.StatusCode);
            Assert.NotNull(response.Result<DetailedRefund>());
        }
    }
}
