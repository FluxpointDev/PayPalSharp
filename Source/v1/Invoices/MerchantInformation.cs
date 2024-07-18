




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Merchant business information that appears on the invoice.
    /// </summary>

    public class MerchantInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public MerchantInformation() { }

        /// <summary>
        /// Additional information, such as business hours.
        /// </summary>
        [JsonPropertyName("additional_info")]
        public string AdditionalInfo;

        /// <summary>
        /// A label for the `additional_info` field.
        /// </summary>
        [JsonPropertyName("additional_info_label")]
        public string AdditionalInfoLabel;

        /// <summary>
        /// Base Address object used as billing address in a payment or extended for Shipping Address.
        /// </summary>
        [JsonPropertyName("address")]
        public Address Address;

        /// <summary>
        /// The merchant company business name.
        /// </summary>
        [JsonPropertyName("business_name")]
        public string BusinessName;

        /// <summary>
        /// REQUIRED
        /// The merchant email address.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email;

        /// <summary>
        /// The phone number.
        /// </summary>
        [JsonPropertyName("fax")]
        public Phone Fax;

        /// <summary>
        /// The merchant first name.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName;

        /// <summary>
        /// The merchant last name.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName;

        /// <summary>
        /// The phone number.
        /// </summary>
        [JsonPropertyName("phone")]
        public Phone Phone;

        /// <summary>
        /// The merchant tax ID.
        /// </summary>
        [JsonPropertyName("tax_id")]
        public string TaxId;

        /// <summary>
        /// The merchant website.
        /// </summary>
        [JsonPropertyName("website")]
        public string Website;
    }
}

