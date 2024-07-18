




using System.Text.Json.Serialization;

namespace PayPal.v1.Orders
{
    /// <summary>
    /// The tokenized credit card details. You can use this instrument to fund a payment.
    /// </summary>

    public class CreditCardToken
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CreditCardToken() { }

        /// <summary>
        /// REQUIRED
        /// The ID of credit card that is stored in the PayPal vault.
        /// </summary>
        [JsonPropertyName("credit_card_id")]
        public string CreditCardId;

        /// <summary>
        /// The expiration month with no leading zero. Value is from `1` to `12`.
        /// </summary>
        [JsonPropertyName("expire_month")]
        public int? ExpireMonth;

        /// <summary>
        /// The four-digit expiration year.
        /// </summary>
        [JsonPropertyName("expire_year")]
        public int? ExpireYear;

        /// <summary>
        /// The last four digits of the stored credit card number.
        /// </summary>
        [JsonPropertyName("last4")]
        public string Last4;

        /// <summary>
        /// A unique ID that you can assign and track when you store a credit card in the vault or use a vaulted credit card. This ID can help to avoid unintentional use or misuse of credit cards. This ID can be any value you would like to associate with the saved card, such as a UUID, user name, or email address. **Required when you use a vaulted credit card if a `payer_id` was originally provided when you vaulted the credit card.**
        /// </summary>
        [JsonPropertyName("payer_id")]
        public string PayerId;

        /// <summary>
        /// The credit card type. Value is `visa`, `mastercard`, `discover`, or `amex`. Values are in lowercase; do not use these values for display.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type;
    }
}

