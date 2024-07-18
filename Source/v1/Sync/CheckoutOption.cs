




using System.Text.Json.Serialization;

namespace PayPal.v1.Sync
{
    /// <summary>
    /// A checkout option as a name-and-value pair.
    /// </summary>

    public class CheckoutOption
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CheckoutOption() { }

        /// <summary>
        /// The checkout option name, which is a characteristic of an item, such as `color` or `texture`.
        /// </summary>
        [JsonPropertyName("checkout_option_name")]
        public string CheckoutOptionName;

        /// <summary>
        /// The checkout option value. For example, the checkout option `color` might be `blue` or `red` while the checkout option `texture` might be `smooth` or `rippled`.
        /// </summary>
        [JsonPropertyName("checkout_option_value")]
        public string CheckoutOptionValue;
    }
}

