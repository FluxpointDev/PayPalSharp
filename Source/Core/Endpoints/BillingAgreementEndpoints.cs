using BraintreeHttp;
using PayPal.v1;
using PayPal.v1.BillingAgreements;
using PayPal.v1.Subscriptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace PayPal.Core
{
    public class BillingAgreementEndpoints : IEndpoints
    {
        internal BillingAgreementEndpoints(PayPalHttpClient client) : base(client)
        {

        }

        public async Task<HttpResponse> GetPlanAsync(string planId)
        {
            HttpRequest Req = new HttpRequest($"/v1/billing/plans/{Uri.EscapeDataString(planId)}?", HttpMethod.Get, typeof(Plan))
            {
                ContentType = "application/json",
            };

            return await Client.Execute(Req);
        }
    }

    /// <summary>
    /// Bills the balance for an agreement, by ID. In the JSON request body, include an optional note that describes the reason for the billing action and the agreement amount and currency.
    /// </summary>
    public class AgreementBillBalanceRequest : HttpRequest
    {
        public AgreementBillBalanceRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/bill-balance?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AgreementBillBalanceRequest RequestBody(AgreementStateDescriptor AgreementStateDescriptor)
        {
            this.Body = AgreementStateDescriptor;
            return this;
        }
    }

    /// <summary>
    /// Cancels a billing agreement, by ID. In the JSON request body, include an `agreement_state_descriptor` object with an optional note that describes the reason for the cancellation and the agreement amount and currency.
    /// </summary>
    public class AgreementCancelRequest : HttpRequest
    {
        public AgreementCancelRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/cancel?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AgreementCancelRequest RequestBody(AgreementStateDescriptor AgreementStateDescriptor)
        {
            this.Body = AgreementStateDescriptor;
            return this;
        }
    }

    /// <summary>
    /// Creates a billing agreement. In the JSON request body, include an `agreement` object with the name, description, start date, ID of the plan on which to base the agreement, and customer and shipping address information.
    /// </summary>
    public class AgreementCreateRequest : HttpRequest
    {
        public AgreementCreateRequest() : base("/v1/payments/billing-agreements/?", HttpMethod.Post, typeof(Agreement))
        {

            this.ContentType = "application/json";
        }

        public AgreementCreateRequest RequestBody(Agreement Agreement)
        {
            this.Body = Agreement;
            return this;
        }
    }

    /// <summary>
    /// Executes a billing agreement, by ID, after customer approval.
    /// </summary>
    public class AgreementExecuteRequest : HttpRequest
    {
        public AgreementExecuteRequest(string PaymentToken) : base("/v1/payments/billing-agreements/{payment_token}/agreement-execute?", HttpMethod.Post, typeof(Agreement))
        {
            try
            {
                this.Path = this.Path.Replace("{payment_token}", Uri.EscapeDataString(Convert.ToString(PaymentToken)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Shows details for a billing agreement, by ID.
    /// </summary>
    public class AgreementGetRequest : HttpRequest
    {
        public AgreementGetRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}?", HttpMethod.Get, typeof(Agreement))
        {
            try
            {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Re-activates a suspended billing agreement, by ID. In the JSON request body, include an `agreement_state_descriptor` object with with a note that describes the reason for the re-activation and the agreement amount and currency.
    /// </summary>
    public class AgreementReActivateRequest : HttpRequest
    {
        public AgreementReActivateRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/re-activate?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AgreementReActivateRequest RequestBody(AgreementStateDescriptor AgreementStateDescriptor)
        {
            this.Body = AgreementStateDescriptor;
            return this;
        }
    }

    /// <summary>
    /// Sets the balance for an agreement, by ID. In the JSON request body, specify the balance currency type and value.
    /// </summary>
    public class AgreementSetBalanceRequest : HttpRequest
    {
        public AgreementSetBalanceRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/set-balance?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AgreementSetBalanceRequest RequestBody(MoneyTypeWithCurrencyCodeQualifiedValue Currency)
        {
            this.Body = Currency;
            return this;
        }
    }

    /// <summary>
    /// Suspends a billing agreement, by ID.
    /// </summary>
    public class AgreementSuspendRequest : HttpRequest
    {
        public AgreementSuspendRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/suspend?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AgreementSuspendRequest RequestBody(AgreementStateDescriptor AgreementStateDescriptor)
        {
            this.Body = AgreementStateDescriptor;
            return this;
        }
    }

    /// <summary>
    /// Lists transactions for an agreement, by ID. To filter the transactions that appear in the response, specify the optional start and end date query parameters.
    /// </summary>
    public class AgreementTransactionsRequest : HttpRequest
    {
        public AgreementTransactionsRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/transactions?", HttpMethod.Get, typeof(AgreementTransactions))
        {
            try
            {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AgreementTransactionsRequest EndDate(string EndDate)
        {
            var strParams = Convert.ToString(EndDate);
            try
            {
                this.Path = $"{this.Path}end_date={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public AgreementTransactionsRequest StartDate(string StartDate)
        {
            var strParams = Convert.ToString(StartDate);
            try
            {
                this.Path = $"{this.Path}start_date={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }

    /// <summary>
    /// Updates details of a billing agreement, by ID. Details include the description, shipping address, start date, and so on.
    /// </summary>
    public class AgreementUpdateRequest<T> : HttpRequest
    {
        public AgreementUpdateRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}?", new HttpMethod("PATCH"), typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AgreementUpdateRequest<T> RequestBody(List<JsonPatch<T>> PatchRequest)
        {
            this.Body = PatchRequest;
            return this;
        }
    }
}
