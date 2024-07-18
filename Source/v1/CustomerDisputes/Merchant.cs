

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// The details for the merchant who receives the funds and fulfills the order. For example, merchant ID, contact email address, and so on.
    /// </summary>

    public class Merchant
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Merchant() { }

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [JsonPropertyName("email")]
        public string Email;

        /// <summary>
        /// The PayPal account ID for the merchant.
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId;

        /// <summary>
        /// The name of the merchant.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;
    }
}

