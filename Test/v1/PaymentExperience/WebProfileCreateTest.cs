using System;
using System.Text;
using System.Net.Http;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.PaymentExperience.Test
{

    [Collection("Web Profile")]
    public class WebProfileCreateTest
    {
        private static WebProfile buildRequestBody()
        {
            var profileName = "Template " + Guid.NewGuid();
            var jsonContent = new StringContent("{ \"name\": \"" + profileName + "\", \"flow_config\": { \"landing_page_type\": \"Billing\", \"bank_txn_pending_url\": \"http://www.yeowza.com/\", \"user_action\": \"commit\", \"return_uri_http_method\": \"GET\" }, \"presentation\": { \"logo_image\": \"http://www.yeowza.com/favico.ico\", \"brand_name\": \"YeowZa! Paypal\", \"locale_code\": \"US\", \"return_url_label\": \"Return\", \"note_to_seller_label\": \"Thanks!\" }, \"input_fields\": { \"allow_note\": true, \"no_shipping\": 1, \"address_override\": 0 }, \"temporary\": true }", Encoding.UTF8, "application/json");
            return (WebProfile) new JsonSerializer().Decode(jsonContent, typeof(WebProfile));
        }

        public static async Task<HttpResponse> createWebProfile() {
            WebProfileCreateRequest request = new WebProfileCreateRequest();
            request.RequestBody(buildRequestBody());
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestWebProfileCreateRequest()
        {
            HttpResponse response = await createWebProfile();
            Assert.Equal(201, (int) response.StatusCode);
            Assert.NotNull(response.Result<WebProfile>());
        }
    }
}
