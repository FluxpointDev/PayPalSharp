




using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Marks the status of an invoice, by ID, as refunded. In the JSON request body, include a payment detail object that defines the payment method and other details.
    /// </summary>
    public class InvoiceRecordRefundRequest : HttpRequest
    {
        public InvoiceRecordRefundRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/record-refund?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public InvoiceRecordRefundRequest RequestBody(RefundDetail Body)
        {
            this.Body = Body;
            return this;
        }
    }
}
