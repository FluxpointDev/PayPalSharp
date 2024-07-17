using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Payments.Test
{
    [Collection("Payments")]
    public class PaymentExecuteTest
    {
        private PaymentExecution buildRequestBody()
        {
            return new PaymentExecution()
            {
                PayerId = "some_payer_id"
            };
        }

        [Fact(Skip="Tests that use this class must be ignored when run in an automated environment because executing an order will require approval via the executed payment\'s approval_url")]
        public async void TestPaymentExecuteRequest()
        {
            var paymentResponse = await PaymentCreateTest.CreatePayment("order", "paypal");
            var payment = paymentResponse.Result<Payment>();

            PaymentExecuteRequest request = new PaymentExecuteRequest(payment.Id);
            request.RequestBody(buildRequestBody());

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<Payment>());
        }
    }
}
