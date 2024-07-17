using System;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Identity.Test
{
    [Collection("Identity")]
    public class UserConsentTest
    {
        [Fact]
        public void TestUserConsent()
        {
            var url = new UserConsent(TestHarness.environment())
                                .ResponseType("code")
                                .Scope("profile+email+openid+phone+address+https%3A%2F%2Furi.paypal.com%2Fservices%2Fpaypalattributes")
                                .RedirectUri("http%3A%2F%2Frequestbin.fullcontact.com%2F15a7bhu1")
                                .Build();
            Assert.Equal("https://www.sandbox.paypal.com/signin/authorize?client_id=AdV4d6nLHabWLyemrw4BKdO9LjcnioNIOgoz7vD611ObbDUL0kJQfzrdhXEBwnH8QmV-7XZjvjRWn0kg&response_type=code&scope=profile+email+openid+phone+address+https%3A%2F%2Furi.paypal.com%2Fservices%2Fpaypalattributes&redirect_uri=http%3A%2F%2Frequestbin.fullcontact.com%2F15a7bhu1&", url);
        }

        [Fact(Skip="Tests that use this class must be ignored when run in an automated environment because generating refresh token from code will require a new code returned by PayPal after user's approval")]
        public async void TestGetRefreshTokenFromCode()
        {
            var code = "C21AAHLX4BEjqn4GPXgSLnqJyBkJwxQyCUly4PU10pIN4hgoHtWB7UTdUKIrhDlxlGuvF41VgeYmDVbVNoEykO9uy7Zd6hKVg";
            RefreshTokenRequest request = new RefreshTokenRequest(TestHarness.environment(), code);
            HttpResponse response = null;
            response = await TestHarness.client().Execute(request);
            Assert.NotNull(response);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<RefreshToken>());
            var actual = response.Result<RefreshToken>();
            Console.WriteLine(actual.Token);
        }

        [Fact(Skip="Tests that use this class must be ignored when run in an automated environment because refresh token used here will depend on the code, and is bound to change")]
        public async void TestUserinfoGetRequest()
        {
            var refreshToken = "R23AAGugHBGsj7Y-yWS-XtgY8MtL1ovx4S86SRWLgiZgRjug85nO0egYreBn-4oSV321IwuLuGt0MQ2c2COzq5pJQzHWwvnb14IW6VspQIuJd9rpsegIKuQYfEjgcfhyey3CIGjK7DWdmHdaQAgXw";
            var request = new UserinfoGetRequest().Schema("openid");
            var client = TestHarness.client(refreshToken);

            HttpResponse response = await client.Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<UserInfo>());
            var actual = response.Result<UserInfo>();
            Assert.Equal("Sample Buyer", actual.Name);
            Assert.Equal("samplebuyer@buy.com", actual.Email);
            Assert.Equal("Sample", actual.GivenName);
            Assert.Equal("4084891074", actual.PhoneNumber);
            Assert.NotNull(actual.Address);
            Assert.Equal("San Jose", actual.Address.Locality);
        }
    }
}
