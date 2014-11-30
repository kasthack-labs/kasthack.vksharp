using System;
using System.IO;
using System.Threading.Tasks;
using kasthack.Tools;
using VKSharp;
using VKSharp.Data.Api;

namespace TestApp
{
    partial class Program {
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

        private static async Task Main2() {
            var vk = new VKApi();
#if !DEBUG
            var str = VKToken.GetOAuthURL( 3174839, VKPermission.Offline | VKPermission.Photos );
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
            await Impl( vk );
        }
    }
}
