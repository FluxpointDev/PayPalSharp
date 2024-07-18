using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PayPal.v1.Subscriptions
{
    public class PlanBillingCycle
    {
        [JsonPropertyName("tenure_type")]
        public PlanBillingCycleTenureType TenureType;

        [JsonPropertyName("sequence")]
        public int Sequence;

        [JsonPropertyName("total_cycles")]
        public int TotalCycles;

        [JsonPropertyName("pricing_scheme")]
        public PlanPricingScheme PricingScheme;

        [JsonPropertyName("frequency")]
        public PlanFrequency Frequency;
    }
    public enum PlanBillingCycleTenureType
    {
        [EnumMember(Value = "REGULAR")]
        Regular,

        [EnumMember(Value = "TRIAL")]
        Trial
    }
}
