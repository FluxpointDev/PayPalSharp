// This class was generated on Mon, 09 Apr 2018 18:07:50 UTC by version 0.1.0-dev+291f3f of Braintree SDK Generator
// PaymentListRequest.cs
// @version 0.1.0-dev+291f3f
// @type request
// @data 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
// DO NOT EDIT
using System;
using System.IO;
using System.Net.Http;
using BraintreeHttp;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Lists payments that were created by the [create payment](#payment_create) call and that are in any state. The list shows the payments that are made to the merchant who makes the call. To filter the payments that appear in the response, you can specify one or more optional query and pagination parameters. See [Filtering and pagination](/docs/api/overview/#query-parameters).
    /// </summary>
    public class PaymentListRequest : HttpRequest
    {
        public PaymentListRequest() : base("/v1/payments/payment?", HttpMethod.Get, typeof(PaymentHistory))
        {
            
            this.ContentType =  "application/json";
        }

        public PaymentListRequest Count(int Count)
        {
            var strParams = Convert.ToString(Count);
            try {
                this.Path = $"{this.Path}count={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest EndTime(string EndTime)
        {
            var strParams = Convert.ToString(EndTime);
            try {
                this.Path = $"{this.Path}end_time={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest PayeeId(string PayeeId)
        {
            var strParams = Convert.ToString(PayeeId);
            try {
                this.Path = $"{this.Path}payee_id={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest SortBy(string SortBy)
        {
            var strParams = Convert.ToString(SortBy);
            try {
                this.Path = $"{this.Path}sort_by={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest SortOrder(string SortOrder)
        {
            var strParams = Convert.ToString(SortOrder);
            try {
                this.Path = $"{this.Path}sort_order={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest StartId(string StartId)
        {
            var strParams = Convert.ToString(StartId);
            try {
                this.Path = $"{this.Path}start_id={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest StartIndex(int StartIndex)
        {
            var strParams = Convert.ToString(StartIndex);
            try {
                this.Path = $"{this.Path}start_index={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest StartTime(string StartTime)
        {
            var strParams = Convert.ToString(StartTime);
            try {
                this.Path = $"{this.Path}start_time={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        
        
    }
}
