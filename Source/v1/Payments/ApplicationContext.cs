// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.Payments
{
    /// <summary>
    /// Use the application context resource to customize payment flow experience for your buyers.
    /// </summary>

    public class ApplicationContext
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ApplicationContext() { }

        /// <summary>
        /// A label that Overrides the business name in the Merchant's PayPal account on the PayPal checkout pages.Character length and limitations: 127 single-byte alphanumeric characters.
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName;

        /// <summary>
        /// The type of landing page to display on the PayPal site for user checkout. To use the non-PayPal account landing page, set to `Billing`. To use the PayPal account login landing page, set to `Login`.
        /// </summary>
        [JsonPropertyName("landing_page")]
        public string LandingPage;

        /// <summary>
        /// The locale of pages that the PayPal payment experience displays. A valid value is `AU`, `AT`, `BE`, `BR`, `CA`, `CH`, `CN`, `DE`, `ES`, `GB`, `FR`, `IT`, `NL`, `PL`, `PT`, `RU`, or `US`. A 5-character code is also valid for languages in these countries: `da_DK`, `he_IL`, `id_ID`, `ja_JP`, `no_NO`, `pt_BR`, `ru_RU`, `sv_SE`, `th_TH`, `zh_CN`, `zh_HK`, or `zh_TW`.
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale;

        /// <summary>
        /// Specify Shipping Preferences:<ul><li><code>NO_SHIPPING</code>  Redacts shipping address fields from the PayPal pages. Recommended value to use for digital goods.</li><li><code>GET_FROM_FILE</code> (default) Get the shipping address selected by the buyer on PayPal pages.</li><li><code>SET_PROVIDED_ADDRESS</code>  Use the address provided by the merchant. Buyer is not able to change the address on the PayPal pages. If merchant doesn't pass an address buyer has the option to choose the address on PayPal pages.</li></ul>.
        /// </summary>
        [JsonPropertyName("shipping_preferences")]
        public string ShippingPreferences;

        /// <summary>
        /// Defines whether to present the buyer with a  Continue  or  Pay Now  checkout flow.For <strong>Pay Now</strong> checkout flow, set  user_action=commit .Once buyer is redirected to the PayPal payment page, a <strong>Pay Now</strong> button is shown. Use this option when final amount is known when checkout is initiated and you want to process payment immediately upon buyer clicking Pay Now. For <strong>Continue</strong> checkout flow, set user_action=continue (default).Once buyer is redirected to the PayPal payment page, a <Strong>Continue</Strong> button is shown. Use this option when final amount is not known when you initiate the checkout flow and you want to redirect the buyer to the merchant page without processing the payment.
        /// </summary>
        [JsonPropertyName("user_action")]
        public string UserAction;
    }
}

