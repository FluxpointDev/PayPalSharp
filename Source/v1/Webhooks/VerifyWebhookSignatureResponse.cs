




using System.Text.Json.Serialization;

namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// The verify webhook signature response.
    /// </summary>

    public class VerifyWebhookSignatureResponse
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public VerifyWebhookSignatureResponse() { }

        /// <summary>
        /// REQUIRED
        /// The status of the signature verification.
        /// </summary>
        [JsonPropertyName("verification_status")]
        public string VerificationStatus;
    }
}

