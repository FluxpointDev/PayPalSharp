// This class was generated on Mon, 09 Apr 2018 18:07:50 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Refunds a captured payment, by ID. In the JSON request body, include an `amount` object.
    /// </summary>
    public class CaptureRefundRequest : HttpRequest
    {
        public CaptureRefundRequest(string CaptureId) : base("/v1/payments/capture/{capture_id}/refund?", HttpMethod.Post, typeof(DetailedRefund))
        {
            try
            {
                this.Path = this.Path.Replace("{capture_id}", Uri.EscapeDataString(Convert.ToString(CaptureId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }
        public CaptureRefundRequest PaypalRequestId(string PaypalRequestId)
        {
            this.Headers.Add("PayPal-Request-Id", PaypalRequestId);
            return this;
        }


        public CaptureRefundRequest RequestBody(RefundRequest RefundRequest)
        {
            this.Body = RefundRequest;
            return this;
        }
    }
}
