

// @version 0.1.0-dev+291f3f


using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// A list of disputes. Includes links that enable you to navigate through the response.
    /// </summary>

    public class DisputeSearchResponse
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public DisputeSearchResponse() { }

        /// <summary>
        /// An array of disputes that match the filter criteria. Sorted from latest to earliest creation time order.
        /// </summary>
        [JsonPropertyName("items")]
        public List<Dispute> Items;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/hateoas-links/).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescription> Links;

        /// <summary>
        /// The total number of items. If `total_required=true` was specified in the request, appears in the response.
        /// </summary>
        [JsonPropertyName("total_items")]
        public int? TotalItems;

        /// <summary>
        /// The total number of pages. If `total_required=true` was specified in the request, appears in the response.
        /// </summary>
        [JsonPropertyName("total_pages")]
        public int? TotalPages;
    }
}

