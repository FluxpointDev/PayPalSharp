




using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Lists all merchant-created templates. The list shows the emails, addresses, and phone numbers from the merchant profile.
    /// </summary>
    public class TemplateListRequest : HttpRequest
    {
        public TemplateListRequest() : base("/v1/invoicing/templates/?", HttpMethod.Get, typeof(TemplateList))
        {

            this.ContentType = "application/json";
        }

        public TemplateListRequest Fields(string Fields)
        {
            var strParams = Convert.ToString(Fields);
            try
            {
                this.Path = $"{this.Path}fields={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }
}
