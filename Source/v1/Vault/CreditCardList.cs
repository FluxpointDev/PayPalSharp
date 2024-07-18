




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Vault
{
    /// <summary>
    /// A list of credit cards.
    /// </summary>

    public class CreditCardList
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CreditCardList() { }

        /// <summary>
        /// An array of credit card objects.
        /// </summary>
        [JsonPropertyName("items")]
        public List<CreditCard> Items;

        /// <summary>
        /// The credit card-specific [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// The total number of items.
        /// </summary>
        [JsonPropertyName("total_items")]
        public int? TotalItems;

        /// <summary>
        /// The total number of pages.
        /// </summary>
        [JsonPropertyName("total_pages")]
        public int? TotalPages;
    }
}

