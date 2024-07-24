




using BraintreeHttp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// Replaces webhook fields with new values. Supports only the `replace` operation. Pass a `json_patch` object with `replace` operation and `path`, which is `/url` for a URL or `/event_types` for events. The `value` is either the URL or a list of events.
    /// </summary>
    public class WebhookUpdateRequest<T> : HttpRequest
    {
        public WebhookUpdateRequest(string WebhookId) : base("/v1/notifications/webhooks/{webhook_id}?", new HttpMethod("PATCH"), typeof(Webhook))
        {
            try
            {
                this.Path = this.Path.Replace("{webhook_id}", Uri.EscapeDataString(Convert.ToString(WebhookId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public WebhookUpdateRequest<T> RequestBody(List<JsonPatch<T>> PatchRequest)
        {
            this.Body = PatchRequest;
            return this;
        }
    }
}
