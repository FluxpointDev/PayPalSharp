




using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Webhooks
{
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
}
