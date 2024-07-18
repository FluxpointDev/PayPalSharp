// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.Payments
{
    /// <summary>
    /// The processor-provided response codes that describe the submitted payment. Supported only when the `payment_method` is `credit_card`.
    /// </summary>

    public class ProcessorResponse
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ProcessorResponse() { }

        /// <summary>
        /// The merchant advice on how to handle declines for recurring payments.
        /// </summary>
        [JsonPropertyName("advice_code")]
        public string AdviceCode;

        /// <summary>
        /// The [Address Verification System (AVS)](https://developer.paypal.com/webapps/developer/docs/classic/api/AVSResponseCodes/) response code.
        /// </summary>
        [JsonPropertyName("avs_code")]
        public string AvsCode;

        /// <summary>
        /// The [CVV](https://developer.paypal.com/webapps/developer/docs/classic/api/AVSResponseCodes/) system response code.
        /// </summary>
        [JsonPropertyName("cvv_code")]
        public string CvvCode;

        /// <summary>
        /// The processor-provided authorization response.
        /// </summary>
        [JsonPropertyName("eci_submitted")]
        public string EciSubmitted;

        /// <summary>
        /// REQUIRED
        /// The PayPal normalized response code, which is generated from the processor's specific response code.
        /// </summary>
        [JsonPropertyName("response_code")]
        public string ResponseCode;

        /// <summary>
        /// The processor-provided Visa Payer Authentication Service (VPAS) status.
        /// </summary>
        [JsonPropertyName("vpas")]
        public string Vpas;
    }
}

