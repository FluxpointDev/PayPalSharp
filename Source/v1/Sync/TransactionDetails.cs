




using System.Text.Json.Serialization;

namespace PayPal.v1.Sync
{
    /// <summary>
    /// The transaction details.
    /// </summary>

    public class TransactionDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public TransactionDetails() { }

        /// <summary>
        /// The auction information.
        /// </summary>
        [JsonPropertyName("auction_info")]
        public AuctionInformation AuctionInfo;

        /// <summary>
        /// The cart information.
        /// </summary>
        [JsonPropertyName("cart_info")]
        public CartInformation CartInfo;

        /// <summary>
        /// The incentive details.
        /// </summary>
        [JsonPropertyName("incentive_info")]
        public IncentiveInformation IncentiveInfo;

        /// <summary>
        /// The payer information.
        /// </summary>
        [JsonPropertyName("payer_info")]
        public PayerInformation PayerInfo;

        /// <summary>
        /// The shipping information.
        /// </summary>
        [JsonPropertyName("shipping_info")]
        public ShippingInformation ShippingInfo;

        /// <summary>
        /// The store information.
        /// </summary>
        [JsonPropertyName("store_info")]
        public StoreInformation StoreInfo;

        /// <summary>
        /// The transaction information.
        /// </summary>
        [JsonPropertyName("transaction_info")]
        public TransactionInformation TransactionInfo;
    }
}

