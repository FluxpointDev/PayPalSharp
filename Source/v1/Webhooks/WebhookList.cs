




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// List of webhooks.
    /// </summary>

    public class WebhookList
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public WebhookList() { }

        /// <summary>
        /// An array of webhooks.
        /// </summary>
        [JsonPropertyName("webhooks")]
        public List<Webhook> Webhooks;
    }
}

