




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The custom amount to apply to an invoice. If you include a label, you must include a custom amount.
    /// </summary>

    public class CustomAmount
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CustomAmount() { }

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [JsonPropertyName("amount")]
        public Currency Amount;

        /// <summary>
        /// The custom amount label.
        /// </summary>
        [JsonPropertyName("label")]
        public string Label;
    }
}

