

// @version 0.1.0-dev+291f3f


using BraintreeHttp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.CustomerDisputes
{
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
}
