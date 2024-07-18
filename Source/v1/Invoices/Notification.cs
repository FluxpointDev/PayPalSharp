




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The email or SMS notification.
    /// </summary>

    public class Notification
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Notification() { }

        /// <summary>
        /// An array of one or more CC: emails. If you omit this parameter from the JSON request body, a notification is sent to all CC: email addresses that are part of the invoice. Otherwise, specify this parameter to limit the email addresses to which notifications are sent.<blockquote><strong>Note:</strong> Additional email addresses are not supported.</blockquote>
        /// </summary>
        [JsonPropertyName("cc_emails")]
        public List<string> CcEmails;

        /// <summary>
        /// A note to the payer.
        /// </summary>
        [JsonPropertyName("note")]
        public string Note;

        /// <summary>
        /// Indicates whether to send a copy of the email to the merchant.
        /// </summary>
        [JsonPropertyName("send_to_merchant")]
        public bool? SendToMerchant;

        /// <summary>
        /// The subject of the notification.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject;
    }
}

