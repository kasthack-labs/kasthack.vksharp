using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using EpicMorg.Net;
using kasthack.Tools;
using VKSharp;
using VKSharp.Core.Entities;
using VKSharp.Data.Api;
using VKSharp.Data.Parameters;
using VKSharp.Data.Request;
using VKSharp.Helpers;

namespace TestApp {
    class Program {
        static void Main() {
            var vk = new VKApi();
#if !DEBUG
            var str = VKToken.GetOAuthURL( 3174839,VKPermission.Everything^(VKPermission.Notify|VKPermission.Nohttps) );
            str.Dump();
            var redirecturl = ConTools.ReadLine( "Enter redirect url or Ctrl-C" );
#else
            var redirecturl = File.ReadAllText( "debug.token" );
#endif
            var tk = VKToken.FromRedirectUrl( redirecturl );
            try {
                vk.AddToken( tk );
            }
            catch ( FormatException ex ) {
                ConTools.WriteError( ex.Message );
                Console.ReadLine();
                return;
            }
            //Reorder( vk );
            //GetArtistsStats(vk);
            //GetArtistsStats(vk);
            //GetUsersTest(vk);
            //CheckLyrics(vk);
            //CheckMutual( vk );
        }

        private static void CheckMutual( VKApi vk ) {
            var v = vk.FriendsGetMutual( 1704311 );
        }

        private static void GetUsersTest( VKApi vk ) {
            var users = vk.UsersGet( ids: 1 );
            users.Dump();
        }

        private static void CheckLyrics( VKApi vk ) {
            var v = vk.AudiosGetLyrics( 1 );
            v.Text.Dump();
            Console.ReadLine();
        }

        private static void GetArtistsStats( VKApi vk ) {
            var audios = vk.AudiosGet();
            var arr = audios.GroupBy( a => a.Artist )
                  .Select( a => new { Artist = a.Key, Count = a.ToArray().Count() } )
                  .Where( a=>a.Count>1 )
                  .OrderByDescending( a => a.Count )
                  .ToArray();
            foreach ( var au in arr ) {
                Console.WriteLine( "{0} records by {1}", au.Count, au.Artist );
            }
            Console.ReadLine();
        }

        private static void GetBadAudios( VKApi vk ) {
            var audios = vk.AudiosGet();
            foreach ( var audio in audios.Where( a=>a.Artist.Trim()!=a.Artist||a.Title.Trim()!=a.Title ) ) {
                Console.WriteLine( audio );
            }
            "Press enter to exit".Dump();
            Console.ReadLine();
        }

        private static void Reorder( VKApi api ) {
            var audios = api.AudiosGet();
            var firstid = audios.First().Id;
            var sorted = audios.Items
                .OrderBy(
                a => {
                    var artist = a.Artist.Trim().ToLower();
                    if ( artist.StartsWith( "the " ) )
                        artist = a.Artist.Substring( 4 );
                    return artist + a.Title;
                } ).ToArray();
            api.AudiosReorder(audioId: sorted.First().Id, before: firstid);
            var map = audios.Select( ( audio, index ) => new { audio.Id, index } ).ToDictionary( a => a.Id,a => a.index );
            for (var i = 1; i < sorted.Length; i++) {
                var cur = sorted[ i ];
                var prev = sorted[ i - 1 ];
                var previ = map[ cur.Id ];
                if (previ == 0 || audios[previ - 1].Id != prev.Id) { 
                    api.AudiosReorder( cur.Id, after: prev.Id);
                    Thread.Sleep( 300 );
                }
                Console.WriteLine("Moved {0}, {1} of {2} complete", cur, i, audios.Items.Length);
            }
        }
    }
}
