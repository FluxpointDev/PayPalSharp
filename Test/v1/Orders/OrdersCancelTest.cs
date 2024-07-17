using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Orders.Test
{
    [Collection("Orders")]
    public class OrdersCancelTest
    {
        [Fact]
        public async void TestOrdersCancelRequest()
        {
            var response = await OrdersCreateTest.CreateOrder();
            Order createdOrder = response.Result<Order>();

            OrdersGetRequest getRequest = new OrdersGetRequest(createdOrder.Id);
            HttpResponse getResponse = await TestHarness.client().Execute(getRequest);
            Assert.Equal(200, (int)getResponse.StatusCode);

            OrdersCancelRequest request = new OrdersCancelRequest(createdOrder.Id);
            HttpResponse cancelResponse = await TestHarness.client().Execute(request);
            Assert.Equal(204, (int) cancelResponse.StatusCode);

            try {
                getRequest = new OrdersGetRequest(createdOrder.Id);
                getResponse = await TestHarness.client().Execute(getRequest);
            } catch (BraintreeHttp.HttpException e) {
                Assert.Equal(404, (int)e.StatusCode);
            }
        }
    }
}
