

// @version 0.1.0-dev+291f3f


using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// A request by a merchant or buyer to provide evidence for a dispute.
    /// </summary>

    public class ProvideEvidenceRequest
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ProvideEvidenceRequest() { }

        /// <summary>
        /// An array of evidences for the dispute.
        /// </summary>
        [JsonPropertyName("evidences")]
        public List<Evidence> Evidences;
    }
}

