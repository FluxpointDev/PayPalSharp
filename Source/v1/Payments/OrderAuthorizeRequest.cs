// This class was generated on Mon, 09 Apr 2018 18:07:50 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Authorizes an order, by ID. In the JSON request body, include an `amount` object.
    /// </summary>
    public class OrderAuthorizeRequest : HttpRequest
    {
        public OrderAuthorizeRequest(string OrderId) : base("/v1/payments/orders/{order_id}/authorize?", HttpMethod.Post, typeof(Authorization))
        {
            try
            {
                this.Path = this.Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(OrderId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public OrderAuthorizeRequest RequestBody(Order Order)
        {
            this.Body = Order;
            return this;
        }
    }
}
