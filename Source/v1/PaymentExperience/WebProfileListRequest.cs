




using BraintreeHttp;
using System.Collections.Generic;
using System.Net.Http;


namespace PayPal.v1.PaymentExperience
{
    /// <summary>
    /// Lists all web experience profiles for a merchant or subject.
    /// </summary>
    public class WebProfileListRequest : HttpRequest
    {
        public WebProfileListRequest() : base("/v1/payment-experience/web-profiles/?", HttpMethod.Get, typeof(List<WebProfile>))
        {

            this.ContentType = "application/json";
        }

    }
}
