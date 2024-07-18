


// @type request

using BraintreeHttp;
using System.Net.Http;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// Verifies a webhook signature.
    /// </summary>
    public class WebhookVerifySignatureRequest<T> : HttpRequest
    {
        public WebhookVerifySignatureRequest() : base("/v1/notifications/verify-webhook-signature?", HttpMethod.Post, typeof(VerifyWebhookSignatureResponse))
        {

            this.ContentType = "application/json";
        }

        public WebhookVerifySignatureRequest<T> RequestBody(VerifyWebhookSignature<T> VerifyWebhookSignature)
        {
            this.Body = VerifyWebhookSignature;
            return this;
        }
    }
}
