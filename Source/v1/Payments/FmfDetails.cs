// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.Payments
{
    /// <summary>
    /// The Fraud Management Filter (FMF) details that are applied to the payment that result in an accept, deny, or pending action. Returned in a payment response only if the merchant has enabled FMF in the profile settings and one of the fraud filters was triggered based on those settings. For more information, see [Fraud Management Filters Summary](/docs/classic/fmf/integration-guide/FMFSummary/).
    /// </summary>

    public class FmfDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public FmfDetails() { }

        /// <summary>
        /// The filter description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description;

        /// <summary>
        /// REQUIRED
        /// The filter ID.
        /// </summary>
        [JsonPropertyName("filter_id")]
        public string FilterId;

        /// <summary>
        /// REQUIRED
        /// The filter type.
        /// </summary>
        [JsonPropertyName("filter_type")]
        public string FilterType;

        /// <summary>
        /// The filter name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;
    }
}

