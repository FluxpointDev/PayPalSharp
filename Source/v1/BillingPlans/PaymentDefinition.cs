




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.BillingPlans
{
    /// <summary>
    /// A payment definition, which determines how often and for how long the customer is charged. Includes the interval at which the customer is charged, the charge amount, and optional shipping fees and taxes.
    /// </summary>

    public class PaymentDefinition
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentDefinition() { }

        /// <summary>
        /// REQUIRED
        /// The base object for all financial value-related fields, such as balance, payment due, and so on.
        /// </summary>
        [JsonPropertyName("amount")]
        public Currency Amount;

        /// <summary>
        /// An array of shipping fees and taxes.
        /// </summary>
        [JsonPropertyName("charge_models")]
        public List<ChargeModel> ChargeModels;

        /// <summary>
        /// REQUIRED
        /// The number of payment cycles. For infinite plans with a regular payment definition, set `cycles` to `0`.
        /// </summary>
        [JsonPropertyName("cycles")]
        public string Cycles;

        /// <summary>
        /// REQUIRED
        /// The frequency of the payment in this definition.
        /// </summary>
        [JsonPropertyName("frequency")]
        public string Frequency;

        /// <summary>
        /// REQUIRED
        /// The interval at which the customer is charged. Value cannot be greater than 12 months.
        /// </summary>
        [JsonPropertyName("frequency_interval")]
        public string FrequencyInterval;

        /// <summary>
        /// The ID of the payment definition.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// REQUIRED
        /// The payment definition name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;

        /// <summary>
        /// REQUIRED
        /// The payment definition type. Each plan must have at least one regular payment definition and, optionally, a trial payment definition. Each definition specifies how often and for how long the customer is charged.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type;
    }
}

