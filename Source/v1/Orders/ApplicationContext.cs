




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Orders
{
    /// <summary>
    /// The application context experience information.
    /// </summary>

    public class ApplicationContext
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ApplicationContext() { }

        /// <summary>
        /// A label that overrides the business name in the PayPal account on the PayPal pages. Maximum length is 127 single-byte alphanumeric characters.
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName;

        /// <summary>
        /// The type of landing page to display on the PayPal site for user checkout. To use the non-PayPal account landing page, set to `Billing`. To use the PayPal account login landing page, set to `Login`.
        /// </summary>
        [JsonPropertyName("landing_page")]
        public string LandingPage;

        /// <summary>
        /// A [BCP-47 language tag](https://tools.ietf.org/html/bcp47#section-2), which is made up of the [ISO 639-2 language code](https://www.loc.gov/standards/iso639-2/php/code_list.php), the optional [ISO-15924 script tag](http://www.unicode.org/iso15924/codelists.html), and the [ISO-3166 alpha-2 country code](/docs/integration/direct/rest/country-codes/).
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale;

        /// <summary>
        /// An array of name-and-value pairs that contain external data, such as user feedback, score, and so on.
        /// </summary>
        [JsonPropertyName("postback_data")]
        public List<NameAndValuePair> PostbackData;

        /// <summary>
        /// Specify Shipping Preferences:<ul><li><code>NO_SHIPPING</code>  Redacts shipping address fields from the PayPal pages. Recommended value to use for digital goods.</li><li><code>GET_FROM_FILE</code>  Get the shipping address selected by the buyer on PayPal pages.</li><li><code>SET_PROVIDED_ADDRESS</code>  Use the address provided by the merchant. Buyer is not able to change the address on the PayPal pages. If merchant doesn't pass an address buyer has the option to choose the address on PayPal pages.</li></ul>.
        /// </summary>
        [JsonPropertyName("shipping_preference")]
        public string ShippingPreference;

        /// <summary>
        /// An array of name-and-value pairs that contain supplementary data required by PayPal for transaction processing.
        /// </summary>
        [JsonPropertyName("supplementary_data")]
        public List<NameAndValuePair> SupplementaryData;

        /// <summary>
        /// Defines whether to present the customer with a <strong>Continue</strong> or <strong>Pay Now</strong> checkout flow. To present buyers with the <strong>Pay Now</strong> checkout flow, set <code>useraction=commit</code>. Default is the <strong>Continue</strong> checkout flow.<table><thead><tr><th>Checkout&nbsp;flow</th><th>Choose when</th><th>Description</th></tr></thead><tbody><tr><td><strong>Continue</strong></td><td>You do not know the final payment amount when you initiate the checkout flow.</td><td>The default flow. Redirects the customer to the PayPal payment page, which shows the <strong>Continue</strong> button. When the customer clicks <strong>Continue</strong>, the customer can change the payment amount.</td></tr><tr><td><strong>Pay Now</strong></td><td>You know the final payment amount when you initiate the checkout flow.</td><td>Set <code>user_action=commit</code>. Redirects the customer to the PayPal payment page, which shows the <strong>Pay Now</strong> button. When the customer clicks <strong>Pay Now</strong>, the payment is processed immediately.</td></tr></tbody></table>
        /// </summary>
        [JsonPropertyName("user_action")]
        public string UserAction;
    }
}

