// This class was generated on Tue, 30 Jan 2018 11:14:21 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// PlanGetRequest.cs
// @version 0.1.0-dev+6beb51-dirty
// @type request
// @data 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
// DO NOT EDIT
using System;
using System.IO;
using System.Net.Http;
using BraintreeHttp;


namespace PayPal.v1.BillingPlans
{
    /// <summary>
    /// Shows details for a billing plan, by ID.
    /// </summary>
    public class PlanGetRequest : HttpRequest
    {
        public PlanGetRequest(string PlanId) : base("/v1/payments/billing-plans/{plan_id}?", HttpMethod.Get, typeof(Plan))
        {
            try {
                this.Path = this.Path.Replace("{plan_id}", Uri.EscapeDataString(Convert.ToString(PlanId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
