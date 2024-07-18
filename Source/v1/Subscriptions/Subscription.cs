using PayPal.v1.CustomerDisputes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPal.v1.Subscriptions
{

    public class Subscription
    {
        [DataMember(Name = "id")]
        public string Id;

        [DataMember(Name = "status")]
        public string Status;

        [DataMember(Name = "status_update_time")]
        public string StatusUpdateTime;

        [DataMember(Name = "plan_id")]
        public string PlanId;

        [DataMember(Name = "plan_overridden")]
        public bool PlanOverridden;

        [DataMember(Name = "start_time")]
        public string StartTime;

        [DataMember(Name = "quantity")]
        public string Quantity;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [DataMember(Name = "shipping_amount")]
        public Money ShippingAmount;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name = "links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// The application context experience information.
        /// </summary>
        [DataMember(Name = "application_context")]
        public SubscriptionApplicationContext ApplicationContext;
    }

    public class SubscriptionApplicationContext : Orders.ApplicationContext
    {
        [DataMember(Name = "return_url")]
        public string ReturnUrl;

        [DataMember(Name = "cancel_url")]
        public string CancelUrl;

        [DataMember(Name = "payment_method")]
        public SubscriptionPaymentMethod PaymentMethod;
    }

    public class SubscriptionPaymentMethod
    {
        [DataMember(Name = "payer_selected")]
        public string PayerSelected;

        [DataMember(Name = "payee_preferred")]
        public string PayeePreferred;
    }
}
