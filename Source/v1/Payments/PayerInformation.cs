// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.Payments
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
        /// The billing address or shipping address for a payment.
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
        /// The extended address, which is used as the shipping address in a payment.
        /// </summary>
        [JsonPropertyName("shipping_address")]
        public ShippingAddress ShippingAddress;

        /// <summary>
        /// The payer's suffix.
        /// </summary>
        [JsonPropertyName("suffix")]
        public string Suffix;

        /// <summary>
        /// The payer's tax ID. Supported for the PayPal payment method only.
        /// </summary>
        [JsonPropertyName("tax_id")]
        public string TaxId;

        /// <summary>
        /// The payer's tax ID type. Supported for the PayPal payment method only.
        /// </summary>
        [JsonPropertyName("tax_id_type")]
        public string TaxIdType;
    }
}

