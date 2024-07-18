


// @type request

using BraintreeHttp;
using System.Net.Http;


namespace PayPal.v1.PaymentExperience
{
    /// <summary>
    /// Creates a web experience profile. In the JSON request body, specify the profile name and details.
    /// </summary>
    public class WebProfileCreateRequest : HttpRequest
    {
        public WebProfileCreateRequest() : base("/v1/payment-experience/web-profiles/?", HttpMethod.Post, typeof(WebProfile))
        {

            this.ContentType = "application/json";
        }

        public WebProfileCreateRequest RequestBody(WebProfile WebProfile)
        {
            this.Body = WebProfile;
            return this;
        }
    }
}
