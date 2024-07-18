




using System.Text.Json.Serialization;

namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// A type for all financial value-related fields. For example, balance, payment due, and so on.
    /// </summary>

    public class MoneyTypeWithCurrencyCodeQualifiedValue
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public MoneyTypeWithCurrencyCodeQualifiedValue() { }

        /// <summary>
        /// REQUIRED
        /// The [three-character ISO-4217 currency code](https://developer.paypal.com/docs/integration/direct/rest/currency-codes/).
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency;

        /// <summary>
        /// REQUIRED
        /// The currency value. Might be an integer for currencies like `JPY` that are not typically fractional or a three-place decimal fraction for currencies like `TND` that are subdivided into thousandths. For the required number of decimal places for a currency code, see [ISO 4217](http://www.iso.org/iso/home/standards/currency_codes.htm).
        /// </summary>
        [JsonPropertyName("value")]
        public string Value;
    }
}

