// This class was generated on Mon, 09 Apr 2018 18:07:50 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Shows details for a captured payment, by ID.
    /// </summary>
    public class CaptureGetRequest : HttpRequest
    {
        public CaptureGetRequest(string CaptureId) : base("/v1/payments/capture/{capture_id}?", HttpMethod.Get, typeof(Capture))
        {
            try
            {
                this.Path = this.Path.Replace("{capture_id}", Uri.EscapeDataString(Convert.ToString(CaptureId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }
}
