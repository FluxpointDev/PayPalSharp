




using BraintreeHttp;
using System.Net.Http;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// Subscribes your webhook listener to events.
    /// </summary>
    public class WebhookCreateRequest : HttpRequest
    {
        public WebhookCreateRequest() : base("/v1/notifications/webhooks?", HttpMethod.Post, typeof(Webhook))
        {

            this.ContentType = "application/json";
        }

        public WebhookCreateRequest RequestBody(Webhook Webhook)
        {
            this.Body = Webhook;
            return this;
        }
    }
}
