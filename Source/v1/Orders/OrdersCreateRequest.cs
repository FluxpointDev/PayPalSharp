


// @type request

using BraintreeHttp;
using System.Net.Http;


namespace PayPal.v1.Orders
{
    /// <summary>
    /// Creates an order. To set the transaction context and enable the server to complete risk and compliance analysis of the transaction, call `/v1/risk/transaction-contexts` to generate a tracking ID. Save and include this ID in the `Paypal-Client-Metadata-Id` request header in your call to `/v1/checkout/orders`.
    /// </summary>
    public class OrdersCreateRequest : HttpRequest
    {
        public OrdersCreateRequest() : base("/v1/checkout/orders?", HttpMethod.Post, typeof(Order))
        {

            this.ContentType = "application/json";
        }

        public OrdersCreateRequest RequestBody(Order Order)
        {
            this.Body = Order;
            return this;
        }
    }
}
