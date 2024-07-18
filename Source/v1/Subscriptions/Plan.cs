using System;
using System.Globalization;
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

        [JsonPropertyName("create_time")]
        public string CreateTimeFormat;

        [JsonIgnore]
        public DateTime CreatedDate => DateTime.Parse(CreateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
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
