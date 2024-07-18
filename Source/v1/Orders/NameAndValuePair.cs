




using System.Text.Json.Serialization;

namespace PayPal.v1.Orders
{
    /// <summary>
    /// The name-and-value pair details.
    /// </summary>

    public class NameAndValuePair
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public NameAndValuePair() { }

        /// <summary>
        /// REQUIRED
        /// The key for the name-and-value pair. You must correlate the value and name types.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;

        /// <summary>
        /// REQUIRED
        /// The value for the name-and-value pair.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value;
    }
}

