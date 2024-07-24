




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.BillingPlans
{
    /// <summary>
    /// A list of plans. Contains details for each plan and a set of [HATEOAS links](/docs/api/overview/#hateoas-links).
    /// </summary>

    public class PlanList
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PlanList() { }

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// An array of plans.
        /// </summary>
        [JsonPropertyName("plans")]
        public List<Plan> Plans;

        /// <summary>
        /// The total number of plans in the list.
        /// </summary>
        [JsonPropertyName("total_items")]
        public string TotalItems;

        /// <summary>
        /// The total number of pages in the response. The `page_size` request value determines how many plans appear on each page. The `total_items` and `page_size` request values are used to calculate the total number of pages in the response.
        /// </summary>
        [JsonPropertyName("total_pages")]
        public string TotalPages;
    }
}

