using Newtonsoft.Json;

namespace oauth_client_sample.Define

{
    public class Define
    {
        private static readonly string _authUrl = "https://openapi.swit.io/oauth/authorize";
        private static readonly string _tokenUrl = "https://openapi.swit.io/oauth/token";
        
        private static readonly string _clientId = "";
        private static readonly string _clientSecret = "";
        private static readonly string _redirectUri = "http://localhost:5000/callback";
        private static readonly string[] _scopes = {};

        private static readonly string _resourceUrl = "https://openapi.swit.io/v1";
        private static readonly string _userInfoUrl = "/api/user.info";
        private static readonly string _workspaceListUrl = "/api/workspace.list";
        private static readonly string _channelListUrl = "/api/channel.list";
        private static readonly string _messageCreateUrl = "/api/message.create";


        public static string GetAuthorizeUrl()
        {
            var url = string.Format("{0}?client_id={1}&redirect_uri={2}&response_type=code", _authUrl, _clientId,
                _redirectUri);
            return url;
        }

        public static string GetTokenUrl() => _tokenUrl;
        public static string GetUserInfoUrl() => _resourceUrl + _userInfoUrl;
        
        public static string GetWorkspaceListUrl() => _resourceUrl + _workspaceListUrl;
        
        public static string GetChannelListUrl() => _resourceUrl + _channelListUrl;
        public static string GetMesageCreateUrl() => _resourceUrl + _messageCreateUrl;

        public static string GetFormData(string code)
        {
            var formData =
                string.Format("client_id={0}&code={1}&grant_type=authorization_code&redirect_uri={2}&client_secret={3}",
                    _clientId, code, _redirectUri, _clientSecret);
            return formData;
        }
        public static string GetChatData(string a,string b)
        {
            return JsonConvert.SerializeObject(new
            {
                channel_id = a,
                content = b
            }).ToString();

        }
        public static string GetHookData(string a)
        {
            return JsonConvert.SerializeObject(new
            {
                text = a
            }).ToString();

        }
    }
}