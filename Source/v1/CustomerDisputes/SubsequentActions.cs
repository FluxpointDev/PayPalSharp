

// @version 0.1.0-dev+291f3f

// @data H4sIAAAAAAAC/7yUwWvbShDG7++vGPTeIQZZyuElL883Q1oSGprgKL0Yg8bSyFq82lV2RnVFyf9eVhs7VUwJtKXH/TSr+X7zjfQ1yvqWoll0362ZHjsyAvNClDUcxdEndArXmj5i42uiOPpA/cvhkrhwqvXV4zdgeEMSxdHcOexDj9M4WhCWt0b30axCzeSFx045Kg/CnbMtOVHE0Wx5cHejzBa+b3fkTSuz5ZHBvTJ2OTeA3hLYCpy3yzJ1pFGohOXVPHt3O7+H4erqJC1twSm2Kq1RyCJPhwfp5BXY+c+DsThlNsc4taNqRPMsjGGymqCwTatJCATdhgQeFjcJZBYa3BJITbCnK1Dr2JevlQlPGpLalrBTUoPUimH5sLiGjJrW35hW1jUoQuXqpBZpeZamYq3mRJFUiXWbtJZGp64qzs/+O50MU0vgvXXQOpq2zhbErMwmBmUK3ZWhaf5PHkN+kseApoR8kkNRo8NCyHECnij3rDkoHuq31MM+F89qjd8wqVFCTICHEQTGwIPAL/vo5V9dRtNp/RS/GVyY6Si6g3Qc3lWW3e1jcM/dQX4Q3h8icKRH9sP52PvSjz8YVNaA9C29uShn/19c/M00/B6m/05i2NWqqIHJfSYGZEAD15dQWQc4xBuC7gw2a7XpbMe6h3KwsqawH0wNGlEF+y/aC2EN74lgOfw2Fs8O+cXdbrdLFBocvCGz2piGjHDq7073SK+PyRePMfktMayeVk9/fQMAAP//
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// Subsequent actions.
    /// </summary>

    public class SubsequentActions
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public SubsequentActions() { }

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/hateoas-links/).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescription> Links;
    }
}

