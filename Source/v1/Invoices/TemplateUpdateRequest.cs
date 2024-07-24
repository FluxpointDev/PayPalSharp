




using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Updates a template, by ID. In the JSON request body, specify a complete `template` object. The update method does not support partial updates.
    /// </summary>
    public class TemplateUpdateRequest : HttpRequest
    {
        public TemplateUpdateRequest(string TemplateId) : base("/v1/invoicing/templates/{template_id}?", HttpMethod.Put, typeof(Template))
        {
            try
            {
                this.Path = this.Path.Replace("{template_id}", Uri.EscapeDataString(Convert.ToString(TemplateId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public TemplateUpdateRequest RequestBody(Template Body)
        {
            this.Body = Body;
            return this;
        }
    }
}
