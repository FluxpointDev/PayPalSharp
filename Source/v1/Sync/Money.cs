




using System.Text.Json.Serialization;

namespace PayPal.v1.Sync
{
    /// <summary>
    /// The currency and amount for a financial value-related field. For example, balance or payment due.
    /// </summary>

    public class Money
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Money() { }

        /// <summary>
        /// REQUIRED
        /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/) that identifies the currency.
        /// </summary>
        [JsonPropertyName("currency_code")]
        public string CurrencyCode;

        /// <summary>
        /// REQUIRED
        /// The value, which might be:<ul><li>An integer for currencies like `JPY` that are not typically fractional.</li><li>A decimal fraction for currencies like `TND` that are subdivided into thousandths.</li></ul>For the required number of decimal places for a currency code, see [Currency codes - ISO 4217](https://www.iso.org/iso-4217-currency-codes.html).
        /// </summary>
        [JsonPropertyName("value")]
        public string Value;
    }
}

