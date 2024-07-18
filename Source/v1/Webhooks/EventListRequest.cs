


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// Lists webhook event notifications. Use query parameters to filter the response.
    /// </summary>
    public class EventListRequest<T> : HttpRequest
    {
        public EventListRequest() : base("/v1/notifications/webhooks-events?", HttpMethod.Get, typeof(EventList<T>))
        {

            this.ContentType = "application/json";
        }

        public EventListRequest<T> EndTime(string EndTime)
        {
            var strParams = Convert.ToString(EndTime);
            try
            {
                this.Path = $"{this.Path}end_time={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public EventListRequest<T> EventType(string EventType)
        {
            var strParams = Convert.ToString(EventType);
            try
            {
                this.Path = $"{this.Path}event_type={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public EventListRequest<T> PageSize(int PageSize)
        {
            var strParams = Convert.ToString(PageSize);
            try
            {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public EventListRequest<T> StartTime(string StartTime)
        {
            var strParams = Convert.ToString(StartTime);
            try
            {
                this.Path = $"{this.Path}start_time={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public EventListRequest<T> TransactionId(string TransactionId)
        {
            var strParams = Convert.ToString(TransactionId);
            try
            {
                this.Path = $"{this.Path}transaction_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }
}
