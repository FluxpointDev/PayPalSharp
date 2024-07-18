using PayPal.v1.CustomerDisputes;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PayPal.v1.Subscriptions
{

    public class Subscription
    {
        [JsonPropertyName("id")]
        public string Id;

        [JsonPropertyName("status")]
        public SubscriptionStatusType Status;

        [JsonPropertyName("status_update_time")]
        public string StatusUpdateTime;

        [JsonPropertyName("plan_id")]
        public string PlanId;

        [JsonPropertyName("plan_overridden")]
        public bool PlanOverridden;

        [JsonPropertyName("start_time")]
        public string StartTime;

        [JsonPropertyName("quantity")]
        public string Quantity;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("shipping_amount")]
        public Money ShippingAmount;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// The application context experience information.
        /// </summary>
        [JsonPropertyName("application_context")]
        public SubscriptionApplicationContext ApplicationContext;
    }

    public enum SubscriptionStatusType
    {
        [EnumMember(Value = "APPROVAL_PENDING")]
        ApprovalPending,

        [EnumMember(Value = "APPROVED")]
        Approved,

        [EnumMember(Value = "ACTIVE")]
        Active,

        [EnumMember(Value = "SUSPENDED")]
        Suspended,

        [EnumMember(Value = "CANCELLED")]
        Cancelled,

        [EnumMember(Value = "EXPIRED")]
        Expired,
    }

    public class SubscriptionApplicationContext : Orders.ApplicationContext
    {
        [JsonPropertyName("return_url")]
        public string ReturnUrl;

        [JsonPropertyName("cancel_url")]
        public string CancelUrl;

        [JsonPropertyName("payment_method")]
        public SubscriptionPaymentMethod PaymentMethod;
    }

    public class SubscriptionPaymentMethod
    {
        [JsonPropertyName("payer_selected")]
        public string PayerSelected;

        [JsonPropertyName("payee_preferred")]
        public string PayeePreferred;
    }
}
