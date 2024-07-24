

// @version 0.1.0-dev+291f3f


using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// Updates the state of a dispute, by ID, to either `WAITING_FOR_BUYER_RESPONSE` or `WAITING_FOR_SELLER_RESPONSE`. This state change enables either the buyer or seller to submit evidence for the dispute. If the `action` is `BUYER_EVIDENCE`, the `state` updates to `WAITING_FOR_BUYER_RESPONSE`. If the action is `,SELLER_EVIDENCE`, the `state` updates to `WAITING_FOR_SELLER_RESPONSE`.
    /// </summary>
    public class DisputeRequireEvidenceRequest : HttpRequest
    {
        public DisputeRequireEvidenceRequest(string DisputeId) : base("/v1/customer/disputes/{dispute_id}/require-evidence?", HttpMethod.Post, typeof(SubsequentActions))
        {
            try
            {
                this.Path = this.Path.Replace("{dispute_id}", Uri.EscapeDataString(Convert.ToString(DisputeId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public DisputeRequireEvidenceRequest RequestBody(RequireEvidenceRequest Body)
        {
            this.Body = Body;
            return this;
        }
    }
}
