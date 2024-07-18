


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Lists merchant invoices. To filter the invoices that appear in the response, you can specify one or more optional query parameters.
    /// </summary>
    public class InvoiceListRequest : HttpRequest
    {
        public InvoiceListRequest() : base("/v1/invoicing/invoices/?", HttpMethod.Get, typeof(InvoiceList))
        {

            this.ContentType = "application/json";
        }

        public InvoiceListRequest Page(int Page)
        {
            var strParams = Convert.ToString(Page);
            try
            {
                this.Path = $"{this.Path}page={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public InvoiceListRequest PageSize(int PageSize)
        {
            var strParams = Convert.ToString(PageSize);
            try
            {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public InvoiceListRequest TotalCountRequired(bool TotalCountRequired)
        {
            var strParams = Convert.ToString(TotalCountRequired);
            try
            {
                this.Path = $"{this.Path}total_count_required={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }
}
