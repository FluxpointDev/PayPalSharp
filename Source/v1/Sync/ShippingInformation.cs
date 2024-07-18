




using System.Text.Json.Serialization;

namespace PayPal.v1.Sync
{
    /// <summary>
    /// The shipping information.
    /// </summary>

    public class ShippingInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ShippingInformation() { }

        /// <summary>
        /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
        /// </summary>
        [JsonPropertyName("address")]
        public SimplePostalAddress Address;

        /// <summary>
        /// The shipping method that is associated with this order.
        /// </summary>
        [JsonPropertyName("method")]
        public string Method;

        /// <summary>
        /// The recipient's name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;

        /// <summary>
        /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
        /// </summary>
        [JsonPropertyName("secondary_shipping_address")]
        public SimplePostalAddress SecondaryShippingAddress;
    }
}

