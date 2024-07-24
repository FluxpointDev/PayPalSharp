




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// base64 encoded image of type image/png
    /// </summary>

    public class QrCode
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public QrCode() { }

        /// <summary>
        /// </summary>
        [JsonPropertyName("image")]
        public string Image;
    }
}

