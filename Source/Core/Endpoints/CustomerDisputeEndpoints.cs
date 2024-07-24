using BraintreeHttp;
using PayPal.v1.CustomerDisputes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace PayPal.Core
{
    public class CustomerDisputeEndpoints : IEndpoints
    {
        internal CustomerDisputeEndpoints(PayPalHttpClient client) : base(client)
        {

        }

    }

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

    /// <summary>
    /// Appeals a dispute, by ID. To appeal a dispute, use the <code>appeal</code> link in the <a href="/docs/api/hateoas-links/">HATEOAS links</a> from the show dispute details response. If this link does not appear, you cannot appeal the dispute. Submit new evidence as a document or notes in the JSON request body.
    /// </summary>
    public class DisputeAppealRequest : HttpRequest
    {
        public DisputeAppealRequest(string DisputeId) : base("/v1/customer/disputes/{dispute_id}/appeal?", HttpMethod.Post, typeof(SubsequentActions))
        {
            try
            {
                this.Path = this.Path.Replace("{dispute_id}", Uri.EscapeDataString(Convert.ToString(DisputeId)));
            }
            catch (IOException) { }

            this.ContentType = "multipart/form-data";
            this.Body = new Dictionary<string, object>();
        }
    }

    /// <summary>
    /// Shows details for a dispute, by ID.<blockquote><strong>Note:</strong> The fields that appear in the response depend on whether you access this call through first- or third-party access. For example, if the merchant shows dispute details through third-party access, the customer's email ID does not appear.</blockquote>
    /// </summary>
    public class DisputeGetRequest : HttpRequest
    {
        public DisputeGetRequest(string DisputeId) : base("/v1/customer/disputes/{dispute_id}?", HttpMethod.Get, typeof(Dispute))
        {
            try
            {
                this.Path = this.Path.Replace("{dispute_id}", Uri.EscapeDataString(Convert.ToString(DisputeId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Lists disputes. To filter the disputes in the response, specify one or more optional query parameters. To limit the number of disputes in the response, specify the <code>page_size</code> query parameter.
    /// </summary>
    public class DisputeListRequest : HttpRequest
    {
        public DisputeListRequest() : base("/v1/customer/disputes?", HttpMethod.Get, typeof(DisputeSearchResponse))
        {

            this.ContentType = "application/json";
        }

        public DisputeListRequest DisputeState(string DisputeState)
        {
            var strParams = Convert.ToString(DisputeState);
            try
            {
                this.Path = $"{this.Path}dispute_state={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public DisputeListRequest DisputedTransactionId(string DisputedTransactionId)
        {
            var strParams = Convert.ToString(DisputedTransactionId);
            try
            {
                this.Path = $"{this.Path}disputed_transaction_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public DisputeListRequest NextPageToken(string NextPageToken)
        {
            var strParams = Convert.ToString(NextPageToken);
            try
            {
                this.Path = $"{this.Path}next_page_token={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public DisputeListRequest PageSize(int PageSize)
        {
            var strParams = Convert.ToString(PageSize);
            try
            {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public DisputeListRequest StartTime(string StartTime)
        {
            var strParams = Convert.ToString(StartTime);
            try
            {
                this.Path = $"{this.Path}start_time={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public DisputeListRequest TotalRequired(bool TotalRequired)
        {
            var strParams = Convert.ToString(TotalRequired);
            try
            {
                this.Path = $"{this.Path}total_required={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }

    /// <summary>
    /// Provides evidence for a dispute, by ID. A merchant can provide evidence for disputes with the <code>WAITING_FOR_SELLER_RESPONSE</code> status while customers can provide evidence for disputes with the <code>WAITING_FOR_BUYER_RESPONSE</code> status. Evidence can be a proof of delivery or proof of refund document or notes, which can include logs. A proof of delivery document includes a tracking number while a proof of refund document includes a refund ID. The following rules apply to document file types and sizes:<ul><li>The seller can upload up to 10 MB of files for a case.</li><li>Individual files must be smaller than 5 MB.</li><li>The supported file formats are JPG, GIF, PNG, and PDF.</li></ul><br/>To make this request, specify the dispute ID in the URI and specify the evidence in the JSON request body.
    /// </summary>
    public class DisputeProvideEvidenceRequest : HttpRequest
    {
        public DisputeProvideEvidenceRequest(string DisputeId) : base("/v1/customer/disputes/{dispute_id}/provide-evidence?", HttpMethod.Post, typeof(SubsequentActions))
        {
            try
            {
                this.Path = this.Path.Replace("{dispute_id}", Uri.EscapeDataString(Convert.ToString(DisputeId)));
            }
            catch (IOException) { }

            this.ContentType = "multipart/form-data";
            this.Body = new Dictionary<string, object>();
        }
        public DisputeProvideEvidenceRequest Evidence(FileStream Evidence)
        {
            Dictionary<String, Object> existingBody = (Dictionary<string, object>)this.Body;
            existingBody.Add("evidence", Evidence);
            this.Body = existingBody;
            return this;
        }

    }

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
