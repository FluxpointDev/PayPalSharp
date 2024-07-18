using BraintreeHttp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;

namespace PayPal.v1.Subscriptions
{
    public class PlanGetRequest : HttpRequest
    {
        public PlanGetRequest(string planId) : base("/v1/billing/plans/{plan_id}?", HttpMethod.Get, typeof(Plan))
        {
            try
            {
                this.Path = this.Path.Replace("{plan_id}", Uri.EscapeDataString(Convert.ToString(planId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }
}
