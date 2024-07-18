



// @data H4sIAAAAAAAC/6zPPUsEMRAG4N5fEaYOYr2dcM0hqOhhIyJjMusO5mOdzBZB7r9LVr0Pt7DwyrwZZt7nAzZ1JOjgXrOQWac+S0TlnMDCAwrjS6BrjG0ELFxR3T9WVJzwOA93sBnIlHkJ75ecg4VLEaxfVy4s3BH6mxQqdD2GQi14n1jI74JbySOJMhXoHnf9igqn12Wp+eQz+6NyB+Gy5Hplcm/wu2yfxaCJJG7ApIaT0QapRSm2OSGXxf/XkaYQtvZPjJJEThh+e47zJennv9kaqBHcQO4tT2qKYvINdsCc7SdBPW3PPgEAAP//
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

