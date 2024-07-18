




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Billing information for the invoice recipient.
    /// </summary>

    public class BillingInfo
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public BillingInfo() { }

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
        /// The invoice recipient company business name.
        /// </summary>
        [JsonPropertyName("business_name")]
        public string BusinessName;

        /// <summary>
        /// REQUIRED
        /// The invoice recipient email address.<blockquote><strong>Note:</strong>Before you get a QR code, you must create an invoice that specifies `qrinvoice@paypal.com `as the recipient email address in the `billing_info` object. Use a customer email address only if you want to email the invoice.</blockquote>
        /// </summary>
        [JsonPropertyName("email")]
        public string Email;

        /// <summary>
        /// The invoice recipient first name.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName;

        /// <summary>
        /// The language in which an email can be sent to the recipient. Used only when the recipient lacks a PayPal account.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language;

        /// <summary>
        /// The invoice recipient last name.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName;

        /// <summary>
        /// The preferred notification channel for the recipient. Default is `EMAIL`. For `SMS`, a `phone` value is required.
        /// </summary>
        [JsonPropertyName("notification_channel")]
        public string NotificationChannel;

        /// <summary>
        /// The phone number.
        /// </summary>
        [JsonPropertyName("phone")]
        public Phone Phone;
    }
}

