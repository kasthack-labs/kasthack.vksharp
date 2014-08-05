using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using EpicMorg.Net;
using kasthack.Tools;
using VKSharp;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Api;
using VKSharp.Data.Executors;
using VKSharp.Data.Parameters;
using VKSharp.Data.Request;
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
            var vk = new RawApi();
#if !DEBUG
            var str = VKToken.GetOAuthURL( 3174839,VKPermission.Offline|VKPermission.Nohttps );
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
            CheckVkParser(@"C:\Temp\217053001_217054001.xml", vk.Executor);
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
