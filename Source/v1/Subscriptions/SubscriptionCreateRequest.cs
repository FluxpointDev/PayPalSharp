using BraintreeHttp;
using System.Net.Http;

namespace PayPal.v1.Subscriptions
{
    public class SubscriptionCreateRequest : HttpRequest
    {
        public SubscriptionCreateRequest() : base("/v1/billing/subscriptions?", HttpMethod.Post, typeof(Subscription))
        {

            this.ContentType = "application/json";
        }

        public SubscriptionCreateRequest RequestBody(Subscription Subscription)
        {
            this.Body = Subscription;
            return this;
        }
    }
}
