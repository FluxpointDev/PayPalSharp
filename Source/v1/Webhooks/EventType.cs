



// @data H4sIAAAAAAAC/6zQzU7DMAwH8DtPYfkcEOfeJsEJCRCauCAOHvVoROZ0jgOK0N4dZZ1Kyw6Ij1OVf1znZ7/jsvSMDV6+shjsDw7vST2tAl/Tpt6hwysun4cLTk/qe/NRsMGFAO9/ttLzGTpcqFIZ2p47vGNqbyQUbNYUEtdgm71yOwa3GntW85yweRhBydTL8zGmnTw+dc3zL0To8obkVJna2gomxRDXYB0PM/yVLzmEnft2BqmfKf4QzNXLjiGL3+YDDmrVj4Sm+XfAZGQ5zYhjdIwcruoiCd541cX48o/rfNydfAAAAP//
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

