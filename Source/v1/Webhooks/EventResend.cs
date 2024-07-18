




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// Resends a webhook event notification, by ID.
    /// </summary>

    public class EventResend
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public EventResend() { }

        /// <summary>
        /// An array of webhook account IDs.
        /// </summary>
        [JsonPropertyName("webhook_ids")]
        public List<string> WebhookIds;
    }
}

