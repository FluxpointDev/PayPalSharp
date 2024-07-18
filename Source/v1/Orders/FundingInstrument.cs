




using System.Text.Json.Serialization;

namespace PayPal.v1.Orders
{
    /// <summary>
    /// The funding instrument details. An instance of this schema is valid if and only if it validates against exactly one of these supported properties.
    /// </summary>

    public class FundingInstrument
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public FundingInstrument() { }

        /// <summary>
        /// [DEPRECATED] The credit card details. You can use this instrument to fund a payment. Use a payment card instead.
        /// </summary>
        [JsonPropertyName("credit_card")]
        public CreditCard CreditCard;

        /// <summary>
        /// The tokenized credit card details. You can use this instrument to fund a payment.
        /// </summary>
        [JsonPropertyName("credit_card_token")]
        public CreditCardToken CreditCardToken;
    }
}

