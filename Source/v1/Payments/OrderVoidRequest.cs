// This class was generated on Mon, 09 Apr 2018 18:07:50 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f
// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Voids, or cancels, an order, by ID. You cannot void an order if the payment has already been partially or fully captured.
    /// </summary>
    public class OrderVoidRequest : HttpRequest
    {
        public OrderVoidRequest(string OrderId) : base("/v1/payments/orders/{order_id}/do-void?", HttpMethod.Post, typeof(Order))
        {
            try
            {
                this.Path = this.Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(OrderId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }
        public OrderVoidRequest PaypalRequestId(string PaypalRequestId)
        {
            this.Headers.Add("PayPal-Request-Id", PaypalRequestId);
            return this;
        }


    }
}
