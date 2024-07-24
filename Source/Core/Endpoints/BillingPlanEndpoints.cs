using BraintreeHttp;
using System;
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
}
