using BraintreeHttp;
using PayPal.v1;
using PayPal.v1.BillingPlans;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace PayPal.Core
{
    public class BillingPlanEndpoints : IEndpoints
    {
        internal BillingPlanEndpoints(PayPalHttpClient client) : base(client)
        {

        }

        public async Task<HttpResponse> GetPlanAsync(string planId)
        {
            HttpRequest Req = new HttpRequest($"/v1/billing/plans/{Uri.EscapeDataString(planId)}?", HttpMethod.Get, typeof(Plan))
            {
                ContentType = "application/json",
            };

            return await Client.Execute(Req);
        }
    }

    /// <summary>
    /// Creates a billing plan. In the JSON request body, include the plan details. A plan must include at least one regular payment definition and, optionally, a trial payment definition. Each payment definition specifies a billing period, which determines how often and for how long the customer is charged. A plan can specify a fixed or infinite number of payment cycles. A payment definition can optionally specify shipping fee and tax amounts. The default state of a new plan is `CREATED`. Before you can create an agreement from a plan, you must activate the plan by updating its `state` to `ACTIVE`.
    /// </summary>
    public class PlanCreateRequest : HttpRequest
    {
        public PlanCreateRequest() : base("/v1/payments/billing-plans/?", HttpMethod.Post, typeof(Plan))
        {

            this.ContentType = "application/json";
        }

        public PlanCreateRequest RequestBody(Plan Plan)
        {
            this.Body = Plan;
            return this;
        }
    }

    /// <summary>
    /// Shows details for a billing plan, by ID.
    /// </summary>
    public class PlanGetRequest : HttpRequest
    {
        public PlanGetRequest(string PlanId) : base("/v1/payments/billing-plans/{plan_id}?", HttpMethod.Get, typeof(Plan))
        {
            try
            {
                this.Path = this.Path.Replace("{plan_id}", Uri.EscapeDataString(Convert.ToString(PlanId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Lists billing plans. To filter the plans that appear in the response, specify one or more optional query and pagination parameters.
    /// </summary>
    public class PlanListRequest : HttpRequest
    {
        public PlanListRequest() : base("/v1/payments/billing-plans/?", HttpMethod.Get, typeof(PlanList))
        {

            this.ContentType = "application/json";
        }

        public PlanListRequest Page(string Page)
        {
            var strParams = Convert.ToString(Page);
            try
            {
                this.Path = $"{this.Path}page={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PlanListRequest PageSize(string PageSize)
        {
            var strParams = Convert.ToString(PageSize);
            try
            {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PlanListRequest Status(string Status)
        {
            var strParams = Convert.ToString(Status);
            try
            {
                this.Path = $"{this.Path}status={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PlanListRequest TotalRequired(string TotalRequired)
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
