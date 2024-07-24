




using BraintreeHttp;
using System.Net.Http;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// Simulates a webhook event. In the JSON request body, specify a sample payload.
    /// </summary>
    public class SimulateEventRequest<T> : HttpRequest
    {
        public SimulateEventRequest() : base("/v1/notifications/simulate-event?", HttpMethod.Post, typeof(Event<T>))
        {

            this.ContentType = "application/json";
        }

        public SimulateEventRequest<T> RequestBody(SimulateEvent SimulateEvent)
        {
            this.Body = SimulateEvent;
            return this;
        }
    }
}
