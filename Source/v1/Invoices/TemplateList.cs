




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// List of merchant templates.
    /// </summary>

    public class TemplateList
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public TemplateList() { }

        /// <summary>
        /// List of addresses in merchant profile.
        /// </summary>
        [JsonPropertyName("addresses")]
        public List<Address> Addresses;

        /// <summary>
        /// List of emails in merchant profile.
        /// </summary>
        [JsonPropertyName("emails")]
        public List<string> Emails;

        /// <summary>
        /// The HATEOAS links that provide related actions for the templates in the response.
        /// </summary>
        [JsonPropertyName("links")]
        public List<InvoiceLinkDescriptionObject> Links;

        /// <summary>
        /// List of phone numbers in merchant profile.
        /// </summary>
        [JsonPropertyName("phones")]
        public List<Phone> Phones;

        /// <summary>
        /// An array of templates.
        /// </summary>
        [JsonPropertyName("templates")]
        public List<Template> Templates;
    }
}

