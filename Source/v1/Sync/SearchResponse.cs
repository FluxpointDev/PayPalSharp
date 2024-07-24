




using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;


namespace PayPal.v1.Sync
{
    /// <summary>
    /// The search response information.
    /// </summary>

    public class SearchResponse
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public SearchResponse() { }

        /// <summary>
        /// The merchant account number.
        /// </summary>
        [JsonPropertyName("account_number")]
        public string AccountNumber;

        /// <summary>
        /// The end date and time or the last date when the data can be served, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate;

        /// <summary>
        /// The date and time when the data was last refreshed, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("last_refreshed_datetime")]
        public string LastRefreshedDateFormat;

        [JsonIgnore]
        public DateTime LastRefreshedDate => DateTime.Parse(LastRefreshedDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescription> Links;

        /// <summary>
        /// A zero-relative index of transactions.
        /// </summary>
        [JsonPropertyName("page")]
        public int? Page;

        /// <summary>
        /// The start date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate;

        /// <summary>
        /// The total number of transactions as an integer beginning with the specified `page` in the full result and not just in this response.
        /// </summary>
        [JsonPropertyName("total_items")]
        public int? TotalItems;

        /// <summary>
        /// The total number of pages, as an `integer`, when the `total_items` is divided into pages of the specified `page_size`.
        /// </summary>
        [JsonPropertyName("total_pages")]
        public int? TotalPages;

        /// <summary>
        /// An array of transaction detail objects.
        /// </summary>
        [JsonPropertyName("transaction_details")]
        public List<TransactionDetails> TransactionDetails;
    }
}

