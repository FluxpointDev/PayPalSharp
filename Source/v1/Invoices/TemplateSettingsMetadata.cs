




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The template settings metadata.
    /// </summary>

    public class TemplateSettingsMetadata
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public TemplateSettingsMetadata() { }

        /// <summary>
        /// Indicates whether this field is hidden.
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool? Hidden;
    }
}

