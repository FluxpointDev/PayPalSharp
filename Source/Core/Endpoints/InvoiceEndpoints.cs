using BraintreeHttp;
using PayPal.v1.Invoices;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace PayPal.Core
{
    public class InvoiceEndpoints : IEndpoints
    {
        internal InvoiceEndpoints(PayPalHttpClient client) : base(client)
        {

        }

    }

    /// <summary>
    /// Cancels a sent invoice, by ID, and, optionally, sends a notification about the cancellation to the payer, merchant, and Cc: emails.
    /// </summary>
    public class InvoiceCancelRequest : HttpRequest
    {
        public InvoiceCancelRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/cancel?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public InvoiceCancelRequest RequestBody(CancelNotification Body)
        {
            this.Body = Body;
            return this;
        }
    }

    /// <summary>
    /// Creates a draft invoice. You can optionally create an invoice [template](/docs/api/invoicing/#templates). Then, when you create an invoice from a template, the invoice is populated with the predefined data that the source template contains. To move the invoice from a draft to payable state, you must [send the invoice](/docs/api/invoicing/#invoices_send). In the JSON request body, include invoice details including merchant information. The `invoice` object must include an `items` array.<blockquote><strong>Note:</strong> The merchant specified in an invoice must have a PayPal account in good standing.</blockquote>
    /// </summary>
    public class InvoiceCreateRequest : HttpRequest
    {
        public InvoiceCreateRequest() : base("/v1/invoicing/invoices?", HttpMethod.Post, typeof(Invoice))
        {

            this.ContentType = "application/json";
        }

        public InvoiceCreateRequest RequestBody(Invoice Body)
        {
            this.Body = Body;
            return this;
        }
    }

    /// <summary>
    /// Deletes an external payment, by invoice ID and transaction ID.
    /// </summary>
    public class InvoiceDeleteExternalPaymentRequest : HttpRequest
    {
        public InvoiceDeleteExternalPaymentRequest(string InvoiceId, string TransactionId) : base("/v1/invoicing/invoices/{invoice_id}/payment-records/{transaction_id}?", HttpMethod.Delete, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }
            try
            {
                this.Path = this.Path.Replace("{transaction_id}", Uri.EscapeDataString(Convert.ToString(TransactionId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Deletes an external refund, by invoice ID and transaction ID.
    /// </summary>
    public class InvoiceDeleteExternalRefundRequest : HttpRequest
    {
        public InvoiceDeleteExternalRefundRequest(string InvoiceId, string TransactionId) : base("/v1/invoicing/invoices/{invoice_id}/refund-records/{transaction_id}?", HttpMethod.Delete, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }
            try
            {
                this.Path = this.Path.Replace("{transaction_id}", Uri.EscapeDataString(Convert.ToString(TransactionId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Deletes a draft invoice, by ID. Deletes invoices in the draft state only. For invoices that have already been sent, you can [cancel the invoice](/docs/api/invoicing/#invoices_cancel). After you delete a draft invoice, you can no longer use it or show its details. However, you can reuse its invoice number.
    /// </summary>
    public class InvoiceDeleteRequest : HttpRequest
    {
        public InvoiceDeleteRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}?", HttpMethod.Delete, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Shows details for an invoice, by ID.
    /// </summary>
    public class InvoiceGetRequest : HttpRequest
    {
        public InvoiceGetRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}?", HttpMethod.Get, typeof(Invoice))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

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

    /// <summary>
    /// Generates the next invoice number that is available to the merchant.
    /// </summary>
    public class InvoiceNextInvoiceNumberRequest : HttpRequest
    {
        public InvoiceNextInvoiceNumberRequest() : base("/v1/invoicing/invoices/next-invoice-number?", HttpMethod.Post, typeof(InvoiceNumber))
        {

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Generates a QR code for an invoice, by ID.<br/><br/>The QR code is a PNG image in [Base64-encoded](https://www.base64encode.org/) format that corresponds to the invoice ID. You can generate a QR code for an invoice and add it to a paper or PDF invoice. When a customer uses their mobile device to scan the QR code, he or she is redirected to the PayPal mobile payment flow where he or she can pay online with PayPal or a credit card.<br/><br/>Before you get a QR code, you must:<ol><li><p>[Create an invoice](#invoices_create). Specify `qrinvoice@paypal.com` as the recipient email address in the `billing_info` object. Use a customer email address only if you want to email the invoice.</p></li><li><p>[Send an invoice](#invoices_send) to move the invoice from a draft to payable state. If you specify `qrinvoice@paypal.com` as the recipient email address, the invoice is not emailed.</p></li></ol>
    /// </summary>
    public class InvoiceQrCodeRequest : HttpRequest
    {
        public InvoiceQrCodeRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/qr-code?", HttpMethod.Get, typeof(QrCode))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public InvoiceQrCodeRequest Action(string Action)
        {
            var strParams = Convert.ToString(Action);
            try
            {
                this.Path = $"{this.Path}action={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public InvoiceQrCodeRequest Height(int Height)
        {
            var strParams = Convert.ToString(Height);
            try
            {
                this.Path = $"{this.Path}height={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public InvoiceQrCodeRequest Width(int Width)
        {
            var strParams = Convert.ToString(Width);
            try
            {
                this.Path = $"{this.Path}width={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }

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

    /// <summary>
    /// Sends a reminder to the payer about an invoice, by ID. In the JSON request body, include a `notification` object that defines the subject of the reminder and other details.
    /// </summary>
    public class InvoiceRemindRequest : HttpRequest
    {
        public InvoiceRemindRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/remind?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public InvoiceRemindRequest RequestBody(Notification Body)
        {
            this.Body = Body;
            return this;
        }
    }

    /// <summary>
    /// Lists invoices that match search criteria. In the JSON request body, include a `search` object that specifies the search criteria.
    /// </summary>
    public class InvoiceSearchRequest : HttpRequest
    {
        public InvoiceSearchRequest() : base("/v1/invoicing/search?", HttpMethod.Post, typeof(InvoiceList))
        {

            this.ContentType = "application/json";
        }

        public InvoiceSearchRequest RequestBody(Search Body)
        {
            this.Body = Body;
            return this;
        }
    }

    /// <summary>
    /// Sends an invoice, by ID, to a customer.<blockquote><strong>Note:</strong> After you send an invoice, you cannot resend it.</blockquote><br/>Optionally, set the `notify_merchant` query parameter to also send the merchant an invoice update notification. Default is `true`.
    /// </summary>
    public class InvoiceSendRequest : HttpRequest
    {
        public InvoiceSendRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/send?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public InvoiceSendRequest NotifyMerchant(bool NotifyMerchant)
        {
            var strParams = Convert.ToString(NotifyMerchant);
            try
            {
                this.Path = $"{this.Path}notify_merchant={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }

    /// <summary>
    /// Fully updates an invoice, by ID. In the JSON request body, include a complete `invoice` object. This call does not support partial updates.
    /// </summary>
    public class InvoiceUpdateRequest : HttpRequest
    {
        public InvoiceUpdateRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}?", HttpMethod.Put, typeof(Invoice))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public InvoiceUpdateRequest NotifyMerchant(bool NotifyMerchant)
        {
            var strParams = Convert.ToString(NotifyMerchant);
            try
            {
                this.Path = $"{this.Path}notify_merchant={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public InvoiceUpdateRequest RequestBody(Invoice Body)
        {
            this.Body = Body;
            return this;
        }
    }

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

    /// <summary>
    /// Deletes a template, by ID.
    /// </summary>
    public class TemplateDeleteRequest : HttpRequest
    {
        public TemplateDeleteRequest(string TemplateId) : base("/v1/invoicing/templates/{template_id}?", HttpMethod.Delete, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{template_id}", Uri.EscapeDataString(Convert.ToString(TemplateId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

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
