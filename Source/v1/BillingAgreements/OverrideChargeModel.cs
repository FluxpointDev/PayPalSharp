




using System.Text.Json.Serialization;

namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// A charge model that overrides default charge information during agreement creation.
    /// </summary>

    public class OverrideChargeModel
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public OverrideChargeModel() { }

        /// <summary>
        /// REQUIRED
        /// A type for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [JsonPropertyName("amount")]
        public MoneyTypeWithCurrencyCodeQualifiedValue Amount;

        /// <summary>
        /// REQUIRED
        /// The ID of the charge model.
        /// </summary>
        [JsonPropertyName("charge_id")]
        public string ChargeId;
    }
}

