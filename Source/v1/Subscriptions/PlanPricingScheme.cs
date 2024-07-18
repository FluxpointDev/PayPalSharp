using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PayPal.v1.Subscriptions
{
    public class PlanPricingScheme
    {
        [JsonPropertyName("version")]
        public int Version;

        [JsonPropertyName("pricing_mode;")]
        public PlanPricingSchemeModelType IntervalCount;

        [JsonPropertyName("tiers")]
        public List<PlanTier> Tiers;

        [JsonPropertyName("fixed_price")]
        public PlanFixedAmount FixedPrice;

        [JsonPropertyName("create_time")]
        public string CreateTimeFormat;

        [JsonIgnore]
        public DateTime CreatedDate => DateTime.Parse(CreateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        [JsonPropertyName("update_time")]
        public string UpdateTimeFormat;

        [JsonIgnore]
        public DateTime UpdateDate => DateTime.Parse(UpdateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
    }

    public class PlanTier
    {
        [JsonPropertyName("starting_quantity")]
        public string StartingQuantity;

        [JsonPropertyName("EndingQuantity")]
        public string EndingQuantity;

        [JsonPropertyName("amount")]
        public PlanFixedAmount Amount;
    }

    public class PlanFixedAmount
    {
        /// <summary>
        /// REQUIRED
        /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/) that identifies the currency.
        /// </summary>
        [JsonPropertyName("currency_code")]
        public string CurrencyCode;

        /// <summary>
        /// REQUIRED
        /// The value, which might be:<ul><li>An integer for currencies like `JPY` that are not typically fractional.</li><li>A decimal fraction for currencies like `TND` that are subdivided into thousandths.</li></ul>For the required number of decimal places for a currency code, see [Currency codes - ISO 4217](https://www.iso.org/iso-4217-currency-codes.html).
        /// </summary>
        [JsonPropertyName("value")]
        public string Value;
    }

    public enum PlanPricingSchemeModelType
    {
        [EnumMember(Value = "VOLUME")]
        Volume,

        [EnumMember(Value = "TIERED")]
        Tiered
    }
}
