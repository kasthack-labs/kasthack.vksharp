using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task PhotosConfirmTagAsync(uint photoId, uint tagId, int? ownerId = null) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.confirmTag",
                Parameters =
                    new Dictionary<string, string> {
                        { "photo_id", photoId.ToNCString() },
                        { "tag_id", tagId.ToNCString() },
                        { "owner_id", MiscTools.NullableString( ownerId ) }
                    }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            await this._executor.ExecAsync(req);
        }
        public async Task PhotosCopyAsync( int ownerId, uint photoId, string accessKey = "" ) {
            var req = new VKRequest<StructEntity<int>> {
                MethodName = "photos.copy",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", ownerId.ToNCString() },
                        { "photo_id", photoId.ToNCString() },
                        { "access_key", accessKey }
                    }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            await this._executor.ExecAsync(req);
        }
        //public async Task<PhotoAlbum>
        public async Task PhotosDeleteAlbumAsync(uint albumId,  uint? groupId=null) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.deleteAlbum",
                Parameters =
                    new Dictionary<string, string> {
                        { "album_id", albumId.ToNCString() },
                        { "group_id", MiscTools.NullableString( groupId ) }
                    }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            await this._executor.ExecAsync(req);
        }
        public async Task PhotosDeleteAsync(uint photoId, int? ownerId = null) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.delete",
                Parameters =
                    new Dictionary<string, string> {
                        { "photo_id", photoId.ToNCString() },
                        { "owner_id", MiscTools.NullableString( ownerId ) }
                    }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            await this._executor.ExecAsync(req);
        }
        public async Task PhotosDeleteCommentAsync(int ownerId, uint commentId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.deleteComment",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", ownerId.ToNCString() },
                        { "comment_id", commentId.ToNCString() },
                    }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            await this._executor.ExecAsync(req);
        }
        public async Task PhotosEditAsync( int ownerId, uint photoId, string caption = "" ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.edit",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", ownerId.ToNCString() },
                        { "photo_id", photoId.ToNCString() },
                        { "access_key", caption }
                    }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            await this._executor.ExecAsync(req);
        }
        public async Task PhotosGetAlbumCountAsync( uint? userId, uint? groupId ) {
            var req = new VKRequest<StructEntity<int>> {
                MethodName = "photos.getAlbumsCount",
                Parameters =
                    new Dictionary<string, string> {
                        { "user_id", MiscTools.NullableString( userId ) },
                        { "group_id", MiscTools.NullableString( groupId ) }
                    }
            };
            if ( this.IsLogged )
                req.Token = this.CurrenToken;
            await this._executor.ExecAsync(req);
        }

        public async Task<EntityList<PhotoAlbum>> PhotosGetAlbumsAsync( int? ownerId=null, int offset = 0,
            int? count = null, bool needSystem = true, bool needCovers = false, params long[] albumIds ) {
                var req = new VKRequest<EntityList<PhotoAlbum>>
                {
                    MethodName = "photos.getAlbums",
                    Parameters = new Dictionary<string, string> {
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                        {"offset", offset.ToNCString()},
                        {"count", MiscTools.NullableString( count )},
                        {"need_system", needSystem?"1":"0"},
                        {"need_covers", needCovers?"1":"0"},
                        {"album_ids", String.Join( ",", albumIds )}
                    }
                };
                if (this.IsLogged) req.Token = this.CurrenToken;
                return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }

        public async Task PhotosGetProfileUploadServerAsync() {
            var req = new VKRequest<SimpleEntity<string>> {
                MethodName = "photos.getProfileUploadServer",
                Parameters = new Dictionary<string, string>()
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            await this._executor.ExecAsync(req);
        }
        public async Task PhotosGetUploadServerAsync( int albumId, uint? groupId ) {
            var req = new VKRequest<SimpleEntity<string>> {
                MethodName = "photos.getUploadServer",
                Parameters =
                    new Dictionary<string, string> {
                        { "album_id", albumId.ToNCString() },
                        { "group_id", MiscTools.NullableString( groupId ) }
                    }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            await this._executor.ExecAsync(req);
        }
        public async Task PhotosMakeCoverAsync( uint photoId, int albumId, int? ownerId = null ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.makeCover",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                        { "photo_id", photoId.ToNCString() },
                        { "album_id", albumId.ToNCString() }
                    }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            await this._executor.ExecAsync(req);
        }
        public async Task PhotosMoveAsync( uint photoId, int targetAlbumId, int? ownerId = null ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.move",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                        { "photo_id", photoId.ToNCString() },
                        { "target_album_id", targetAlbumId.ToNCString() }
                    }
            };

            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            await this._executor.ExecAsync(req);
        }
        public async Task PhotosRemoveTagAsync(uint photoId, uint tagId, int? ownerId = null) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.removeTag",
                Parameters =
                    new Dictionary<string, string> {
                        { "photo_id", photoId.ToNCString() },
                        { "tag_id", tagId.ToNCString() },
                        { "owner_id", MiscTools.NullableString( ownerId ) }
                    }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            await this._executor.ExecAsync(req);
        }
        public async Task PhotosReorderAlbumsAsync( int albumId, int before, int after, int? ownerId = null ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.reorderAlbums",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                        { "album_id", albumId.ToNCString() },
                        { "before", before.ToNCString() },
                        { "after", after.ToNCString() },
                    }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            await this._executor.ExecAsync(req);
        }
        public async Task PhotosReorderPhotosAsync( int photoId, int before, int after, int? ownerId = null ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.reorderPhotos",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                        { "photo_id", photoId.ToNCString() },
                        { "before", before.ToNCString() },
                        { "after", after.ToNCString() },
                    }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            await this._executor.ExecAsync( req );
        }
        public async Task PhotosReportAsync( int ownerId, uint photoId, ReportReason? reason = null ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.report",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", ownerId.ToNCString() },
                        { "photo_id", photoId.ToNCString() },
                        { "reason", reason == null ? "" : ( (int) reason ).ToNCString() }
                    }
            };
            if ( this.IsLogged )
                req.Token = this.CurrenToken;
            await this._executor.ExecAsync(req);
        }
        public async Task PhotosReportCommentAsync( int ownerId, uint commentId, ReportReason? reason = null ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.reportComment",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", ownerId.ToNCString() },
                        { "comment_id", commentId.ToNCString() },
                        { "reason", reason == null ? "" : ( (int) reason ).ToNCString() }
                    }
            };
            if ( this.IsLogged )
                req.Token = this.CurrenToken;
            await this._executor.ExecAsync(req);
        }
        public async Task PhotosRestoreCommentAsync(int ownerId, uint commentId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.restoreComment",
                Parameters = new Dictionary<string, string> {
                    { "owner_id", ownerId.ToNCString() },
                    { "comment_id", commentId.ToNCString() },
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            await this._executor.ExecAsync(req);
        }
        
    }
}