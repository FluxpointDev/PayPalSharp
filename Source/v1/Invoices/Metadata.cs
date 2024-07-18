




using System.Globalization;
using System;
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
        public string CancelledDateFormat;

        [JsonIgnore]
        public DateTime CancelledDate => DateTime.Parse(CancelledDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// The email address of the account that created the resource.
        /// </summary>
        [JsonPropertyName("created_by")]
        public string CreatedBy;

        /// <summary>
        /// The date and time when the resource was created.
        /// </summary>
        [JsonPropertyName("created_date")]
        public string CreatedDateFormat;

        [JsonIgnore]
        public DateTime CreatedDate => DateTime.Parse(CreatedDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// The date and time when the resource was first sent.
        /// </summary>
        [JsonPropertyName("first_sent_date")]
        public string FirstSentDateFormat;

        [JsonIgnore]
        public DateTime FirstSentDate => DateTime.Parse(FirstSentDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// The email address of the account that last sent the resource.
        /// </summary>
        [JsonPropertyName("last_sent_by")]
        public string LastSentBy;

        /// <summary>
        /// The date and time when the resource was last sent.
        /// </summary>
        [JsonPropertyName("last_sent_date")]
        public string LastSentDateFormat;

        [JsonIgnore]
        public DateTime LastSentDate => DateTime.Parse(LastSentDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// The email address of the account that last edited the resource.
        /// </summary>
        [JsonPropertyName("last_updated_by")]
        public string LastUpdatedBy;

        /// <summary>
        /// The date and time when the resource was last edited.
        /// </summary>
        [JsonPropertyName("last_updated_date")]
        public string LastUpdatedDateFormat;

        [JsonIgnore]
        public DateTime LastUpdatedDate => DateTime.Parse(LastUpdatedDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// URL representing the payer's view of the invoice.
        /// </summary>
        [JsonPropertyName("payer_view_url")]
        public string PayerViewUrl;
    }
}

