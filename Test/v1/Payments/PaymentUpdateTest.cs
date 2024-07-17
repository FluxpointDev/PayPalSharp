using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Payments.Test
{
    [Collection("Payments")]
    public class PaymentUpdateTest
    {
        private List<JsonPatch<Amount>> buildRequestBody()
        {
            return new List<JsonPatch<Amount>>()
            {
                new JsonPatch<Amount>()
                {
                    Path = "/transactions/0/amount",
                    Op = "replace",
                    Value = new Amount()
                    {
                        Currency = "USD",
                        Total = "11"
                    }
                }
            };
        }

        [Fact]
        public async void TestPaymentUpdateRequest()
        {
            var paymentCreateResponse = await PaymentCreateTest.CreatePayment("sale", "paypal");
            var payment = paymentCreateResponse.Result<Payment>();

            PaymentUpdateRequest<Amount> request = new PaymentUpdateRequest<Amount>(payment.Id);
            request.RequestBody(buildRequestBody());

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<Payment>());

            Assert.Equal("11.00", response.Result<Payment>().Transactions[0].Amount.Total);
        }
    }
}
