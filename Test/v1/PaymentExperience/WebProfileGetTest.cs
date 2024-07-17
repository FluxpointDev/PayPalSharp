using System;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.PaymentExperience.Test
{
    [Collection("Web Profile")]
    public class WebProfileGetTest
    {

        public static async Task<HttpResponse> getWebProfile(String id) {
            WebProfileGetRequest request = new WebProfileGetRequest(id);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestWebProfileGetRequest()
        {
            HttpResponse createResponse = await WebProfileCreateTest.createWebProfile();

            var expected = createResponse.Result<WebProfile>();
            HttpResponse response = await getWebProfile(expected.Id);

            Assert.Equal(200, (int) response.StatusCode);
            var webProfile = response.Result<WebProfile>();
            Assert.NotNull(webProfile);
            Assert.Equal(expected.Id, webProfile.Id);
            Assert.Equal(expected.Name, webProfile.Name);
            Assert.Equal(expected.FlowConfig.LandingPageType, webProfile.FlowConfig.LandingPageType);
            Assert.Equal(expected.Presentation.LogoImage, webProfile.Presentation.LogoImage);
            Assert.Equal(expected.InputFields.AllowNote, webProfile.InputFields.AllowNote);
        }
    }
}
