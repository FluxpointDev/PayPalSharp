using BraintreeHttp;
using PayPal.v1;
using PayPal.v1.Webhooks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace PayPal.Core
{
    public class WebhookEndpoints : IEndpoints
    {
        internal WebhookEndpoints(PayPalHttpClient client) : base(client)
        {

        }

    }

    /// <summary>
    /// Lists available events to which any webhook can subscribe. For a list of supported events, see [Webhook event names](/docs/integration/direct/webhooks/event-names/).
    /// </summary>
    public class AvailableEventTypeListRequest : HttpRequest
    {
        public AvailableEventTypeListRequest() : base("/v1/notifications/webhooks-event-types?", HttpMethod.Get, typeof(EventTypeList))
        {

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Shows details for a webhook event notification, by ID.
    /// </summary>
    public class EventGetRequest<T> : HttpRequest
    {
        public EventGetRequest(string EventId) : base("/v1/notifications/webhooks-events/{event_id}?", HttpMethod.Get, typeof(Event<T>))
        {
            try
            {
                this.Path = this.Path.Replace("{event_id}", Uri.EscapeDataString(Convert.ToString(EventId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Lists webhook event notifications. Use query parameters to filter the response.
    /// </summary>
    public class EventListRequest<T> : HttpRequest
    {
        public EventListRequest() : base("/v1/notifications/webhooks-events?", HttpMethod.Get, typeof(EventList<T>))
        {

            this.ContentType = "application/json";
        }

        public EventListRequest<T> EndTime(string EndTime)
        {
            var strParams = Convert.ToString(EndTime);
            try
            {
                this.Path = $"{this.Path}end_time={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public EventListRequest<T> EventType(string EventType)
        {
            var strParams = Convert.ToString(EventType);
            try
            {
                this.Path = $"{this.Path}event_type={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public EventListRequest<T> PageSize(int PageSize)
        {
            var strParams = Convert.ToString(PageSize);
            try
            {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public EventListRequest<T> StartTime(string StartTime)
        {
            var strParams = Convert.ToString(StartTime);
            try
            {
                this.Path = $"{this.Path}start_time={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public EventListRequest<T> TransactionId(string TransactionId)
        {
            var strParams = Convert.ToString(TransactionId);
            try
            {
                this.Path = $"{this.Path}transaction_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }

    /// <summary>
    /// Resends a webhook event notification, by ID. Any pending notifications are not resent.
    /// </summary>
    public class EventResendRequest<T> : HttpRequest
    {
        public EventResendRequest(string EventId) : base("/v1/notifications/webhooks-events/{event_id}/resend?", HttpMethod.Post, typeof(Event<T>))
        {
            try
            {
                this.Path = this.Path.Replace("{event_id}", Uri.EscapeDataString(Convert.ToString(EventId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public EventResendRequest<T> RequestBody(EventResend EventResend)
        {
            this.Body = EventResend;
            return this;
        }
    }

    /// <summary>
    /// Simulates a webhook event. In the JSON request body, specify a sample payload.
    /// </summary>
    public class SimulateEventRequest<T> : HttpRequest
    {
        public SimulateEventRequest() : base("/v1/notifications/simulate-event?", HttpMethod.Post, typeof(Event<T>))
        {

            this.ContentType = "application/json";
        }

        public SimulateEventRequest<T> RequestBody(SimulateEvent SimulateEvent)
        {
            this.Body = SimulateEvent;
            return this;
        }
    }

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
