




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Participant information.
    /// </summary>

    public class Participant
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Participant() { }

        /// <summary>
        /// Additional information, such as business hours.
        /// </summary>
        [JsonPropertyName("additional_info")]
        public string AdditionalInfo;

        /// <summary>
        /// Base Address object used as billing address in a payment or extended for Shipping Address.
        /// </summary>
        [JsonPropertyName("address")]
        public Address Address;

        /// <summary>
        /// The participant company business name.
        /// </summary>
        [JsonPropertyName("business_name")]
        public string BusinessName;

        /// <summary>
        /// REQUIRED
        /// The participant email address.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email;

        /// <summary>
        /// The phone number.
        /// </summary>
        [JsonPropertyName("fax")]
        public Phone Fax;

        /// <summary>
        /// The participant first name.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName;

        /// <summary>
        /// The participant last name.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName;

        /// <summary>
        /// The phone number.
        /// </summary>
        [JsonPropertyName("phone")]
        public Phone Phone;

        /// <summary>
        /// The participant website.
        /// </summary>
        [JsonPropertyName("website")]
        public string Website;
    }
}

