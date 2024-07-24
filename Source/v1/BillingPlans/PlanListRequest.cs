




using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.BillingPlans
{
    /// <summary>
    /// Lists billing plans. To filter the plans that appear in the response, specify one or more optional query and pagination parameters.
    /// </summary>
    public class PlanListRequest : HttpRequest
    {
        public PlanListRequest() : base("/v1/payments/billing-plans/?", HttpMethod.Get, typeof(PlanList))
        {

            this.ContentType = "application/json";
        }

        public PlanListRequest Page(string Page)
        {
            var strParams = Convert.ToString(Page);
            try
            {
                this.Path = $"{this.Path}page={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PlanListRequest PageSize(string PageSize)
        {
            var strParams = Convert.ToString(PageSize);
            try
            {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PlanListRequest Status(string Status)
        {
            var strParams = Convert.ToString(Status);
            try
            {
                this.Path = $"{this.Path}status={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PlanListRequest TotalRequired(string TotalRequired)
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
