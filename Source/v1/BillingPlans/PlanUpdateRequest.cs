


// @type request

using BraintreeHttp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.BillingPlans
{
    /// <summary>
    /// Updates fields in a billing plan, by ID. In the JSON request body, include a patch object that specifies the operation to perform, one or more fields to update, and a new value for each updated field.
    /// </summary>
    public class PlanUpdateRequest<T> : HttpRequest
    {
        public PlanUpdateRequest(string PlanId) : base("/v1/payments/billing-plans/{plan_id}?", new HttpMethod("PATCH"), typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{plan_id}", Uri.EscapeDataString(Convert.ToString(PlanId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public PlanUpdateRequest<T> RequestBody(List<JsonPatch<T>> PatchRequest)
        {
            this.Body = PatchRequest;
            return this;
        }
    }
}
