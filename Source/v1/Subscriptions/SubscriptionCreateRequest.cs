using BraintreeHttp;
using PayPal.v1.Payments;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

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
