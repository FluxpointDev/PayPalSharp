




using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Identity
{
    /// <summary>
    /// Shows user details.<blockquote><strong>Note:</strong> This API is deprecated. Use `v1/oauth2/token/userinfo` instead.</blockquote>
    /// </summary>
    public class UserinfoGetRequest : HttpRequest
    {
        public UserinfoGetRequest() : base("/v1/identity/openidconnect/userinfo?", HttpMethod.Get, typeof(UserInfo))
        {

        }

        public UserinfoGetRequest Schema(string Schema)
        {
            var strParams = Convert.ToString(Schema);
            try
            {
                this.Path = $"{this.Path}schema={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }
}
