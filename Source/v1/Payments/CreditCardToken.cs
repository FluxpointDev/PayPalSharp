// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.Payments
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
        /// The ID of credit card that is stored in the PayPal vault.<blockquote><strong>Important:</strong> The use of the PayPal REST <code>/payments</code> APIs to accept credit card payments is restricted. Instead, you can accept credit card payments with:<ul><li><a href="/docs/integration/direct/payments/guest-payments/">Guest payments</a> with a <a href="/docs/api/vault/#credit-card_create">credit card that is stored in the PayPal vault</a></li><li><a href="https://www.braintreepayments.com/products/braintree-direct">Braintree Direct</a></li><li><a href="https://www.paypal.com/us/webapps/mpp/merchant">PayPal business products</a></li></ul></blockquote>
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
        /// A unique ID that you can assign and track when you store a credit card in the vault or use a vaulted credit card. This ID can help to avoid unintentional use or misuse of credit cards and can be any value, such as a UUID, user name, or email address. **Required** when you use a vaulted credit card and if a `payer_id` was originally provided when you vaulted the credit card.
        /// </summary>
        [JsonPropertyName("payer_id")]
        public string PayerId;

        /// <summary>
        /// The credit card type. Value is `visa`, `mastercard`, `discover`, or `amex`. Do not use these lowercase values for display.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type;
    }
}

