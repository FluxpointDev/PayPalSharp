using PayPal.v1.BillingPlans;
using PayPal.v1.CustomerDisputes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPal.v1.Subscriptions
{
    [DataContract]
    public class Subscription
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id;

        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status;

        [DataMember(Name = "status_update_time", EmitDefaultValue = false)]
        public string StatusUpdateTime;

        [DataMember(Name = "plan_id", EmitDefaultValue = false)]
        public string PlanId;

        [DataMember(Name = "plan_overridden", EmitDefaultValue = false)]
        public bool PlanOverridden;

        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime;

        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public string Quantity;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [DataMember(Name = "shipping_amount", EmitDefaultValue = false)]
        public Money ShippingAmount;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<BillingPlans.LinkDescriptionObject> Links;

        /// <summary>
        /// The application context experience information.
        /// </summary>
        [DataMember(Name = "application_context", EmitDefaultValue = false)]
        public SubscriptionApplicationContext ApplicationContext;
    }

    public class SubscriptionApplicationContext : Orders.ApplicationContext
    {
        [DataMember(Name = "return_url", EmitDefaultValue = false)]
        public string ReturnUrl;

        [DataMember(Name = "cancel_url", EmitDefaultValue = false)]
        public string CancelUrl;

        [DataMember(Name = "payment_method", EmitDefaultValue = false)]
        public SubscriptionPaymentMethod PaymentMethod;
    }

    public class SubscriptionPaymentMethod
    {
        [DataMember(Name = "payer_selected", EmitDefaultValue = false)]
        public string PayerSelected;

        [DataMember(Name = "payee_preferred", EmitDefaultValue = false)]
        public string PayeePreferred;
    }
}
