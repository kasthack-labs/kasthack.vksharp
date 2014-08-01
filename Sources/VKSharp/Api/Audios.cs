using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Data.Parameters;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<StructEntity<int>> AudiosAddAlbumAsync( string title, uint? groupId = null ) {
            var req = new VKRequest<StructEntity<int>> {
                MethodName = "audio.addAlbum",
                Parameters = new Dictionary<string, string> {
                    { "group_id", MiscTools.NullableString( groupId ) },
                    { "title", title }
                }
            };
            req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
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
            req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task AudiosDeleteAlbumAsync(uint albumId, uint? groupId = null) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "audio.deleteAlbum",
                Parameters =
                    new Dictionary<string, string> {
                        { "album_id", albumId.ToNCString() },
                        { "group_id", MiscTools.NullableString( groupId ) }
                    }
            };
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task AudiosDeleteAsync( uint audioId, int ownerId ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "audio.delete",
                Parameters = new Dictionary<string, string> { { "audio_id", audioId.ToNCString() }, { "owner_id", ownerId.ToNCString() } }
            };
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task<EntityList<Audio>> AudiosGetAsync( int? ownerId = null, int? albumId = null,
            IEnumerable<ulong> audioIds = null, bool needUser = false, int offset = 0, int? count = null ) {
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
            if ( !IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<Audio[]> AudiosGetByIdAsync( IEnumerable<Tuple<int, int>> audios, bool itunes = false ) {
            return await AudiosGetByIdAsync( audios.Select( a => a.Item1 + "_" + a.Item2 ), itunes );
        }
        public async Task<Audio[]> AudiosGetByIdAsync(IEnumerable<string> audios, bool itunes = false) {
            var req = new VKRequest<Audio>
            {
                MethodName = "audio.getById",
                Parameters = new Dictionary<string, string> {
                        { "audios", String.Join( ",", audios ) },
                        { "itunes", (itunes?1:0).ToNCString() }
                    }
            };
            if (IsLogged)
                req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data;
        }
        public async Task<StructEntity<int>> AudiosGetCountAsync(int? ownerId) {
            var req = new VKRequest<StructEntity<int>> {
                MethodName = "audio.getCount",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                    }
            };
            if (IsLogged)
                req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<Lyrics> AudiosGetLyricsAsync( int lyricsId ) {
            var req = new VKRequest<Lyrics> {
                MethodName = "audio.getLyrics",
                Parameters = new Dictionary<string, string> { { "lyrics_id", lyricsId.ToNCString() } }
            };
            req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<SimpleEntity<string>> AudiosGetUploadServerAsync( int albumId, uint? groupId ) {
            var req = new VKRequest<SimpleEntity<string>> {
                MethodName = "audio.getUploadServer",
                Parameters = new Dictionary<string, string>() {
                    {"album_id", albumId.ToNCString()},
                    {"group_id", MiscTools.NullableString( groupId )}
                }
            };
            req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task AudiosReorderAsync( long audioId, int? ownerId = null, long? after = null, long? before = null ) {
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
            if ( !IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task<Audio> AudiosRestoreAsync( long audioId, int? ownerId = null ) {
            var req = new VKRequest<Audio>
            {
                MethodName = "audio.restore",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                        { "audio_id", audioId.ToNCString() }
                    }
            };
            if (IsLogged)
                req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<Audio[]> AudiosSaveAsync(string server, string audio,
                                                   string hash, string artist="", string title="")
        {
            var req = new VKRequest<Audio> {
                MethodName = "audio.save",
                Parameters = new Dictionary<string, string> {
                    { "server", server },
                    { "audio", audio },
                    { "hash", hash },
                    { "artist", artist },
                    { "title", title },
                }
            };
            if (IsLogged)
                req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data;
        }
        public async Task<EntityList<Audio>> AudiosSearchAsync( string q, bool autoComplete=true, bool lyrics=false,
            bool performerOnly=false, AudioSortOrder sort = AudioSortOrder.ByRating, bool searchOwn = false,
            int offset=0, int? count = null) {
            var req = new VKRequest<EntityList<Audio>> {
                MethodName = "audio.search",
                Parameters = new Dictionary<string, string> {
                    { "q",q},
                    { "auto_complete",(autoComplete?1:0).ToNCString()},
                    { "lyrics",(lyrics?1:0).ToNCString()},
                    { "performer_only",(searchOwn?1:0).ToNCString()},
                    { "search_own",(performerOnly?1:0).ToNCString()},
                    { "offset", offset.ToNCString() },
                    { "count", MiscTools.NullableString( count ) },
                    { "sort",((int)sort).ToNCString()}
                }
            };
            if (IsLogged)
                req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
    }
}