




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The shipping information for the invoice recipient.
    /// </summary>

    public class ShippingInfo
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ShippingInfo() { }

        /// <summary>
        /// Base Address object used as billing address in a payment or extended for Shipping Address.
        /// </summary>
        [JsonPropertyName("address")]
        public Address Address;

        /// <summary>
        /// The invoice recipient company business name.
        /// </summary>
        [JsonPropertyName("business_name")]
        public string BusinessName;

        /// <summary>
        /// The invoice recipient first name.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName;

        /// <summary>
        /// The invoice recipient last name.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName;
    }
}

