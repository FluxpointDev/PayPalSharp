



// @data H4sIAAAAAAAC/6TOP6vCMBQF8P19inDnwHvDwyGb6Cb4p4iLONw2tyWQJvEmHYL0u0tbrNTV8ZwL9/wecM6BQMGpEBuvCSRckA2WlvbYDgeQsKP8DluKFZuQjHegoMRIq39BrvKatDAtNiR8LVIONKXf4BqQsGbGPG39SSgI9cHZDKpGG2ko7p1h0nNxZB+Ik6EI6jorY2IzvvtAjksL6atZcr+EuM7a/tb/PAEAAP//
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

