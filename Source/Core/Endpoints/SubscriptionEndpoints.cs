using BraintreeHttp;
using PayPal.v1.Subscriptions;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PayPal.Core
{
    public class SubscriptionEndpoints : IEndpoints
    {
        internal SubscriptionEndpoints(PayPalHttpClient client) : base(client)
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

        public async Task<HttpResponse> GetSubscriptionAsync(string subscriptionId)
        {
            HttpRequest Req = new HttpRequest($"/v1/billing/subscriptions/{Uri.EscapeDataString(subscriptionId)}?", HttpMethod.Get, typeof(Subscription))
            {
                ContentType = "application/json",
            };

            return await Client.Execute(Req);
        }

        public async Task<HttpResponse> CreateSubscriptionAsync(Subscription subscription)
        {
            HttpRequest Req = new HttpRequest($"/v1/billing/subscriptions?", HttpMethod.Post, typeof(Subscription))
            {
                ContentType = "application/json",
                Body = subscription
            };

            return await Client.Execute(Req);
        }

    }
}
