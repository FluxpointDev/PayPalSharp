// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// A payment. Use this object to create, process, and manage payments.
    /// </summary>

    public class Payment
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Payment() { }

        /// <summary>
        /// Use the application context resource to customize payment flow experience for your buyers.
        /// </summary>
        [JsonPropertyName("application_context")]
        public ApplicationContext ApplicationContext;

        /// <summary>
        /// The date and time when the payment was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime;

        /// <summary>
        /// The PayPal-generated ID for the merchant's payment experience profile. For information, see [create web experience profile](/docs/api/payment-experience/#web-profiles_create).
        /// </summary>
        [JsonPropertyName("experience_profile_id")]
        public string ExperienceProfileId;

        /// <summary>
        /// The reason code for a payment failure.
        /// </summary>
        [JsonPropertyName("failure_reason")]
        public string FailureReason;

        /// <summary>
        /// The ID of the payment.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// REQUIRED
        /// The payment intent. Value is:<ul><li><code>sale</code>. Makes an immediate payment.</li><li><code>authorize</code>. [Authorizes a payment for capture later](/docs/integration/direct/payments/capture-payment/).</li><li><code>order</code>. [Creates an order](/docs/integration/direct/payments/orders/).</li></ul>
        /// </summary>
        [JsonPropertyName("intent")]
        public string Intent;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// A free-form field that clients can use to send a note to the payer.
        /// </summary>
        [JsonPropertyName("note_to_payer")]
        public string NoteToPayer;

        /// <summary>
        /// REQUIRED
        /// The payer. The payer funds the payment.
        /// </summary>
        [JsonPropertyName("payer")]
        public Payer Payer;

        /// <summary>
        /// A set of redirect URLs that you provide for PayPal-based payments.
        /// </summary>
        [JsonPropertyName("redirect_urls")]
        public RedirectUrls RedirectUrls;

        /// <summary>
        /// The state of the payment, authorization, or order transaction. Value is:<ul><li><code>created</code>. The transaction was successfully created.</li><li><code>approved</code>. The buyer approved the transaction.</li><li><code>failed</code>. The transaction request failed.</li></ul>
        /// </summary>
        [JsonPropertyName("state")]
        public string State;

        /// <summary>
        /// An array of payment-related transactions. A transaction defines what the payment is for and who fulfills the payment. For update and execute payment calls, the **`transactions`** object accepts the **`amount`** object only.
        /// </summary>
        [JsonPropertyName("transactions")]
        public List<Transaction> Transactions;

        /// <summary>
        /// The date and time when the payment was updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime;
    }
}

