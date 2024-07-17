using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Orders.Test
{
    [Collection("Orders")]
    public class OrdersCreateTest
    {
        private static Order buildRequestBody()
        {
            var order = new Order() {
                Intent = "SALE",
                PurchaseUnits = new List<PurchaseUnit>() 
                {
                    new PurchaseUnit()
                    {
                        ReferenceId = "test_ref_id1",
                        Amount = new Amount()
                        {
                            Total = "100.00",
                            Currency = "USD"
                        }
                    },
                    new PurchaseUnit()
                    {
                        ReferenceId = "test_ref_id2",
                        Amount = new Amount()
                        {
                            Total = "50.00",
                            Currency = "USD"
                        }
                    }
                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = "https://example.com/cancel",
                    ReturnUrl = "https://example.com/return"
                }
            };
            return order;
        }
        public async static Task<HttpResponse> CreateOrder() 
        {
            var request = new OrdersCreateRequest();

            request.RequestBody(buildRequestBody());
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestPaymentCreateRequest()
        {
            var response = await CreateOrder();

            Assert.Equal(201, (int) response.StatusCode);
            Assert.NotNull(response.Result<Order>());

            Order createdOrder = response.Result<Order>();
            Assert.NotNull(createdOrder.Id);
            Assert.NotNull(createdOrder.PurchaseUnits);
            Assert.Equal(2, createdOrder.PurchaseUnits.Count);

            PurchaseUnit firstPurchaseUnit = createdOrder.PurchaseUnits[0];
            Assert.Equal("test_ref_id1", firstPurchaseUnit.ReferenceId);
            Assert.Equal("USD", firstPurchaseUnit.Amount.Currency);
            Assert.Equal("100.00", firstPurchaseUnit.Amount.Total);
            Assert.Equal("NOT_PROCESSED", firstPurchaseUnit.Status);

            PurchaseUnit secondPurchaseUnit = createdOrder.PurchaseUnits[1];
            Assert.Equal("test_ref_id2", secondPurchaseUnit.ReferenceId);
            Assert.Equal("USD", secondPurchaseUnit.Amount.Currency);
            Assert.Equal("50.00", secondPurchaseUnit.Amount.Total);
            Assert.Equal("NOT_PROCESSED", secondPurchaseUnit.Status);

            Assert.Equal("https://example.com/return", createdOrder.RedirectUrls.ReturnUrl);
            Assert.Equal("https://example.com/cancel", createdOrder.RedirectUrls.CancelUrl);

            Assert.NotNull(createdOrder.CreateTime);

            Assert.NotNull(createdOrder.Links);
            bool foundApprovalURL = false;
            foreach (var linkDescription in createdOrder.Links) {
                if ("approval_url".Equals(linkDescription.Rel)) {
                    foundApprovalURL = true;
                    Assert.NotNull(linkDescription.Href);
                    Assert.Equal("REDIRECT", linkDescription.Method);
                    Console.WriteLine(linkDescription.Href);
                }
            }

            Console.WriteLine(createdOrder.Id);
            Assert.True(foundApprovalURL);
            Assert.Equal("CREATED", createdOrder.Status);
        }
    }
}