


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Orders
{
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
