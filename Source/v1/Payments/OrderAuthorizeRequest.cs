// This class was generated on Mon, 09 Apr 2018 18:07:50 UTC by version 0.1.0-dev+291f3f of Braintree SDK Generator
// OrderAuthorizeRequest.cs
// @version 0.1.0-dev+291f3f
// @type request
// @data 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
// DO NOT EDIT
using System;
using System.IO;
using System.Net.Http;
using BraintreeHttp;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Authorizes an order, by ID. In the JSON request body, include an `amount` object.
    /// </summary>
    public class OrderAuthorizeRequest : HttpRequest
    {
        public OrderAuthorizeRequest(string OrderId) : base("/v1/payments/orders/{order_id}/authorize?", HttpMethod.Post, typeof(Authorization))
        {
            try {
                this.Path = this.Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(OrderId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
        public OrderAuthorizeRequest RequestBody(Order Order)
        {
            this.Body = Order;
            return this;
        }
    }
}
