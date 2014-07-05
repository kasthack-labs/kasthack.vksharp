using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using kasthack.Tools;
using VKSharp;
using VKSharp.Data.Api;
using VKSharp.Data.Parameters;

namespace TestApp {
    class Program {
        private static void Main() {
            try{
                Console.WriteLine("Starting..");
                var t = Main2();
                t.Wait();
            }finally{
                Console.WriteLine( "Complete" );
                Console.ReadLine();
            }
        }

        static async Task Main2() {
            var vk = new VKApi();
#if !DEBUG
            var str = VKToken.GetOAuthURL( 3174839,VKPermission.Everything^(VKPermission.Notify|VKPermission.Nohttps) );
            str.Dump();
            var redirecturl = ConTools.ReadLine( "Enter redirect url or Ctrl-C" );
#else
            string redirecturl=null;
            try{
                redirecturl = File.ReadAllText( "debug.token" );
            }
            catch(Exception ex){
                ex.Message.Dump();
            }
#endif
            //WebRequest.DefaultWebProxy = WebRequest.GetSystemWebProxy();
            vk.AddToken( VKToken.FromRedirectUrl( redirecturl ) );

            await ByIdTest( vk );
            //await GetPostsTest( vk );
            //GetImplementedMethods();
            //await vk.unr
            //await Reorder( vk );
            //await GetArtistsStats(vk);
            //await GetArtistsStats(vk);
            //await GetUsersTest(vk);
            //await CheckLyrics(vk);
            //await CheckMutual( vk );
            //await GetSubscriptions( vk );

        }

        private static async Task ByIdTest( VKApi vk ) {
            var post = await vk.WallGetByIdAsync( 50, "-50664244_1067" );
            post.Dump();
        }

        private static async Task GetPostsTest (VKApi vk) {
            var posts = await vk.WallGetAsync(8878040);
            posts.Items.Dump();
        }

        private static async Task GetSubscriptions( VKApi vk ) {
            var s = await vk.UserGetSubscriptionsAsync(1);
        }

        private static void GetImplementedMethods() {
            var s = string.Join(
                "\r\n",
                typeof( VKApi ).GetMethods( BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod )
                               .Select( a => a.Name ) );
            Console.ReadLine();
        }

        private static async Task CheckMutual(VKApi vk) {
            var v = await vk.FriendsGetMutualAsync(1704311);
        }

        private static async Task GetUsersTest(VKApi vk) {
            var users = await vk.UsersGetAsync(fields: UserFields.Everything, ids: new uint[]{8878040});
            users.Dump();
        }

        private static async Task CheckLyrics(VKApi vk) {
            var v = await vk.AudiosGetLyricsAsync(1);
            v.Text.Dump();
            Console.ReadLine();
        }

        private static async Task GetArtistsStats(VKApi vk) {
            var audios = await vk.AudiosGetAsync();
            var arr = audios.GroupBy(a => a.Artist)
                  .Select(a => new { Artist = a.Key, Count = a.ToArray().Count() })
                  .Where(a => a.Count > 1)
                  .OrderByDescending(a => a.Count)
                  .ToArray();
            foreach (var au in arr) {
                Console.WriteLine("{0} records by {1}", au.Count, au.Artist);
            }
            Console.ReadLine();
        }

        private static async Task GetBadAudios(VKApi vk) {
            var audios = await vk.AudiosGetAsync();
            foreach (var audio in audios.Where(a => a.Artist.Trim() != a.Artist || a.Title.Trim() != a.Title)) {
                Console.WriteLine(audio);
            }
            "Press enter to exit".Dump();
            Console.ReadLine();
        }

        private static async Task Reorder(VKApi api) {
            var audios = await api.AudiosGetAsync();
            var firstid = audios.First().Id;
            var sorted = audios.Items
                .OrderBy(
                a => {
                    var artist = a.Artist.Trim().ToLower();
                    if (artist.StartsWith("the "))
                        artist = a.Artist.Substring(4);
                    return artist + a.Title;
                }).ToArray();
            await api.AudiosReorderAsync(audioId: sorted.First().Id, before: firstid);
            var map = audios.Select((audio, index) => new { audio.Id, index }).ToDictionary(a => a.Id, a => a.index);
            for (var i = 1; i < sorted.Length; i++) {
                var cur = sorted[i];
                var prev = sorted[i - 1];
                var previ = map[cur.Id];
                if (previ == 0 || audios[previ - 1].Id != prev.Id) {
                    await api.AudiosReorderAsync(cur.Id, after: prev.Id);
                    Thread.Sleep(300);
                }
                Console.WriteLine("Moved {0}, {1} of {2} complete", cur, i, audios.Items.Length);
            }
        }
    }
}
