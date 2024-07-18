// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.Payments
{
    /// <summary>
    /// The display-only metadata for the payee.
    /// </summary>

    public class PayeeDisplayMetadata
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PayeeDisplayMetadata() { }

        /// <summary>
        /// The payer's business name.
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName;

        /// <summary>
        /// The payee's phone number.
        /// </summary>
        [JsonPropertyName("display_phone")]
        public DisplayPhone DisplayPhone;

        /// <summary>
        /// The email address for the payer. Maximum length is 127 characters.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email;
    }
}

