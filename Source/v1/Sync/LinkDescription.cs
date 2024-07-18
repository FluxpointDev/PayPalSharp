




using System.Text.Json.Serialization;

namespace PayPal.v1.Sync
{
    /// <summary>
    /// The request-related [HATEOAS link](/docs/api/overview/#hateoas-links) information.
    /// </summary>

    public class LinkDescription
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public LinkDescription() { }

        /// <summary>
        /// REQUIRED
        /// The complete target URL. To make the related call, combine the method with this [URI Template-formatted](https://tools.ietf.org/html/rfc6570) link. For pre-processing, include the `$`, `(`, and `)` characters. The `href` is the key HATEOAS component that links a completed call with a subsequent call.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href;

        /// <summary>
        /// The HTTP method required to make the related call.
        /// </summary>
        [JsonPropertyName("method")]
        public string Method;

        /// <summary>
        /// REQUIRED
        /// The [link relation type](https://tools.ietf.org/html/rfc5988#section-4), which serves as an ID for a link that unambiguously describes the semantics of the link. See [Link Relations](https://www.iana.org/assignments/link-relations/link-relations.xhtml).
        /// </summary>
        [JsonPropertyName("rel")]
        public string Rel;
    }
}

