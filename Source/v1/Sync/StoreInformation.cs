




using System.Text.Json.Serialization;

namespace PayPal.v1.Sync
{
    /// <summary>
    /// The store information.
    /// </summary>

    public class StoreInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public StoreInformation() { }

        /// <summary>
        /// The ID of a store for a merchant in the system of record.
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId;

        /// <summary>
        /// The terminal ID for the checkout stand in a merchant store.
        /// </summary>
        [JsonPropertyName("terminal_id")]
        public string TerminalId;
    }
}

