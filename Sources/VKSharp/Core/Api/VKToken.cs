using System;
using System.Linq;
using System.Security.Authentication;
using VKSharp.Helpers;

namespace VKSharp.Data.Api {
    public class VKToken {
        public string Token { get; private set; }
        public string Sign { get; private set; }
        public int UserId { get; private set; }

        public VKToken( string token, string sign = null, int userId = 0 ) {
            Token = token;
            Sign = sign;
            UserId = userId;
        }

        public static string GetOAuthURL(
            int appId,
            VKPermission permissions = VKPermission.None,
            string redirectURL = "https://oauth.vk.com/blank.html" ) {
            var testperm =
                Enum.GetValues(typeof (VKPermission))
                    .OfType<VKPermission>()
                    .Where(a => a != VKPermission.None && a != VKPermission.Everything);
            return String.Format(
                                 BuiltInData.Instance.OAuthURL,
                                 appId,
                                 String.Join(
                                             ",",
                                             testperm
                                                .Where( a => permissions.HasFlag( a ) )
                                                .Select( a => a.ToString()
                                                    .ToLowerInvariant() )
                                                ),
                                 redirectURL );
        }

        public static VKToken FromRedirectUrl( string url ) {
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
                return new VKToken(
                    query[ accessTokenPn ],
                    query.ContainsKey( signPn )
                        ? query[ signPn ]
                        : "",
                    int.Parse( query[ useridPn ] )
                );
            if ( query.ContainsKey(errorPn))
                throw new AuthenticationException(
                    String.Format(
                    "Error: {0}\r\nType:{1}\r\nMessage:{2}",
                    query[errorPn],
                    query[errorRPn],
                    query[errorDescPn].Replace('+',' ')
                )
            );
            throw new FormatException("Can't parse VK response from URL");
        }
        public static VKToken FromLoginPass( string login, string pass ) {
            throw new NotImplementedException();
        }
    }
}