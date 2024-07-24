

// @version 0.1.0-dev+291f3f


using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// Lists disputes. To filter the disputes in the response, specify one or more optional query parameters. To limit the number of disputes in the response, specify the <code>page_size</code> query parameter.
    /// </summary>
    public class DisputeListRequest : HttpRequest
    {
        public DisputeListRequest() : base("/v1/customer/disputes?", HttpMethod.Get, typeof(DisputeSearchResponse))
        {

            this.ContentType = "application/json";
        }

        public DisputeListRequest DisputeState(string DisputeState)
        {
            var strParams = Convert.ToString(DisputeState);
            try
            {
                this.Path = $"{this.Path}dispute_state={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public DisputeListRequest DisputedTransactionId(string DisputedTransactionId)
        {
            var strParams = Convert.ToString(DisputedTransactionId);
            try
            {
                this.Path = $"{this.Path}disputed_transaction_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public DisputeListRequest NextPageToken(string NextPageToken)
        {
            var strParams = Convert.ToString(NextPageToken);
            try
            {
                this.Path = $"{this.Path}next_page_token={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public DisputeListRequest PageSize(int PageSize)
        {
            var strParams = Convert.ToString(PageSize);
            try
            {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public DisputeListRequest StartTime(string StartTime)
        {
            var strParams = Convert.ToString(StartTime);
            try
            {
                this.Path = $"{this.Path}start_time={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public DisputeListRequest TotalRequired(bool TotalRequired)
        {
            var strParams = Convert.ToString(TotalRequired);
            try
            {
                this.Path = $"{this.Path}total_required={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }
}
