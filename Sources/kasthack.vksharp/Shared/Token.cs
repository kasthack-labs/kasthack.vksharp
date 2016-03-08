using System;
using System.Linq;
#if !PORTABLE
using System.Security.Authentication;
#endif
using kasthack.vksharp.Internal;

namespace kasthack.vksharp {
    public class Token {
        public string Value { get; private set; }
        public string Sign { get; private set; }
        public int UserId { get; private set; }

        public Token( string value, string sign = null, int userId = 0 ) {
            Value = value;
            Sign = sign;
            UserId = userId;
        }

        public static string GetOAuthURL(
            int appId,
            Permission permissions = Permission.None,
            string redirectURL = "https://oauth.vk.com/blank.html" ) {
            var testperm =
                Enum.GetValues(typeof (Permission))
                    .OfType<Permission>()
                    .Where(a => a != Permission.None && a != Permission.Everything);
            return string.Format(
                                 BuiltInData.Instance.OAuthURL,
                                 appId,
                                 string.Join(
                                             ",",
                                             testperm
                                                .Where( a => permissions.HasFlag( a ) )
                                                .Select( a => a.ToString()
                                                    .ToLowerInvariant() )
                                                ),
                                 redirectURL );
        }

        public static Token FromRedirectUrl( string url ) {
            const string accessTokenPn = @"access_token";
            const string signPn = @"secret";
            const string useridPn = @"user_id";
            const string errorPn = @"error";
            const string errorRPn = @"error_reason";
            const string errorDescPn = @"error_description";
            var query =new Uri(url)
                .Fragment
                .TrimStart('#')
                .Split( '&' )
                .Select(a => a.Split('='))
                .Where(a => a.Length == 2)
                .GroupBy(a => a[ 0 ])
                .ToDictionary(a => a.Key, a => a.First()[1]);
            if ( query.ContainsKey( accessTokenPn ) )
                return new Token(
                    query[ accessTokenPn ],
                    query.ContainsKey( signPn )
                        ? query[ signPn ]
                        : "",
                    int.Parse( query[ useridPn ] )
                );
            if ( query.ContainsKey(errorPn))
#if !PORTABLE
                throw new AuthenticationException(
#else
                throw new VkException(
#endif
                $"Error: {query[errorPn]}\r\nType:{query[errorRPn]}\r\nMessage:{query[errorDescPn].Replace('+', ' ')}"
                    );
            throw new FormatException("Can't parse VK response from URL");
        }
    }
}