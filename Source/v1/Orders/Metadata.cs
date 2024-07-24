




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Orders
{
    /// <summary>
    /// Metadata.
    /// </summary>

    public class Metadata
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Metadata() { }

        /// <summary>
        /// An array of name-and-value pairs that contain external data, such as user, user feedback, score, and so on.
        /// </summary>
        [JsonPropertyName("postback_data")]
        public List<NameAndValuePair> PostbackData;

        /// <summary>
        /// An array of name-and-value pairs that contain data required by PayPal for transaction processing.
        /// </summary>
        [JsonPropertyName("supplementary_data")]
        public List<NameAndValuePair> SupplementaryData;
    }
}

