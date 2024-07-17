using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Payments.Test
{
    [Collection("Payments")]
    public class PaymentListTest
    {

        [Fact]
        public async void TestPaymentListRequest()
        {
            PaymentListRequest request = new PaymentListRequest()
                .Count(2);

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<PaymentHistory>());
        }
    }
}
