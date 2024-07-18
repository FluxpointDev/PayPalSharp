



// @data H4sIAAAAAAAC/6yTUWsUMRDH3/0UQ0BQWI49tQj3ViuCCK1o6YsUOpf8t41kkziZLS7S7y7pbW9driBiH/dPspnfb2Z+mfMxw2zMSSpqGnPB4nkbcMp9TU1jPmGcP96jWPFZfYpmY85vQDYVJS7ElCEWUSkJcSTu0xCVbjkMWNGHJISf3OeAhjRRybC+G2ndPm8IUSF0tW6vVnQcFBJZ/S3CuDg6/zN1dLS/dXS1Mo05FuFxR9I25gvYncUwmk3HoaAGPwYvcPvgs6QMUY9iNt9mB4MIoh0PPexeXtjYR0sn77iA0vY7rFJXVYRAnY8creew00GCwApHnUdwhV5sOXC0aCjz2FeFbkBDULt6+WRsRcXH60MyOzGfJIcFn51lLAlfU4BW9w8nyCaHOgMOnY9wtB3p49czevNq/fZ/mxOHEO6av1Lce12U/5Asa58maMh1sk7J+WuvxF2l0RuQg/U9h0IFmYW19m/G8nGPdd/aeoNzlpTFs2Lp45/AVYbHuC//II9Dv4Uckk9bt2Cfs8f3tVku7LSjFxy8mybUF+ok9dRWT+u2fZI2Xt49+w0AAP//
using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The cost as a percent or an amount value. For example, to specify 10%, enter `10`. Alternatively, to specify an amount of 5, enter `5`.
    /// </summary>

    public class Cost
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Cost() { }

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [JsonPropertyName("amount")]
        public Currency Amount;

        /// <summary>
        /// The cost, as a percent value. Valid value is from 0 to 100.
        /// </summary>
        [JsonPropertyName("percent")]
        public double? Percent;
    }
}

