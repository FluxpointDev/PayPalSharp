// This class was generated on Mon, 09 Apr 2018 18:07:50 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Shows details for a refund, by ID.
    /// </summary>
    public class RefundGetRequest : HttpRequest
    {
        public RefundGetRequest(string RefundId) : base("/v1/payments/refund/{refund_id}?", HttpMethod.Get, typeof(Refund))
        {
            try
            {
                this.Path = this.Path.Replace("{refund_id}", Uri.EscapeDataString(Convert.ToString(RefundId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }
}
