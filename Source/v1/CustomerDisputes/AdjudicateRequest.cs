

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// A request to adjudicate a dispute in either the buyer's or seller's favor.
    /// </summary>

    public class AdjudicateRequest
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AdjudicateRequest() { }

        /// <summary>
        /// The outcome of the adjudication.
        /// </summary>
        [JsonPropertyName("adjudication_outcome")]
        public string AdjudicationOutcome;
    }
}

