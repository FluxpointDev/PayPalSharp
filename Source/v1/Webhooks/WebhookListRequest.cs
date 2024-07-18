


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// Lists all webhooks for an app.
    /// </summary>
    public class WebhookListRequest : HttpRequest
    {
        public WebhookListRequest() : base("/v1/notifications/webhooks?", HttpMethod.Get, typeof(WebhookList))
        {

            this.ContentType = "application/json";
        }

        public WebhookListRequest AnchorType(string AnchorType)
        {
            var strParams = Convert.ToString(AnchorType);
            try
            {
                this.Path = $"{this.Path}anchor_type={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }
}
