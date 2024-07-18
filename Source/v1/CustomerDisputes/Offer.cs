

// @version 0.1.0-dev+291f3f

// @data H4sIAAAAAAAC/6yT0WvbTgzH339/hbinFpy4v20wyFtZKWxjbdnKYHShVe7kWOx85+p0zczo/z7sxGnTdIxBn8zpdJK+H3/1y1x2LZmZOa8qElOYryiMC09n2PRhU5iP1D0cTihZ4VY5BjMzlzUBhypKg30EqiigNUHsi4HWqICwyB0JRIFE3pNAK7GNidI223Fqs9LUFOZYBLv1REeF+UzozoPvzKxCn6gP3GYWctvAhcSWRJmSmV1ttXyKgbp9LcMg10K3mZKSu8Ym5qA7Cv+Ysq/bZhEKtgMMDtZ5gyKEigMGy+jhDn2miZBHJQcVk3dTOI0C9BOb1lMBC/QYLPV4WuwaCgouvyCKpMJhuc9inP7aRkc7CJ7e7Cu/0lqIJrZGQask8P7L+eTNq//fPjDp384PShdtKjkoLWUwSOlYyGoplLQckyd9cioP135hR0G5YkqDN8akfyKikp8ACdn7++KvVIb/tUNjjOxTGG4KWNVsa2h4WSssaPY9Hx29ttkPX1qfPK9PxwEGFiSDUTbSeqWefxDcfLj4drNZGiEIUUG7li1630HVo+YY0E/XRcux6pMe4Mhyg3774vlel2cnj3qlvHB8x45cP2EErWNOGJzW6fl25ajwdLPDsoEPITeLft2r7SCtR7vZdtx1SAGJCK7ePY4lmPR+gt5P84NatU2zslytVlNOcRplWXKKg9smuwaa1tr4w5fwyfx+fv/fbwAAAP//
using System.Text.Json.Serialization;

namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// The information for the offer that a buyer or seller proposes for the dispute.
    /// </summary>

    public class Offer
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Offer() { }

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("buyer_requested_amount")]
        public Money BuyerRequestedAmount;
    }
}

