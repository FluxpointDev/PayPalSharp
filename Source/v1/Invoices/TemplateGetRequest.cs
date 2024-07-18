


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Shows details for a template, by ID.
    /// </summary>
    public class TemplateGetRequest : HttpRequest
    {
        public TemplateGetRequest(string TemplateId) : base("/v1/invoicing/templates/{template_id}?", HttpMethod.Get, typeof(Template))
        {
            try
            {
                this.Path = this.Path.Replace("{template_id}", Uri.EscapeDataString(Convert.ToString(TemplateId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }
}
