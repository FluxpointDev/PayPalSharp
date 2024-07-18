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
    /// Re-authorizes a PayPal account payment, by authorization ID. To ensure that funds are still available, re-authorize a payment after the initial three-day honor period. Supports only the `amount` request parameter. You can re-authorize a payment only once from four to 29 days after three-day honor period for the original authorization expires. If 30 days have passed from the original authorization, you must create a new authorization instead. A re-authorized payment itself has a new three-day honor period. You can re-authorize a transaction once for up to 115% of the originally authorized amount, not to exceed an increase of $75 USD.
    /// </summary>
    public class AuthorizationReauthorizeRequest : HttpRequest
    {
        public AuthorizationReauthorizeRequest(string AuthorizationId) : base("/v1/payments/authorization/{authorization_id}/reauthorize?", HttpMethod.Post, typeof(Authorization))
        {
            try
            {
                this.Path = this.Path.Replace("{authorization_id}", Uri.EscapeDataString(Convert.ToString(AuthorizationId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AuthorizationReauthorizeRequest RequestBody(Authorization Authorization)
        {
            this.Body = Authorization;
            return this;
        }
    }
}
