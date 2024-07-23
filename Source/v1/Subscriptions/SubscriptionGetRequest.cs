using BraintreeHttp;
using System.IO;
using System;
using System.Net.Http;

namespace PayPal.v1.Subscriptions
{
    public class SubscriptionGetRequest : HttpRequest
    {
        public SubscriptionGetRequest(string subscriptionId) : base("/v1/billing/subscriptions/{sub_id}?", HttpMethod.Get, typeof(Subscription))
        {
            try
            {
                this.Path = this.Path.Replace("{sub_id}", Uri.EscapeDataString(Convert.ToString(subscriptionId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }
}
