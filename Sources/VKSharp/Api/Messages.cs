using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<StructEntity<bool>> MessagesAddChatUserAsync(uint userId, int? chatId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "messages.addChatUser",
                Parameters = new Dictionary<string, string> {
                    { "chat_id", MiscTools.NullableString( chatId ) },
                    { "user_id", userId.ToNCString() }
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> MessagesDeleteAsync( params int[] messageIds ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "messages.delete",
                Parameters = new Dictionary<string, string> {
                    {
                        "message_ids", messageIds.ToNCStringA()
                    }
                }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> MessagesDeleteDialogAsync(
            string userId, uint offset, uint count ) {
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
        public async Task<StructEntity<bool>> MessagesMarkAsImportantAsync(
            bool important, params int[] messageIds) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "messages.markAsImportant",
                Parameters = new Dictionary<string, string> {
                    { "message_ids", messageIds.ToNCStringA() },
                    { "important", (important?1:0).ToNCString() }
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> MessagesMarkAsReadAsync(
            int userId, uint? startMessageId = null, params int[] messageIds) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "messages.markAsRead",
                Parameters = new Dictionary<string, string> {
                    { "message_ids", messageIds.ToNCStringA() },
                    { "user_id", userId.ToNCString() },
                    { "start_message_id", MiscTools.NullableString( startMessageId ) }
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> MessagesRemoveChatUserAsync( int chatId, int userId ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "messages.removeChatUser",
                Parameters = new Dictionary<string, string> {
                    { "chat_id", chatId.ToNCString() },
                    { "user_id", userId.ToNCString() }
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