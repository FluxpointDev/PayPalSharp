// This class was generated on Mon, 09 Apr 2018 18:07:50 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f
// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Lists payments that were created by the [create payment](#payment_create) call and that are in any state. The list shows the payments that are made to the merchant who makes the call. To filter the payments that appear in the response, you can specify one or more optional query and pagination parameters. See [Filtering and pagination](/docs/api/overview/#query-parameters).
    /// </summary>
    public class PaymentListRequest : HttpRequest
    {
        public PaymentListRequest() : base("/v1/payments/payment?", HttpMethod.Get, typeof(PaymentHistory))
        {

            this.ContentType = "application/json";
        }

        public PaymentListRequest Count(int Count)
        {
            var strParams = Convert.ToString(Count);
            try
            {
                this.Path = $"{this.Path}count={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PaymentListRequest EndTime(string EndTime)
        {
            var strParams = Convert.ToString(EndTime);
            try
            {
                this.Path = $"{this.Path}end_time={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PaymentListRequest PayeeId(string PayeeId)
        {
            var strParams = Convert.ToString(PayeeId);
            try
            {
                this.Path = $"{this.Path}payee_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PaymentListRequest SortBy(string SortBy)
        {
            var strParams = Convert.ToString(SortBy);
            try
            {
                this.Path = $"{this.Path}sort_by={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PaymentListRequest SortOrder(string SortOrder)
        {
            var strParams = Convert.ToString(SortOrder);
            try
            {
                this.Path = $"{this.Path}sort_order={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PaymentListRequest StartId(string StartId)
        {
            var strParams = Convert.ToString(StartId);
            try
            {
                this.Path = $"{this.Path}start_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PaymentListRequest StartIndex(int StartIndex)
        {
            var strParams = Convert.ToString(StartIndex);
            try
            {
                this.Path = $"{this.Path}start_index={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PaymentListRequest StartTime(string StartTime)
        {
            var strParams = Convert.ToString(StartTime);
            try
            {
                this.Path = $"{this.Path}start_time={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }
}
