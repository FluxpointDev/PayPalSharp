




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// One or more webhook objects.
    /// </summary>

    public class Webhook
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Webhook() { }

        /// <summary>
        /// REQUIRED
        /// An array of up to ten events to which to subscribe your webhook. To subscribe to all events including new events as they are added, specify the asterisk (`*`) wild card. To replace the `event_types` array, specify the `*` wild card. To list all supported events, [list available events](#available-event-type.list).
        /// </summary>
        [JsonPropertyName("event_types")]
        public List<EventType> EventTypes;

        /// <summary>
        /// The ID of the webhook.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/hateoas-links/).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// REQUIRED
        /// The URL that is configured to listen on `localhost` for incoming `POST` notification messages that contain event information.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url;
    }
}

