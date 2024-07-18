using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PayPal.v1.Subscriptions
{
    public class PlanFrequency
    {
        [JsonPropertyName("interval_unit")]
        public PlanFrequencyIntervalType IntervalUnit;

        [JsonPropertyName("interval_count")]
        public int IntervalCount;
    }

    public enum PlanFrequencyIntervalType
    {
        [EnumMember(Value = "DAY")]
        Day,

        [EnumMember(Value = "WEEK")]
        Week,

        [EnumMember(Value = "MONTH")]
        Month,

        [EnumMember(Value = "YEAR")]
        Year
    }
}
