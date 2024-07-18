




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Audit information for the resource.
    /// </summary>

    public class Metadata
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Metadata() { }

        /// <summary>
        /// The actor who canceled the resource.
        /// </summary>
        [JsonPropertyName("cancelled_by")]
        public string CancelledBy;

        /// <summary>
        /// The date and time when the resource was canceled.
        /// </summary>
        [JsonPropertyName("cancelled_date")]
        public string CancelledDate;

        /// <summary>
        /// The email address of the account that created the resource.
        /// </summary>
        [JsonPropertyName("created_by")]
        public string CreatedBy;

        /// <summary>
        /// The date and time when the resource was created.
        /// </summary>
        [JsonPropertyName("created_date")]
        public string CreatedDate;

        /// <summary>
        /// The date and time when the resource was first sent.
        /// </summary>
        [JsonPropertyName("first_sent_date")]
        public string FirstSentDate;

        /// <summary>
        /// The email address of the account that last sent the resource.
        /// </summary>
        [JsonPropertyName("last_sent_by")]
        public string LastSentBy;

        /// <summary>
        /// The date and time when the resource was last sent.
        /// </summary>
        [JsonPropertyName("last_sent_date")]
        public string LastSentDate;

        /// <summary>
        /// The email address of the account that last edited the resource.
        /// </summary>
        [JsonPropertyName("last_updated_by")]
        public string LastUpdatedBy;

        /// <summary>
        /// The date and time when the resource was last edited.
        /// </summary>
        [JsonPropertyName("last_updated_date")]
        public string LastUpdatedDate;

        /// <summary>
        /// URL representing the payer's view of the invoice.
        /// </summary>
        [JsonPropertyName("payer_view_url")]
        public string PayerViewUrl;
    }
}

