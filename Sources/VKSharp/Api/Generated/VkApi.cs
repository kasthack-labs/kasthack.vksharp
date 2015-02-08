
using System;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Core.ResponseEntities;
using VKSharp.Data.Parameters;

// ReSharper disable UnusedMember.Global
namespace VKSharp {
    public partial class VKApi {
                    private void InitializeMethodGroups(){
                            this.Account = new MethodGroup_account(this);
                            this.Ads = new MethodGroup_ads(this);
                            this.Audio = new MethodGroup_audio(this);
                            this.Auth = new MethodGroup_auth(this);
                            this.Board = new MethodGroup_board(this);
                            this.Database = new MethodGroup_database(this);
                            this.Docs = new MethodGroup_docs(this);
                            this.Friends = new MethodGroup_friends(this);
                            this.Groups = new MethodGroup_groups(this);
                            this.Messages = new MethodGroup_messages(this);
                            this.Newsfeed = new MethodGroup_newsfeed(this);
                            this.Notes = new MethodGroup_notes(this);
                            this.Notifications = new MethodGroup_notifications(this);
                            this.Pages = new MethodGroup_pages(this);
                            this.Photos = new MethodGroup_photos(this);
                            this.Stats = new MethodGroup_stats(this);
                            this.Status = new MethodGroup_status(this);
                            this.Storage = new MethodGroup_storage(this);
                            this.Users = new MethodGroup_users(this);
                            this.Utils = new MethodGroup_utils(this);
                            this.Video = new MethodGroup_video(this);
                            this.Wall = new MethodGroup_wall(this);
                        }
                            public MethodGroup_account Account {get; private set;}
                public partial class MethodGroup_account {
                    private readonly VKApi _parent;
                    internal MethodGroup_account(VKApi parent){_parent=parent;}
                                                public async Task BanUser(  int userId  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AccountBanUser(
                                    userId
                                )
                                )
                                ;
                            }
                                                public async Task <long>GetAppPermissions(  int? userId = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AccountGetAppPermissions(
                                    userId
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <User[]>GetBanned(  int offset = 0, int count = 20 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AccountGetBanned(
                                    offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <AccountInfo>GetInfo(  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AccountGetInfo(
                                    
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <User>GetProfileInfo(  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AccountGetProfileInfo(
                                    
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task SetInfo(  int? intro = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AccountSetInfo(
                                    intro
                                )
                                )
                                ;
                            }
                                                public async Task SetNameInMenu(  string name  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AccountSetNameInMenu(
                                    name
                                )
                                )
                                ;
                            }
                                                public async Task SetOffline(  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AccountSetOffline(
                                    
                                )
                                )
                                ;
                            }
                                                public async Task SetOnline(  bool voip = true ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AccountSetOnline(
                                    voip
                                )
                                )
                                ;
                            }
                                                public async Task SetSilenceMode(  string token , int time , int? chatId = null, int? userId = null, int sound = 0 ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AccountSetSilenceMode(
                                    token,time,chatId,userId,sound
                                )
                                )
                                ;
                            }
                                                public async Task UnbanUser(  int userId  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AccountUnbanUser(
                                    userId
                                )
                                )
                                ;
                            }
                                                public async Task UnregisterDevice(  string token  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AccountUnregisterDevice(
                                    token
                                )
                                )
                                ;
                            }
                                    }
                        public MethodGroup_ads Ads {get; private set;}
                public partial class MethodGroup_ads {
                    private readonly VKApi _parent;
                    internal MethodGroup_ads(VKApi parent){_parent=parent;}
                                                public async Task <int[]>DeleteClients(  ulong accountId ,params ulong[] ids  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AdsDeleteClients(
                                    accountId,ids
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                    }
                        public MethodGroup_audio Audio {get; private set;}
                public partial class MethodGroup_audio {
                    private readonly VKApi _parent;
                    internal MethodGroup_audio(VKApi parent){_parent=parent;}
                                                public async Task <int>Add(  int ownerId , long audioId , int? groupId = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioAdd(
                                    ownerId,audioId,groupId
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <int>AddAlbum(  string title , int? groupId = 0 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioAddAlbum(
                                    title,groupId
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task Delete(  long audioId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioDelete(
                                    audioId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task DeleteAlbum(  long albumId , int? groupId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioDeleteAlbum(
                                    albumId,groupId
                                )
                                )
                                ;
                            }
                                                public async Task <int>Edit(  int ownerId , long audioId , string artist = "", string title = "", string text = "", AudioGenre? genreId = null, bool? noSearch = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioEdit(
                                    ownerId,audioId,artist,title,text,genreId,noSearch
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task EditAlbum(  long albumId , string title , int? groupId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioEditAlbum(
                                    albumId,title,groupId
                                )
                                )
                                ;
                            }
                                                public async Task <EntityList<Audio>>Get(  int? ownerId = null, long? albumId = null, ulong[] audioIds = null, bool needUser = false, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioGet(
                                    ownerId,albumId,audioIds,needUser,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <EntityList<Audio>>GetPopular(  AudioGenre? genreId = null, bool? onlyEng = null, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioGetPopular(
                                    genreId,onlyEng,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <EntityList<Audio>>GetRecommendations(  AudioGenre? genreId = null, bool? onlyEng = null, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioGetRecommendations(
                                    genreId,onlyEng,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <EntityList<AudioAlbum>>GetAlbums(  int? ownerId = null, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioGetAlbums(
                                    ownerId,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <Audio[]>GetById(  bool itunes = false,params string[] audios  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioGetById(
                                    itunes,audios
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <Audio[]>GetById(  bool itunes = false,params Tuple<int, long>[] audios  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioGetById(
                                    itunes,audios
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <int>GetCount(  int? ownerId = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioGetCount(
                                    ownerId
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <Lyrics>GetLyrics(  long lyricsId  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioGetLyrics(
                                    lyricsId
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <string>GetUploadServer(  long albumId , int? groupId = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioGetUploadServer(
                                    albumId,groupId
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task Reorder(  long audioId , int? ownerId = null, long? before = null, long? after = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioReorder(
                                    audioId,ownerId,before,after
                                )
                                )
                                ;
                            }
                                                public async Task <Audio>Restore(  long audioId , int? ownerId = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioRestore(
                                    audioId,ownerId
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <Audio[]>Save(  string server , string audio , string hash , string artist = "", string title = "" ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioSave(
                                    server,audio,hash,artist,title
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <EntityList<Audio>>Search(  string q , bool autoComplete = true, bool lyrics = false, bool performerOnly = false, AudioSortOrder sort = AudioSortOrder.ByRating, bool searchOwn = false, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AudioSearch(
                                    q,autoComplete,lyrics,performerOnly,sort,searchOwn,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                    }
                        public MethodGroup_auth Auth {get; private set;}
                public partial class MethodGroup_auth {
                    private readonly VKApi _parent;
                    internal MethodGroup_auth(VKApi parent){_parent=parent;}
                                                public async Task <bool>CheckPhone(  string phone , string clientSecret , int? clientId = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AuthCheckPhone(
                                    phone,clientSecret,clientId
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <ConfirmResult>Confirm(  int clientId , string clientSecret , string phone , string code , string password = "", bool testMode = false, int? intro = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AuthConfirm(
                                    clientId,clientSecret,phone,code,password,testMode,intro
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <AuthRestore>Restore(  long phone  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.AuthRestore(
                                    phone
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                    }
                        public MethodGroup_board Board {get; private set;}
                public partial class MethodGroup_board {
                    private readonly VKApi _parent;
                    internal MethodGroup_board(VKApi parent){_parent=parent;}
                                                public async Task CloseTopic(  int groupId , int topicId  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.BoardCloseTopic(
                                    groupId,topicId
                                )
                                )
                                ;
                            }
                                                public async Task DeleteComment(  int groupId , int topicId , int commentId  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.BoardDeleteComment(
                                    groupId,topicId,commentId
                                )
                                )
                                ;
                            }
                                                public async Task DeleteTopic(  int groupId , int topicId  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.BoardDeleteTopic(
                                    groupId,topicId
                                )
                                )
                                ;
                            }
                                                public async Task FixTopic(  int groupId , int topicId  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.BoardFixTopic(
                                    groupId,topicId
                                )
                                )
                                ;
                            }
                                                public async Task RestoreComment(  int groupId , int topicId , int commentId  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.BoardRestoreComment(
                                    groupId,topicId,commentId
                                )
                                )
                                ;
                            }
                                                public async Task UnfixTopic(  int groupId , int topicId  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.BoardUnfixTopic(
                                    groupId,topicId
                                )
                                )
                                ;
                            }
                                    }
                        public MethodGroup_database Database {get; private set;}
                public partial class MethodGroup_database {
                    private readonly VKApi _parent;
                    internal MethodGroup_database(VKApi parent){_parent=parent;}
                                                public async Task <EntityList<DatabaseEntry>>GetChairs(  int facultyId , int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.DatabaseGetChairs(
                                    facultyId,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <DatabaseCity[]>GetCities(  int countryId , int? regionId = null, string q = "", bool needAll = false, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.DatabaseGetCities(
                                    countryId,regionId,q,needAll,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <DatabaseCity[]>GetCitiesById( params int[] cityIds  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.DatabaseGetCitiesById(
                                    cityIds
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <EntityList<DatabaseEntry>>GetCountries(  string code = "", bool needAll = false, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.DatabaseGetCountries(
                                    code,needAll,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <DatabaseEntry[]>GetCountriesById( params int[] countryIds  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.DatabaseGetCountriesById(
                                    countryIds
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <EntityList<DatabaseEntry>>GetFaculties(  int universityId , int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.DatabaseGetFaculties(
                                    universityId,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <EntityList<DatabaseEntry>>GetRegions(  int countryId , string q = "", int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.DatabaseGetRegions(
                                    countryId,q,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <DatabaseEntry[]>GetSchools(  int? cityId = null, string q = "", int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.DatabaseGetSchools(
                                    cityId,q,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <DatabaseEntry[]>GetStreetsById( params int[] streetIds  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.DatabaseGetStreetsById(
                                    streetIds
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <DatabaseEntry[]>GetUniversities(  int? countryId = null, int? cityId = null, string q = "", int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.DatabaseGetUniversities(
                                    countryId,cityId,q,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                    }
                        public MethodGroup_docs Docs {get; private set;}
                public partial class MethodGroup_docs {
                    private readonly VKApi _parent;
                    internal MethodGroup_docs(VKApi parent){_parent=parent;}
                                                public async Task <int>Add(  long docId , int ownerId , string accessKey = "" ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.DocsAdd(
                                    docId,ownerId,accessKey
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task Delete(  long docId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.DocsDelete(
                                    docId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task <EntityList<Document>>Get(  int? ownerId = null, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.DocsGet(
                                    ownerId,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <Document[]>GetById( params Tuple<int,int>[] docs  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.DocsGetById(
                                    docs
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <string>GetUploadServer(  int? groupId = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.DocsGetUploadServer(
                                    groupId
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <string>GetWallUploadServer(  int? groupId = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.DocsGetWallUploadServer(
                                    groupId
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <Document[]>Save(  string file , string title ,params string[] tags  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.DocsSave(
                                    file,title,tags
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                    }
                        public MethodGroup_friends Friends {get; private set;}
                public partial class MethodGroup_friends {
                    private readonly VKApi _parent;
                    internal MethodGroup_friends(VKApi parent){_parent=parent;}
                                                public async Task <int>Add(  int userId , string text = "" ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.FriendsAdd(
                                    userId,text
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <FriendshipStatus[]>AreFriends(  bool needSign = false,params int[] userIds  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.FriendsAreFriends(
                                    needSign,userIds
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <int>Delete(  int userId  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.FriendsDelete(
                                    userId
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task DeleteAllRequests(  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.FriendsDeleteAllRequests(
                                    
                                )
                                )
                                ;
                            }
                                                public async Task DeleteList(  int listId  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.FriendsDeleteList(
                                    listId
                                )
                                )
                                ;
                            }
                                                public async Task Edit(  int userId ,params long[] listIds  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.FriendsEdit(
                                    userId,listIds
                                )
                                )
                                ;
                            }
                                                public async Task EditList(  long listId , string name = "", int[] userIds = null, int[] addUserIds = null,params int[] deleteUserIds  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.FriendsEditList(
                                    listId,name,userIds,addUserIds,deleteUserIds
                                )
                                )
                                ;
                            }
                                                public async Task <EntityList<User>>Get(  int? userId = null, int? listId = null, UserFields fields = UserFields.None, UserSortOrder order = UserSortOrder.ById, NameCase nameCase = NameCase.Nom, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.FriendsGet(
                                    userId,listId,fields,order,nameCase,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <int[]>GetAppUsers(  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.FriendsGetAppUsers(
                                    
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <User[]>GetByPhones(  UserFields fields = UserFields.None,params ulong[] phones  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.FriendsGetByPhones(
                                    fields,phones
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <int[]>GetMutual(  int targetUid , int? sourceUid = null, bool order = false, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.FriendsGetMutual(
                                    targetUid,sourceUid,order,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <int[]>GetOnline(  int? userId = null, int? listId = null, UserSortOrder? order = null, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.FriendsGetOnline(
                                    userId,listId,order,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <int[]>GetRecent(  int count = 20 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.FriendsGetRecent(
                                    count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <EntityList<User>>GetSuggestions(  FriendSuggestionFilters filters = FriendSuggestionFilters.Everything, UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.FriendsGetSuggestions(
                                    filters,fields,nameCase,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                    }
                        public MethodGroup_groups Groups {get; private set;}
                public partial class MethodGroup_groups {
                    private readonly VKApi _parent;
                    internal MethodGroup_groups(VKApi parent){_parent=parent;}
                                                public async Task <User[]>GetBanned(  int groupId , int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.GroupsGetBanned(
                                    groupId,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <Group[]>GetById(  string[] groupIds , GroupFields fields  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.GroupsGetById(
                                    groupIds,fields
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <Group[]>GetById(  int groupId , GroupFields fields  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.GroupsGetById(
                                    groupId,fields
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <EntityList<User>>GetMembers(  int groupId , UserFields fields = UserFields.Everything, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.GroupsGetMembers(
                                    groupId,fields,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <EntityList<User>>GetMembers(  string groupId , UserFields fields = UserFields.None, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.GroupsGetMembers(
                                    groupId,fields,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <MemberShip[]>IsMember(  int groupId , bool extended = false,params int[] userIds  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.GroupsIsMember(
                                    groupId,extended,userIds
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task Join(  int groupId , bool notSure = false ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.GroupsJoin(
                                    groupId,notSure
                                )
                                )
                                ;
                            }
                                                public async Task Leave(  int groupId  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.GroupsLeave(
                                    groupId
                                )
                                )
                                ;
                            }
                                                public async Task UnbanUser(  int groupId , int userId  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.GroupsUnbanUser(
                                    groupId,userId
                                )
                                )
                                ;
                            }
                                    }
                        public MethodGroup_messages Messages {get; private set;}
                public partial class MethodGroup_messages {
                    private readonly VKApi _parent;
                    internal MethodGroup_messages(VKApi parent){_parent=parent;}
                                                public async Task AddChatUser(  int userId , int? chatId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.MessagesAddChatUser(
                                    userId,chatId
                                )
                                )
                                ;
                            }
                                                public async Task Delete( params int[] messageIds  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.MessagesDelete(
                                    messageIds
                                )
                                )
                                ;
                            }
                                                public async Task DeleteDialog(  int userId , int offset = 0, int count = 100 ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.MessagesDeleteDialog(
                                    userId,offset,count
                                )
                                )
                                ;
                            }
                                                public async Task GetLastActivity(  int userId  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.MessagesGetLastActivity(
                                    userId
                                )
                                )
                                ;
                            }
                                                public async Task MarkAsImportant(  bool important ,params int[] messageIds  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.MessagesMarkAsImportant(
                                    important,messageIds
                                )
                                )
                                ;
                            }
                                                public async Task MarkAsRead(  int userId , int? startMessageId = null,params int[] messageIds  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.MessagesMarkAsRead(
                                    userId,startMessageId,messageIds
                                )
                                )
                                ;
                            }
                                                public async Task RemoveChatUser(  int userId , int chatId  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.MessagesRemoveChatUser(
                                    userId,chatId
                                )
                                )
                                ;
                            }
                                                public async Task Restore(  int messageId  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.MessagesRestore(
                                    messageId
                                )
                                )
                                ;
                            }
                                                public async Task SetActivity(  int userId , ImActivity type = ImActivity.Typing ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.MessagesSetActivity(
                                    userId,type
                                )
                                )
                                ;
                            }
                                    }
                        public MethodGroup_newsfeed Newsfeed {get; private set;}
                public partial class MethodGroup_newsfeed {
                    private readonly VKApi _parent;
                    internal MethodGroup_newsfeed(VKApi parent){_parent=parent;}
                                                public async Task AddBan(  int[] userIds = null,params int[] groupIds  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.NewsfeedAddBan(
                                    userIds,groupIds
                                )
                                )
                                ;
                            }
                                                public async Task DeleteBan(  int[] userIds = null,params int[] groupIds  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.NewsfeedDeleteBan(
                                    userIds,groupIds
                                )
                                )
                                ;
                            }
                                    }
                        public MethodGroup_notes Notes {get; private set;}
                public partial class MethodGroup_notes {
                    private readonly VKApi _parent;
                    internal MethodGroup_notes(VKApi parent){_parent=parent;}
                                                public async Task Delete(  int noteId  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.NotesDelete(
                                    noteId
                                )
                                )
                                ;
                            }
                                                public async Task DeleteComment(  int commentId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.NotesDeleteComment(
                                    commentId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task RestoreComment(  int commentId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.NotesRestoreComment(
                                    commentId,ownerId
                                )
                                )
                                ;
                            }
                                    }
                        public MethodGroup_notifications Notifications {get; private set;}
                public partial class MethodGroup_notifications {
                    private readonly VKApi _parent;
                    internal MethodGroup_notifications(VKApi parent){_parent=parent;}
                                                public async Task MarkAsViewed(  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.NotificationsMarkAsViewed(
                                    
                                )
                                )
                                ;
                            }
                                    }
                        public MethodGroup_pages Pages {get; private set;}
                public partial class MethodGroup_pages {
                    private readonly VKApi _parent;
                    internal MethodGroup_pages(VKApi parent){_parent=parent;}
                                                public async Task ClearCache(  string url  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PagesClearCache(
                                    url
                                )
                                )
                                ;
                            }
                                    }
                        public MethodGroup_photos Photos {get; private set;}
                public partial class MethodGroup_photos {
                    private readonly VKApi _parent;
                    internal MethodGroup_photos(VKApi parent){_parent=parent;}
                                                public async Task ConfirmTag(  int tagId , long photoId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosConfirmTag(
                                    tagId,photoId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task Copy(  long photoId , int? ownerId = null, string accessKey = "" ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosCopy(
                                    photoId,ownerId,accessKey
                                )
                                )
                                ;
                            }
                                                public async Task <PhotoAlbum>CreateAlbum(  string title , string description = "", int? groupId = null, PrivacyType? privacy = null, PrivacyType? commentPrivacy = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosCreateAlbum(
                                    title,description,groupId,privacy,commentPrivacy
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task Delete(  long photoId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosDelete(
                                    photoId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task DeleteAlbum(  long albumId , int? groupId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosDeleteAlbum(
                                    albumId,groupId
                                )
                                )
                                ;
                            }
                                                public async Task DeleteComment(  int commentId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosDeleteComment(
                                    commentId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task Edit(  long photoId , int? ownerId = null, string caption = "" ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosEdit(
                                    photoId,ownerId,caption
                                )
                                )
                                ;
                            }
                                                public async Task EditAlbum(  long albumId , int? ownerId = null, string title = "", string description = "", PrivacyType? privacy = null, PrivacyType? commentPrivacy = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosEditAlbum(
                                    albumId,ownerId,title,description,privacy,commentPrivacy
                                )
                                )
                                ;
                            }
                                                public async Task <EntityList<Photo>>Get(  long? albumId = null, int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null, int? feed = null, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosGet(
                                    albumId,ownerId,photoIds,rev,extended,feedType,feed,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <EntityList<Photo>>Get(  SpecialAlbum albumId , int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null, int? feed = null, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosGet(
                                    albumId,ownerId,photoIds,rev,extended,feedType,feed,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <EntityList<PhotoAlbum>>GetAlbums(  int? ownerId = null, bool needSystem = true, bool needCovers = true, int offset = 0, int count = 100,params long[] albumIds  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosGetAlbums(
                                    ownerId,needSystem,needCovers,offset,count,albumIds
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <int>GetAlbumsCount(  int? userId = null, int? groupId = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosGetAlbumsCount(
                                    userId,groupId
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <EntityList<Photo>>GetAll(  int? ownerId = null, bool extended = false, bool noServiceAlbums = false, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosGetAll(
                                    ownerId,extended,noServiceAlbums,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <Photo[]>GetById( params ContentId[] photos  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosGetById(
                                    photos
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <PhotosUploadServer>GetChatUploadServer(  int chatId , int? cropX = null, int? cropY = null, int? cropWidth = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosGetChatUploadServer(
                                    chatId,cropX,cropY,cropWidth
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <string>GetOwnerPhotoUploadServer(  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosGetOwnerPhotoUploadServer(
                                    
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <PhotosUploadServer>GetUploadServer(  long albumId , int? groupId = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosGetUploadServer(
                                    albumId,groupId
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task MakeCover(  long albumId , long photoId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosMakeCover(
                                    albumId,photoId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task Move(  long targetAlbumId , long photoId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosMove(
                                    targetAlbumId,photoId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task RemoveTag(  int tagId , long photoId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosRemoveTag(
                                    tagId,photoId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task ReorderAlbums(  long albumId , int? ownerId = null, long? before = null, long? after = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosReorderAlbums(
                                    albumId,ownerId,before,after
                                )
                                )
                                ;
                            }
                                                public async Task ReorderPhotos(  long photoId , int? ownerId = null, long? before = null, long? after = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosReorderPhotos(
                                    photoId,ownerId,before,after
                                )
                                )
                                ;
                            }
                                                public async Task Report(  long photoId , int? ownerId = null, ReportReason? reason = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosReport(
                                    photoId,ownerId,reason
                                )
                                )
                                ;
                            }
                                                public async Task ReportComment(  int commentId , int? ownerId = null, ReportReason? reason = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosReportComment(
                                    commentId,ownerId,reason
                                )
                                )
                                ;
                            }
                                                public async Task RestoreComment(  int commentId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosRestoreComment(
                                    commentId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task <Photo[]>Save(  long albumId , string server , string photosList , string hash , int? groupId = null, double? latitude = null, double? longitude = null, string caption = "", string description = "" ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.PhotosSave(
                                    albumId,server,photosList,hash,groupId,latitude,longitude,caption,description
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                    }
                        public MethodGroup_stats Stats {get; private set;}
                public partial class MethodGroup_stats {
                    private readonly VKApi _parent;
                    internal MethodGroup_stats(VKApi parent){_parent=parent;}
                                                public async Task <int>TrackVisitor(  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.StatsTrackVisitor(
                                    
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                    }
                        public MethodGroup_status Status {get; private set;}
                public partial class MethodGroup_status {
                    private readonly VKApi _parent;
                    internal MethodGroup_status(VKApi parent){_parent=parent;}
                                                public async Task <Status[]>Get(  int? userId = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.StatusGet(
                                    userId
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task Set(  string text  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.StatusSet(
                                    text
                                )
                                )
                                ;
                            }
                                    }
                        public MethodGroup_storage Storage {get; private set;}
                public partial class MethodGroup_storage {
                    private readonly VKApi _parent;
                    internal MethodGroup_storage(VKApi parent){_parent=parent;}
                                                public async Task <StorageEntry[]>Get(  int? userId = null, bool global = false,params string[] keys  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.StorageGet(
                                    userId,global,keys
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <string[]>GetKeys(  int? userId = null, bool global = false, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.StorageGetKeys(
                                    userId,global,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <StorageEntry[]>Set(  string key , string value , int? userId = null, bool global = false ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.StorageSet(
                                    key,value,userId,global
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                    }
                        public MethodGroup_users Users {get; private set;}
                public partial class MethodGroup_users {
                    private readonly VKApi _parent;
                    internal MethodGroup_users(VKApi parent){_parent=parent;}
                                                public async Task <User[]>Get(  UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom,params int[] userIds  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.UsersGet(
                                    fields,nameCase,userIds
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <EntityList<User>>GetFollowers(  int? userId = null, UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.UsersGetFollowers(
                                    userId,fields,nameCase,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <EntityList<User>>GetNearby(  double latitude , double longitude , int? accuracy = null, int? timeout = null, byte? radius = null, UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.UsersGetNearby(
                                    latitude,longitude,accuracy,timeout,radius,fields,nameCase,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <UserSubscriptions>GetSubscriptions(  int? userId = null, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.UsersGetSubscriptions(
                                    userId,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <bool>IsAppUser(  int? userId = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.UsersIsAppUser(
                                    userId
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task Report(  int userId , ComplaintType type , string comment  ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.UsersReport(
                                    userId,type,comment
                                )
                                )
                                ;
                            }
                                                public async Task <EntityList<User>>Search(  string query = "", SearchSortOrder sort = SearchSortOrder.ByRating, ushort? offset = null, ushort? count = null, UserFields fields = UserFields.None, int? cityId = null, int? countryId = null, string hometown = "", int? universityCountryId = null, int? universityId = null, int? universityYear = null, Sex? sex = null, Relation? relation = null, byte? ageFrom = null, byte? ageTo = null, byte? birthDay = null, byte? birthMonth = null, ushort? birthYear = null, bool? online = null, bool? hasPhoto = null, int? schoolCountryId = null, int? schoolCityId = null, int? schoolId = null, int? schoolYear = null, string religion = "", string interests = "", string company = "", string position = "", int? groupId = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.UsersSearch(
                                    query,sort,offset,count,fields,cityId,countryId,hometown,universityCountryId,universityId,universityYear,sex,relation,ageFrom,ageTo,birthDay,birthMonth,birthYear,online,hasPhoto,schoolCountryId,schoolCityId,schoolId,schoolYear,religion,interests,company,position,groupId
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                    }
                        public MethodGroup_utils Utils {get; private set;}
                public partial class MethodGroup_utils {
                    private readonly VKApi _parent;
                    internal MethodGroup_utils(VKApi parent){_parent=parent;}
                                                public async Task <LinkCheckResult>CheckLink(  string url  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.UtilsCheckLink(
                                    url
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <int>GetServerTime(  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.UtilsGetServerTime(
                                    
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <ResolveResult>ResolveScreenName(  string sreenName  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.UtilsResolveScreenName(
                                    sreenName
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                    }
                        public MethodGroup_video Video {get; private set;}
                public partial class MethodGroup_video {
                    private readonly VKApi _parent;
                    internal MethodGroup_video(VKApi parent){_parent=parent;}
                                                public async Task Delete(  ulong videoId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.VideoDelete(
                                    videoId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task DeleteAlbum(  long albumId , int? groupId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.VideoDeleteAlbum(
                                    albumId,groupId
                                )
                                )
                                ;
                            }
                                                public async Task DeleteComment(  int commentId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.VideoDeleteComment(
                                    commentId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task RemoveTag(  ulong videoId , int tagId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.VideoRemoveTag(
                                    videoId,tagId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task Report(  ulong videoId , int? ownerId = null, ReportReason? reason = null, string comment = "", string searchQuery = "" ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.VideoReport(
                                    videoId,ownerId,reason,comment,searchQuery
                                )
                                )
                                ;
                            }
                                                public async Task ReportComment(  int commentId , int? ownerId = null, ReportReason? reason = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.VideoReportComment(
                                    commentId,ownerId,reason
                                )
                                )
                                ;
                            }
                                                public async Task RestoreComment(  int commentId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.VideoRestoreComment(
                                    commentId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task Restore(  long videoId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.VideoRestore(
                                    videoId,ownerId
                                )
                                )
                                ;
                            }
                                    }
                        public MethodGroup_wall Wall {get; private set;}
                public partial class MethodGroup_wall {
                    private readonly VKApi _parent;
                    internal MethodGroup_wall(VKApi parent){_parent=parent;}
                                                public async Task Delete(  int postId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.WallDelete(
                                    postId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task DeleteComment(  int commentId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.WallDeleteComment(
                                    commentId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task <EntityList<Post>>Get(  int? ownerId = null, string domain = "", WallPostFilter filter = WallPostFilter.All, int offset = 0, int count = 100 ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.WallGet(
                                    ownerId,domain,filter,offset,count
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <Post[]>GetById(  int copyHistoryDepth = 2,params string[] posts  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.WallGetById(
                                    copyHistoryDepth,posts
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task <Post[]>GetById(  int copyHistoryDepth = 2,params Tuple<int,int>[] posts  ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.WallGetById(
                                    copyHistoryDepth,posts
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task Pin(  int postId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.WallPin(
                                    postId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task Post(  string attachments , string services , int? ownerId = null, bool? friendsOnly = false, bool fromGroup = false, string message = "", bool signed = false, int? publishDate = null, double? lat = null, double? @long = null, int? placeId = null, int? postId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.WallPost(
                                    attachments,services,ownerId,friendsOnly,fromGroup,message,signed,publishDate,lat,@long,placeId,postId
                                )
                                )
                                ;
                            }
                                                public async Task ReportComment(  int commentId , int? ownerId = null, ReportReason? reason = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.WallReportComment(
                                    commentId,ownerId,reason
                                )
                                )
                                ;
                            }
                                                public async Task ReportPost(  int postId , int? ownerId = null, ReportReason? reason = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.WallReportPost(
                                    postId,ownerId,reason
                                )
                                )
                                ;
                            }
                                                public async Task <RepostInfo>Repost(  string @object , string message = "", int? groupId = null ){
                                                                    return (
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.WallRepost(
                                    @object,message,groupId
                                )
                                )
                                                                    ).Response
                                ;
                            }
                                                public async Task Restore(  int postId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.WallRestore(
                                    postId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task RestoreComment(  int commentId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.WallRestoreComment(
                                    commentId,ownerId
                                )
                                )
                                ;
                            }
                                                public async Task Unpin(  int postId , int? ownerId = null ){
                                                                await _parent.Executor.ExecAsync(
                                _parent._reqapi.WallUnpin(
                                    postId,ownerId
                                )
                                )
                                ;
                            }
                                    }
            }
}