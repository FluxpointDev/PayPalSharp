




using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Orders
{
    /// <summary>
    /// Cancels an order, by ID, and deletes the order. To call this method, the order status must be  `CREATED` or `APPROVED`.
    /// </summary>
    public class OrdersCancelRequest : HttpRequest
    {
        public OrdersCancelRequest(string OrderId) : base("/v1/checkout/orders/{order_id}?", HttpMethod.Delete, typeof(void))
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
