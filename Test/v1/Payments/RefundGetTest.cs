using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Payments.Test
{
    [Collection("Payments")]
    public class RefundGetTest
    {

        [Fact]
        public async void TestRefundGetRequest()
        {
            var paymentCreateResponse = await PaymentCreateTest.CreatePayment("sale");
            var saleId = paymentCreateResponse.Result<Payment>()
                .Transactions[0]
                .RelatedResources[0]
                .Sale
                .Id;

            var refundResponse = await SaleRefundTest.RefundSale(saleId);

            RefundGetRequest request = new RefundGetRequest(refundResponse.Result<DetailedRefund>().Id);

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<Refund>());
        }
    }
}
