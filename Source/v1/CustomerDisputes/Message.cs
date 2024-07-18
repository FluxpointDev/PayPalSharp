

// @version 0.1.0-dev+291f3f


using System.Globalization;
using System;
using System.Text.Json.Serialization;

namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// A customer- or merchant-posted message for the dispute.
    /// </summary>

    public class Message
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Message() { }

        /// <summary>
        /// The customer- or merchant-posted content.
        /// </summary>
        [JsonPropertyName("content")]
        public string Content;

        /// <summary>
        /// The customer or merchant who posted the message.
        /// </summary>
        [JsonPropertyName("posted_by")]
        public string PostedBy;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [JsonPropertyName("time_posted")]
        public string TimePostedFormat;

        [JsonIgnore]
        public DateTime TimePostedDate => DateTime.Parse(TimePostedFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
    }
}

