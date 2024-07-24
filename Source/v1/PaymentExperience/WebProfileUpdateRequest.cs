




using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.PaymentExperience
{
    /// <summary>
    /// Updates a web experience profile, by ID. In the JSON request body, specify the profile details. If your request omits any profile parameters, any previously set values for those parameters are removed.
    /// </summary>
    public class WebProfileUpdateRequest : HttpRequest
    {
        public WebProfileUpdateRequest(string ProfileId) : base("/v1/payment-experience/web-profiles/{profile_id}?", HttpMethod.Put, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{profile_id}", Uri.EscapeDataString(Convert.ToString(ProfileId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public WebProfileUpdateRequest RequestBody(WebProfile WebProfile)
        {
            this.Body = WebProfile;
            return this;
        }
    }
}
