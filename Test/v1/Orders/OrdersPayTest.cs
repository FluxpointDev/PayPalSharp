using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Orders.Test
{
    [Collection("Orders")]
    public class OrdersPayTest
    {
        private ExecuteOrder buildRequestBody()
        {
            ExecuteOrder executeOrder = new ExecuteOrder()
            {
                DisbursementMode = "INSTANT"
            };
            return executeOrder;
        }

        [Fact(Skip = "This test is an example. In production, you will need payer approval")]
        public async void TestOrdersPayRequest()
        {
            var orderResponse = await OrdersCreateTest.CreateOrder();

            var orderId = orderResponse.Result<Order>().Id;
            OrdersPayRequest request = new OrdersPayRequest(orderId);

            request.RequestBody(buildRequestBody());

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<PayOrderResponse>());

            PayOrderResponse payOrderResponse = response.Result<PayOrderResponse>();
            Assert.Equal(orderId, payOrderResponse.OrderId);
            Assert.Equal("APPROVED", payOrderResponse.Status);
        }
    }
}
