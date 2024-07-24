




using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// A billing agreement.
    /// </summary>

    public class Agreement
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Agreement() { }

        /// <summary>
        /// The agreement details.
        /// </summary>
        [JsonPropertyName("agreement_details")]
        public AgreementDetails AgreementDetails;

        /// <summary>
        /// REQUIRED
        /// The agreement description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description;

        /// <summary>
        /// The PayPal-generated agreement ID.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// REQUIRED
        /// The agreement name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;

        /// <summary>
        /// An array of charge models to override the charge models in the plan. A charge model defines shipping fee and tax information. If you omit this parameter, the agreement uses the default shipping fee and tax information from the plan.
        /// </summary>
        [JsonPropertyName("override_charge_models")]
        public List<OverrideChargeModel> OverrideChargeModels;

        /// <summary>
        /// The merchant preferences for a plan. Includes how much it costs to set up the agreement, the URLs where the customer can approve or cancel the agreement, the maximum number of allowed failed payment attempts, whether PayPal automatically bills the outstanding balance in the next billing cycle, and the action if the customer's initial payment fails.
        /// </summary>
        [JsonPropertyName("override_merchant_preferences")]
        public MerchantPreferences OverrideMerchantPreferences;

        /// <summary>
        /// REQUIRED
        /// The customer who funds the payment.
        /// </summary>
        [JsonPropertyName("payer")]
        public Payer Payer;

        /// <summary>
        /// REQUIRED
        /// The ID of the plan on which this agreement is based.
        /// </summary>
        [JsonPropertyName("plan")]
        public PlanWithId Plan;

        /// <summary>
        /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
        /// </summary>
        [JsonPropertyName("shipping_address")]
        public SimplePostalAddress ShippingAddress;

        /// <summary>
        /// REQUIRED
        /// The date and time when this agreement begins, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). The start date must be more recent than the current date. The agreement can take up to 24 hours to activate.<br/><br/>The start date and time in the create agreement request might not match the start date and time that the API returns in the execute agreement response. When you execute an agreement, the API internally converts the start date and time to the start of the day in the time zone of the merchant account. For example, the API converts a `2017-01-02T14:36:21Z` start date and time for an account in the Berlin time zone (UTC + 1) to `2017-01-02T00:00:00`. When the API returns this date and time in the execute agreement response, it shows the converted date and time in the UTC time zone. So, the internal `2017-01-02T00:00:00` start date and time becomes `2017-01-01T23:00:00` externally.
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDateFormat;

        [JsonIgnore]
        public DateTime StartDate => DateTime.Parse(StartDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// The state of the agreement. Value is:<ul><li>`Pending`. The agreement is awaiting initial payment completion.</li><li>`Active`. The agreement is active and payments will be scheduled.</li><li>`Suspended`. The agreement is suspended and payments will not be scheduled until the agreement is reactivated.</li><li>`Canceled`. The agreement is canceled and payments will not be scheduled.</li><li>`Expired`. The agreement is expired and no more payments remain to be scheduled.</li></ul>
        /// </summary>
        [JsonPropertyName("state")]
        public string State;
    }
}

