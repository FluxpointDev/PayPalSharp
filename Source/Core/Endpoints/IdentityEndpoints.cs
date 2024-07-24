using BraintreeHttp;
using PayPal.v1.Identity;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace PayPal.Core
{
    public class IdentityEndpoints : IEndpoints
    {
        internal IdentityEndpoints(PayPalHttpClient client) : base(client)
        {

        }

    }

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
