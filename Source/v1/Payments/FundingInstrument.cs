// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.Payments
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
        /// Deprecated. The credit card details. You can use this instrument to fund a payment. Use a payment card instead.
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

