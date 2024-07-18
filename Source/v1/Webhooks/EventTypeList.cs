




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// List of webhook events.
    /// </summary>

    public class EventTypeList
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public EventTypeList() { }

        /// <summary>
        /// An array of webhook events.
        /// </summary>
        [JsonPropertyName("event_types")]
        public List<EventType> EventTypes;
    }
}

