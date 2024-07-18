


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// Lists event subscriptions for a webhook, by ID.
    /// </summary>
    public class WebhookListEventSubscriptionsRequest : HttpRequest
    {
        public WebhookListEventSubscriptionsRequest(string WebhookId) : base("/v1/notifications/webhooks/{webhook_id}/event-types?", HttpMethod.Get, typeof(EventTypeList))
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
