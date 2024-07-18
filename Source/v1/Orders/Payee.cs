




using System.Text.Json.Serialization;

namespace PayPal.v1.Orders
{
    /// <summary>
    /// The payee who receives the funds and fulfills the order.
    /// </summary>

    public class Payee
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Payee() { }

        /// <summary>
        /// The email address associated with the payee's PayPal account. If the provided email address is not associated with any PayPal account, the payee can only receive PayPal Wallet payments. Direct credit card payments are denied due to card compliance requirements.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email;

        /// <summary>
        /// The encrypted PayPal account ID for the payee.
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId;

        /// <summary>
        /// The display-only metadata for the payee.
        /// </summary>
        [JsonPropertyName("payee_display_metadata")]
        public PayeeDisplayMetadata PayeeDisplayMetadata;
    }
}

