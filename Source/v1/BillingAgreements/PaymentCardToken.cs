




using System.Text.Json.Serialization;

namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// A token for a payment card that can be used to fund a payment.
    /// </summary>

    public class PaymentCardToken
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentCardToken() { }

        /// <summary>
        /// The expiry month from the vaulted card. Value is from `1` to `12`.
        /// </summary>
        [JsonPropertyName("expire_month")]
        public int? ExpireMonth;

        /// <summary>
        /// The four-digit expiry year from the vaulted card, in `YYYY` format.
        /// </summary>
        [JsonPropertyName("expire_year")]
        public int? ExpireYear;

        /// <summary>
        /// REQUIRED
        /// The ID of the customer who owns this payment card.
        /// </summary>
        [JsonPropertyName("external_customer_id")]
        public string ExternalCustomerId;

        /// <summary>
        /// The last four digits of the card number from the vaulted card.
        /// </summary>
        [JsonPropertyName("last4")]
        public string Last4;

        /// <summary>
        /// REQUIRED
        /// The ID of the vaulted payment card.
        /// </summary>
        [JsonPropertyName("payment_card_id")]
        public string PaymentCardId;

        /// <summary>
        /// REQUIRED
        /// The card type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type;
    }
}

