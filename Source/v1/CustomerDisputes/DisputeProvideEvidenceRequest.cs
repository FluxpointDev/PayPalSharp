

// @version 0.1.0-dev+291f3f
// @type request

using BraintreeHttp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.CustomerDisputes
{
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
}
