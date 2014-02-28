using System;
using System.IO;
using System.Linq;
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
            var cnt = 5;
            var vs = 800;
            var vr = new VKRequest<User>() {
                Token = tk,
                MethodName = "execute.mfetch"+cnt+"a",
                Parameters =
                    Enumerable.Range( 0, cnt )
                        .ToDictionary( a => "u" + a, a => String.Join( ",", Enumerable.Range( a*vs, vs ) ) )
            };
            var fields = UserFields.Everything;
            vr.Parameters.Add( "fields", String.Join( ",", String.Join( ",", MiscTools.GetUserFields( fields ) ) ) );
            var v = Helper.SyncTask( ParserHelper.ExecRawAsync( vr, "json" ) );

            //var u = vk.UsersSearch(
            //    universityId: 1,
            //    sex: Sex.Male,
            //    sort:SearchSortOrder.ByRegistrationDate,
            //    fields: UserFields.Universities | UserFields.Last_Seen | UserFields.Bdate
            //);
            File.WriteAllText( @"B:\response-"+cnt+"-"+vs+".json", v );
        }
    }
}
