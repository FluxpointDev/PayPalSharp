




using System.Text.Json.Serialization;

namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// Information about the customer.
    /// </summary>

    public class PayerInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PayerInformation() { }

        /// <summary>
        /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
        /// </summary>
        [JsonPropertyName("billing_address")]
        public SimplePostalAddress BillingAddress;

        /// <summary>
        /// The customer's email address.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email;

        /// <summary>
        /// The customer's first name.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName;

        /// <summary>
        /// The customer's last name.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName;

        /// <summary>
        /// The PayPal-assigned ID for the customer.
        /// </summary>
        [JsonPropertyName("payer_id")]
        public string PayerId;
    }
}

