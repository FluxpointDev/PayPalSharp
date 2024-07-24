

// @version 0.1.0-dev+291f3f


using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// Subsequent actions.
    /// </summary>

    public class SubsequentActions
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public SubsequentActions() { }

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/hateoas-links/).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescription> Links;
    }
}

