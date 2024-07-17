using BraintreeHttp;
using System;
using System.Net.Http;
using System.Reflection;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using WireMock.Server;
using Xunit;
using System.Threading;

namespace PayPal.Core
{
    [CollectionDefinition("HttpClient", DisableParallelization = true)]
    public class PayPalHttpClientTest : IDisposable
    {
        private FluentMockServer server;
        private PayPalEnvironment environment;

        public PayPalHttpClientTest()
        {
            server = FluentMockServer.Start();
            environment = new PayPalEnvironment("clientid", "clientsecret", $"http://localhost:{server.Ports[0]}", $"http://www.localhost:{server.Ports[0]}");
            Thread.Sleep(5000);
        }

        private PayPalHttpClient getClient(string refreshToken = null)
        {
            return new PayPalHttpClient(environment, refreshToken);
        }

        public void Dispose()
        {
            server.Stop();
        }

        [Fact]
        public async void Execute_AddsGzipHeader()
        {
            server.Given(accessTokenRequest())
                  .RespondWith(accessTokenReponse());

            HttpRequest request = new HttpRequest("/some", HttpMethod.Get);
            server.Given(builderForRequest(request))
                .RespondWith(defaultResponse());

            await getClient().Execute(request);

            var requestLog = getLogForRequest(request);
            Assert.Equal("gzip", requestLog.Headers["Accept-Encoding"][0]);
        }

        [Fact]
        public async void Execute_FetchesAccessTokenIfNull()
        {
            server.Given(accessTokenRequest())
                  .RespondWith(accessTokenReponse());

            var request = new HttpRequest("/some", HttpMethod.Get);

            server.Given(builderForRequest(request))
                  .RespondWith(defaultResponse());

            await getClient().Execute(request);

            var requestLog = getLogForRequest(request);
            Assert.Equal("Bearer sample-access-token", requestLog.Headers["Authorization"][0]);

            var accessTokenRequestLog = getLogForRequest(accessTokenRequest());
            Assert.NotNull(accessTokenRequestLog);

            string authHeaderValue = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("clientid:clientsecret"));
            Assert.Equal($"Basic {authHeaderValue}", accessTokenRequestLog.Headers["Authorization"][0]);
            Assert.Equal("grant_type=client_credentials", accessTokenRequestLog.Body);
        }

        [Fact]
        public async void Execute_FetchesAccessTokenIfExpired()
        {
            var expiredToken = new AccessToken()
            {
                Token = "old-access-token",
                ExpiresIn = 0,
                TokenType = "Bearer",
            };

            var client = getClient();

            setAccessToken(client, expiredToken);

            server.Given(accessTokenRequest())
                .RespondWith(accessTokenReponse());

            var request = new HttpRequest("/", HttpMethod.Get);
            server.Given(builderForRequest(request))
                .RespondWith(defaultResponse());

            await client.Execute(request);

            var requestLog = getLogForRequest(request);
            Assert.Equal("Bearer sample-access-token", requestLog.Headers["Authorization"][0]);

            var accessTokenRequestLog = getLogForRequest(accessTokenRequest());
            Assert.NotNull(accessTokenRequestLog);
        }

        [Fact]
        public async void Execute_DoesNotFetchAccessTokenIfAuthorizationHeaderAlreadyPresent()
        {
            var client = getClient();

            var request = new HttpRequest("/", HttpMethod.Get);
            request.Headers.Add("Authorization", "custom-header-value");

            server.Given(builderForRequest(request))
                .RespondWith(defaultResponse());

            await client.Execute(request);

            var requestLog = getLogForRequest(request);
            Assert.Equal("custom-header-value", requestLog.Headers["Authorization"][0]);
        }

        [Fact]
        public async void Execute_WithRefreshToken_FetchesAccessTokenWithRefreshToken()
        {
            var client = getClient(refreshToken: "refresh-token");

            server.Given(accessTokenRequest())
                .RespondWith(accessTokenReponse(accessToken: "refreshed-access-token"));

            var request = new HttpRequest("/", HttpMethod.Get);
            server.Given(builderForRequest(request))
                .RespondWith(defaultResponse());

            await client.Execute(request);

            var requestLog = getLogForRequest(request);
            Assert.Equal("Bearer refreshed-access-token", requestLog.Headers["Authorization"][0]);

            var accessTokenRequestLog = getLogForRequest(accessTokenRequest());
            Assert.NotNull(accessTokenRequestLog);
            Assert.Equal("grant_type=refresh_token&refresh_token=refresh-token", accessTokenRequestLog.Body);
        }

        [Fact]
        public async void Execute_UsesCorrectUserAgentHeader()
        {
            var client = getClient();

            var request = new HttpRequest("/some", HttpMethod.Get);

            server.Given(accessTokenRequest())
                .RespondWith(accessTokenReponse());

            server.Given(builderForRequest(request))
                  .RespondWith(defaultResponse());

            await getClient().Execute(request);

            var requestLog = getLogForRequest(request);
            var userAgentHeader = requestLog.Headers["User-Agent"][0];
            Assert.Matches($"^PayPalSDK/PayPal-NET-SDK {PayPal.Core.Version.VERSION} (.*)$", userAgentHeader);
            Assert.Contains("lang=DOTNET", userAgentHeader);
            Assert.Contains(";v=", userAgentHeader);
            Assert.Contains(";clr=", userAgentHeader);
            Assert.Contains(";bit=", userAgentHeader);
            Assert.Contains(";os=", userAgentHeader);
        }

        private void setAccessToken(PayPalHttpClient client, AccessToken token)
        {
            var authInjectorField = client.GetType().GetField("authorizationInjector", BindingFlags.Instance | BindingFlags.NonPublic);
            var injector = authInjectorField.GetValue(client);

            var accessTokenField = injector.GetType().GetField("accessToken", BindingFlags.Instance | BindingFlags.NonPublic);
            accessTokenField.SetValue(injector, token);
        }

        private IRequestBuilder accessTokenRequest()
        {
            return Request.Create().UsingPost().WithPath("/v1/oauth2/token");
        }

        private IResponseBuilder accessTokenReponse(string accessToken = "sample-access-token", int expiresIn = 3800)
        {
            var accessTokenJson = $@"{{
                ""access_token"": ""{accessToken}"",
                ""token_type"": ""Bearer"",
                ""expires_in"": {expiresIn}
            }}";

            return Response.Create()
                           .WithStatusCode(200)
                           .WithBody(accessTokenJson)
                           .WithHeader("Content-Type", "application/json");
        }

        private IResponseBuilder defaultResponse(int statusCode = 200)
        {
            return Response.Create().WithStatusCode(statusCode);
        }

        private IRequestBuilder builderForRequest(HttpRequest request)
        {
            var builder = Request.Create().WithUrl($"{environment.BaseUrl()}{request.Path}");
            var method = request.Method;
            if (request.Method.Equals(HttpMethod.Get))
            {
                builder.UsingGet();
            }
            else if (request.Method.Equals(HttpMethod.Post))
            {
                builder.UsingPost();
            }
            else if (request.Method.Equals(HttpMethod.Delete))
            {
                builder.UsingDelete();
            }
            else if (request.Method.Equals(HttpMethod.Put))
            {
                builder.UsingPut();
            }
            else
            {
                builder.UsingAnyVerb();
            }

            return builder;
        }

        private WireMock.RequestMessage getLogForRequest(HttpRequest request)
        {
            return getLogForRequest(builderForRequest(request));
        }

        private WireMock.RequestMessage getLogForRequest(IRequestBuilder request)
        {
            var enumerator = server.FindLogEntries(request).GetEnumerator();
            if (enumerator.MoveNext())
            {
                return enumerator.Current.RequestMessage;
            }
            return null;
        }
    }
}
