




using System.Text.Json.Serialization;

namespace PayPal.v1.Orders
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
        /// The billing address in a payment. Can be extended for shipping address.
        /// </summary>
        [JsonPropertyName("billing_address")]
        public Address BillingAddress;

        /// <summary>
        /// The birth date of the payer, in [Internet date format](https://tools.ietf.org/html/rfc3339#section-5.6). For example, `1990-04-12`.
        /// </summary>
        [JsonPropertyName("birth_date")]
        public string BirthDate;

        /// <summary>
        /// The payer's [two-character IS0-3166-1 country code](/docs/integration/direct/rest/country-codes/).
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode;

        /// <summary>
        /// The payer's email address. Maximum length is 127 characters.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email;

        /// <summary>
        /// The payer's first name.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName;

        /// <summary>
        /// The payer's last name.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName;

        /// <summary>
        /// The payer's middle name.
        /// </summary>
        [JsonPropertyName("middle_name")]
        public string MiddleName;

        /// <summary>
        /// The PayPal-assigned encrypted payer ID.
        /// </summary>
        [JsonPropertyName("payer_id")]
        public string PayerId;

        /// <summary>
        /// The payer's phone number. Maximum length is 20 characters.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone;

        /// <summary>
        /// The phone type.
        /// </summary>
        [JsonPropertyName("phone_type")]
        public string PhoneType;

        /// <summary>
        /// The payer's salutation.
        /// </summary>
        [JsonPropertyName("salutation")]
        public string Salutation;

        /// <summary>
        /// The shipping address details.
        /// </summary>
        [JsonPropertyName("shipping_address")]
        public ShippingAddress ShippingAddress;

        /// <summary>
        /// The payer's suffix.
        /// </summary>
        [JsonPropertyName("suffix")]
        public string Suffix;

        /// <summary>
        /// The payer’s tax ID. Supported for the PayPal payment method only.
        /// </summary>
        [JsonPropertyName("tax_id")]
        public string TaxId;

        /// <summary>
        /// The payer’s tax ID type. Supported for the PayPal payment method only.
        /// </summary>
        [JsonPropertyName("tax_id_type")]
        public string TaxIdType;
    }
}

