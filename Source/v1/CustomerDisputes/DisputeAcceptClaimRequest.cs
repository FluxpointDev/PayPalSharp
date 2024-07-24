

// @version 0.1.0-dev+291f3f


using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// Accepts a claim for a dispute, by ID. Accepts liability for a claim, which closes the dispute in the customer’s favor. PayPal refunds money to the customer from the merchant's account.
    /// </summary>
    public class DisputeAcceptClaimRequest : HttpRequest
    {
        public DisputeAcceptClaimRequest(string DisputeId) : base("/v1/customer/disputes/{dispute_id}/accept-claim?", HttpMethod.Post, typeof(SubsequentActions))
        {
            try
            {
                this.Path = this.Path.Replace("{dispute_id}", Uri.EscapeDataString(Convert.ToString(DisputeId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public DisputeAcceptClaimRequest RequestBody(AcceptClaimRequest AcceptClaimRequest)
        {
            this.Body = AcceptClaimRequest;
            return this;
        }
    }
}
