


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Orders
{
    /// <summary>
    /// Shows details for an order, by ID.
    /// </summary>
    public class OrdersGetRequest : HttpRequest
    {
        public OrdersGetRequest(string OrderId) : base("/v1/checkout/orders/{order_id}?", HttpMethod.Get, typeof(Order))
        {
            try
            {
                this.Path = this.Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(OrderId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }
}
