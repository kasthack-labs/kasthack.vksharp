using System;
using System.IO;
using System.Linq;
using EpicMorg.Net;
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
                Console.ReadLine();
                return;
            }

            //var userQuery = vk.UsersGet( new[] { 1U }, UserFields.Everything );
            //userQuery.Dump();
            //var followersQuery = vk.UsersGetFollowers( 1u );
            //followersQuery.Items.Dump();
            //var friendsQuery = vk.FriendsGet(8878040, UserSortOrder.ByID, null, 0, 100, UserFields.Everything);
            //friendsQuery.Dump();
            //var friendsPhone = vk.FriendsGetByPhones(new ulong[] {79312602112});
            //friendsPhone.Dump();
            //var isAppUserQuery = vk.UserIsAppUser( 8878040 );
            //isAppUserQuery.Data.Dump();

            var au = vk.AudiosGet(count:500);
            var p = @"B:\p";
            foreach (var v in au.Items) {
                var f = v.Artist + " - " + v.Title + ".mp3";
                f = Path.GetInvalidFileNameChars().Aggregate( f.Trim(),
                    ( current, variable ) => current.Replace( variable,
                        '-' ) ).Replace( "!","" );
                if ( !File.Exists( Path.Combine( @"D:\files\Общие\Музыка\kasthack.Audios", f ) ) && !File.Exists( Path.Combine( p, f ) ) )
                    AWC.DownloadFile(
                        v.Url,
                        Path.Combine( p, f)
                    );
            }
            Console.ReadLine();
        }
    }
}
