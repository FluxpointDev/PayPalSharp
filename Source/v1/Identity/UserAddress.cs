using System.Text.Json.Serialization;

namespace PayPal.v1.Identity
{
    /// <summary>
    /// The end user's preferred address.
    /// </summary>

    public class UserAddress
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public UserAddress() { }

        /// <summary>
        /// The country.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country;

        /// <summary>
        /// The city or locality.
        /// </summary>
        [JsonPropertyName("locality")]
        public string Locality;

        /// <summary>
        /// The zip code or postal code.
        /// </summary>
        [JsonPropertyName("postal_code")]
        public string PostalCode;

        /// <summary>
        /// The state, province, prefecture, or region.
        /// </summary>
        [JsonPropertyName("region")]
        public string Region;

        /// <summary>
        /// The full street address. Can include the house number and street name.
        /// </summary>
        [JsonPropertyName("street_address")]
        public string StreetAddress;
    }
}

