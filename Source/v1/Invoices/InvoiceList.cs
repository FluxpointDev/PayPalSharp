




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// List of merchant invoices. Can include the total invoices count and HATEOAS links for navigation.
    /// </summary>

    public class InvoiceList
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public InvoiceList() { }

        /// <summary>
        /// An array of invoices as search result.
        /// </summary>
        [JsonPropertyName("invoices")]
        public List<Invoice> Invoices;

        /// <summary>
        /// The HATEOAS links for `next` and `previous` navigation in the result set.
        /// </summary>
        [JsonPropertyName("links")]
        public List<InvoiceLinkDescriptionObject> Links;

        /// <summary>
        /// The total number of invoices that match the search criteria.
        /// </summary>
        [JsonPropertyName("total_count")]
        public int? TotalCount;
    }
}

