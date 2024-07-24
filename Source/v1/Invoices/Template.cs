




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Invoicing template.
    /// </summary>

    public class Template
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Template() { }

        /// <summary>
        /// Indicates whether this template is a merchant-created custom template. Non-custom templates are system generated.
        /// </summary>
        [JsonPropertyName("custom")]
        public bool? Custom;

        /// <summary>
        /// Indicates whether this template is the default merchant template. A merchant can have one default template.
        /// </summary>
        [JsonPropertyName("default")]
        public bool? Default;

        /// <summary>
        /// The HATEOS links that enable template actions.
        /// </summary>
        [JsonPropertyName("links")]
        public List<InvoiceLinkDescriptionObject> Links;

        /// <summary>
        /// The template name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;

        /// <summary>
        /// Settings for each template.
        /// </summary>
        [JsonPropertyName("settings")]
        public List<TemplateSettings> Settings;

        /// <summary>
        /// Template data.
        /// </summary>
        [JsonPropertyName("template_data")]
        public TemplateData TemplateData;

        /// <summary>
        /// The ID of the template.
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId;

        /// <summary>
        /// The unit of measure for the template. Value is quantity, hours, or amount.
        /// </summary>
        [JsonPropertyName("unit_of_measure")]
        public string UnitOfMeasure;
    }
}

