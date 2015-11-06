using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kasthack.vksharp;
using kasthack.vksharp.DataTypes.Entities;
using kasthack.vksharp.DataTypes.Enums;
using kasthack.vksharp.Implementation;
using kasthack.vksharp.Internal;

namespace TestApp
{
    partial class Program {
        private static void Main() {
            try{
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Starting..");
                var t = Main2();
                t.Wait();
            }finally{
                Console.WriteLine( "Complete" );
                Console.ReadLine();
            }
        }

        private static async Task Main2() {
            var vk = new Api();
#if DEBUG
            var str = Token.GetOAuthURL( 3174839, Permission.Everything );
            str.Dump();
            var redirecturl = ConTools.ReadLine( "Enter redirect url or Ctrl-C" );
            vk.AddToken( Token.FromRedirectUrl( redirecturl ) );
#else
            try{
                
                foreach (var v in File.ReadAllLines("debug.token"))
                    vk.AddToken(Token.FromRedirectUrl(v));
            }
            catch(Exception ex){
                Console.WriteLine( ex.Message );
            }
#endif
            await Impl( vk ).ConfigureAwait(false);
        }

        private async static Task Impl(Api vk)
        {
            //await DeleteLikes(vk).ConfigureAwait(false);
            await CheckWall( vk ).ConfigureAwait( false );
        }

        private static async Task CheckWall( Api vk )
        {
            var mox = 8895502;
            var count = (await vk.Wall.Get( mox, count: 0 ).ConfigureAwait( false )).Count;
            var chunk = 100;
            List<Post> posts = new List<Post>(count);
            for ( int i = 0; i < count; i+=chunk ) {
                var t = Task.Delay( 350 ).ConfigureAwait( false );
                posts.AddRange( await vk.Wall.Get( mox, count: chunk, offset: i ).ConfigureAwait( false ) );
                await t;
            }
            Console.WriteLine( posts.Sum( a => a.Text?.Length ?? 0 ) );
            Console.WriteLine(  );
            //File.WriteAllText(@"C:\Temp\mox\posts.json", JsonConvert.SerializeObject( posts, Formatting.Indented ));

            //foreach ( var post in posts ) {
            //    Console.WriteLine( new string( '#', 79 ) );
            //    Console.WriteLine( $"post {post.Id} by {post.OwnerId} on {post.Date.LocalDateTime}" );
            //    Console.WriteLine(new string('#', 79));
            //    Console.WriteLine( post.Text );
            //    Console.WriteLine(new string('#', 79));
            //    Console.WriteLine( "Attachments:" );
            //    foreach ( var attachment in post.Attachments ?? new Attachment[] {} ) {
            //        Console.WriteLine( $"   Attached {attachment.Type}: {attachment.ToString()}" );
            //    }
            //}
        }

        private static async Task DeleteLikes( Api vk ) {
            EntityList<Post> posts = await vk.Fave.GetPosts().ConfigureAwait(false);
            foreach (var post in posts)
            {
                try
                {
                    var t = Task.Delay(350);
                    var ret = await vk.Executor.ExecRawAsync(
                        new Request<int>()
                        {
                            MethodName = "likes.delete",
                            Parameters = new Dictionary<string, string>() { { "type", "post" }, { "owner_id", post.OwnerId.ToNCString() }, { "item_id", post.Id.ToNCString() } },
                            Token = vk.CurrentToken
                        }).ConfigureAwait(false);
                    Console.WriteLine( ret );
                    await t.ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private static async Task TestFriends(Api vk) {
            var entityList = await vk.Friends.Get( 8878040, null, UserSortOrder.ById, 0, 100 ).ConfigureAwait(false);
            Console.WriteLine(entityList);
        }
    }
}
