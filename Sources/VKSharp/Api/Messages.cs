using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<StructEntity<bool>> MessagesDeleteAsync( params int[] messageIds ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "messages.delete",
                Parameters = new Dictionary<string, string> {
                    {
                        "message_ids", String.Join( ",", messageIds.Select( a => a.ToNCString() ) )
                    }
                }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }

        public async Task<StructEntity<bool>> MessagesDeleteDialogAsync( string userId,
                                                                         uint offset,
                                                                         uint count ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "messages.deleteDialog",
                Parameters = new Dictionary<string, string> {
                    { "offset", offset.ToNCString() },
                    { "count", count.ToNCString() },
                    { "user_id", userId }
                }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> MessagesRestoreAsync(int messageId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "messages.restore",
                Parameters = new Dictionary<string, string> {
                    { "message_id", messageId.ToNCString() }
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
    }
}