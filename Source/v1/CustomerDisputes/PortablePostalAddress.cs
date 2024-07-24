

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
    /// </summary>

    public class PortablePostalAddress
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PortablePostalAddress() { }

        /// <summary>
        /// The non-portable additional address details that are sometimes needed for compliance, risk, or other scenarios where fine-grain address information might be needed. Not portable with common third party and opensource. Redundant with core fields. For example, `address_portable.address_line_1` is usually a combination of `address_details.street_number` and `street_name` and `street_type`.
        /// </summary>
        [JsonPropertyName("address_details")]
        public AddressDetails AddressDetails;

        /// <summary>
        /// The first line of the address. For example, number, street, and so on. For example, `173 Drury Lane`. Required for data entry and compliance and risk checks. Must contain the full address.
        /// </summary>
        [JsonPropertyName("address_line_1")]
        public string AddressLine1;

        /// <summary>
        /// Optional. The second line of the address. For example, suite, apartment number, and so on.
        /// </summary>
        [JsonPropertyName("address_line_2")]
        public string AddressLine2;

        /// <summary>
        /// Optional. The third line of the address, if needed. Examples include street complement for Brazil, direction text such as `next to Walmart`, or landmark in Indian address.
        /// </summary>
        [JsonPropertyName("address_line_3")]
        public string AddressLine3;

        /// <summary>
        /// The highest level sub-division in a country, which is usually a province, state, or ISO-3166-2 subdivision. Format for postal delivery. For example, `CA` and not `California`. Value, by country, is:<ul><li>UK. A county.</li><li>US. A state.</li><li>Canada. A province.</li><li>Japan. A prefecture.</li><li>Switzerland. A kanton.</li></ul>
        /// </summary>
        [JsonPropertyName("admin_area_1")]
        public string AdminArea1;

        /// <summary>
        /// A city, town, or village. Smaller than `admin_area_level_1`.
        /// </summary>
        [JsonPropertyName("admin_area_2")]
        public string AdminArea2;

        /// <summary>
        /// A sub-locality, suburb, neighborhood, or district. Smaller than `admin_area_level_2`. Value is:<ul><li>Brazil. Suburb, bairro, or neighborhood.</li><li>India. Sub-locality or district. Street name information is not always available but a sub-locality or district can be a very small area.</li></ul>
        /// </summary>
        [JsonPropertyName("admin_area_3")]
        public string AdminArea3;

        /// <summary>
        /// The neighborhood, ward, or district. Smaller than `admin_area_level_3` or `sub_locality`. Value is:<ul><li>The postal sorting code that is used in Guernsey and many French territories, such as French Guiana.</li><li>The fine-grained administrative levels in China.</li></ul>
        /// </summary>
        [JsonPropertyName("admin_area_4")]
        public string AdminArea4;

        /// <summary>
        /// REQUIRED
        /// The [two-character ISO 3166-1 code](/docs/integration/direct/rest/country-codes/) that identifies the country or region.<blockquote><strong>Note:</strong> The country code for Great Britain is <code>GB</code> and not <code>UK</code> as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.</blockquote>
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode;

        /// <summary>
        /// The postal code, which is the zip code or equivalent. Typically required for countries with a postal code or an equivalent. See [postal code](https://en.wikipedia.org/wiki/Postal_code).
        /// </summary>
        [JsonPropertyName("postal_code")]
        public string PostalCode;
    }
}

