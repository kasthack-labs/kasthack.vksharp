using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Data.Parameters;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task PhotosConfirmTagAsync(ulong photoId, uint tagId, int? ownerId = null) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.confirmTag",
                Parameters =
                    new Dictionary<string, string> {
                        { "photo_id", photoId.ToNCString() },
                        { "tag_id", tagId.ToNCString() },
                        { "owner_id", MiscTools.NullableString( ownerId ) }
                    }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task PhotosCopyAsync( int ownerId, ulong photoId, string accessKey = "" ) {
            var req = new VKRequest<StructEntity<int>> {
                MethodName = "photos.copy",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", ownerId.ToNCString() },
                        { "photo_id", photoId.ToNCString() },
                        { "access_key", accessKey }
                    }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task<PhotoAlbum> PhotosCreateAlbumAsync(string title, string description = "", int? groupId = null,
            PrivacyType? privacy=null, PrivacyType? commentPrivacy = null) {
                var req = new VKRequest<PhotoAlbum> {
                    MethodName = "photos.createAlbum",
                    Parameters = new Dictionary<string, string> {
                        { "title", title },
                        { "description", description },
                        { "group_id", MiscTools.NullableString( groupId ) },
                        { "privacy", MiscTools.NullableString( (byte?)privacy ) },
                        { "comment_privacy", MiscTools.NullableString( (byte?) commentPrivacy )}
                    }
                };
                if (!IsLogged)
                    throw new InvalidOperationException("This method requires auth!");
                req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task PhotosDeleteAlbumAsync(ulong albumId,  uint? groupId=null) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.deleteAlbum",
                Parameters =
                    new Dictionary<string, string> {
                        { "album_id", albumId.ToNCString() },
                        { "group_id", MiscTools.NullableString( groupId ) }
                    }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task PhotosDeleteAsync(ulong photoId, int? ownerId = null) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.delete",
                Parameters =
                    new Dictionary<string, string> {
                        { "photo_id", photoId.ToNCString() },
                        { "owner_id", MiscTools.NullableString( ownerId ) }
                    }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
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
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task PhotosEditAlbumAsync( ulong albumId, string title = "", string description = "",
            int? ownerId = null, PrivacyType? privacy = null, PrivacyType? commentPrivacy = null ) {
                var req = new VKRequest<StructEntity<int>> {
                    MethodName = "photos.editAlbum",
                    Parameters = new Dictionary<string, string> {
                        { "album_id", albumId.ToNCString() },
                        { "title", title },
                        { "description", description },
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                        { "privacy", MiscTools.NullableString( (byte?)privacy ) },
                        { "comment_privacy", MiscTools.NullableString( (byte?) commentPrivacy )}
                    }
                };
                if (!IsLogged)
                    throw new InvalidOperationException("This method requires auth!");
                req.Token = CurrenToken;
                await _executor.ExecAsync(req);
        }
        public async Task PhotosEditAsync( int ownerId, ulong photoId, string caption = "" ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.edit",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", ownerId.ToNCString() },
                        { "photo_id", photoId.ToNCString() },
                        { "access_key", caption }
                    }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task<StructEntity<int>> PhotosGetAlbumsCountAsync( uint? userId, uint? groupId ) {
            var req = new VKRequest<StructEntity<int>> {
                MethodName = "photos.getAlbumsCount",
                Parameters = new Dictionary<string, string> {
                        { "user_id", MiscTools.NullableString( userId ) },
                        { "group_id", MiscTools.NullableString( groupId ) }
                    }
            };
            if ( IsLogged )
                req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<EntityList<PhotoAlbum>> PhotosGetAlbumsAsync( int? ownerId=null, int offset = 0,
            int? count = null, bool needSystem = true, bool needCovers = false, params long[] albumIds ) {
                var req = new VKRequest<EntityList<PhotoAlbum>> {
                    MethodName = "photos.getAlbums",
                    Parameters = new Dictionary<string, string> {
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                        { "offset", offset.ToNCString() },
                        { "count", MiscTools.NullableString( count ) },
                        { "need_system", needSystem?"1":"0" },
                        { "need_covers", needCovers?"1":"0" },
                        { "album_ids", String.Join( ",", albumIds ) }
                    }
                };
                if (IsLogged) req.Token = CurrenToken;
                return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<EntityList<Photo>> PhotosGetAllAsync( int? ownerId = null, bool extended = false,
            uint offset = 0, int count = 20, bool noServiceAlbums = false) {
                var req = new VKRequest<EntityList<Photo>> {
                    MethodName = "photos.getAll",
                    Parameters = new Dictionary<string, string> {
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },
                        { "extended", extended?"1":"0" },
                        { "no_service_albums", noServiceAlbums?"1":"0" }
                    }
                };
                if (IsLogged) req.Token = CurrenToken;
                return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<EntityList<Photo>> PhotosGetAsync(int? ownerId = null, int? albumId = null,
            ulong[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null,
            uint? feed = null, uint offset = 0, uint? count = null) {
                var req = new VKRequest<EntityList<Photo>> {
                    MethodName = "photos.get",
                    Parameters = new Dictionary<string, string> {
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                        { "album_id", MiscTools.NullableString( albumId ) },
                        { "photo_ids", String.Join( ",", (photoIds??new ulong[]{}).Select( a=>a.ToNCString() ) ) },
                        { "rev", rev?"1":"0" },
                        { "extended", extended?"1":"0" },
                        { "feed_type", MiscTools.NullableString( feedType ) },
                        { "feed", MiscTools.NullableString( feed ) },
                        { "offset", offset.ToNCString() },
                        { "count", MiscTools.NullableString( count )}
                    }
                };
                if (IsLogged)
                    req.Token = CurrenToken;
                return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<EntityList<Photo>> PhotosGetAsync(SpecialAlbum albumId, int? ownerId = null,
            ulong[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null,
            uint? feed = null, uint offset = 0, uint? count = null) {
            var req = new VKRequest<EntityList<Photo>> {
                MethodName = "photos.get",
                Parameters = new Dictionary<string, string> {
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                        { "albumId", albumId.ToNClString() },
                        { "photo_ids", String.Join( ",", (photoIds??new ulong[]{}).Select( a=>a.ToNCString() ) ) },
                        { "rev", rev?"1":"0" },
                        { "extended", extended?"1":"0" },
                        { "feed_type", MiscTools.NullableString( feedType ) },
                        { "feed", MiscTools.NullableString( feed ) },
                        { "offset", offset.ToNCString() },
                        { "count", MiscTools.NullableString( count )}
                    }
            };
            if (IsLogged)
                req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task PhotosOwnerPhotoUploadServerAsync() {
            var req = new VKRequest<SimpleEntity<string>> {
                MethodName = "photos.getOwnerPhotoUploadServer",
                Parameters = new Dictionary<string, string>()
            };
            if ( !IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task<SimpleEntity<string>> PhotosGetUploadServerAsync( int albumId, uint? groupId ) {
            var req = new VKRequest<SimpleEntity<string>> {
                MethodName = "photos.getUploadServer",
                Parameters =
                    new Dictionary<string, string> {
                        { "album_id", albumId.ToNCString() },
                        { "group_id", MiscTools.NullableString( groupId ) }
                    }
            };
            if ( !IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task PhotosMakeCoverAsync( ulong photoId, int albumId, int? ownerId = null ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.makeCover",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                        { "photo_id", photoId.ToNCString() },
                        { "album_id", albumId.ToNCString() }
                    }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task PhotosMoveAsync( ulong photoId, int targetAlbumId, int? ownerId = null ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.move",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                        { "photo_id", photoId.ToNCString() },
                        { "target_album_id", targetAlbumId.ToNCString() }
                    }
            };

            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task PhotosRemoveTagAsync(ulong photoId, uint tagId, int? ownerId = null) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.removeTag",
                Parameters =
                    new Dictionary<string, string> {
                        { "photo_id", photoId.ToNCString() },
                        { "tag_id", tagId.ToNCString() },
                        { "owner_id", MiscTools.NullableString( ownerId ) }
                    }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
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
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task PhotosReorderPhotosAsync( ulong photoId, int before, int after, int? ownerId = null ) {
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
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync( req );
        }
        public async Task PhotosReportAsync( int ownerId, ulong photoId, ReportReason? reason = null ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.report",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", ownerId.ToNCString() },
                        { "photo_id", photoId.ToNCString() },
                        { "reason", reason == null ? "" : ( (int) reason ).ToNCString() }
                    }
            };
            if ( IsLogged )
                req.Token = CurrenToken;
            await _executor.ExecAsync(req);
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
            if ( IsLogged )
                req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task PhotosRestoreCommentAsync(int ownerId, uint commentId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "photos.restoreComment",
                Parameters = new Dictionary<string, string> {
                    { "owner_id", ownerId.ToNCString() },
                    { "comment_id", commentId.ToNCString() },
                }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task<EntityList<Photo>> PhotosSaveAsync(int albumId, string server, string hash,
            uint? groupId = null, string photosList = "",  double? latitude = null, double? longitude = null,
            string caption = "", string description = "") {
            var req = new VKRequest<EntityList<Photo>> {
                MethodName = "photos.save",
                Parameters = new Dictionary<string, string> {
                    {"album_id", albumId.ToNCString()},
                    {"server",server},
                    {"hash",hash},
                    {"group_id", MiscTools.NullableString( groupId )},
                    {"photos_list", photosList },
                    {"latitude", MiscTools.NullableString( latitude )},
                    {"longitude", MiscTools.NullableString( longitude )},
                    {"caption",caption},
                    {"description",description}
                }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
    }
}