




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// List of webhooks events.
    /// </summary>

    public class EventList<T>
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public EventList() { }

        /// <summary>
        /// The number of items in each range of results. Note that the response might have fewer items than the requested `page_size` value.
        /// </summary>
        [JsonPropertyName("count")]
        public int? Count;

        /// <summary>
        /// An array of webhooks events.
        /// </summary>
        [JsonPropertyName("events")]
        public List<Event<T>> Events;

        /// <summary>
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;
    }
}

