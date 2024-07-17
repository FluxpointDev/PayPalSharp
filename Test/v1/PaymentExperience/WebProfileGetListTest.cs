using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.PaymentExperience.Test
{
    [Collection("Web Profile")]
    public class WebProfileGetListTest
    {

        [Fact]
        public async void TestWebProfileGetListRequest()
        {
            HttpResponse createResponse = await WebProfileCreateTest.createWebProfile();
            WebProfileListRequest request = new WebProfileListRequest();

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<List<WebProfile>>());
        }
    }
}
