




using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// Deletes a webhook, by ID.
    /// </summary>
    public class WebhookDeleteRequest : HttpRequest
    {
        public WebhookDeleteRequest(string WebhookId) : base("/v1/notifications/webhooks/{webhook_id}?", HttpMethod.Delete, typeof(void))
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
