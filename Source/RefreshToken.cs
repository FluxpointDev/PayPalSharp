using System.Text.Json.Serialization;

namespace PayPal.Core
{

    public class RefreshToken
    {
        [JsonPropertyName("refresh_token")]
        public string Token;

        [JsonPropertyName("token_type")]
        public string TokenType;

        [JsonPropertyName("expires_in")]
        public string ExpiresIn;

        [JsonPropertyName("id_token")]
        public string IdToken;
    }
}
