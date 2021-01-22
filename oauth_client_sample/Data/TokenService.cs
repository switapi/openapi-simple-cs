using oauth_client_sample.util;

namespace oauth_client_sample.Data
{
    public class TokenInstance
    {
        private static TokenInstance instance { get; set; }

        public static TokenInstance Instance => (instance ??= new TokenInstance());

        private AccessTokenInfo tokenInfo;
        
        public void SetToken(AccessTokenInfo tokenInfo)
        {
            this.tokenInfo = tokenInfo;
        }

        public AccessTokenInfo GetToken() => this.tokenInfo;
    }
}