using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using EpicMorg.Net;
using kasthack.Tools;
using VKSharp;
using VKSharp.Core.Entities;
using VKSharp.Data.Api;
using VKSharp.Data.Parameters;
using VKSharp.Helpers;

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

            await UploadPhotos(vk);
            //await Backup( vk );
            //await NewAlbumTest( vk );
            //await GetPhotosTest( vk );
            //await Offliner( vk );
            //await AlbumsTest( vk );
            //await ByIdTest( vk );
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

        private static async Task UploadPhotos( VKApi vk ) {
            const string sourcepath = @"C:\Temp\na";
            var v = new UploadHelper( vk );
            var album = await vk.PhotosCreateAlbumAsync( "Test upload album" );
            await v.UploadPhotos( album.Id, null, Directory.GetFiles( sourcepath ) );
        }

        private static async Task Backup( VKApi vk ) {
            var outpath = @"F:\backup\kasthack\vk";
            var albums = await vk.PhotosGetAlbumsAsync();
            Console.WriteLine( "Found {0} albums", albums.Items.Length );
            foreach ( var photoAlbum in albums ) {
                Console.WriteLine("Downloading album {0}/{1}", photoAlbum.Title, albums.Items.Length);

                var name = MakeValidFileName( photoAlbum.Title.Trim() );
                name = String.IsNullOrEmpty( name ) ? photoAlbum.Id.ToNCString() : name;
                var albumPath = Path.Combine( outpath, name );
                if ( Directory.Exists( albumPath ) ) albumPath += photoAlbum.Id;
                if (!Directory.Exists(albumPath)) Directory.CreateDirectory(albumPath);
                
                var photos = await vk.PhotosGetAsync( albumId: photoAlbum.Id, count:1000 );
                var i = 1;
                foreach ( var photo in photos ) {
                    try {
                        await AWC.DownloadFileAsync( FindMaxRes( photo ), Path.Combine( albumPath, i + ".jpg" ) );
                        Console.WriteLine( "Donwloaded {0}/{1} in album", i, photos.Items.Length );
                        i++;
                    }
                    catch {
                        
                    }
                }
                Console.WriteLine( "Complete" );
            }
        }

        private static string FindMaxRes( Photo photo ) {
            if ( photo.Photo2560 != null )
                return photo.Photo2560;
            if ( photo.Photo1280 != null )
                return photo.Photo1280;
            if ( photo.Photo807 != null )
                return photo.Photo807;
            if ( photo.Photo604 != null )
                return photo.Photo604;
            if ( photo.Photo130 != null )
                return photo.Photo130;
            return photo.Photo75;
        }

        private static readonly Regex InvalidRegStr = new Regex(
                string.Format(@"([{0}]*\.+$)|([{0}]+)", Regex.Escape(new string(Path.GetInvalidFileNameChars()))),
                RegexOptions.Compiled | RegexOptions.CultureInvariant);
        private static string MakeValidFileName(string name) {
            return InvalidRegStr.Replace(name, "_");
        }
        private static async Task NewAlbumTest( VKApi vk ) {
            var alb = await vk.PhotosCreateAlbumAsync( "TestAlbum" );
            await vk.PhotosDeleteAlbumAsync( alb.Id );
        }

        private static async Task GetPhotosTest( VKApi vk ) {
            var albums = await vk.PhotosGetAlbumsAsync();
            var photos = await vk.PhotosGetAsync( albumId: albums.FirstOrDefault().Id, count: 1000 );
        }

        private static async Task Offliner( VKApi vk ) {
            while ( true ) {
                await vk.AccountSetOfflineAsync();
                Console.WriteLine( "Offline at {0}", DateTime.Now );
                await Task.Delay( 2000 );
            }
        }

        private static async Task AlbumsTest( VKApi vk ) {
            var albums = await vk.PhotosGetAlbumsAsync(needCovers:true);
            albums.Dump();
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
            var users = await vk.UsersGetAsync(fields: UserFields.Everything, ids: new uint[]{1704311});
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
            await api.AudiosReorderAsync( sorted.First().Id, before: firstid);
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
