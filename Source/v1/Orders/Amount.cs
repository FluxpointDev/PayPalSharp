




using System.Text.Json.Serialization;

namespace PayPal.v1.Orders
{
    /// <summary>
    /// The payment amount, with details.
    /// </summary>

    public class Amount
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Amount() { }

        /// <summary>
        /// REQUIRED
        /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/). PayPal does not support all currencies.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency;

        /// <summary>
        /// The additional details about the payment amount.
        /// </summary>
        [JsonPropertyName("details")]
        public PaymentAmountDetails Details;

        /// <summary>
        /// REQUIRED
        /// The total amount charged to the payee by the payer. For refunds, represents the amount that the payee refunds to the original payer. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>
        /// </summary>
        [JsonPropertyName("total")]
        public string Total;
    }
}

