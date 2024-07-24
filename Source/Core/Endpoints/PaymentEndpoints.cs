using BraintreeHttp;
using PayPal.v1;
using PayPal.v1.Payments;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace PayPal.Core
{
    public class PaymentEndpoints : IEndpoints
    {
        internal PaymentEndpoints(PayPalHttpClient client) : base(client)
        {

        }

    }

    /// <summary>
    /// Captures and processes an authorization, by ID. The original payment call must specify an intent of `authorize`.
    /// </summary>
    public class AuthorizationCaptureRequest : HttpRequest
    {
        public AuthorizationCaptureRequest(string AuthorizationId) : base("/v1/payments/authorization/{authorization_id}/capture?", HttpMethod.Post, typeof(Capture))
        {
            try
            {
                this.Path = this.Path.Replace("{authorization_id}", Uri.EscapeDataString(Convert.ToString(AuthorizationId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AuthorizationCaptureRequest RequestBody(Capture Capture)
        {
            this.Body = Capture;
            return this;
        }
    }

    /// <summary>
    /// Shows details for an authorization, by ID.
    /// </summary>
    public class AuthorizationGetRequest : HttpRequest
    {
        public AuthorizationGetRequest(string AuthorizationId) : base("/v1/payments/authorization/{authorization_id}?", HttpMethod.Get, typeof(Authorization))
        {
            try
            {
                this.Path = this.Path.Replace("{authorization_id}", Uri.EscapeDataString(Convert.ToString(AuthorizationId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Re-authorizes a PayPal account payment, by authorization ID. To ensure that funds are still available, re-authorize a payment after the initial three-day honor period. Supports only the `amount` request parameter. You can re-authorize a payment only once from four to 29 days after three-day honor period for the original authorization expires. If 30 days have passed from the original authorization, you must create a new authorization instead. A re-authorized payment itself has a new three-day honor period. You can re-authorize a transaction once for up to 115% of the originally authorized amount, not to exceed an increase of $75 USD.
    /// </summary>
    public class AuthorizationReauthorizeRequest : HttpRequest
    {
        public AuthorizationReauthorizeRequest(string AuthorizationId) : base("/v1/payments/authorization/{authorization_id}/reauthorize?", HttpMethod.Post, typeof(Authorization))
        {
            try
            {
                this.Path = this.Path.Replace("{authorization_id}", Uri.EscapeDataString(Convert.ToString(AuthorizationId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AuthorizationReauthorizeRequest RequestBody(Authorization Authorization)
        {
            this.Body = Authorization;
            return this;
        }
    }

    /// <summary>
    /// Voids, or cancels, an authorization, by ID. You cannot void a fully captured authorization.
    /// </summary>
    public class AuthorizationVoidRequest : HttpRequest
    {
        public AuthorizationVoidRequest(string AuthorizationId) : base("/v1/payments/authorization/{authorization_id}/void?", HttpMethod.Post, typeof(Authorization))
        {
            try
            {
                this.Path = this.Path.Replace("{authorization_id}", Uri.EscapeDataString(Convert.ToString(AuthorizationId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }
        public AuthorizationVoidRequest PaypalRequestId(string PaypalRequestId)
        {
            this.Headers.Add("PayPal-Request-Id", PaypalRequestId);
            return this;
        }


    }

    /// <summary>
    /// Shows details for a captured payment, by ID.
    /// </summary>
    public class CaptureGetRequest : HttpRequest
    {
        public CaptureGetRequest(string CaptureId) : base("/v1/payments/capture/{capture_id}?", HttpMethod.Get, typeof(Capture))
        {
            try
            {
                this.Path = this.Path.Replace("{capture_id}", Uri.EscapeDataString(Convert.ToString(CaptureId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Refunds a captured payment, by ID. In the JSON request body, include an `amount` object.
    /// </summary>
    public class CaptureRefundRequest : HttpRequest
    {
        public CaptureRefundRequest(string CaptureId) : base("/v1/payments/capture/{capture_id}/refund?", HttpMethod.Post, typeof(DetailedRefund))
        {
            try
            {
                this.Path = this.Path.Replace("{capture_id}", Uri.EscapeDataString(Convert.ToString(CaptureId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }
        public CaptureRefundRequest PaypalRequestId(string PaypalRequestId)
        {
            this.Headers.Add("PayPal-Request-Id", PaypalRequestId);
            return this;
        }


        public CaptureRefundRequest RequestBody(RefundRequest RefundRequest)
        {
            this.Body = RefundRequest;
            return this;
        }
    }

    /// <summary>
    /// Authorizes an order, by ID. In the JSON request body, include an `amount` object.
    /// </summary>
    public class OrderAuthorizeRequest : HttpRequest
    {
        public OrderAuthorizeRequest(string OrderId) : base("/v1/payments/orders/{order_id}/authorize?", HttpMethod.Post, typeof(Authorization))
        {
            try
            {
                this.Path = this.Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(OrderId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public OrderAuthorizeRequest RequestBody(Order Order)
        {
            this.Body = Order;
            return this;
        }
    }

    /// <summary>
    /// Captures a payment for an order, by ID. To use this call, the original payment call must specify an `order` intent. In the JSON request body, include the payment amount and indicate whether this capture is the final capture for the authorization.
    /// </summary>
    public class OrderCaptureRequest : HttpRequest
    {
        public OrderCaptureRequest(string OrderId) : base("/v1/payments/orders/{order_id}/capture?", HttpMethod.Post, typeof(Capture))
        {
            try
            {
                this.Path = this.Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(OrderId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public OrderCaptureRequest RequestBody(Capture Capture)
        {
            this.Body = Capture;
            return this;
        }
    }

    /// <summary>
    /// Shows details for an order, by ID.
    /// </summary>
    public class OrderGetRequest : HttpRequest
    {
        public OrderGetRequest(string OrderId) : base("/v1/payments/orders/{order_id}?", HttpMethod.Get, typeof(Order))
        {
            try
            {
                this.Path = this.Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(OrderId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Voids, or cancels, an order, by ID. You cannot void an order if the payment has already been partially or fully captured.
    /// </summary>
    public class OrderVoidRequest : HttpRequest
    {
        public OrderVoidRequest(string OrderId) : base("/v1/payments/orders/{order_id}/do-void?", HttpMethod.Post, typeof(Order))
        {
            try
            {
                this.Path = this.Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(OrderId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }
        public OrderVoidRequest PaypalRequestId(string PaypalRequestId)
        {
            this.Headers.Add("PayPal-Request-Id", PaypalRequestId);
            return this;
        }


    }

    /// <summary>
    /// Creates a sale, an authorized payment to be captured later, or an order. To create a sale, authorization, or order, include the payment details in the JSON request body. Set the `intent` to `sale`, `authorize`, or `order`. <blockquote><strong>Note: </strong>TPP Clients (Third Party Providers in the context of PSD2 regulation) are restricted from using <code>authorize</code> and <code>order</code> intents.</blockquote> Include payer, transaction details, and, for PayPal payments only, redirect URLs. The combination of the `payment_method` and `funding_instrument` determines the type of payment that is created. For more information, see [Payments REST API](/docs/integration/direct/payments/).<blockquote><strong>Note:</strong> Authorizations are guaranteed for up to three days, though you can attempt to capture an authorization for up to 29 days. After the three-day honor period authorization expires, you can [reauthorize](#authorization_reauthorize) the payment.</blockquote>
    /// </summary>
    public class PaymentCreateRequest : HttpRequest
    {
        public PaymentCreateRequest() : base("/v1/payments/payment?", HttpMethod.Post, typeof(Payment))
        {

            this.ContentType = "application/json";
        }
        public PaymentCreateRequest PaypalPartnerAttributionId(string PaypalPartnerAttributionId)
        {
            this.Headers.Add("PayPal-Partner-Attribution-Id", PaypalPartnerAttributionId);
            return this;
        }


        public PaymentCreateRequest RequestBody(Payment Payment)
        {
            this.Body = Payment;
            return this;
        }
    }

    /// <summary>
    /// Executes a PayPal payment that the customer has approved. You can optionally update one or more transactions when you execute the payment.<blockquote><strong>Important:</strong> This call works only after a customer has approved the payment. For more information, learn about [PayPal payments](/docs/integration/direct/payments/paypal-payments/).</blockquote>
    /// </summary>
    public class PaymentExecuteRequest : HttpRequest
    {
        public PaymentExecuteRequest(string PaymentId) : base("/v1/payments/payment/{payment_id}/execute?", HttpMethod.Post, typeof(Payment))
        {
            try
            {
                this.Path = this.Path.Replace("{payment_id}", Uri.EscapeDataString(Convert.ToString(PaymentId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }
        public PaymentExecuteRequest PaypalPartnerAttributionId(string PaypalPartnerAttributionId)
        {
            this.Headers.Add("PayPal-Partner-Attribution-Id", PaypalPartnerAttributionId);
            return this;
        }

        public PaymentExecuteRequest PaypalRequestId(string PaypalRequestId)
        {
            this.Headers.Add("PayPal-Request-Id", PaypalRequestId);
            return this;
        }


        public PaymentExecuteRequest RequestBody(PaymentExecution PaymentExecution)
        {
            this.Body = PaymentExecution;
            return this;
        }
    }

    /// <summary>
    /// Shows details for a payment, by ID, that has yet to complete. For example, shows details for a payment that was created, approved, or failed.
    /// </summary>
    public class PaymentGetRequest : HttpRequest
    {
        public PaymentGetRequest(string PaymentId) : base("/v1/payments/payment/{payment_id}?", HttpMethod.Get, typeof(Payment))
        {
            try
            {
                this.Path = this.Path.Replace("{payment_id}", Uri.EscapeDataString(Convert.ToString(PaymentId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Lists payments that were created by the [create payment](#payment_create) call and that are in any state. The list shows the payments that are made to the merchant who makes the call. To filter the payments that appear in the response, you can specify one or more optional query and pagination parameters. See [Filtering and pagination](/docs/api/overview/#query-parameters).
    /// </summary>
    public class PaymentListRequest : HttpRequest
    {
        public PaymentListRequest() : base("/v1/payments/payment?", HttpMethod.Get, typeof(PaymentHistory))
        {

            this.ContentType = "application/json";
        }

        public PaymentListRequest Count(int Count)
        {
            var strParams = Convert.ToString(Count);
            try
            {
                this.Path = $"{this.Path}count={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PaymentListRequest EndTime(string EndTime)
        {
            var strParams = Convert.ToString(EndTime);
            try
            {
                this.Path = $"{this.Path}end_time={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PaymentListRequest PayeeId(string PayeeId)
        {
            var strParams = Convert.ToString(PayeeId);
            try
            {
                this.Path = $"{this.Path}payee_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PaymentListRequest SortBy(string SortBy)
        {
            var strParams = Convert.ToString(SortBy);
            try
            {
                this.Path = $"{this.Path}sort_by={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PaymentListRequest SortOrder(string SortOrder)
        {
            var strParams = Convert.ToString(SortOrder);
            try
            {
                this.Path = $"{this.Path}sort_order={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PaymentListRequest StartId(string StartId)
        {
            var strParams = Convert.ToString(StartId);
            try
            {
                this.Path = $"{this.Path}start_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PaymentListRequest StartIndex(int StartIndex)
        {
            var strParams = Convert.ToString(StartIndex);
            try
            {
                this.Path = $"{this.Path}start_index={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public PaymentListRequest StartTime(string StartTime)
        {
            var strParams = Convert.ToString(StartTime);
            try
            {
                this.Path = $"{this.Path}start_time={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }

    /// <summary>
    /// Partially updates a payment, by ID. You can update the amount, shipping address, invoice ID, and custom data. You cannot update a payment after the payment executes. <blockquote><strong>Note: </strong>TPP Clients (Third Party Providers in the context of PSD2 regulation) are restricted from patching amount once authorized.</blockquote>
    /// </summary>
    public class PaymentUpdateRequest<T> : HttpRequest
    {
        public PaymentUpdateRequest(string PaymentId) : base("/v1/payments/payment/{payment_id}?", new HttpMethod("PATCH"), typeof(Payment))
        {
            try
            {
                this.Path = this.Path.Replace("{payment_id}", Uri.EscapeDataString(Convert.ToString(PaymentId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public PaymentUpdateRequest<T> RequestBody(List<JsonPatch<T>> PatchRequest)
        {
            this.Body = PatchRequest;
            return this;
        }
    }

    /// <summary>
    /// Shows details for a refund, by ID.
    /// </summary>
    public class RefundGetRequest : HttpRequest
    {
        public RefundGetRequest(string RefundId) : base("/v1/payments/refund/{refund_id}?", HttpMethod.Get, typeof(Refund))
        {
            try
            {
                this.Path = this.Path.Replace("{refund_id}", Uri.EscapeDataString(Convert.ToString(RefundId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Shows details for a sale, by ID. Returns only sales that were created through the REST API.
    /// </summary>
    public class SaleGetRequest : HttpRequest
    {
        public SaleGetRequest(string SaleId) : base("/v1/payments/sale/{sale_id}?", HttpMethod.Get, typeof(Sale))
        {
            try
            {
                this.Path = this.Path.Replace("{sale_id}", Uri.EscapeDataString(Convert.ToString(SaleId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Refunds a sale, by ID. For a full refund, do not include the `amount` object in the JSON request body. For a partial refund, include an `amount` object in the JSON request body.
    /// </summary>
    public class SaleRefundRequest : HttpRequest
    {
        public SaleRefundRequest(string SaleId) : base("/v1/payments/sale/{sale_id}/refund?", HttpMethod.Post, typeof(DetailedRefund))
        {
            try
            {
                this.Path = this.Path.Replace("{sale_id}", Uri.EscapeDataString(Convert.ToString(SaleId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }
        public SaleRefundRequest PaypalRequestId(string PaypalRequestId)
        {
            this.Headers.Add("PayPal-Request-Id", PaypalRequestId);
            return this;
        }


        public SaleRefundRequest RequestBody(RefundRequest RefundRequest)
        {
            this.Body = RefundRequest;
            return this;
        }
    }
}
