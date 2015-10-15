using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace kasthack.vksharp.Internal {
    class BuiltInData {
        private static readonly Lazy<BuiltInData> Lazy = new Lazy<BuiltInData>(()=>new BuiltInData());

        internal static BuiltInData Instance => Lazy.Value;

        public string VkDomain { get; }

        public string OAuthURL { get; }

        public Encoding TextEncoding { get; } = Encoding.UTF8;

        public MD5 Hasher { get; } = MD5.Create();

        public CultureInfo NC { get; } = CultureInfo.InvariantCulture;

        private BuiltInData() {
            VkDomain = "https://api.vk.com";
            OAuthURL = "https://oauth.vk.com/authorize?client_id={0}&scope={1}&redirect_uri={2}&response_type=token";
        }
    }
}
