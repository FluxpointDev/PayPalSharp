




using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.PaymentExperience
{
    /// <summary>
    /// Shows details for a web experience profile, by ID.
    /// </summary>
    public class WebProfileGetRequest : HttpRequest
    {
        public WebProfileGetRequest(string ProfileId) : base("/v1/payment-experience/web-profiles/{profile_id}?", HttpMethod.Get, typeof(WebProfile))
        {
            try
            {
                this.Path = this.Path.Replace("{profile_id}", Uri.EscapeDataString(Convert.ToString(ProfileId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }
}
