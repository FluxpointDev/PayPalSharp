using BraintreeHttp;
using PayPal.v1.Orders;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace PayPal.Core
{
    public class OrderEndpoints : IEndpoints
    {
        internal OrderEndpoints(PayPalHttpClient client) : base(client)
        {

        }

    }

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

    /// <summary>
    /// Initiates a PayPal payment that a buyer has approved.<blockquote><strong>Note:</strong> For Marketplace use cases, use the <code>disbursement_mode</code> to indicate whether to disburse funds to the merchant and marketplace accounts immediately or later. If you delay disbursement, you must call <a href="/docs/marketplaces/orders/integration-guide/#disburse-funds"><code>/v1/payments/referenced-payouts-items</code></a> to disburse funds to the merchant and marketplace.</blockquote>
    /// </summary>
    public class OrdersPayRequest : HttpRequest
    {
        public OrdersPayRequest(string OrderId) : base("/v1/checkout/orders/{order_id}/pay?", HttpMethod.Post, typeof(PayOrderResponse))
        {
            try
            {
                this.Path = this.Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(OrderId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public OrdersPayRequest RequestBody(ExecuteOrder PayOrderRequest)
        {
            this.Body = PayOrderRequest;
            return this;
        }
    }
}
