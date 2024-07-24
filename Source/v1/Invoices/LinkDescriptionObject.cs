




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The [HATEOAS links](/docs/api/hateoas-links/) related to the request.
    /// </summary>

    public class InvoiceLinkDescriptionObject : LinkDescriptionObject
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public InvoiceLinkDescriptionObject() { }

        /// <summary>
        /// The media type in which to submit data in the request.
        /// </summary>
        [JsonPropertyName("encType")]
        public string EncType;

        /// <summary>
        /// The media type, as defined by RFC 2046, that describes the link target.
        /// </summary>
        [JsonPropertyName("mediaType")]
        public string MediaType;

        /// <summary>
        /// The link title.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title;
    }
}

