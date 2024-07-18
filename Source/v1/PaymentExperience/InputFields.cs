




using System.Text.Json.Serialization;

namespace PayPal.v1.PaymentExperience
{
    /// <summary>
    /// The input field customization parameters.
    /// </summary>

    public class InputFields
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public InputFields() { }

        /// <summary>
        /// Indicates whether to display the shipping address that is passed to this call rather than the one on file for this buyer on the PayPal experience pages. Value is:<ul><li><code>0</code>. Displays the shipping address on file.</li><li><code>1</code>. Displays the shipping address specified in this call. the customer cannot edit this shipping address.</li></ul>
        /// </summary>
        [JsonPropertyName("address_override")]
        public int? AddressOverride;

        /// <summary>
        /// Indicates whether the customer can enter a note to the merchant on the PayPal page during checkout.
        /// </summary>
        [JsonPropertyName("allow_note")]
        public bool? AllowNote;

        /// <summary>
        /// Indicates whether PayPal displays shipping address fields on the experience pages. Value is:<ul><li><code>0</code>. Displays the shipping address on the PayPal pages.</li><li><code>1</code>. Redacts shipping address fields from the PayPal pages. For digital goods, this field is required and must be <code>1</code>.</li><li><code>2</code>. Gets the shipping address from the customer's account profile.</li></ul>
        /// </summary>
        [JsonPropertyName("no_shipping")]
        public int? NoShipping;
    }
}

