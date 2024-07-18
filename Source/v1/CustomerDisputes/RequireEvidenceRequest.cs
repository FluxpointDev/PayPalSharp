

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// A request to update the state of a dispute, by ID, to either `WAITING_FOR_BUYER_RESPONSE` or `WAITING_FOR_SELLER_RESPONSE`. This state change enables either the buyer or seller to submit evidence for the dispute. If the `action` is `BUYER_EVIDENCE`, the `state` of the dispute updates to `WAITING_FOR_BUYER_RESPONSE`. If the action is `,SELLER_EVIDENCE`, the `state` of the dispute updates to `WAITING_FOR_SELLER_RESPONSE`.
    /// </summary>

    public class RequireEvidenceRequest
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public RequireEvidenceRequest() { }

        /// <summary>
        /// The action to complete.
        /// </summary>
        [JsonPropertyName("action")]
        public string Action;
    }
}

