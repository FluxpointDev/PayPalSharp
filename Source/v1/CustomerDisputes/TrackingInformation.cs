
using System.Text.Json.Serialization;

namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// The tracking information.
    /// </summary>

    public class TrackingInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public TrackingInformation() { }

        /// <summary>
        /// The name of the carrier for the shipment of the transaction that is associated with this dispute.
        /// </summary>
        [JsonPropertyName("carrier_name")]
        public string CarrierName;

        /// <summary>
        /// The tracking number for the shipment for the transaction associated with this dispute.
        /// </summary>
        [JsonPropertyName("tracking_number")]
        public string TrackingNumber;

        /// <summary>
        /// The URL to track the item shipment.
        /// </summary>
        [JsonPropertyName("tracking_url")]
        public string TrackingUrl;
    }
}

