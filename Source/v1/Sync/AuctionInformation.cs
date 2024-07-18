




using System.Globalization;
using System;
using System.Text.Json.Serialization;

namespace PayPal.v1.Sync
{
    /// <summary>
    /// The auction information.
    /// </summary>

    public class AuctionInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AuctionInformation() { }

        /// <summary>
        /// The ID of the buyer who makes the purchase in the auction. This ID might be different from the payer ID provided for the payment.
        /// </summary>
        [JsonPropertyName("auction_buyer_id")]
        public string AuctionBuyerId;

        /// <summary>
        /// The date and time when the auction closes, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("auction_closing_date")]
        public string AuctionClosingDateFormat;

        [JsonIgnore]
        public DateTime AuctionClosingDate => DateTime.Parse(AuctionClosingDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// The auction site URL.
        /// </summary>
        [JsonPropertyName("auction_item_site")]
        public string AuctionItemSite;

        /// <summary>
        /// The name of the auction site.
        /// </summary>
        [JsonPropertyName("auction_site")]
        public string AuctionSite;
    }
}

