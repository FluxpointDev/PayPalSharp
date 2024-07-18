// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.Payments
{
    /// <summary>
    /// A set of redirect URLs that you provide for PayPal-based payments.
    /// </summary>

    public class RedirectUrls
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public RedirectUrls() { }

        /// <summary>
        /// The URL where the payer is redirected after he or she cancels the payment. **Required for PayPal account payments**.
        /// </summary>
        [JsonPropertyName("cancel_url")]
        public string CancelUrl;

        /// <summary>
        /// The URL where the payer is redirected after he or she approves the payment. **Required for PayPal account payments**.
        /// </summary>
        [JsonPropertyName("return_url")]
        public string ReturnUrl;
    }
}

