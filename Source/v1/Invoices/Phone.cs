




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The phone number.
    /// </summary>

    public class Phone
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Phone() { }

        /// <summary>
        /// The country calling code (CC), as defined by E.164. The maximum combined length of CC+national is 15 digits.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode;

        /// <summary>
        /// The national number, as defined by E.164. A national number consists of national destination code (NDC) and subscriber number (SN). The maximum combined length of CC+national is 15 digits.
        /// </summary>
        [JsonPropertyName("national_number")]
        public string NationalNumber;
    }
}

