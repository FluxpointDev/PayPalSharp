




using System.Text.Json.Serialization;

namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// Simulates a mock webhook event.
    /// </summary>

    public class SimulateEvent
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public SimulateEvent() { }

        /// <summary>
        /// REQUIRED
        /// The event name. Specify one of the subscribed events. For each request, provide only one event.
        /// </summary>
        [JsonPropertyName("event_type")]
        public string EventType;

        /// <summary>
        /// The URL for the webhook endpoint. If omitted, the webhook ID is required.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url;

        /// <summary>
        /// The ID of the webhook. If omitted, the URL is required.
        /// </summary>
        [JsonPropertyName("webhook_id")]
        public string WebhookId;
    }
}

