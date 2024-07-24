




using BraintreeHttp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.PaymentExperience
{
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
}
