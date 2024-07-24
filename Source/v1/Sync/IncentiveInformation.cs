




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Sync
{
    /// <summary>
    /// The incentive details.
    /// </summary>

    public class IncentiveInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public IncentiveInformation() { }

        /// <summary>
        /// An array of incentive details.
        /// </summary>
        [JsonPropertyName("incentive_details")]
        public List<IncentiveDetails> IncentiveDetails;
    }
}

