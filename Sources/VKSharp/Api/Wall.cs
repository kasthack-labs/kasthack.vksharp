using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Enums;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<StructEntity<bool>> WallDeleteAsync( int ownerId, uint postId ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "wall.delete",
                Parameters = new Dictionary<string, string> { { "owner_id", ownerId.ToNCString() }, { "post_id", postId.ToNCString() }, }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }

        public async Task<StructEntity<bool>> WallRestoreAsync( int ownerId, uint postId ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "wall.restore",
                Parameters = new Dictionary<string, string> { { "owner_id", ownerId.ToNCString() }, { "post_id", postId.ToNCString() }, }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }

        public async Task<StructEntity<bool>> WallDeleteCommentAsync( int ownerId, uint commentId ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "wall.deleteComment",
                Parameters =
                    new Dictionary<string, string> { { "owner_id", ownerId.ToNCString() }, { "comment_id", commentId.ToNCString() }, }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }

        public async Task<StructEntity<bool>> WallRestoreCommentAsync( int ownerId, uint commentId ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "wall.restoreComment",
                Parameters =
                    new Dictionary<string, string> { { "owner_id", ownerId.ToNCString() }, { "comment_id", commentId.ToNCString() }, }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }

        public async Task<StructEntity<bool>> WallReportPostAsync( int ownerId, uint postId, ReportReason? reason = null ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "wall.reportPost",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", ownerId.ToNCString() },
                        { "post_id", postId.ToNCString() },
                        { "reason", reason == null ? "" : ( (int) reason ).ToNCString() }
                    }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }

        public async Task<StructEntity<bool>> WallReportCommentAsync( int ownerId, uint commentId, ReportReason? reason = null ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "wall.reportPost",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", ownerId.ToNCString() },
                        { "comment_id", commentId.ToNCString() },
                        { "reason", reason == null ? "" : ( (int) reason ).ToNCString() }
                    }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
    }
}