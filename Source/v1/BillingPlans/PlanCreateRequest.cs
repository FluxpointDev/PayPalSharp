


// @type request

using BraintreeHttp;
using System.Net.Http;


namespace PayPal.v1.BillingPlans
{
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
}
