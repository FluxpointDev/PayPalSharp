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
    /// Shows details for an authorization, by ID.
    /// </summary>
    public class AuthorizationGetRequest : HttpRequest
    {
        public AuthorizationGetRequest(string AuthorizationId) : base("/v1/payments/authorization/{authorization_id}?", HttpMethod.Get, typeof(Authorization))
        {
            try
            {
                this.Path = this.Path.Replace("{authorization_id}", Uri.EscapeDataString(Convert.ToString(AuthorizationId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }
}
