

// @version 0.1.0-dev+291f3f


using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.CustomerDisputes
{
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
}
