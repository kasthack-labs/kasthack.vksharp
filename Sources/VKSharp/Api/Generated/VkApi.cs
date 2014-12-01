///
using System;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Core.ResponseEntities;
using VKSharp.Data.Parameters;
using VKSharp.Helpers.PrimitiveEntities;

// ReSharper disable UnusedMember.Global

namespace VKSharp {
    public partial class VKApi {
        private void InitializeMethodGroups() {
            Account = new MethodGroupAccount( this );
            Audio = new MethodGroup_audio( this );
            Auth = new MethodGroup_auth( this );
            Board = new MethodGroup_board( this );
            Database = new MethodGroup_database( this );
            Docs = new MethodGroup_docs( this );
            Friends = new MethodGroup_friends( this );
            Groups = new MethodGroup_groups( this );
            Messages = new MethodGroup_messages( this );
            Newsfeed = new MethodGroup_newsfeed( this );
            Notes = new MethodGroup_notes( this );
            Notifications = new MethodGroup_notifications( this );
            Pages = new MethodGroup_pages( this );
            Photos = new MethodGroup_photos( this );
            Status = new MethodGroup_status( this );
            Storage = new MethodGroup_storage( this );
            Users = new MethodGroup_users( this );
            Utils = new MethodGroup_utils( this );
            Video = new MethodGroup_video( this );
            Wall = new MethodGroup_wall( this );
        }

        public MethodGroupAccount Account { get; private set; }

        public partial class MethodGroupAccount {
            private readonly VKApi _parent;
            internal MethodGroupAccount( VKApi parent ) { _parent = parent; }

            public async Task SetNameInMenuAsync( string name ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.AccountSetNameInMenu( name ) );
            }

            public async Task SetOnlineAsync( bool voip = true ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.AccountSetOnline( voip ) );
            }

            public async Task SetOfflineAsync() { await _parent.Executor.ExecAsync( _parent._reqapi.AccountSetOffline() ); }

            public async Task UnregisterDeviceAsync( string token ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.AccountUnregisterDevice( token ) );
            }

            public async Task SetSilenceModeAsync( string token, int time, uint? chatId = null, uint? userId = null, int sound = 0 ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.AccountSetSilenceMode( token, time, chatId, userId, sound ) );
            }

            public async Task<StructEntity<long>> GetAppPermissionsAsync( uint? userId = null ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.AccountGetAppPermissions( userId ) ) ).Data.FirstOrDefault();
            }

            public async Task BanUserAsync( uint userId ) { await _parent.Executor.ExecAsync( _parent._reqapi.AccountBanUser( userId ) ); }

            public async Task UnbanUserAsync( uint userId ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.AccountUnbanUser( userId ) );
            }

            public async Task<User[]> GetBannedAsync( uint offset = 0, uint count = 20 ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.AccountGetBanned( offset, count ) ) ).Data;
            }

            public async Task SetInfoAsync( uint? intro = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.AccountSetInfo( intro ) );
            }

            public async Task<User> GetProfileInfoAsync() {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.AccountGetProfileInfo() ) ).Data.FirstOrDefault();
            }
        }

        public MethodGroup_audio Audio { get; private set; }

        public partial class MethodGroup_audio {
            private readonly VKApi _parent;
            internal MethodGroup_audio( VKApi parent ) { _parent = parent; }

            public async Task<StructEntity<int>> AddAlbumAsync( string title, uint? groupId = 0 ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.AudioAddAlbum( title, groupId ) ) ).Data.FirstOrDefault();
            }

            public async Task<StructEntity<int>> AddAsync( int ownerId, long audioId, uint? groupId = null ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.AudioAdd( ownerId, audioId, groupId ) ) ).Data.FirstOrDefault();
            }

            public async Task DeleteAlbumAsync( long albumId, uint? groupId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.AudioDeleteAlbum( albumId, groupId ) );
            }

            public async Task DeleteAsync( long audioId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.AudioDelete( audioId, ownerId ) );
            }

            public async Task<StructEntity<int>> EditAsync(
                int ownerId,
                long audioId,
                string artist = "",
                string title = "",
                string text = "",
                AudioGenre? genreId = null,
                bool? noSearch = null ) {
                return
                    ( await
                      _parent.Executor.ExecAsync( _parent._reqapi.AudioEdit( ownerId, audioId, artist, title, text, genreId, noSearch ) ) )
                        .Data.FirstOrDefault();
            }

            public async Task<EntityList<Audio>> GetAsync(
                int? ownerId = null,
                long? albumId = null,
                ulong[] audioIds = null,
                bool needUser = false,
                uint offset = 0,
                uint count = 100 ) {
                return
                    ( await _parent.Executor.ExecAsync( _parent._reqapi.AudioGet( ownerId, albumId, audioIds, needUser, offset, count ) ) )
                        .Data.FirstOrDefault();
            }

            public async Task<Audio[]> GetByIdAsync( bool itunes = false, params string[] audios ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.AudioGetById( itunes, audios ) ) ).Data;
            }

            public async Task<Audio[]> GetByIdAsync( bool itunes = false, params Tuple<int, long>[] audios ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.AudioGetById( itunes, audios ) ) ).Data;
            }

            public async Task<StructEntity<int>> GetCountAsync( int? ownerId = null ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.AudioGetCount( ownerId ) ) ).Data.FirstOrDefault();
            }

            public async Task<Lyrics> GetLyricsAsync( long lyricsId ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.AudioGetLyrics( lyricsId ) ) ).Data.FirstOrDefault();
            }

            public async Task<SimpleEntity<string>> GetUploadServerAsync( long albumId, uint? groupId = null ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.AudioGetUploadServer( albumId, groupId ) ) ).Data.FirstOrDefault();
            }

            public async Task ReorderAsync( long audioId, int? ownerId = null, long? before = null, long? after = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.AudioReorder( audioId, ownerId, before, after ) );
            }

            public async Task<Audio> RestoreAsync( long audioId, int? ownerId = null ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.AudioRestore( audioId, ownerId ) ) ).Data.FirstOrDefault();
            }

            public async Task<Audio[]> SaveAsync( string server, string audio, string hash, string artist = "", string title = "" ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.AudioSave( server, audio, hash, artist, title ) ) ).Data;
            }

            public async Task<EntityList<Audio>> SearchAsync(
                string q,
                bool autoComplete = true,
                bool lyrics = false,
                bool performerOnly = false,
                AudioSortOrder sort = AudioSortOrder.ByRating,
                bool searchOwn = false,
                uint offset = 0,
                uint count = 100 ) {
                return
                    ( await
                      _parent.Executor.ExecAsync(
                          _parent._reqapi.AudioSearch( q, autoComplete, lyrics, performerOnly, sort, searchOwn, offset, count ) ) ).Data
                                                                                                                                   .FirstOrDefault
                        ();
            }
        }

        public MethodGroup_auth Auth { get; private set; }

        public partial class MethodGroup_auth {
            private readonly VKApi _parent;
            internal MethodGroup_auth( VKApi parent ) { _parent = parent; }

            public async Task<StructEntity<bool>> CheckPhoneAsync( string phone, string clientSecret, int? clientId = null ) {
                return
                    ( await _parent.Executor.ExecAsync( _parent._reqapi.AuthCheckPhone( phone, clientSecret, clientId ) ) ).Data
                                                                                                                           .FirstOrDefault();
            }

            public async Task<ConfirmResult> ConfirmAsync(
                uint clientId,
                string clientSecret,
                string phone,
                string code,
                string password = "",
                bool testMode = false,
                int? intro = null ) {
                return
                    ( await
                      _parent.Executor.ExecAsync(
                          _parent._reqapi.AuthConfirm( clientId, clientSecret, phone, code, password, testMode, intro ) ) ).Data
                                                                                                                           .FirstOrDefault();
            }

            public async Task<AuthRestore> RestoreAsync( long phone ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.AuthRestore( phone ) ) ).Data.FirstOrDefault();
            }
        }

        public MethodGroup_board Board { get; private set; }

        public partial class MethodGroup_board {
            private readonly VKApi _parent;
            internal MethodGroup_board( VKApi parent ) { _parent = parent; }

            public async Task CloseTopicAsync( uint groupId, uint topicId ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.BoardCloseTopic( groupId, topicId ) );
            }

            public async Task DeleteCommentAsync( uint groupId, uint topicId, uint commentId ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.BoardDeleteComment( groupId, topicId, commentId ) );
            }

            public async Task DeleteTopicAsync( uint groupId, uint topicId ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.BoardDeleteTopic( groupId, topicId ) );
            }

            public async Task FixTopicAsync( uint groupId, uint topicId ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.BoardFixTopic( groupId, topicId ) );
            }

            public async Task UnfixTopicAsync( uint groupId, uint topicId ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.BoardUnfixTopic( groupId, topicId ) );
            }

            public async Task RestoreCommentAsync( uint groupId, uint topicId, uint commentId ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.BoardRestoreComment( groupId, topicId, commentId ) );
            }
        }

        public MethodGroup_database Database { get; private set; }

        public partial class MethodGroup_database {
            private readonly VKApi _parent;
            internal MethodGroup_database( VKApi parent ) { _parent = parent; }

            public async Task<EntityList<DatabaseEntry>> GetCountriesAsync(
                string code = "",
                bool needAll = false,
                uint offset = 0,
                uint count = 100 ) {
                return
                    ( await _parent.Executor.ExecAsync( _parent._reqapi.DatabaseGetCountries( code, needAll, offset, count ) ) ).Data
                                                                                                                                .FirstOrDefault
                        ();
            }

            public async Task<EntityList<DatabaseEntry>> GetRegionsAsync( uint countryId, string q = "", uint offset = 0, uint count = 100 ) {
                return
                    ( await _parent.Executor.ExecAsync( _parent._reqapi.DatabaseGetRegions( countryId, q, offset, count ) ) ).Data
                                                                                                                             .FirstOrDefault
                        ();
            }

            public async Task<DatabaseEntry[]> GetStreetsByIdAsync( params uint[] streetIds ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.DatabaseGetStreetsById( streetIds ) ) ).Data;
            }

            public async Task<EntityList<DatabaseEntry>[]> GetCountriesByIdAsync( params uint[] countryIds ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.DatabaseGetCountriesById( countryIds ) ) ).Data;
            }

            public async Task<DatabaseCity[]> GetCitiesByIdAsync( params uint[] cityIds ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.DatabaseGetCitiesById( cityIds ) ) ).Data;
            }

            public async Task<DatabaseCity[]> GetCitiesAsync(
                uint countryId,
                uint? regionId = null,
                string q = "",
                bool needAll = false,
                uint offset = 0,
                uint count = 100 ) {
                return
                    ( await
                      _parent.Executor.ExecAsync( _parent._reqapi.DatabaseGetCities( countryId, regionId, q, needAll, offset, count ) ) )
                        .Data;
            }

            public async Task<DatabaseEntry[]> GetUniversitiesAsync(
                uint? countryId = null,
                uint? cityId = null,
                string q = "",
                uint offset = 0,
                uint count = 100 ) {
                return
                    ( await _parent.Executor.ExecAsync( _parent._reqapi.DatabaseGetUniversities( countryId, cityId, q, offset, count ) ) )
                        .Data;
            }

            public async Task<DatabaseEntry[]> GetSchoolsAsync( uint? cityId = null, string q = "", uint offset = 0, uint count = 100 ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.DatabaseGetSchools( cityId, q, offset, count ) ) ).Data;
            }

            public async Task<EntityList<DatabaseEntry>> GetFacultiesAsync( uint universityId, uint offset = 0, uint count = 100 ) {
                return
                    ( await _parent.Executor.ExecAsync( _parent._reqapi.DatabaseGetFaculties( universityId, offset, count ) ) ).Data
                                                                                                                               .FirstOrDefault
                        ();
            }

            public async Task<EntityList<DatabaseEntry>> GetChairsAsync( uint facultyId, uint offset = 0, uint count = 100 ) {
                return
                    ( await _parent.Executor.ExecAsync( _parent._reqapi.DatabaseGetChairs( facultyId, offset, count ) ) ).Data
                                                                                                                         .FirstOrDefault();
            }
        }

        public MethodGroup_docs Docs { get; private set; }

        public partial class MethodGroup_docs {
            private readonly VKApi _parent;
            internal MethodGroup_docs( VKApi parent ) { _parent = parent; }

            public async Task<StructEntity<int>> AddAsync( long docId, int ownerId, string accessKey = "" ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.DocsAdd( docId, ownerId, accessKey ) ) ).Data.FirstOrDefault();
            }

            public async Task DeleteAsync( long docId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.DocsDelete( docId, ownerId ) );
            }

            public async Task<SimpleEntity<string>> GetUploadServerAsync( uint? groupId = null ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.DocsGetUploadServer( groupId ) ) ).Data.FirstOrDefault();
            }

            public async Task<SimpleEntity<string>> GetWallUploadServerAsync( uint? groupId = null ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.DocsGetWallUploadServer( groupId ) ) ).Data.FirstOrDefault();
            }

            public async Task<EntityList<Document>> GetAsync( int? ownerId = null, uint offset = 0, uint count = 100 ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.DocsGet( ownerId, offset, count ) ) ).Data.FirstOrDefault();
            }

            public async Task<Document[]> GetByIdAsync( params Tuple<int, int>[] docs ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.DocsGetById( docs ) ) ).Data;
            }

            public async Task<Document[]> SaveAsync( string file, string title, params string[] tags ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.DocsSave( file, title, tags ) ) ).Data;
            }
        }

        public MethodGroup_friends Friends { get; private set; }

        public partial class MethodGroup_friends {
            private readonly VKApi _parent;
            internal MethodGroup_friends( VKApi parent ) { _parent = parent; }

            public async Task<EntityList<User>> GetAsync(
                uint? userId = null,
                uint? listId = null,
                UserFields fields = UserFields.None,
                UserSortOrder order = UserSortOrder.ById,
                NameCase nameCase = NameCase.Nom,
                uint offset = 0,
                uint count = 100 ) {
                return
                    ( await
                      _parent.Executor.ExecAsync( _parent._reqapi.FriendsGet( userId, listId, fields, order, nameCase, offset, count ) ) )
                        .Data.FirstOrDefault();
            }

            public async Task<EntityList<User>> GetSuggestionsAsync(
                FriendSuggestionFilters filters = FriendSuggestionFilters.Everything,
                UserFields fields = UserFields.None,
                NameCase nameCase = NameCase.Nom,
                uint offset = 0,
                uint count = 100 ) {
                return
                    ( await _parent.Executor.ExecAsync( _parent._reqapi.FriendsGetSuggestions( filters, fields, nameCase, offset, count ) ) )
                        .Data.FirstOrDefault();
            }

            public async Task<User[]> GetByPhonesAsync( UserFields fields = UserFields.None, ulong[] phones = null ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.FriendsGetByPhones( fields, phones ) ) ).Data;
            }

            public async Task<StructEntity<int>> AddAsync( uint userId, string text = "" ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.FriendsAdd( userId, text ) ) ).Data.FirstOrDefault();
            }

            public async Task DeleteAllRequestsAsync() { await _parent.Executor.ExecAsync( _parent._reqapi.FriendsDeleteAllRequests() ); }

            public async Task<StructEntity<int>[]> GetRecentAsync( uint count = 20 ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.FriendsGetRecent( count ) ) ).Data;
            }

            public async Task<StructEntity<int>> DeleteAsync( uint userId ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.FriendsDelete( userId ) ) ).Data.FirstOrDefault();
            }

            public async Task DeleteListAsync( uint listId ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.FriendsDeleteList( listId ) );
            }

            public async Task<StructEntity<int>[]> GetAppUsersAsync() {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.FriendsGetAppUsers() ) ).Data;
            }

            public async Task<StructEntity<int>[]> GetMutualAsync(
                uint targetUid,
                uint? sourceUid = null,
                bool order = false,
                uint offset = 0,
                uint count = 100 ) {
                return
                    ( await _parent.Executor.ExecAsync( _parent._reqapi.FriendsGetMutual( targetUid, sourceUid, order, offset, count ) ) )
                        .Data;
            }
        }

        public MethodGroup_groups Groups { get; private set; }

        public partial class MethodGroup_groups {
            private readonly VKApi _parent;
            internal MethodGroup_groups( VKApi parent ) { _parent = parent; }

            public async Task<User[]> GetBannedAsync( uint groupId, uint offset = 0, uint count = 100 ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.GroupsGetBanned( groupId, offset, count ) ) ).Data;
            }

            public async Task<Group[]> GetByIdAsync( string[] groupIds, GroupFields fields ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.GroupsGetById( groupIds, fields ) ) ).Data;
            }

            public async Task<Group[]> GetByIdAsync( uint groupId, GroupFields fields ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.GroupsGetById( groupId, fields ) ) ).Data;
            }

            public async Task<EntityList<User>> GetMembersAsync(
                uint groupId,
                UserFields fields = UserFields.Everything,
                uint offset = 0,
                uint count = 100 ) {
                return
                    ( await _parent.Executor.ExecAsync( _parent._reqapi.GroupsGetMembers( groupId, fields, offset, count ) ) ).Data
                                                                                                                              .FirstOrDefault
                        ();
            }

            public async Task<EntityList<User>> GetMembersAsync(
                string groupId,
                UserFields fields = UserFields.None,
                uint offset = 0,
                uint count = 100 ) {
                return
                    ( await _parent.Executor.ExecAsync( _parent._reqapi.GroupsGetMembers( groupId, fields, offset, count ) ) ).Data
                                                                                                                              .FirstOrDefault
                        ();
            }

            public async Task<MemberShip[]> IsMemberAsync( uint groupId, bool extended = false, params uint[] userIds ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.GroupsIsMember( groupId, extended, userIds ) ) ).Data;
            }

            public async Task JoinAsync( uint groupId, bool notSure = false ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.GroupsJoin( groupId, notSure ) );
            }

            public async Task LeaveAsync( uint groupId ) { await _parent.Executor.ExecAsync( _parent._reqapi.GroupsLeave( groupId ) ); }

            public async Task UnbanUserAsync( uint groupId, uint userId ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.GroupsUnbanUser( groupId, userId ) );
            }
        }

        public MethodGroup_messages Messages { get; private set; }

        public partial class MethodGroup_messages {
            private readonly VKApi _parent;
            internal MethodGroup_messages( VKApi parent ) { _parent = parent; }

            public async Task AddChatUserAsync( uint userId, uint? chatId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.MessagesAddChatUser( userId, chatId ) );
            }

            public async Task RemoveChatUserAsync( uint userId, uint chatId ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.MessagesRemoveChatUser( userId, chatId ) );
            }

            public async Task DeleteAsync( params int[] messageIds ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.MessagesDelete( messageIds ) );
            }

            public async Task MarkAsReadAsync( uint userId, uint? startMessageId = null, params int[] messageIds ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.MessagesMarkAsRead( userId, startMessageId, messageIds ) );
            }

            public async Task RestoreAsync( int messageId ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.MessagesRestore( messageId ) );
            }

            public async Task DeleteDialogAsync( uint userId, uint offset = 0, uint count = 100 ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.MessagesDeleteDialog( userId, offset, count ) );
            }

            public async Task MarkAsImportantAsync( bool important, params int[] messageIds ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.MessagesMarkAsImportant( important, messageIds ) );
            }
        }

        public MethodGroup_newsfeed Newsfeed { get; private set; }

        public partial class MethodGroup_newsfeed {
            private readonly VKApi _parent;
            internal MethodGroup_newsfeed( VKApi parent ) { _parent = parent; }

            public async Task AddBanAsync( uint[] userIds = null, uint[] groupIds = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.NewsfeedAddBan( userIds, groupIds ) );
            }

            public async Task DeleteBanAsync( uint[] userIds = null, uint[] groupIds = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.NewsfeedDeleteBan( userIds, groupIds ) );
            }
        }

        public MethodGroup_notes Notes { get; private set; }

        public partial class MethodGroup_notes {
            private readonly VKApi _parent;
            internal MethodGroup_notes( VKApi parent ) { _parent = parent; }
            public async Task DeleteAsync( uint noteId ) { await _parent.Executor.ExecAsync( _parent._reqapi.NotesDelete( noteId ) ); }

            public async Task DeleteCommentAsync( uint commentId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.NotesDeleteComment( commentId, ownerId ) );
            }

            public async Task RestoreCommentAsync( uint commentId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.NotesRestoreComment( commentId, ownerId ) );
            }
        }

        public MethodGroup_notifications Notifications { get; private set; }

        public partial class MethodGroup_notifications {
            private readonly VKApi _parent;
            internal MethodGroup_notifications( VKApi parent ) { _parent = parent; }
            public async Task MarkAsViewedAsync() { await _parent.Executor.ExecAsync( _parent._reqapi.NotificationsMarkAsViewed() ); }
        }

        public MethodGroup_pages Pages { get; private set; }

        public partial class MethodGroup_pages {
            private readonly VKApi _parent;
            internal MethodGroup_pages( VKApi parent ) { _parent = parent; }
            public async Task ClearCacheAsync( string url ) { await _parent.Executor.ExecAsync( _parent._reqapi.PagesClearCache( url ) ); }
        }

        public MethodGroup_photos Photos { get; private set; }

        public partial class MethodGroup_photos {
            private readonly VKApi _parent;
            internal MethodGroup_photos( VKApi parent ) { _parent = parent; }

            public async Task DeleteCommentAsync( uint commentId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.PhotosDeleteComment( commentId, ownerId ) );
            }

            public async Task RestoreCommentAsync( uint commentId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.PhotosRestoreComment( commentId, ownerId ) );
            }

            public async Task ReportCommentAsync( uint commentId, int? ownerId = null, ReportReason? reason = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.PhotosReportComment( commentId, ownerId, reason ) );
            }

            public async Task DeleteAlbumAsync( long albumId, uint? groupId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.PhotosDeleteAlbum( albumId, groupId ) );
            }

            public async Task DeleteAsync( long photoId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.PhotosDelete( photoId, ownerId ) );
            }

            public async Task ConfirmTagAsync( uint tagId, long photoId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.PhotosConfirmTag( tagId, photoId, ownerId ) );
            }

            public async Task RemoveTagAsync( uint tagId, long photoId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.PhotosRemoveTag( tagId, photoId, ownerId ) );
            }

            public async Task ReportAsync( long photoId, int? ownerId = null, ReportReason? reason = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.PhotosReport( photoId, ownerId, reason ) );
            }

            public async Task CopyAsync( long photoId, int? ownerId = null, string accessKey = "" ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.PhotosCopy( photoId, ownerId, accessKey ) );
            }

            public async Task EditAsync( long photoId, int? ownerId = null, string caption = "" ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.PhotosEdit( photoId, ownerId, caption ) );
            }

            public async Task<StructEntity<int>> GetAlbumsCountAsync( uint? userId = null, uint? groupId = null ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.PhotosGetAlbumsCount( userId, groupId ) ) ).Data.FirstOrDefault();
            }

            public async Task<PhotoAlbum> CreateAlbumAsync(
                string title,
                string description = "",
                uint? groupId = null,
                PrivacyType? privacy = null,
                PrivacyType? commentPrivacy = null ) {
                return
                    ( await
                      _parent.Executor.ExecAsync(
                          _parent._reqapi.PhotosCreateAlbum( title, description, groupId, privacy, commentPrivacy ) ) ).Data.FirstOrDefault(
                              );
            }

            public async Task EditAlbumAsync(
                long albumId,
                int? ownerId = null,
                string title = "",
                string description = "",
                PrivacyType? privacy = null,
                PrivacyType? commentPrivacy = null ) {
                await
                    _parent.Executor.ExecAsync(
                        _parent._reqapi.PhotosEditAlbum( albumId, ownerId, title, description, privacy, commentPrivacy ) );
            }

            public async Task<SimpleEntity<string>> GetOwnerPhotoUploadServerAsync() {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.PhotosGetOwnerPhotoUploadServer() ) ).Data.FirstOrDefault();
            }

            public async Task<PhotosUploadServer> GetUploadServerAsync( long albumId, uint? groupId = null ) {
                return
                    ( await _parent.Executor.ExecAsync( _parent._reqapi.PhotosGetUploadServer( albumId, groupId ) ) ).Data.FirstOrDefault();
            }

            public async Task<PhotosUploadServer> GetChatUploadServerAsync(
                uint chatId,
                uint? cropX = null,
                uint? cropY = null,
                uint? cropWidth = null ) {
                return
                    ( await _parent.Executor.ExecAsync( _parent._reqapi.PhotosGetChatUploadServer( chatId, cropX, cropY, cropWidth ) ) )
                        .Data.FirstOrDefault();
            }

            public async Task ReorderAlbumsAsync( long albumId, int? ownerId = null, long? before = null, long? after = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.PhotosReorderAlbums( albumId, ownerId, before, after ) );
            }

            public async Task ReorderPhotosAsync( long photoId, int? ownerId = null, long? before = null, long? after = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.PhotosReorderPhotos( photoId, ownerId, before, after ) );
            }

            public async Task MoveAsync( long targetAlbumId, long photoId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.PhotosMove( targetAlbumId, photoId, ownerId ) );
            }

            public async Task MakeCoverAsync( long albumId, long photoId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.PhotosMakeCover( albumId, photoId, ownerId ) );
            }

            public async Task<EntityList<Photo>> GetAllAsync(
                int? ownerId = null,
                bool extended = false,
                bool noServiceAlbums = false,
                uint offset = 0,
                uint count = 100 ) {
                return
                    ( await _parent.Executor.ExecAsync( _parent._reqapi.PhotosGetAll( ownerId, extended, noServiceAlbums, offset, count ) ) )
                        .Data.FirstOrDefault();
            }

            public async Task<EntityList<Photo>> GetAsync(
                long? albumId = null,
                int? ownerId = null,
                int[] photoIds = null,
                bool rev = true,
                bool extended = false,
                FeedType? feedType = null,
                uint? feed = null,
                uint offset = 0,
                uint count = 100 ) {
                return
                    ( await
                      _parent.Executor.ExecAsync(
                          _parent._reqapi.PhotosGet( albumId, ownerId, photoIds, rev, extended, feedType, feed, offset, count ) ) ).Data
                                                                                                                                   .FirstOrDefault
                        ();
            }

            public async Task<EntityList<Photo>> GetAsync(
                SpecialAlbum albumId,
                int? ownerId = null,
                int[] photoIds = null,
                bool rev = true,
                bool extended = false,
                FeedType? feedType = null,
                uint? feed = null,
                uint offset = 0,
                uint count = 100 ) {
                return
                    ( await
                      _parent.Executor.ExecAsync(
                          _parent._reqapi.PhotosGet( albumId, ownerId, photoIds, rev, extended, feedType, feed, offset, count ) ) ).Data
                                                                                                                                   .FirstOrDefault
                        ();
            }

            public async Task<EntityList<PhotoAlbum>> GetAlbumsAsync(
                int? ownerId = null,
                bool needSystem = true,
                bool needCovers = true,
                uint offset = 0,
                uint count = 100,
                params long[] albumIds ) {
                return
                    ( await
                      _parent.Executor.ExecAsync(
                          _parent._reqapi.PhotosGetAlbums( ownerId, needSystem, needCovers, offset, count, albumIds ) ) ).Data
                                                                                                                         .FirstOrDefault();
            }

            public async Task<Photo[]> SaveAsync(
                long albumId,
                string server,
                string photosList,
                string hash,
                uint? groupId = null,
                double? latitude = null,
                double? longitude = null,
                string caption = "",
                string description = "" ) {
                return
                    ( await
                      _parent.Executor.ExecAsync(
                          _parent._reqapi.PhotosSave(
                              albumId,
                              server,
                              photosList,
                              hash,
                              groupId,
                              latitude,
                              longitude,
                              caption,
                              description ) ) ).Data;
            }
        }

        public MethodGroup_status Status { get; private set; }

        public partial class MethodGroup_status {
            private readonly VKApi _parent;
            internal MethodGroup_status( VKApi parent ) { _parent = parent; }

            public async Task<Status[]> GetAsync( int? userId = null ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.StatusGet( userId ) ) ).Data;
            }

            public async Task SetAsync( string text ) { await _parent.Executor.ExecAsync( _parent._reqapi.StatusSet( text ) ); }
        }

        public MethodGroup_storage Storage { get; private set; }

        public partial class MethodGroup_storage {
            private readonly VKApi _parent;
            internal MethodGroup_storage( VKApi parent ) { _parent = parent; }

            public async Task<StorageEntry[]> GetAsync( uint? userId = null, bool global = false, params string[] keys ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.StorageGet( userId, global, keys ) ) ).Data;
            }

            public async Task<SimpleEntity<string>[]> GetKeysAsync(
                uint? userId = null,
                bool global = false,
                uint offset = 0,
                uint count = 100 ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.StorageGetKeys( userId, global, offset, count ) ) ).Data;
            }

            public async Task<StorageEntry[]> SetAsync( string key, string value, uint? userId = null, bool global = false ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.StorageSet( key, value, userId, global ) ) ).Data;
            }
        }

        public MethodGroup_users Users { get; private set; }

        public partial class MethodGroup_users {
            private readonly VKApi _parent;
            internal MethodGroup_users( VKApi parent ) { _parent = parent; }

            public async Task<StructEntity<bool>> IsAppUserAsync( uint? userId = null ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.UsersIsAppUser( userId ) ) ).Data.FirstOrDefault();
            }

            public async Task ReportAsync( uint userId, ComplaintType type, string comment ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.UsersReport( userId, type, comment ) );
            }

            public async Task<UserSubscriptions> GetSubscriptionsAsync( uint? userId = null, uint offset = 0, uint count = 100 ) {
                return
                    ( await _parent.Executor.ExecAsync( _parent._reqapi.UsersGetSubscriptions( userId, offset, count ) ) ).Data
                                                                                                                          .FirstOrDefault();
            }

            public async Task<User[]> GetAsync(
                UserFields fields = UserFields.None,
                NameCase nameCase = NameCase.Nom,
                params uint[] userIds ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.UsersGet( fields, nameCase, userIds ) ) ).Data;
            }

            public async Task<EntityList<User>> GetFollowersAsync(
                uint? userId = null,
                UserFields fields = UserFields.None,
                NameCase nameCase = NameCase.Nom,
                uint offset = 0,
                uint count = 100 ) {
                return
                    ( await _parent.Executor.ExecAsync( _parent._reqapi.UsersGetFollowers( userId, fields, nameCase, offset, count ) ) )
                        .Data.FirstOrDefault();
            }

            public async Task<EntityList<User>> GetNearbyAsync(
                double latitude,
                double longitude,
                uint? accuracy = null,
                uint? timeout = null,
                byte? radius = null,
                UserFields fields = UserFields.None,
                NameCase nameCase = NameCase.Nom,
                uint offset = 0,
                uint count = 100 ) {
                return
                    ( await
                      _parent.Executor.ExecAsync(
                          _parent._reqapi.UsersGetNearby( latitude, longitude, accuracy, timeout, radius, fields, nameCase, offset, count ) ) )
                        .Data.FirstOrDefault();
            }
        }

        public MethodGroup_utils Utils { get; private set; }

        public partial class MethodGroup_utils {
            private readonly VKApi _parent;
            internal MethodGroup_utils( VKApi parent ) { _parent = parent; }

            public async Task<LinkCheckResult> CheckLinkAsync( string url = "" ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.UtilsCheckLink( url ) ) ).Data.FirstOrDefault();
            }

            public async Task<StructEntity<int>> GetServerTimeAsync() {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.UtilsGetServerTime() ) ).Data.FirstOrDefault();
            }
        }

        public MethodGroup_video Video { get; private set; }

        public partial class MethodGroup_video {
            private readonly VKApi _parent;
            internal MethodGroup_video( VKApi parent ) { _parent = parent; }

            public async Task DeleteCommentAsync( uint commentId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.VideoDeleteComment( commentId, ownerId ) );
            }

            public async Task RestoreCommentAsync( uint commentId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.VideoRestoreComment( commentId, ownerId ) );
            }

            public async Task ReportCommentAsync( uint commentId, int? ownerId = null, ReportReason? reason = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.VideoReportComment( commentId, ownerId, reason ) );
            }

            public async Task DeleteAlbumAsync( long albumId, uint? groupId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.VideoDeleteAlbum( albumId, groupId ) );
            }

            public async Task DeleteAsync( ulong videoId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.VideoDelete( videoId, ownerId ) );
            }

            public async Task RemoveTagAsync( ulong videoId, uint tagId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.VideoRemoveTag( videoId, tagId, ownerId ) );
            }

            public async Task ReportAsync(
                ulong videoId,
                int? ownerId = null,
                ReportReason? reason = null,
                string comment = "",
                string searchQuery = "" ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.VideoReport( videoId, ownerId, reason, comment, searchQuery ) );
            }
        }

        public MethodGroup_wall Wall { get; private set; }

        public partial class MethodGroup_wall {
            private readonly VKApi _parent;
            internal MethodGroup_wall( VKApi parent ) { _parent = parent; }

            public async Task DeleteAsync( uint postId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.WallDelete( postId, ownerId ) );
            }

            public async Task RestoreAsync( uint postId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.WallRestore( postId, ownerId ) );
            }

            public async Task DeleteCommentAsync( uint commentId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.WallDeleteComment( commentId, ownerId ) );
            }

            public async Task RestoreCommentAsync( uint commentId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.WallRestoreComment( commentId, ownerId ) );
            }

            public async Task ReportPostAsync( uint postId, int? ownerId = null, ReportReason? reason = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.WallReportPost( postId, ownerId, reason ) );
            }

            public async Task ReportCommentAsync( uint commentId, int? ownerId = null, ReportReason? reason = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.WallReportComment( commentId, ownerId, reason ) );
            }

            public async Task<Post[]> GetByIdAsync( uint copyHistoryDepth = 2, params string[] posts ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.WallGetById( copyHistoryDepth, posts ) ) ).Data;
            }

            public async Task<Post[]> GetByIdAsync( uint copyHistoryDepth = 2, params Tuple<int, uint>[] posts ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.WallGetById( copyHistoryDepth, posts ) ) ).Data;
            }

            public async Task<EntityList<Post>> GetAsync(
                int? ownerId = null,
                string domain = "",
                WallPostFilter filter = WallPostFilter.All,
                uint offset = 0,
                uint count = 100 ) {
                return
                    ( await _parent.Executor.ExecAsync( _parent._reqapi.WallGet( ownerId, domain, filter, offset, count ) ) ).Data
                                                                                                                             .FirstOrDefault
                        ();
            }

            public async Task PinAsync( uint postId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.WallPin( postId, ownerId ) );
            }

            public async Task UnpinAsync( uint postId, int? ownerId = null ) {
                await _parent.Executor.ExecAsync( _parent._reqapi.WallUnpin( postId, ownerId ) );
            }

            public async Task<RepostInfo> RepostAsync( string @object, string message = "", uint? groupId = null ) {
                return ( await _parent.Executor.ExecAsync( _parent._reqapi.WallRepost( @object, message, groupId ) ) ).Data.FirstOrDefault();
            }
        }
    }
}