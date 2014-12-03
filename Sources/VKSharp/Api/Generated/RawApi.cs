
using System;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Core.ResponseEntities;
using VKSharp.Data.Parameters;

// ReSharper disable UnusedMember.Global
namespace VKSharp {
    public partial class RawApi {
        private void InitializeMethodGroups(){

        Account = new MethodGroup_account(this);
    
        Audio = new MethodGroup_audio(this);
    
        Auth = new MethodGroup_auth(this);
    
        Board = new MethodGroup_board(this);
    
        Database = new MethodGroup_database(this);
    
        Docs = new MethodGroup_docs(this);
    
        Friends = new MethodGroup_friends(this);
    
        Groups = new MethodGroup_groups(this);
    
        Messages = new MethodGroup_messages(this);
    
        Newsfeed = new MethodGroup_newsfeed(this);
    
        Notes = new MethodGroup_notes(this);
    
        Notifications = new MethodGroup_notifications(this);
    
        Pages = new MethodGroup_pages(this);
    
        Photos = new MethodGroup_photos(this);
    
        Status = new MethodGroup_status(this);
    
        Storage = new MethodGroup_storage(this);
    
        Users = new MethodGroup_users(this);
    
        Utils = new MethodGroup_utils(this);
    
        Video = new MethodGroup_video(this);
    
        Wall = new MethodGroup_wall(this);
        }

        public MethodGroup_account Account {get; private set;}
        public partial class MethodGroup_account {
            private readonly RawApi _parent;
            internal MethodGroup_account(RawApi parent){_parent=parent;}

            public async Task<string> SetNameInMenuAsync(  string name  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AccountSetNameInMenu( name ) );
            }
                    
            public async Task<string> SetOnlineAsync(  bool voip = true ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AccountSetOnline( voip ) );
            }
                    
            public async Task<string> SetOfflineAsync(  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AccountSetOffline(  ) );
            }
                    
            public async Task<string> UnregisterDeviceAsync(  string token  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AccountUnregisterDevice( token ) );
            }
                    
            public async Task<string> SetSilenceModeAsync(  string token , int time , uint? chatId = null, uint? userId = null, int sound = 0 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AccountSetSilenceMode( token,time,chatId,userId,sound ) );
            }
                    
            public async Task<string> GetAppPermissionsAsync(  uint? userId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AccountGetAppPermissions( userId ) );
            }
                    
            public async Task<string> BanUserAsync(  uint userId  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AccountBanUser( userId ) );
            }
                    
            public async Task<string> UnbanUserAsync(  uint userId  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AccountUnbanUser( userId ) );
            }
                    
            public async Task<string> GetBannedAsync(  uint offset = 0, uint count = 20 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AccountGetBanned( offset,count ) );
            }
                    
            public async Task<string> SetInfoAsync(  uint? intro = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AccountSetInfo( intro ) );
            }
                    
            public async Task<string> GetInfoAsync(  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AccountGetInfo(  ) );
            }
                    
            public async Task<string> GetProfileInfoAsync(  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AccountGetProfileInfo(  ) );
            }
                                    }
        
        public MethodGroup_audio Audio {get; private set;}
        public partial class MethodGroup_audio {
            private readonly RawApi _parent;
            internal MethodGroup_audio(RawApi parent){_parent=parent;}

            public async Task<string> AddAlbumAsync(  string title , uint? groupId = 0 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AudioAddAlbum( title,groupId ) );
            }
                    
            public async Task<string> AddAsync(  int ownerId , long audioId , uint? groupId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AudioAdd( ownerId,audioId,groupId ) );
            }
                    
            public async Task<string> DeleteAlbumAsync(  long albumId , uint? groupId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AudioDeleteAlbum( albumId,groupId ) );
            }
                    
            public async Task<string> DeleteAsync(  long audioId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AudioDelete( audioId,ownerId ) );
            }
                    
            public async Task<string> EditAsync(  int ownerId , long audioId , string artist = "", string title = "", string text = "", AudioGenre? genreId = null, bool? noSearch = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AudioEdit( ownerId,audioId,artist,title,text,genreId,noSearch ) );
            }
                    
            public async Task<string> GetAlbumsAsync(  int? ownerId = null, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AudioGetAlbums( ownerId,offset,count ) );
            }
                    
            public async Task<string> GetAsync(  int? ownerId = null, long? albumId = null, ulong[] audioIds = null, bool needUser = false, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AudioGet( ownerId,albumId,audioIds,needUser,offset,count ) );
            }
                    
            public async Task<string> GetByIdAsync(  bool itunes = false,params string[] audios  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AudioGetById( itunes,audios ) );
            }
                    
            public async Task<string> GetByIdAsync(  bool itunes = false,params Tuple<int, long>[] audios  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AudioGetById( itunes,audios ) );
            }
                    
            public async Task<string> GetCountAsync(  int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AudioGetCount( ownerId ) );
            }
                    
            public async Task<string> GetLyricsAsync(  long lyricsId  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AudioGetLyrics( lyricsId ) );
            }
                    
            public async Task<string> GetUploadServerAsync(  long albumId , uint? groupId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AudioGetUploadServer( albumId,groupId ) );
            }
                    
            public async Task<string> ReorderAsync(  long audioId , int? ownerId = null, long? before = null, long? after = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AudioReorder( audioId,ownerId,before,after ) );
            }
                    
            public async Task<string> RestoreAsync(  long audioId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AudioRestore( audioId,ownerId ) );
            }
                    
            public async Task<string> SaveAsync(  string server , string audio , string hash , string artist = "", string title = "" ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AudioSave( server,audio,hash,artist,title ) );
            }
                    
            public async Task<string> SearchAsync(  string q , bool autoComplete = true, bool lyrics = false, bool performerOnly = false, AudioSortOrder sort = AudioSortOrder.ByRating, bool searchOwn = false, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AudioSearch( q,autoComplete,lyrics,performerOnly,sort,searchOwn,offset,count ) );
            }
                                    }
        
        public MethodGroup_auth Auth {get; private set;}
        public partial class MethodGroup_auth {
            private readonly RawApi _parent;
            internal MethodGroup_auth(RawApi parent){_parent=parent;}

            public async Task<string> CheckPhoneAsync(  string phone , string clientSecret , int? clientId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AuthCheckPhone( phone,clientSecret,clientId ) );
            }
                    
            public async Task<string> ConfirmAsync(  uint clientId , string clientSecret , string phone , string code , string password = "", bool testMode = false, int? intro = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AuthConfirm( clientId,clientSecret,phone,code,password,testMode,intro ) );
            }
                    
            public async Task<string> RestoreAsync(  long phone  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.AuthRestore( phone ) );
            }
                                    }
        
        public MethodGroup_board Board {get; private set;}
        public partial class MethodGroup_board {
            private readonly RawApi _parent;
            internal MethodGroup_board(RawApi parent){_parent=parent;}

            public async Task<string> CloseTopicAsync(  uint groupId , uint topicId  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.BoardCloseTopic( groupId,topicId ) );
            }
                    
            public async Task<string> DeleteCommentAsync(  uint groupId , uint topicId , uint commentId  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.BoardDeleteComment( groupId,topicId,commentId ) );
            }
                    
            public async Task<string> DeleteTopicAsync(  uint groupId , uint topicId  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.BoardDeleteTopic( groupId,topicId ) );
            }
                    
            public async Task<string> FixTopicAsync(  uint groupId , uint topicId  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.BoardFixTopic( groupId,topicId ) );
            }
                    
            public async Task<string> UnfixTopicAsync(  uint groupId , uint topicId  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.BoardUnfixTopic( groupId,topicId ) );
            }
                    
            public async Task<string> RestoreCommentAsync(  uint groupId , uint topicId , uint commentId  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.BoardRestoreComment( groupId,topicId,commentId ) );
            }
                                    }
        
        public MethodGroup_database Database {get; private set;}
        public partial class MethodGroup_database {
            private readonly RawApi _parent;
            internal MethodGroup_database(RawApi parent){_parent=parent;}

            public async Task<string> GetCountriesAsync(  string code = "", bool needAll = false, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.DatabaseGetCountries( code,needAll,offset,count ) );
            }
                    
            public async Task<string> GetRegionsAsync(  uint countryId , string q = "", uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.DatabaseGetRegions( countryId,q,offset,count ) );
            }
                    
            public async Task<string> GetStreetsByIdAsync( params uint[] streetIds  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.DatabaseGetStreetsById( streetIds ) );
            }
                    
            public async Task<string> GetCountriesByIdAsync( params uint[] countryIds  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.DatabaseGetCountriesById( countryIds ) );
            }
                    
            public async Task<string> GetCitiesByIdAsync( params uint[] cityIds  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.DatabaseGetCitiesById( cityIds ) );
            }
                    
            public async Task<string> GetCitiesAsync(  uint countryId , uint? regionId = null, string q = "", bool needAll = false, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.DatabaseGetCities( countryId,regionId,q,needAll,offset,count ) );
            }
                    
            public async Task<string> GetUniversitiesAsync(  uint? countryId = null, uint? cityId = null, string q = "", uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.DatabaseGetUniversities( countryId,cityId,q,offset,count ) );
            }
                    
            public async Task<string> GetSchoolsAsync(  uint? cityId = null, string q = "", uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.DatabaseGetSchools( cityId,q,offset,count ) );
            }
                    
            public async Task<string> GetFacultiesAsync(  uint universityId , uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.DatabaseGetFaculties( universityId,offset,count ) );
            }
                    
            public async Task<string> GetChairsAsync(  uint facultyId , uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.DatabaseGetChairs( facultyId,offset,count ) );
            }
                                    }
        
        public MethodGroup_docs Docs {get; private set;}
        public partial class MethodGroup_docs {
            private readonly RawApi _parent;
            internal MethodGroup_docs(RawApi parent){_parent=parent;}

            public async Task<string> AddAsync(  long docId , int ownerId , string accessKey = "" ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.DocsAdd( docId,ownerId,accessKey ) );
            }
                    
            public async Task<string> DeleteAsync(  long docId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.DocsDelete( docId,ownerId ) );
            }
                    
            public async Task<string> GetUploadServerAsync(  uint? groupId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.DocsGetUploadServer( groupId ) );
            }
                    
            public async Task<string> GetWallUploadServerAsync(  uint? groupId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.DocsGetWallUploadServer( groupId ) );
            }
                    
            public async Task<string> GetAsync(  int? ownerId = null, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.DocsGet( ownerId,offset,count ) );
            }
                    
            public async Task<string> GetByIdAsync( params Tuple<int,int>[] docs  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.DocsGetById( docs ) );
            }
                    
            public async Task<string> SaveAsync(  string file , string title ,params string[] tags  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.DocsSave( file,title,tags ) );
            }
                                    }
        
        public MethodGroup_friends Friends {get; private set;}
        public partial class MethodGroup_friends {
            private readonly RawApi _parent;
            internal MethodGroup_friends(RawApi parent){_parent=parent;}

            public async Task<string> GetAsync(  uint? userId = null, uint? listId = null, UserFields fields = UserFields.None, UserSortOrder order = UserSortOrder.ById, NameCase nameCase = NameCase.Nom, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.FriendsGet( userId,listId,fields,order,nameCase,offset,count ) );
            }
                    
            public async Task<string> GetSuggestionsAsync(  FriendSuggestionFilters filters = FriendSuggestionFilters.Everything, UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.FriendsGetSuggestions( filters,fields,nameCase,offset,count ) );
            }
                    
            public async Task<string> GetByPhonesAsync(  UserFields fields = UserFields.None, ulong[] phones = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.FriendsGetByPhones( fields,phones ) );
            }
                    
            public async Task<string> AddAsync(  uint userId , string text = "" ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.FriendsAdd( userId,text ) );
            }
                    
            public async Task<string> DeleteAllRequestsAsync(  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.FriendsDeleteAllRequests(  ) );
            }
                    
            public async Task<string> GetRecentAsync(  uint count = 20 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.FriendsGetRecent( count ) );
            }
                    
            public async Task<string> DeleteAsync(  uint userId  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.FriendsDelete( userId ) );
            }
                    
            public async Task<string> DeleteListAsync(  uint listId  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.FriendsDeleteList( listId ) );
            }
                    
            public async Task<string> GetAppUsersAsync(  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.FriendsGetAppUsers(  ) );
            }
                    
            public async Task<string> GetMutualAsync(  uint targetUid , uint? sourceUid = null, bool order = false, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.FriendsGetMutual( targetUid,sourceUid,order,offset,count ) );
            }
                                    }
        
        public MethodGroup_groups Groups {get; private set;}
        public partial class MethodGroup_groups {
            private readonly RawApi _parent;
            internal MethodGroup_groups(RawApi parent){_parent=parent;}

            public async Task<string> GetBannedAsync(  uint groupId , uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.GroupsGetBanned( groupId,offset,count ) );
            }
                    
            public async Task<string> GetByIdAsync(  string[] groupIds , GroupFields fields  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.GroupsGetById( groupIds,fields ) );
            }
                    
            public async Task<string> GetByIdAsync(  uint groupId , GroupFields fields  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.GroupsGetById( groupId,fields ) );
            }
                    
            public async Task<string> GetMembersAsync(  uint groupId , UserFields fields = UserFields.Everything, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.GroupsGetMembers( groupId,fields,offset,count ) );
            }
                    
            public async Task<string> GetMembersAsync(  string groupId , UserFields fields = UserFields.None, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.GroupsGetMembers( groupId,fields,offset,count ) );
            }
                    
            public async Task<string> IsMemberAsync(  uint groupId , bool extended = false,params uint[] userIds  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.GroupsIsMember( groupId,extended,userIds ) );
            }
                    
            public async Task<string> JoinAsync(  uint groupId , bool notSure = false ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.GroupsJoin( groupId,notSure ) );
            }
                    
            public async Task<string> LeaveAsync(  uint groupId  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.GroupsLeave( groupId ) );
            }
                    
            public async Task<string> UnbanUserAsync(  uint groupId , uint userId  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.GroupsUnbanUser( groupId,userId ) );
            }
                                    }
        
        public MethodGroup_messages Messages {get; private set;}
        public partial class MethodGroup_messages {
            private readonly RawApi _parent;
            internal MethodGroup_messages(RawApi parent){_parent=parent;}

            public async Task<string> AddChatUserAsync(  uint userId , uint? chatId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.MessagesAddChatUser( userId,chatId ) );
            }
                    
            public async Task<string> RemoveChatUserAsync(  uint userId , uint chatId  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.MessagesRemoveChatUser( userId,chatId ) );
            }
                    
            public async Task<string> DeleteAsync( params int[] messageIds  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.MessagesDelete( messageIds ) );
            }
                    
            public async Task<string> MarkAsReadAsync(  uint userId , uint? startMessageId = null,params int[] messageIds  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.MessagesMarkAsRead( userId,startMessageId,messageIds ) );
            }
                    
            public async Task<string> RestoreAsync(  int messageId  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.MessagesRestore( messageId ) );
            }
                    
            public async Task<string> GetLastActivityAsync(  int userId  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.MessagesGetLastActivity( userId ) );
            }
                    
            public async Task<string> DeleteDialogAsync(  uint userId , uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.MessagesDeleteDialog( userId,offset,count ) );
            }
                    
            public async Task<string> MarkAsImportantAsync(  bool important ,params int[] messageIds  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.MessagesMarkAsImportant( important,messageIds ) );
            }
                                    }
        
        public MethodGroup_newsfeed Newsfeed {get; private set;}
        public partial class MethodGroup_newsfeed {
            private readonly RawApi _parent;
            internal MethodGroup_newsfeed(RawApi parent){_parent=parent;}

            public async Task<string> AddBanAsync(  uint[] userIds = null, uint[] groupIds = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.NewsfeedAddBan( userIds,groupIds ) );
            }
                    
            public async Task<string> DeleteBanAsync(  uint[] userIds = null, uint[] groupIds = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.NewsfeedDeleteBan( userIds,groupIds ) );
            }
                                    }
        
        public MethodGroup_notes Notes {get; private set;}
        public partial class MethodGroup_notes {
            private readonly RawApi _parent;
            internal MethodGroup_notes(RawApi parent){_parent=parent;}

            public async Task<string> DeleteAsync(  uint noteId  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.NotesDelete( noteId ) );
            }
                    
            public async Task<string> DeleteCommentAsync(  uint commentId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.NotesDeleteComment( commentId,ownerId ) );
            }
                    
            public async Task<string> RestoreCommentAsync(  uint commentId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.NotesRestoreComment( commentId,ownerId ) );
            }
                                    }
        
        public MethodGroup_notifications Notifications {get; private set;}
        public partial class MethodGroup_notifications {
            private readonly RawApi _parent;
            internal MethodGroup_notifications(RawApi parent){_parent=parent;}

            public async Task<string> MarkAsViewedAsync(  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.NotificationsMarkAsViewed(  ) );
            }
                                    }
        
        public MethodGroup_pages Pages {get; private set;}
        public partial class MethodGroup_pages {
            private readonly RawApi _parent;
            internal MethodGroup_pages(RawApi parent){_parent=parent;}

            public async Task<string> ClearCacheAsync(  string url  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PagesClearCache( url ) );
            }
                                    }
        
        public MethodGroup_photos Photos {get; private set;}
        public partial class MethodGroup_photos {
            private readonly RawApi _parent;
            internal MethodGroup_photos(RawApi parent){_parent=parent;}

            public async Task<string> DeleteCommentAsync(  uint commentId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosDeleteComment( commentId,ownerId ) );
            }
                    
            public async Task<string> RestoreCommentAsync(  uint commentId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosRestoreComment( commentId,ownerId ) );
            }
                    
            public async Task<string> ReportCommentAsync(  uint commentId , int? ownerId = null, ReportReason? reason = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosReportComment( commentId,ownerId,reason ) );
            }
                    
            public async Task<string> DeleteAlbumAsync(  long albumId , uint? groupId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosDeleteAlbum( albumId,groupId ) );
            }
                    
            public async Task<string> DeleteAsync(  long photoId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosDelete( photoId,ownerId ) );
            }
                    
            public async Task<string> ConfirmTagAsync(  uint tagId , long photoId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosConfirmTag( tagId,photoId,ownerId ) );
            }
                    
            public async Task<string> RemoveTagAsync(  uint tagId , long photoId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosRemoveTag( tagId,photoId,ownerId ) );
            }
                    
            public async Task<string> ReportAsync(  long photoId , int? ownerId = null, ReportReason? reason = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosReport( photoId,ownerId,reason ) );
            }
                    
            public async Task<string> CopyAsync(  long photoId , int? ownerId = null, string accessKey = "" ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosCopy( photoId,ownerId,accessKey ) );
            }
                    
            public async Task<string> EditAsync(  long photoId , int? ownerId = null, string caption = "" ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosEdit( photoId,ownerId,caption ) );
            }
                    
            public async Task<string> GetAlbumsCountAsync(  uint? userId = null, uint? groupId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosGetAlbumsCount( userId,groupId ) );
            }
                    
            public async Task<string> CreateAlbumAsync(  string title , string description = "", uint? groupId = null, PrivacyType? privacy = null, PrivacyType? commentPrivacy = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosCreateAlbum( title,description,groupId,privacy,commentPrivacy ) );
            }
                    
            public async Task<string> EditAlbumAsync(  long albumId , int? ownerId = null, string title = "", string description = "", PrivacyType? privacy = null, PrivacyType? commentPrivacy = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosEditAlbum( albumId,ownerId,title,description,privacy,commentPrivacy ) );
            }
                    
            public async Task<string> GetOwnerPhotoUploadServerAsync(  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosGetOwnerPhotoUploadServer(  ) );
            }
                    
            public async Task<string> GetUploadServerAsync(  long albumId , uint? groupId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosGetUploadServer( albumId,groupId ) );
            }
                    
            public async Task<string> GetChatUploadServerAsync(  uint chatId , uint? cropX = null, uint? cropY = null, uint? cropWidth = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosGetChatUploadServer( chatId,cropX,cropY,cropWidth ) );
            }
                    
            public async Task<string> ReorderAlbumsAsync(  long albumId , int? ownerId = null, long? before = null, long? after = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosReorderAlbums( albumId,ownerId,before,after ) );
            }
                    
            public async Task<string> ReorderPhotosAsync(  long photoId , int? ownerId = null, long? before = null, long? after = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosReorderPhotos( photoId,ownerId,before,after ) );
            }
                    
            public async Task<string> MoveAsync(  long targetAlbumId , long photoId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosMove( targetAlbumId,photoId,ownerId ) );
            }
                    
            public async Task<string> MakeCoverAsync(  long albumId , long photoId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosMakeCover( albumId,photoId,ownerId ) );
            }
                    
            public async Task<string> GetAllAsync(  int? ownerId = null, bool extended = false, bool noServiceAlbums = false, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosGetAll( ownerId,extended,noServiceAlbums,offset,count ) );
            }
                    
            public async Task<string> GetAsync(  long? albumId = null, int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null, uint? feed = null, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosGet( albumId,ownerId,photoIds,rev,extended,feedType,feed,offset,count ) );
            }
                    
            public async Task<string> GetAsync(  SpecialAlbum albumId , int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null, uint? feed = null, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosGet( albumId,ownerId,photoIds,rev,extended,feedType,feed,offset,count ) );
            }
                    
            public async Task<string> GetByIdAsync( params ContentId[] photos  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosGetById( photos ) );
            }
                    
            public async Task<string> GetAlbumsAsync(  int? ownerId = null, bool needSystem = true, bool needCovers = true, uint offset = 0, uint count = 100,params long[] albumIds  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosGetAlbums( ownerId,needSystem,needCovers,offset,count,albumIds ) );
            }
                    
            public async Task<string> SaveAsync(  long albumId , string server , string photosList , string hash , uint? groupId = null, double? latitude = null, double? longitude = null, string caption = "", string description = "" ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.PhotosSave( albumId,server,photosList,hash,groupId,latitude,longitude,caption,description ) );
            }
                                    }
        
        public MethodGroup_status Status {get; private set;}
        public partial class MethodGroup_status {
            private readonly RawApi _parent;
            internal MethodGroup_status(RawApi parent){_parent=parent;}

            public async Task<string> GetAsync(  int? userId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.StatusGet( userId ) );
            }
                    
            public async Task<string> SetAsync(  string text  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.StatusSet( text ) );
            }
                                    }
        
        public MethodGroup_storage Storage {get; private set;}
        public partial class MethodGroup_storage {
            private readonly RawApi _parent;
            internal MethodGroup_storage(RawApi parent){_parent=parent;}

            public async Task<string> GetAsync(  uint? userId = null, bool global = false,params string[] keys  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.StorageGet( userId,global,keys ) );
            }
                    
            public async Task<string> GetKeysAsync(  uint? userId = null, bool global = false, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.StorageGetKeys( userId,global,offset,count ) );
            }
                    
            public async Task<string> SetAsync(  string key , string value , uint? userId = null, bool global = false ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.StorageSet( key,value,userId,global ) );
            }
                                    }
        
        public MethodGroup_users Users {get; private set;}
        public partial class MethodGroup_users {
            private readonly RawApi _parent;
            internal MethodGroup_users(RawApi parent){_parent=parent;}

            public async Task<string> IsAppUserAsync(  uint? userId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.UsersIsAppUser( userId ) );
            }
                    
            public async Task<string> ReportAsync(  uint userId , ComplaintType type , string comment  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.UsersReport( userId,type,comment ) );
            }
                    
            public async Task<string> GetSubscriptionsAsync(  uint? userId = null, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.UsersGetSubscriptions( userId,offset,count ) );
            }
                    
            public async Task<string> GetAsync(  UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom,params uint[] userIds  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.UsersGet( fields,nameCase,userIds ) );
            }
                    
            public async Task<string> GetFollowersAsync(  uint? userId = null, UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.UsersGetFollowers( userId,fields,nameCase,offset,count ) );
            }
                    
            public async Task<string> GetNearbyAsync(  double latitude , double longitude , uint? accuracy = null, uint? timeout = null, byte? radius = null, UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.UsersGetNearby( latitude,longitude,accuracy,timeout,radius,fields,nameCase,offset,count ) );
            }
                                    }
        
        public MethodGroup_utils Utils {get; private set;}
        public partial class MethodGroup_utils {
            private readonly RawApi _parent;
            internal MethodGroup_utils(RawApi parent){_parent=parent;}

            public async Task<string> CheckLinkAsync(  string url = "" ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.UtilsCheckLink( url ) );
            }
                    
            public async Task<string> GetServerTimeAsync(  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.UtilsGetServerTime(  ) );
            }
                                    }
        
        public MethodGroup_video Video {get; private set;}
        public partial class MethodGroup_video {
            private readonly RawApi _parent;
            internal MethodGroup_video(RawApi parent){_parent=parent;}

            public async Task<string> DeleteCommentAsync(  uint commentId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.VideoDeleteComment( commentId,ownerId ) );
            }
                    
            public async Task<string> RestoreCommentAsync(  uint commentId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.VideoRestoreComment( commentId,ownerId ) );
            }
                    
            public async Task<string> ReportCommentAsync(  uint commentId , int? ownerId = null, ReportReason? reason = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.VideoReportComment( commentId,ownerId,reason ) );
            }
                    
            public async Task<string> DeleteAlbumAsync(  long albumId , uint? groupId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.VideoDeleteAlbum( albumId,groupId ) );
            }
                    
            public async Task<string> DeleteAsync(  ulong videoId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.VideoDelete( videoId,ownerId ) );
            }
                    
            public async Task<string> RemoveTagAsync(  ulong videoId , uint tagId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.VideoRemoveTag( videoId,tagId,ownerId ) );
            }
                    
            public async Task<string> ReportAsync(  ulong videoId , int? ownerId = null, ReportReason? reason = null, string comment = "", string searchQuery = "" ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.VideoReport( videoId,ownerId,reason,comment,searchQuery ) );
            }
                                    }
        
        public MethodGroup_wall Wall {get; private set;}
        public partial class MethodGroup_wall {
            private readonly RawApi _parent;
            internal MethodGroup_wall(RawApi parent){_parent=parent;}

            public async Task<string> DeleteAsync(  uint postId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.WallDelete( postId,ownerId ) );
            }
                    
            public async Task<string> RestoreAsync(  uint postId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.WallRestore( postId,ownerId ) );
            }
                    
            public async Task<string> DeleteCommentAsync(  uint commentId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.WallDeleteComment( commentId,ownerId ) );
            }
                    
            public async Task<string> RestoreCommentAsync(  uint commentId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.WallRestoreComment( commentId,ownerId ) );
            }
                    
            public async Task<string> ReportPostAsync(  uint postId , int? ownerId = null, ReportReason? reason = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.WallReportPost( postId,ownerId,reason ) );
            }
                    
            public async Task<string> ReportCommentAsync(  uint commentId , int? ownerId = null, ReportReason? reason = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.WallReportComment( commentId,ownerId,reason ) );
            }
                    
            public async Task<string> GetByIdAsync(  uint copyHistoryDepth = 2,params string[] posts  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.WallGetById( copyHistoryDepth,posts ) );
            }
                    
            public async Task<string> GetByIdAsync(  uint copyHistoryDepth = 2,params Tuple<int,uint>[] posts  ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.WallGetById( copyHistoryDepth,posts ) );
            }
                    
            public async Task<string> GetAsync(  int? ownerId = null, string domain = "", WallPostFilter filter = WallPostFilter.All, uint offset = 0, uint count = 100 ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.WallGet( ownerId,domain,filter,offset,count ) );
            }
                    
            public async Task<string> PinAsync(  uint postId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.WallPin( postId,ownerId ) );
            }
                    
            public async Task<string> UnpinAsync(  uint postId , int? ownerId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.WallUnpin( postId,ownerId ) );
            }
                    
            public async Task<string> RepostAsync(  string @object , string message = "", uint? groupId = null ){
                return await _parent.Executor.ExecRawAsync( _parent._reqapi.WallRepost( @object,message,groupId ) );
            }
                                    }
            }
}