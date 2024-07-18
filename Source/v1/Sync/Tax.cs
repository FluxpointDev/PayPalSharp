




using System.Text.Json.Serialization;

namespace PayPal.v1.Sync
{
    /// <summary>
    /// The tax levied by a government on the purchase of goods or services.
    /// </summary>

    public class Tax
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Tax() { }

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("tax_amount")]
        public Money TaxAmount;
    }
}

