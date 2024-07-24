




using System.Globalization;
using System;
using System.Text.Json.Serialization;

namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// A verify webhook signature request.
    /// </summary>

    public class VerifyWebhookSignature<T>
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public VerifyWebhookSignature() { }

        /// <summary>
        /// REQUIRED
        /// The algorithm that PayPal uses to generate the signature and that you can use to verify the signature. Extract this value from the `PAYPAL-AUTH-ALGO` response header, which is received with the webhook notification.
        /// </summary>
        [JsonPropertyName("auth_algo")]
        public string AuthAlgo;

        /// <summary>
        /// REQUIRED
        /// The X.509 public key certificate. Download the certificate from this URL and use it to verify the signature. Extract this value from the `PAYPAL-CERT-URL` response header, which is received with the webhook notification.
        /// </summary>
        [JsonPropertyName("cert_url")]
        public string CertUrl;

        /// <summary>
        /// REQUIRED
        /// The ID of the HTTP transmission. Contained in the `PAYPAL-TRANSMISSION-ID` header of the notification message.
        /// </summary>
        [JsonPropertyName("transmission_id")]
        public string TransmissionId;

        /// <summary>
        /// REQUIRED
        /// The PayPal-generated asymmetric signature. Appears in the `PAYPAL-TRANSMISSION-SIG` header of the notification message.
        /// </summary>
        [JsonPropertyName("transmission_sig")]
        public string TransmissionSig;

        /// <summary>
        /// REQUIRED
        /// The date and time of the HTTP transmission, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Appears in the `PAYPAL-TRANSMISSION-TIME` header of the notification message.
        /// </summary>
        [JsonPropertyName("transmission_time")]
        public string TransmissionTimeFormat;

        [JsonIgnore]
        public DateTime TransmissionDate => DateTime.Parse(TransmissionTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// REQUIRED
        /// A webhook event notification.
        /// </summary>
        [JsonPropertyName("webhook_event")]
        public Event<T> WebhookEvent;

        /// <summary>
        /// REQUIRED
        /// The ID of the webhook as configured in your Developer Portal account.
        /// </summary>
        [JsonPropertyName("webhook_id")]
        public string WebhookId;
    }
}

