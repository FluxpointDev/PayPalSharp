using BraintreeHttp;
using PayPal.v1;
using PayPal.v1.PaymentExperience;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace PayPal.Core
{
    public class PaymentExperienceEndpoints : IEndpoints
    {
        internal PaymentExperienceEndpoints(PayPalHttpClient client) : base(client)
        {

        }

    }

    /// <summary>
    /// Creates a web experience profile. In the JSON request body, specify the profile name and details.
    /// </summary>
    public class WebProfileCreateRequest : HttpRequest
    {
        public WebProfileCreateRequest() : base("/v1/payment-experience/web-profiles/?", HttpMethod.Post, typeof(WebProfile))
        {

            this.ContentType = "application/json";
        }

        public WebProfileCreateRequest RequestBody(WebProfile WebProfile)
        {
            this.Body = WebProfile;
            return this;
        }
    }

    /// <summary>
    /// Deletes a web experience profile, by ID.
    /// </summary>
    public class WebProfileDeleteRequest : HttpRequest
    {
        public WebProfileDeleteRequest(string ProfileId) : base("/v1/payment-experience/web-profiles/{profile_id}?", HttpMethod.Delete, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{profile_id}", Uri.EscapeDataString(Convert.ToString(ProfileId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Shows details for a web experience profile, by ID.
    /// </summary>
    public class WebProfileGetRequest : HttpRequest
    {
        public WebProfileGetRequest(string ProfileId) : base("/v1/payment-experience/web-profiles/{profile_id}?", HttpMethod.Get, typeof(WebProfile))
        {
            try
            {
                this.Path = this.Path.Replace("{profile_id}", Uri.EscapeDataString(Convert.ToString(ProfileId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Lists all web experience profiles for a merchant or subject.
    /// </summary>
    public class WebProfileListRequest : HttpRequest
    {
        public WebProfileListRequest() : base("/v1/payment-experience/web-profiles/?", HttpMethod.Get, typeof(List<WebProfile>))
        {

            this.ContentType = "application/json";
        }

    }

    /// <summary>
    /// Partially-updates a web experience profile, by ID. In the JSON request body, specify a patch object, the path of the profile location to update, and a new value.
    /// </summary>
    public class WebProfilePartialUpdateRequest<T> : HttpRequest
    {
        public WebProfilePartialUpdateRequest(string ProfileId) : base("/v1/payment-experience/web-profiles/{profile_id}?", new HttpMethod("PATCH"), typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{profile_id}", Uri.EscapeDataString(Convert.ToString(ProfileId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public WebProfilePartialUpdateRequest<T> RequestBody(List<JsonPatch<T>> PatchRequest)
        {
            this.Body = PatchRequest;
            return this;
        }
    }

    /// <summary>
    /// Updates a web experience profile, by ID. In the JSON request body, specify the profile details. If your request omits any profile parameters, any previously set values for those parameters are removed.
    /// </summary>
    public class WebProfileUpdateRequest : HttpRequest
    {
        public WebProfileUpdateRequest(string ProfileId) : base("/v1/payment-experience/web-profiles/{profile_id}?", HttpMethod.Put, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{profile_id}", Uri.EscapeDataString(Convert.ToString(ProfileId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public WebProfileUpdateRequest RequestBody(WebProfile WebProfile)
        {
            this.Body = WebProfile;
            return this;
        }
    }
}
