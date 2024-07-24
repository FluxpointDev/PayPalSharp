using BraintreeHttp;
using PayPal.v1;
using PayPal.v1.Vault;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace PayPal.Core
{
    public class VaultEndpoints : IEndpoints
    {
        internal VaultEndpoints(PayPalHttpClient client) : base(client)
        {

        }

    }

    /// <summary>
    /// Stores credit card details in the PayPal vault. To use the vaulted card to make a payment, specify this ID as the `credit_card_id` in a [`credit_card_token`](/docs/api/payments/#definition-credit_card_token) object. If you include a `payer_id` when you store the credit card, you must also include that ID as the `external_customer_id` in the `credit_card_token` object.<br/>You can also use the ID of the vaulted credit card to show details for, update, or delete the vaulted card.
    /// </summary>
    public class CreditCardCreateRequest : HttpRequest
    {
        public CreditCardCreateRequest() : base("/v1/vault/credit-cards?", HttpMethod.Post, typeof(CreditCard))
        {

            this.ContentType = "application/json";
        }

        public CreditCardCreateRequest RequestBody(CreditCard CreditCard)
        {
            this.Body = CreditCard;
            return this;
        }
    }

    /// <summary>
    /// Deletes a vaulted credit card, by ID.
    /// </summary>
    public class CreditCardDeleteRequest : HttpRequest
    {
        public CreditCardDeleteRequest(string CreditCardId) : base("/v1/vault/credit-cards/{credit_card_id}?", HttpMethod.Delete, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{credit_card_id}", Uri.EscapeDataString(Convert.ToString(CreditCardId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Shows details for a vaulted credit card, by ID.
    /// </summary>
    public class CreditCardGetRequest : HttpRequest
    {
        public CreditCardGetRequest(string CreditCardId) : base("/v1/vault/credit-cards/{credit_card_id}?", HttpMethod.Get, typeof(CreditCard))
        {
            try
            {
                this.Path = this.Path.Replace("{credit_card_id}", Uri.EscapeDataString(Convert.ToString(CreditCardId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Lists vaulted credit cards. To filter the cards in the response, specify one or more optional query parameters.
    /// </summary>
    public class CreditCardListRequest : HttpRequest
    {
        public CreditCardListRequest() : base("/v1/vault/credit-cards?", HttpMethod.Get, typeof(CreditCardList))
        {

            this.ContentType = "application/json";
        }

        public CreditCardListRequest EndTime(string EndTime)
        {
            var strParams = Convert.ToString(EndTime);
            try
            {
                this.Path = $"{this.Path}end_time={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest ExternalCardId(string ExternalCardId)
        {
            var strParams = Convert.ToString(ExternalCardId);
            try
            {
                this.Path = $"{this.Path}external_card_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest ExternalCustomerId(string ExternalCustomerId)
        {
            var strParams = Convert.ToString(ExternalCustomerId);
            try
            {
                this.Path = $"{this.Path}external_customer_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest MerchantId(string MerchantId)
        {
            var strParams = Convert.ToString(MerchantId);
            try
            {
                this.Path = $"{this.Path}merchant_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest Page(int Page)
        {
            var strParams = Convert.ToString(Page);
            try
            {
                this.Path = $"{this.Path}page={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest PageSize(int PageSize)
        {
            var strParams = Convert.ToString(PageSize);
            try
            {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest SortBy(string SortBy)
        {
            var strParams = Convert.ToString(SortBy);
            try
            {
                this.Path = $"{this.Path}sort_by={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest SortOrder(string SortOrder)
        {
            var strParams = Convert.ToString(SortOrder);
            try
            {
                this.Path = $"{this.Path}sort_order={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest StartTime(string StartTime)
        {
            var strParams = Convert.ToString(StartTime);
            try
            {
                this.Path = $"{this.Path}start_time={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest TotalRequired(bool TotalRequired)
        {
            var strParams = Convert.ToString(TotalRequired);
            try
            {
                this.Path = $"{this.Path}total_required={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }

    /// <summary>
    /// Updates information for a vaulted credit card, by ID. In the JSON request body, specify the values to update.
    /// </summary>
    public class CreditCardUpdateRequest<T> : HttpRequest
    {
        public CreditCardUpdateRequest(string CreditCardId) : base("/v1/vault/credit-cards/{credit_card_id}?", new HttpMethod("PATCH"), typeof(CreditCard))
        {
            try
            {
                this.Path = this.Path.Replace("{credit_card_id}", Uri.EscapeDataString(Convert.ToString(CreditCardId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public CreditCardUpdateRequest<T> RequestBody(List<JsonPatch<T>> PatchRequest)
        {
            this.Body = PatchRequest;
            return this;
        }
    }
}
