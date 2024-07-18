

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// The outcome of a dispute.
    /// </summary>

    public class DisputeOutcome
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public DisputeOutcome() { }

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("amount_refunded")]
        public Money AmountRefunded;

        /// <summary>
        /// The outcome of a resolved dispute. Value is:<ul><li><code>RESOLVED_BUYER_FAVOUR</code>. The dispute was resolved in the customer's favor.</li><li><code>RESOLVED_SELLER_FAVOUR</code>. The dispute was resolved in the merchant's favor.</li><li><code>RESOLVED_WITH_PAYOUT</code>. PayPal provided the merchant or customer with protection and the case is resolved.</li><li><code>CANCELED_BY_BUYER</code>. The customer canceled the dispute.</li><li><code>ACCEPTED</code>. The dispute was accepted.</li><li><code>DENIED</code>. The dispute was denied.</li><li>Empty. The dispute was not resolved.</li></ul>
        /// </summary>
        [JsonPropertyName("outcome_code")]
        public string OutcomeCode;
    }
}

