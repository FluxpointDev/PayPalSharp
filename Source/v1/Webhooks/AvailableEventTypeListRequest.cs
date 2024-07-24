




using BraintreeHttp;
using System.Net.Http;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// Lists available events to which any webhook can subscribe. For a list of supported events, see [Webhook event names](/docs/integration/direct/webhooks/event-names/).
    /// </summary>
    public class AvailableEventTypeListRequest : HttpRequest
    {
        public AvailableEventTypeListRequest() : base("/v1/notifications/webhooks-event-types?", HttpMethod.Get, typeof(EventTypeList))
        {

            this.ContentType = "application/json";
        }

    }
}
