

// @version 0.1.0-dev+291f3f


using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// The evidence-related information.
    /// </summary>

    public class EvidenceInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public EvidenceInformation() { }

        /// <summary>
        /// An array of refund IDs for the transaction involved in this dispute.
        /// </summary>
        [JsonPropertyName("refund_ids")]
        public List<string> RefundIds;

        /// <summary>
        /// An array of relevant tracking information for the transaction involved in this dispute.
        /// </summary>
        [JsonPropertyName("tracking_info")]
        public List<TrackingInformation> TrackingInfo;
    }
}

