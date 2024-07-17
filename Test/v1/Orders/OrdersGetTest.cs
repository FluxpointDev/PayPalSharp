using System;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Orders.Test
{
    [Collection("Orders")]
    public class OrdersGetTest
    {

        [Fact]
        public async void TestOrdersGetRequest()
        {
            var response = await OrdersCreateTest.CreateOrder();
            Order createdOrder = response.Result<Order>();

            OrdersGetRequest getRequest = new OrdersGetRequest(createdOrder.Id);
            HttpResponse getResponse = await TestHarness.client().Execute(getRequest);
            Assert.Equal(200, (int)getResponse.StatusCode);

            Order retrievedOrder = getResponse.Result<Order>();
            Assert.NotNull(retrievedOrder);
            Assert.Equal(retrievedOrder.Id, createdOrder.Id);
            Assert.NotNull(retrievedOrder.PurchaseUnits);
            Assert.Equal(retrievedOrder.PurchaseUnits.Count, createdOrder.PurchaseUnits.Count);

            for (int count = 0; count < retrievedOrder.PurchaseUnits.Count; count++) {
                PurchaseUnit retrievedOrderPurchaseUnit = retrievedOrder.PurchaseUnits[count];
                PurchaseUnit createdOrderPurchaseUnit = createdOrder.PurchaseUnits[count];
                Assert.Equal(retrievedOrderPurchaseUnit.ReferenceId, createdOrderPurchaseUnit.ReferenceId);
                Assert.Equal(retrievedOrderPurchaseUnit.Amount.Currency, createdOrderPurchaseUnit.Amount.Currency);
                Assert.Equal(retrievedOrderPurchaseUnit.Amount.Total, createdOrderPurchaseUnit.Amount.Total);
            }

            Assert.Equal("https://example.com/return", retrievedOrder.RedirectUrls.ReturnUrl);
            Assert.Equal("https://example.com/cancel", retrievedOrder.RedirectUrls.CancelUrl);

            Assert.NotNull(retrievedOrder.CreateTime);

            Assert.NotNull(retrievedOrder.Links);
            bool foundApprovalURL = false;
            foreach (var linkDescription in retrievedOrder.Links) {
                if ("approval_url".Equals(linkDescription.Rel)) {
                    foundApprovalURL = true;
                    Assert.NotNull(linkDescription.Href);
                    Assert.Equal("REDIRECT", linkDescription.Method);
                    Console.WriteLine(linkDescription.Href);
                }
            }

            Console.WriteLine(retrievedOrder.Id);
            Assert.True(foundApprovalURL);
            Assert.Equal("CREATED", retrievedOrder.Status);
        }
    }
}
