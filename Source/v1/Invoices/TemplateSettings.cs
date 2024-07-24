




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The template settings.
    /// </summary>

    public class TemplateSettings
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public TemplateSettings() { }

        /// <summary>
        /// The template settings metadata.
        /// </summary>
        [JsonPropertyName("display_preference")]
        public TemplateSettingsMetadata DisplayPreference;

        /// <summary>
        /// The field name for any field in `template_data` for which to map corresponding display preferences.
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName;
    }
}

