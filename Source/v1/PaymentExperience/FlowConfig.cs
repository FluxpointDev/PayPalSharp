




using System.Text.Json.Serialization;

namespace PayPal.v1.PaymentExperience
{
    /// <summary>
    /// The flow configuration parameters.
    /// </summary>

    public class FlowConfig
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public FlowConfig() { }

        /// <summary>
        /// The merchant site URL to display after a bank transfer payment. In Germany, valid only for the Giropay payment method or bank transfer payment method.
        /// </summary>
        [JsonPropertyName("bank_txn_pending_url")]
        public string BankTxnPendingUrl;

        /// <summary>
        /// The type of landing page to display on the PayPal site for user checkout. To use the non-PayPal account landing page, set to `Billing`. To use the PayPal account login landing page, set to `Login`.
        /// </summary>
        [JsonPropertyName("landing_page_type")]
        public string LandingPageType;

        /// <summary>
        /// The HTTP method to use to redirect the customer to a return URL. Value is `GET` or `POST`.
        /// </summary>
        [JsonPropertyName("return_uri_http_method")]
        public string ReturnUriHttpMethod;

        /// <summary>
        /// Presents either the <strong>Continue</strong> or <strong>Pay Now</strong> checkout flow to the customer.<br/><br/>Default is <strong>Continue</strong>, or <code>user_action=continue</code>. When you do not know the final payment amount, accept this default flow, which redirects the customer to the PayPal payment page with the <strong>Continue</strong> button. When the customer clicks <strong>Continue</strong>, the customer can change the payment amount.<br/><br/> When you know the final payment amount, set <code>user_action=commit</code> to choose the <strong>Pay Now</strong> flow, which redirects the customer to the PayPal payment page with the <strong>Pay Now</strong> button. When the customer clicks <strong>Pay Now</strong>, the payment is processed immediately.
        /// </summary>
        [JsonPropertyName("user_action")]
        public string UserAction;
    }
}

