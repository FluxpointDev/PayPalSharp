// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f
// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Captures and processes an authorization, by ID. The original payment call must specify an intent of `authorize`.
    /// </summary>
    public class AuthorizationCaptureRequest : HttpRequest
    {
        public AuthorizationCaptureRequest(string AuthorizationId) : base("/v1/payments/authorization/{authorization_id}/capture?", HttpMethod.Post, typeof(Capture))
        {
            try
            {
                this.Path = this.Path.Replace("{authorization_id}", Uri.EscapeDataString(Convert.ToString(AuthorizationId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AuthorizationCaptureRequest RequestBody(Capture Capture)
        {
            this.Body = Capture;
            return this;
        }
    }
}
