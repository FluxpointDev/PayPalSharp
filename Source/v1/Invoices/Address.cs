




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Base Address object used as billing address in a payment or extended for Shipping Address.
    /// </summary>

    public class Address
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Address() { }

        /// <summary>
        /// REQUIRED
        /// City name.
        /// </summary>
        [JsonPropertyName("city")]
        public string City;

        /// <summary>
        /// REQUIRED
        /// 2 letter country code.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode;

        /// <summary>
        /// REQUIRED
        /// Line 1 of the Address (eg. number, street, etc).
        /// </summary>
        [JsonPropertyName("line1")]
        public string Line1;

        /// <summary>
        /// Optional line 2 of the Address (eg. suite, apt #, etc.).
        /// </summary>
        [JsonPropertyName("line2")]
        public string Line2;

        /// <summary>
        /// Phone number in E.123 format.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone;

        /// <summary>
        /// Zip code or equivalent is usually required for countries that have them. For list of countries that do not have postal codes please refer to http://en.wikipedia.org/wiki/Postal_code.
        /// </summary>
        [JsonPropertyName("postal_code")]
        public string PostalCode;

        /// <summary>
        /// 2 letter code for US states, and the equivalent for other countries.
        /// </summary>
        [JsonPropertyName("state")]
        public string State;
    }
}

