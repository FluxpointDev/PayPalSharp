

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// An uploaded document that supports a dispute. The API submits the document as a binary object.
    /// </summary>

    public class Document
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Document() { }

        /// <summary>
        /// The document name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;

        /// <summary>
        /// The document size.
        /// </summary>
        [JsonPropertyName("size")]
        public string Size;

        /// <summary>
        /// The document URI.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url;
    }
}

