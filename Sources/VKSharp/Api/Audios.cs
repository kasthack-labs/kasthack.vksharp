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
        public async Task<EntityList<Audio>> AudiosGetAsync(
            int? ownerId = null,
            int? albumId = null,
            IEnumerable<ulong> audioIds = null,
            bool needUser = false,
            int offset = 0,
            int? count = null ) {
            var req = new VKRequest<EntityList<Audio>> {
                MethodName = "audio.get",
                Parameters =
                    new Dictionary<string, string> {
                        { "offset", offset.ToNCString() },
                        { "count", MiscTools.NullableString( count ) },
                        { "need_user", ( needUser ? 1 : 0 ).ToNCString() },
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                        { "album_id", MiscTools.NullableString( albumId ) },
                        { "audio_ids", (audioIds ?? new ulong[] { } ).ToNCStringA() }
                    }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<Lyrics> AudiosGetLyricsAsync( int lyricsId ) {
            var req = new VKRequest<Lyrics> {
                MethodName = "audio.getLyrics",
                Parameters = new Dictionary<string, string> { { "lyrics_id", lyricsId.ToNCString() } }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> AudiosReorderAsync(
            ulong audioId,
            int? ownerId = null,
            ulong? after = null,
            ulong? before = null ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "audio.reorder",
                Parameters =
                    new Dictionary<string, string> {
                        { "audio_id", audioId.ToNCString() },
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                        { "after", MiscTools.NullableString( after ) },
                        { "before", MiscTools.NullableString( before ) },
                    }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<SimpleEntity<string>> AudiosGetUploadServerAsync( int albumId, uint? groupId ) {
            var req = new VKRequest<SimpleEntity<string>> {
                MethodName = "audio.getUploadServer",
                Parameters = new Dictionary<string, string>()
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<StructEntity<int>> AudiosAddAsync( int ownerId, uint audioId, uint? groupId = null ) {
            var req = new VKRequest<StructEntity<int>> {
                MethodName = "audio.add",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", ownerId.ToNCString() },
                        { "audio_id", audioId.ToNCString() },
                        { "group_id", MiscTools.NullableString( groupId ) }
                    }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> AudiosDeleteAsync( uint audioId, int ownerId ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "audio.delete",
                Parameters = new Dictionary<string, string> { { "audio_id", audioId.ToNCString() }, { "owner_id", ownerId.ToNCString() } }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<StructEntity<int>> AudiosAddAlbumAsync( string title, uint? groupId = null ) {
            var req = new VKRequest<StructEntity<int>> {
                MethodName = "audio.addAlbum",
                Parameters = new Dictionary<string, string> {
                    { "group_id", MiscTools.NullableString( groupId ) },
                    { "title", title }
                }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> AudiosDeleteAlbumAsync(uint albumId, uint? groupId = null) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "audio.deleteAlbum",
                Parameters =
                    new Dictionary<string, string> {
                        { "album_id", albumId.ToNCString() },
                        { "group_id", MiscTools.NullableString( groupId ) }
                    }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<StructEntity<int>> AudiosGetCountAsync(int? ownerId) {
            var req = new VKRequest<StructEntity<int>> {
                MethodName = "audio.getCount",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                    }
            };
            if (this.IsLogged)
                req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        
    }
}