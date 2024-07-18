// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.Payments
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
        /// The email address associated with the payee's PayPal account. For an intent of authorize or order, the email address must be associated with a confirmed PayPal business account. For an intent of sale, the email can either:<ul><li>Be associated with a confirmed PayPal personal or business account.</li><li>Not be associated with a PayPal account.</li></ul>
        /// </summary>
        [JsonPropertyName("email")]
        public string Email;

        /// <summary>
        /// The PayPal account ID for the payee.
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

