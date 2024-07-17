using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.PaymentExperience.Test
{
    [Collection("Web Profile")]
    public class WebProfilePartialUpdateTest
    {
        private List<JsonPatch<string>> buildRequestBody()
        {
            var jsonContent = new StringContent("[ { \"op\": \"add\", \"path\": \"/presentation/brand_name\", \"value\": \"new_brand_name\" }, { \"op\": \"remove\", \"path\": \"/flow_config/landing_page_type\" } ]", Encoding.UTF8, "application/json");
            return (List<JsonPatch<string>>) new JsonSerializer().Decode(jsonContent, typeof(List<JsonPatch<string>>));
        }

        [Fact]
        public async void TestWebProfilePartialUpdateRequest()
        {
            // Create
            HttpResponse createResponse = await WebProfileCreateTest.createWebProfile();
            var expected = createResponse.Result<WebProfile>();

            // Partial Update
            WebProfilePartialUpdateRequest<string> request = new WebProfilePartialUpdateRequest<string>(expected.Id);
            request.RequestBody(buildRequestBody());
                
            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(204, (int) response.StatusCode);

            // Get
            HttpResponse getResponse = await WebProfileGetTest.getWebProfile(expected.Id);
            Assert.Equal(200, (int) getResponse.StatusCode);
            var updated = getResponse.Result<WebProfile>();
            Assert.NotNull(updated);
            Assert.Equal("new_brand_name", updated.Presentation.BrandName);
        }
    }
}
