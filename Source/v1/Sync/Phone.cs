




using System.Text.Json.Serialization;

namespace PayPal.v1.Sync
{
    /// <summary>
    /// The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
    /// </summary>

    public class Phone
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Phone() { }

        /// <summary>
        /// REQUIRED
        /// The country calling code (CC), in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en). The combined length of the CC and the national number must not be greater than 15 digits. The national number consists of a national destination code (NDC) and subscriber number (SN).
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode;

        /// <summary>
        /// The extension number.
        /// </summary>
        [JsonPropertyName("extension_number")]
        public string ExtensionNumber;

        /// <summary>
        /// REQUIRED
        /// The national number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en). The combined length of the country calling code (CC) and the national number must not be greater than 15 digits. The national number consists of a national destination code (NDC) and subscriber number (SN).
        /// </summary>
        [JsonPropertyName("national_number")]
        public string NationalNumber;
    }
}

