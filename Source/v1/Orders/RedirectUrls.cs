




using System.Text.Json.Serialization;

namespace PayPal.v1.Orders
{
    /// <summary>
    /// The redirect URLs. Required only for the PayPal payment method. The supported settings are return and cancel URLs.
    /// </summary>

    public class RedirectUrls
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public RedirectUrls() { }

        /// <summary>
        /// The URL where the payer is redirected after he or she cancels the payment.
        /// </summary>
        [JsonPropertyName("cancel_url")]
        public string CancelUrl;

        /// <summary>
        /// The URL where the payer is redirected after he or she approves the payment.
        /// </summary>
        [JsonPropertyName("return_url")]
        public string ReturnUrl;
    }
}

