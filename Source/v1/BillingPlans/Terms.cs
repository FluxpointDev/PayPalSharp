




using System.Text.Json.Serialization;

namespace PayPal.v1.BillingPlans
{
    /// <summary>
    /// The terms for the plan.
    /// </summary>

    public class Terms
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Terms() { }

        /// <summary>
        /// REQUIRED
        /// The base object for all financial value-related fields, such as balance, payment due, and so on.
        /// </summary>
        [JsonPropertyName("amount_range")]
        public Currency AmountRange;

        /// <summary>
        /// REQUIRED
        /// Indicates whether the customer can edit the amount in this term.
        /// </summary>
        [JsonPropertyName("buyer_editable")]
        public string BuyerEditable;

        /// <summary>
        /// The ID of the terms.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// REQUIRED
        /// The base object for all financial value-related fields, such as balance, payment due, and so on.
        /// </summary>
        [JsonPropertyName("max_billing_amount")]
        public Currency MaxBillingAmount;

        /// <summary>
        /// REQUIRED
        /// The number of times that money can be pulled during this term.
        /// </summary>
        [JsonPropertyName("occurrences")]
        public string Occurrences;

        /// <summary>
        /// REQUIRED
        /// The term type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type;
    }
}

