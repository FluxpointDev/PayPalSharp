// This class was generated on Mon, 09 Apr 2018 18:07:50 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Captures a payment for an order, by ID. To use this call, the original payment call must specify an `order` intent. In the JSON request body, include the payment amount and indicate whether this capture is the final capture for the authorization.
    /// </summary>
    public class OrderCaptureRequest : HttpRequest
    {
        public OrderCaptureRequest(string OrderId) : base("/v1/payments/orders/{order_id}/capture?", HttpMethod.Post, typeof(Capture))
        {
            try
            {
                this.Path = this.Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(OrderId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public OrderCaptureRequest RequestBody(Capture Capture)
        {
            this.Body = Capture;
            return this;
        }
    }
}
