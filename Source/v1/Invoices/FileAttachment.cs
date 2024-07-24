




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The file attached to an invoice or template.
    /// </summary>

    public class FileAttachment
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public FileAttachment() { }

        /// <summary>
        /// The name of the attached file.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;

        /// <summary>
        /// The URL of the attached file, which can be downloaded.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url;
    }
}

