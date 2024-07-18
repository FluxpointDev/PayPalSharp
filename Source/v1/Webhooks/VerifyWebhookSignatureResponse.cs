



// @data H4sIAAAAAAAC/5SPz0tDMQyA7/4VJeeHeO5N8CaozDEPIpJteVuwtjVJlSL736W+UX88Lx6TkI/ve4dlzQQeViQ8VndH631KT+6WdxGtCLkFaU5RCQZYoTCuA13hc3uBAS6pfg0XpBvhbJwieFjuyb1O0LcjVDtUjtBTGOBcBOtkcTbAgnB7HUMFP2JQaouXwkLbvriRlEmMScHfd3814bibS34q8Aab1aMaWtEf3n/f5ynTyaXRWZt6yff/f9WYlF8xsYRweDicfAAAAP//
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

