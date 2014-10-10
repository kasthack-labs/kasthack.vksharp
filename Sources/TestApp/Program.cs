using System;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using kasthack.Tools;
using VKSharp;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Api;
using VKSharp.Data.Executors;
using VKSharp.Data.Parameters;
using VKSharp.Data.Request;

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
            var str = VKToken.GetOAuthURL( 3174839,VKPermission.Offline|VKPermission.Photos );
            str.Dump();
            var redirecturl = ConTools.ReadLine( "Enter redirect url or Ctrl-C" );
            vk.AddToken( VKToken.FromRedirectUrl( redirecturl ) );
#else
            try{
                foreach (var v in File.ReadAllLines("debug.token"))
                    vk.AddToken(VKToken.FromRedirectUrl(v));
            }
            catch(Exception ex){
                ex.Message.Dump();
            }
#endif
            //CheckVkParser(@"C:\Temp\217053001_217054001.xml", vk.Executor);
            //await PrivatePics( vk );
            await GroupsTest( vk );
        }

        private static async Task DelAuds() {
            
        }

        static async Task GroupsTest( VKApi api ) {
            var groups = await api.GroupsGetMembersAsync( "web_digger", fields: UserFields.Everything );
            groups.Dump();
        }
        static async Task PrivateVids( VKApi api ) {
            //var vids = await api.Vide
        }
        static async Task PrivatePics(VKApi api) {
            var album = await api.PhotosCreateAlbumAsync( "WALL_PUB_30.09.2014" );
            var pics = await api.PhotosGetAsync( SpecialAlbum.Preview, count:200 );
            Console.WriteLine("Moving {0} pics", pics.TotalCount);
            var cnt = 0;
            foreach (var pic in pics) { 
                await api.PhotosMoveAsync( album.Id, pic.Id );
                await Task.Delay( 300 );
                Console.WriteLine(++cnt);
            }
            Console.WriteLine("Winrar");
        }
        private static void CheckVkParser( string cTempXml, IExecutor executor ) {
            try {
                var a = LoadFromFile<User>( cTempXml, executor, false );
                a.Dump();
            }
            catch ( Exception ex ) {
                Console.WriteLine( ex.Message );
            }
        }
        public static VKResponse<T> LoadFromFile<T>(string path, IExecutor exec, bool gz = true) where T : IVKEntity<T>
        {
            using (var f = File.OpenRead(path))
            using (var s = gz ? new GZipStream(f, CompressionMode.Decompress) as Stream : f)
            using (var r = new StreamReader(s))
                return exec.Parse<T>(r.ReadToEnd());
        }
    }
}
