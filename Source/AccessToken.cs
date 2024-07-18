using System;
using System.Text.Json.Serialization;

namespace PayPal.Core
{

    public class AccessToken
    {
        [JsonPropertyName("access_token")]
        public string Token;

        [JsonPropertyName("token_type")]
        public string TokenType;

        [JsonPropertyName("expires_in")]
        public int ExpiresIn;

        [JsonIgnore]
        private DateTime createDate;

        public AccessToken()
        {
            this.createDate = DateTime.Now;
        }

        public bool IsExpired()
        {
            DateTime expireDate = this.createDate.Add(TimeSpan.FromSeconds(this.ExpiresIn));
            return DateTime.Now.CompareTo(expireDate) > 0;
        }
    }
}
