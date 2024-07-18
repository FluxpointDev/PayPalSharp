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
    /// Refunds a sale, by ID. For a full refund, do not include the `amount` object in the JSON request body. For a partial refund, include an `amount` object in the JSON request body.
    /// </summary>
    public class SaleRefundRequest : HttpRequest
    {
        public SaleRefundRequest(string SaleId) : base("/v1/payments/sale/{sale_id}/refund?", HttpMethod.Post, typeof(DetailedRefund))
        {
            try
            {
                this.Path = this.Path.Replace("{sale_id}", Uri.EscapeDataString(Convert.ToString(SaleId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }
        public SaleRefundRequest PaypalRequestId(string PaypalRequestId)
        {
            this.Headers.Add("PayPal-Request-Id", PaypalRequestId);
            return this;
        }


        public SaleRefundRequest RequestBody(RefundRequest RefundRequest)
        {
            this.Body = RefundRequest;
            return this;
        }
    }
}
