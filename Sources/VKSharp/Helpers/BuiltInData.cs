using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace VKSharp.Helpers {
    class BuiltInData {
        private static Lazy<BuiltInData> _lazy = new Lazy<BuiltInData>(()=>new BuiltInData());

        internal static BuiltInData Instance {
            get {
                return _lazy.Value;
            }
        }

        public string VKDomain {
            get { return this._vkDomain; }
        }
        public string OAuthURL {
            get { return this._oAuthURL; }
        }
        public Encoding TextEncoding {
            get { return this._textEncoding; }
        }
        public MD5 Hasher {
            get { return this._hasher; }
        }

        public CultureInfo NC {
            get { return this._culture; }
        }

        private readonly string _vkDomain;
        private readonly string _oAuthURL;
        private readonly Encoding _textEncoding = Encoding.UTF8;
        private readonly MD5 _hasher = MD5.Create();
        private readonly CultureInfo _culture = CultureInfo.InvariantCulture;
        private BuiltInData() {
            this._vkDomain = "https://api.vk.com";
            this._oAuthURL = "https://oauth.vk.com/authorize?client_id={0}&scope={1}&redirect_uri={2}&response_type=token";
        }
    }
}
