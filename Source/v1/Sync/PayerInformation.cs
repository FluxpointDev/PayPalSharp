




using System.Text.Json.Serialization;

namespace PayPal.v1.Sync
{
    /// <summary>
    /// The payer information.
    /// </summary>

    public class PayerInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PayerInformation() { }

        /// <summary>
        /// The PayPal` customer account ID.
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId;

        /// <summary>
        /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
        /// </summary>
        [JsonPropertyName("address")]
        public SimplePostalAddress Address;

        /// <summary>
        /// The address status of the payer. Value is either:<ul><li><code>Y</code>. Verified.</li><li><code>N</code>. Not verified.</li></ul>
        /// </summary>
        [JsonPropertyName("address_status")]
        public string AddressStatus;

        /// <summary>
        /// The [two-character ISO 3166-1 code](/docs/integration/direct/rest/country-codes/) that identifies the country or region.<blockquote><strong>Note:</strong> The country code for Great Britain is <code>GB</code> and not <code>UK</code> as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.</blockquote>
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode;

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [JsonPropertyName("email_address")]
        public string EmailAddress;

        /// <summary>
        /// The name of the party.
        /// </summary>
        [JsonPropertyName("payer_name")]
        public Name PayerName;

        /// <summary>
        /// The status of the payer. Value is `Verified` or `Unverified`.
        /// </summary>
        [JsonPropertyName("payer_status")]
        public string PayerStatus;

        /// <summary>
        /// The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
        /// </summary>
        [JsonPropertyName("phone_number")]
        public Phone PhoneNumber;
    }
}

