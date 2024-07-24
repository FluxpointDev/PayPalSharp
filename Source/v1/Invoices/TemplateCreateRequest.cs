




using BraintreeHttp;
using System.Net.Http;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Creates a template.
    /// </summary>
    public class TemplateCreateRequest : HttpRequest
    {
        public TemplateCreateRequest() : base("/v1/invoicing/templates?", HttpMethod.Post, typeof(Template))
        {

            this.ContentType = "application/json";
        }

        public TemplateCreateRequest RequestBody(Template Body)
        {
            this.Body = Body;
            return this;
        }
    }
}
