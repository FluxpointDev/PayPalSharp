


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Marks the status of an invoice, by ID, as paid. Include a payment detail object that defines the payment method and other details in the JSON request body.
    /// </summary>
    public class InvoiceRecordPaymentRequest : HttpRequest
    {
        public InvoiceRecordPaymentRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/record-payment?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public InvoiceRecordPaymentRequest RequestBody(PaymentDetail Body)
        {
            this.Body = Body;
            return this;
        }
    }
}
