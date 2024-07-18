


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// Shows details for a webhook, by ID.
    /// </summary>
    public class WebhookGetRequest : HttpRequest
    {
        public WebhookGetRequest(string WebhookId) : base("/v1/notifications/webhooks/{webhook_id}?", HttpMethod.Get, typeof(Webhook))
        {
            try
            {
                this.Path = this.Path.Replace("{webhook_id}", Uri.EscapeDataString(Convert.ToString(WebhookId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }
}
