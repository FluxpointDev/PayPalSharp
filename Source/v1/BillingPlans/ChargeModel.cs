




using System.Text.Json.Serialization;

namespace PayPal.v1.BillingPlans
{
    /// <summary>
    /// The shipping fee and tax information.
    /// </summary>

    public class ChargeModel
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ChargeModel() { }

        /// <summary>
        /// REQUIRED
        /// The base object for all financial value-related fields, such as balance, payment due, and so on.
        /// </summary>
        [JsonPropertyName("amount")]
        public Currency Amount;

        /// <summary>
        /// The ID of the charge model.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// REQUIRED
        /// The charge model type, which is tax or shipping.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type;
    }
}

