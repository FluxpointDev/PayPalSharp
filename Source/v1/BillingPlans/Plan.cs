




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.BillingPlans
{
    /// <summary>
    /// A billing plan. You can base one or more agreements on an active plan.
    /// </summary>

    public class Plan
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Plan() { }

        /// <summary>
        /// The date and time when the plan was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime;

        /// <summary>
        /// REQUIRED
        /// The plan description. Maximum length is 127 single-byte alphanumeric characters.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description;

        /// <summary>
        /// The ID of the plan.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// The merchant preferences for a plan. Includes how much it costs to set up the agreement, the URLs where the customer can approve or cancel the agreement, the maximum number of allowed failed payment attempts, whether PayPal automatically bills the outstanding balance in the next billing cycle, and the action if the customer's initial payment fails.
        /// </summary>
        [JsonPropertyName("merchant_preferences")]
        public MerchantPreferences MerchantPreferences;

        /// <summary>
        /// REQUIRED
        /// The plan name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;

        /// <summary>
        /// A payment definition, which determines how often and for how long the customer is charged. Includes the interval at which the customer is charged, the charge amount, and optional shipping fees and taxes.
        /// </summary>
        [JsonPropertyName("payment_definitions")]
        public List<PaymentDefinition> PaymentDefinitions;

        /// <summary>
        /// The plan status.
        /// </summary>
        [JsonPropertyName("state")]
        public string State;

        /// <summary>
        /// An array of terms for this plan. Read-only and reserved for future use.
        /// </summary>
        [JsonPropertyName("terms")]
        public List<Terms> Terms;

        /// <summary>
        /// REQUIRED
        /// The plan type. Indicates whether the payment definitions in the plan have a fixed number of or infinite payment cycles. Value is:<ul><li><code>FIXED</code>. The plan has a fixed number of payment cycles.</li><li><code>INFINITE</code>. The plan has infinite, or <code>0</code>, payment cycles.</li></ul>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type;

        /// <summary>
        /// The date and time when the plan was updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime;
    }
}

