




using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Webhooks
{
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
}
