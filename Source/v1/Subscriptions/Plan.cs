using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PayPal.v1.Subscriptions
{

    public class Plan
    {
        [JsonPropertyName("id")]
        public string Id;

        [JsonPropertyName("product_id")]
        public string ProductId;

        [JsonPropertyName("name")]
        public string Name;

        [JsonPropertyName("status")]
        public PlanStatusType Status;
    }

    public enum PlanStatusType
    {
        [EnumMember(Value = "CREATED")]
        Created,

        [EnumMember(Value = "INACTIVE")]
        Inactive,

        [EnumMember(Value = "ACTIVE")]
        Active
    }
}
