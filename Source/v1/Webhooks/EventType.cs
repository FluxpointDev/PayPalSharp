




using System.Text.Json.Serialization;

namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// An event type.
    /// </summary>

    public class EventType
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public EventType() { }

        /// <summary>
        /// A human-readable description of the event.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description;

        /// <summary>
        /// REQUIRED
        /// The unique event name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;

        /// <summary>
        /// The status of a webhook event.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status;
    }
}

