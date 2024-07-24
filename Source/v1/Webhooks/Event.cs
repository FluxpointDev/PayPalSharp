




using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// A webhook event notification.
    /// </summary>

    public class Event<T>
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Event() { }

        /// <summary>
        /// The date and time when the webhook event notification was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTimeFormat;

        [JsonIgnore]
        public DateTime CreatedDate => DateTime.Parse(CreateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// The event that triggered the webhook event notification.
        /// </summary>
        [JsonPropertyName("event_type")]
        public string EventType;

        /// <summary>
        /// The event version in the webhook notification.
        /// </summary>
        [JsonPropertyName("event_version")]
        public string EventVersion;

        /// <summary>
        /// The ID of the webhook event notification.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// The resource that triggered the webhook event notification.
        /// </summary>
        [JsonPropertyName("resource")]
        public T Resource;

        /// <summary>
        /// The name of the resource related to the webhook notification event.
        /// </summary>
        [JsonPropertyName("resource_type")]
        public string ResourceType;

        /// <summary>
        /// A summary description for the event notification. For example, `A payment authorization was created.`
        /// </summary>
        [JsonPropertyName("summary")]
        public string Summary;
    }
}

