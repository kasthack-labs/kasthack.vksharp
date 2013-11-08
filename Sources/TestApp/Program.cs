using System;
using kasthack.Tools;
using VKSharp;
using VKSharp.Data.Api;
using VKSharp.Data.Parameters;

namespace TestApp {
    class Program {
        static void Main( string[] args ) {
            var vk = new VKApi();
            var str = VKToken.GetOAuthURL( 3174839,VKPermission.Everything^(VKPermission.Notify|VKPermission.Nohttps) );
            str.Dump();
            var redirecturl = ConTools.ReadLine( "Enter redirect url or Ctrl-C" );
            try {
                vk.AddToken(VKToken.FromRedirectUrl(redirecturl));
            }
            catch ( FormatException ex ) {
                ConTools.WriteError( ex.Message );
            }
            var userQuery = vk.UsersGet( new[] { 1U }, UserFields.Everything );
            userQuery.Dump();
            var subsQuery = vk.UsersGetFollowers(1u);
            subsQuery.Dump();
            Console.ReadLine();
        }
    }
}
