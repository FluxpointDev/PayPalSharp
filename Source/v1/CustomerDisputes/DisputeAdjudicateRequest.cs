

// @version 0.1.0-dev+291f3f


using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// Settles a dispute, by ID, in either the buyer's or seller's favor.
    /// </summary>
    public class DisputeAdjudicateRequest : HttpRequest
    {
        public DisputeAdjudicateRequest(string DisputeId) : base("/v1/customer/disputes/{dispute_id}/adjudicate?", HttpMethod.Post, typeof(SubsequentActions))
        {
            try
            {
                this.Path = this.Path.Replace("{dispute_id}", Uri.EscapeDataString(Convert.ToString(DisputeId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public DisputeAdjudicateRequest RequestBody(AdjudicateRequest Body)
        {
            this.Body = Body;
            return this;
        }
    }
}
