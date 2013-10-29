using System;

namespace VKSharp.VK.Helpers {
    class BuiltInData {
        private static Lazy<BuiltInData> _lazy = new Lazy<BuiltInData>(()=>new BuiltInData());
        internal static BuiltInData Instance {
            get {
                return _lazy.Value;
            }
        }

        internal readonly string VKDomain,
                        OAuthURL;

        private BuiltInData() {
            VKDomain = "https://vk.com";
            OAuthURL = "https://oauth.vk.com/authorize?client_id={0}&scope={1}&redirect_uri={2}&response_type=token";
        }
    }
}
