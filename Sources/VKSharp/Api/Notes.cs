using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<StructEntity<bool>> NotesDeleteAsync(uint noteId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "notes.delete",
                Parameters = new Dictionary<string, string> { { "note_id", noteId.ToNCString() }}
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> NotesDeleteCommentAsync(uint ownerId, uint commentId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "notes.deleteComment",
                Parameters = new Dictionary<string, string> {
                    { "owner_id", ownerId.ToNCString() },
                    { "comment_id", commentId.ToNCString() },
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> NotesRestoreCommentAsync(uint ownerId, uint commentId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "notes.restoreComment",
                Parameters = new Dictionary<string, string> {
                    { "owner_id", ownerId.ToNCString() },
                    { "comment_id", commentId.ToNCString() },
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }

    }
}
