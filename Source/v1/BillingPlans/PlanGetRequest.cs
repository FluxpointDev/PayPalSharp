




using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.BillingPlans
{
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
}
