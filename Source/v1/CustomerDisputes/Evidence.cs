

// @version 0.1.0-dev+291f3f


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;


namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// A merchant- or customer-submitted evidence document.
    /// </summary>

    public class Evidence
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Evidence() { }

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [JsonPropertyName("date")]
        public string DateFormat;

        [JsonIgnore]
        public DateTime Date => DateTime.Parse(DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// An array of documents that were submitted as evidence.
        /// </summary>
        [JsonPropertyName("documents")]
        public List<Document> Documents;

        /// <summary>
        /// The evidence-related information.
        /// </summary>
        [JsonPropertyName("evidence_info")]
        public EvidenceInformation EvidenceInfo;

        /// <summary>
        /// The type of evidence.
        /// </summary>
        [JsonPropertyName("evidence_type")]
        public string EvidenceType;

        /// <summary>
        /// The ID of the item.
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId;

        /// <summary>
        /// Any evidence-related notes.
        /// </summary>
        [JsonPropertyName("notes")]
        public string Notes;

        /// <summary>
        /// The source of the evidence. Indicates whether PayPal requested the evidence, the customer submitted the evidence, or the merchant submitted the evidence.
        /// </summary>
        [JsonPropertyName("source")]
        public string Source;
    }
}

