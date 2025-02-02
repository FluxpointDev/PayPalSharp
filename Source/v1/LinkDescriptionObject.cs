﻿using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PayPal.v1
{
    /// <summary>
    /// The request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
    /// </summary>

    public class LinkDescriptionObject
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public LinkDescriptionObject() { }

        /// <summary>
        /// REQUIRED
        /// The complete target URL. To make the related call, combine the method with this link, in [URI template format](https://tools.ietf.org/html/rfc6570). Include the `$`, `(`, and `)` characters for pre-processing. The `href` is the key HATEOAS component that links a completed call with a subsequent call.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href;

        /// <summary>
        /// The HTTP method required to make the related call.
        /// </summary>
        [JsonPropertyName("method")]
        public LinkMethodType Method;

        /// <summary>
        /// REQUIRED
        /// The [link relation type](https://tools.ietf.org/html/rfc5988#section-4), which serves as an ID for a link that unambiguously describes the semantics of the link. See [Link Relations](https://www.iana.org/assignments/link-relations/link-relations.xhtml).
        /// </summary>
        [JsonPropertyName("rel")]
        public string Rel;
    }

    public enum LinkMethodType
    {
        [EnumMember(Value = "GET")]
        GET,

        [EnumMember(Value = "POST")]
        POST,

        [EnumMember(Value = "PUT")]
        PUT,

        [EnumMember(Value = "DELETE")]
        DELETE,

        [EnumMember(Value = "HEAD")]
        HEAD,

        [EnumMember(Value = "CONNECT")]
        CONNECT,

        [EnumMember(Value = "OPTIONS")]
        OPTIONS,

        [EnumMember(Value = "PATCH")]
        PATCH,
    }
}
