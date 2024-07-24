// This class was generated on Mon, 09 Apr 2018 18:07:50 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Voids, or cancels, an authorization, by ID. You cannot void a fully captured authorization.
    /// </summary>
    public class AuthorizationVoidRequest : HttpRequest
    {
        public AuthorizationVoidRequest(string AuthorizationId) : base("/v1/payments/authorization/{authorization_id}/void?", HttpMethod.Post, typeof(Authorization))
        {
            try
            {
                this.Path = this.Path.Replace("{authorization_id}", Uri.EscapeDataString(Convert.ToString(AuthorizationId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }
        public AuthorizationVoidRequest PaypalRequestId(string PaypalRequestId)
        {
            this.Headers.Add("PayPal-Request-Id", PaypalRequestId);
            return this;
        }


    }
}
