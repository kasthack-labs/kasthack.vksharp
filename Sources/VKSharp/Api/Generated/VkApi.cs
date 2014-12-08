
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
                            this.Status = new MethodGroup_status(this);
                            this.Stats = new MethodGroup_stats(this);
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
												public async Task SetNameInMenu(  string name  ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.AccountSetNameInMenu(
									name
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
												public async Task SetOffline(  ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.AccountSetOffline(
									
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
												public async Task SetSilenceMode(  string token , int time , uint? chatId = null, uint? userId = null, int sound = 0 ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.AccountSetSilenceMode(
									token,time,chatId,userId,sound
								)
								)
								;
							}
												public async Task <long>GetAppPermissions(  uint? userId = null ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.AccountGetAppPermissions(
									userId
								)
								)
																	).Response
								;
							}
												public async Task BanUser(  uint userId  ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.AccountBanUser(
									userId
								)
								)
								;
							}
												public async Task UnbanUser(  uint userId  ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.AccountUnbanUser(
									userId
								)
								)
								;
							}
												public async Task <User[]>GetBanned(  uint offset = 0, uint count = 20 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.AccountGetBanned(
									offset,count
								)
								)
																	).Response
								;
							}
												public async Task SetInfo(  uint? intro = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.AccountSetInfo(
									intro
								)
								)
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
												public async Task <int>AddAlbum(  string title , uint? groupId = 0 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.AudioAddAlbum(
									title,groupId
								)
								)
																	).Response
								;
							}
												public async Task <int>Add(  int ownerId , long audioId , uint? groupId = null ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.AudioAdd(
									ownerId,audioId,groupId
								)
								)
																	).Response
								;
							}
												public async Task DeleteAlbum(  long albumId , uint? groupId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.AudioDeleteAlbum(
									albumId,groupId
								)
								)
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
												public async Task <EntityList<AudioAlbum>>GetAlbums(  int? ownerId = null, uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.AudioGetAlbums(
									ownerId,offset,count
								)
								)
																	).Response
								;
							}
												public async Task <EntityList<Audio>>Get(  int? ownerId = null, long? albumId = null, ulong[] audioIds = null, bool needUser = false, uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.AudioGet(
									ownerId,albumId,audioIds,needUser,offset,count
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
												public async Task <string>GetUploadServer(  long albumId , uint? groupId = null ){
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
												public async Task <EntityList<Audio>>Search(  string q , bool autoComplete = true, bool lyrics = false, bool performerOnly = false, AudioSortOrder sort = AudioSortOrder.ByRating, bool searchOwn = false, uint offset = 0, uint count = 100 ){
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
												public async Task <ConfirmResult>Confirm(  uint clientId , string clientSecret , string phone , string code , string password = "", bool testMode = false, int? intro = null ){
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
												public async Task CloseTopic(  uint groupId , uint topicId  ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.BoardCloseTopic(
									groupId,topicId
								)
								)
								;
							}
												public async Task DeleteComment(  uint groupId , uint topicId , uint commentId  ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.BoardDeleteComment(
									groupId,topicId,commentId
								)
								)
								;
							}
												public async Task DeleteTopic(  uint groupId , uint topicId  ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.BoardDeleteTopic(
									groupId,topicId
								)
								)
								;
							}
												public async Task FixTopic(  uint groupId , uint topicId  ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.BoardFixTopic(
									groupId,topicId
								)
								)
								;
							}
												public async Task UnfixTopic(  uint groupId , uint topicId  ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.BoardUnfixTopic(
									groupId,topicId
								)
								)
								;
							}
												public async Task RestoreComment(  uint groupId , uint topicId , uint commentId  ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.BoardRestoreComment(
									groupId,topicId,commentId
								)
								)
								;
							}
									}
						public MethodGroup_database Database {get; private set;}
				public partial class MethodGroup_database {
					private readonly VKApi _parent;
					internal MethodGroup_database(VKApi parent){_parent=parent;}
												public async Task <EntityList<DatabaseEntry>>GetCountries(  string code = "", bool needAll = false, uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.DatabaseGetCountries(
									code,needAll,offset,count
								)
								)
																	).Response
								;
							}
												public async Task <EntityList<DatabaseEntry>>GetRegions(  uint countryId , string q = "", uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.DatabaseGetRegions(
									countryId,q,offset,count
								)
								)
																	).Response
								;
							}
												public async Task <DatabaseEntry[]>GetStreetsById( params uint[] streetIds  ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.DatabaseGetStreetsById(
									streetIds
								)
								)
																	).Response
								;
							}
												public async Task <DatabaseEntry[]>GetCountriesById( params uint[] countryIds  ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.DatabaseGetCountriesById(
									countryIds
								)
								)
																	).Response
								;
							}
												public async Task <DatabaseCity[]>GetCitiesById( params uint[] cityIds  ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.DatabaseGetCitiesById(
									cityIds
								)
								)
																	).Response
								;
							}
												public async Task <DatabaseCity[]>GetCities(  uint countryId , uint? regionId = null, string q = "", bool needAll = false, uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.DatabaseGetCities(
									countryId,regionId,q,needAll,offset,count
								)
								)
																	).Response
								;
							}
												public async Task <DatabaseEntry[]>GetUniversities(  uint? countryId = null, uint? cityId = null, string q = "", uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.DatabaseGetUniversities(
									countryId,cityId,q,offset,count
								)
								)
																	).Response
								;
							}
												public async Task <DatabaseEntry[]>GetSchools(  uint? cityId = null, string q = "", uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.DatabaseGetSchools(
									cityId,q,offset,count
								)
								)
																	).Response
								;
							}
												public async Task <EntityList<DatabaseEntry>>GetFaculties(  uint universityId , uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.DatabaseGetFaculties(
									universityId,offset,count
								)
								)
																	).Response
								;
							}
												public async Task <EntityList<DatabaseEntry>>GetChairs(  uint facultyId , uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.DatabaseGetChairs(
									facultyId,offset,count
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
												public async Task <string>GetUploadServer(  uint? groupId = null ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.DocsGetUploadServer(
									groupId
								)
								)
																	).Response
								;
							}
												public async Task <string>GetWallUploadServer(  uint? groupId = null ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.DocsGetWallUploadServer(
									groupId
								)
								)
																	).Response
								;
							}
												public async Task <EntityList<Document>>Get(  int? ownerId = null, uint offset = 0, uint count = 100 ){
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
												public async Task <EntityList<User>>Get(  uint? userId = null, uint? listId = null, UserFields fields = UserFields.None, UserSortOrder order = UserSortOrder.ById, NameCase nameCase = NameCase.Nom, uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.FriendsGet(
									userId,listId,fields,order,nameCase,offset,count
								)
								)
																	).Response
								;
							}
												public async Task <EntityList<User>>GetSuggestions(  FriendSuggestionFilters filters = FriendSuggestionFilters.Everything, UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.FriendsGetSuggestions(
									filters,fields,nameCase,offset,count
								)
								)
																	).Response
								;
							}
												public async Task <User[]>GetByPhones(  UserFields fields = UserFields.None, ulong[] phones = null ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.FriendsGetByPhones(
									fields,phones
								)
								)
																	).Response
								;
							}
												public async Task <int>Add(  uint userId , string text = "" ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.FriendsAdd(
									userId,text
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
												public async Task <int[]>GetRecent(  uint count = 20 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.FriendsGetRecent(
									count
								)
								)
																	).Response
								;
							}
												public async Task <int>Delete(  uint userId  ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.FriendsDelete(
									userId
								)
								)
																	).Response
								;
							}
												public async Task DeleteList(  uint listId  ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.FriendsDeleteList(
									listId
								)
								)
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
												public async Task <int[]>GetMutual(  uint targetUid , uint? sourceUid = null, bool order = false, uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.FriendsGetMutual(
									targetUid,sourceUid,order,offset,count
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
												public async Task <User[]>GetBanned(  uint groupId , uint offset = 0, uint count = 100 ){
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
												public async Task <Group[]>GetById(  uint groupId , GroupFields fields  ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.GroupsGetById(
									groupId,fields
								)
								)
																	).Response
								;
							}
												public async Task <EntityList<User>>GetMembers(  uint groupId , UserFields fields = UserFields.Everything, uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.GroupsGetMembers(
									groupId,fields,offset,count
								)
								)
																	).Response
								;
							}
												public async Task <EntityList<User>>GetMembers(  string groupId , UserFields fields = UserFields.None, uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.GroupsGetMembers(
									groupId,fields,offset,count
								)
								)
																	).Response
								;
							}
												public async Task <MemberShip[]>IsMember(  uint groupId , bool extended = false,params uint[] userIds  ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.GroupsIsMember(
									groupId,extended,userIds
								)
								)
																	).Response
								;
							}
												public async Task Join(  uint groupId , bool notSure = false ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.GroupsJoin(
									groupId,notSure
								)
								)
								;
							}
												public async Task Leave(  uint groupId  ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.GroupsLeave(
									groupId
								)
								)
								;
							}
												public async Task UnbanUser(  uint groupId , uint userId  ){
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
												public async Task AddChatUser(  uint userId , uint? chatId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.MessagesAddChatUser(
									userId,chatId
								)
								)
								;
							}
												public async Task RemoveChatUser(  uint userId , uint chatId  ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.MessagesRemoveChatUser(
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
												public async Task MarkAsRead(  uint userId , uint? startMessageId = null,params int[] messageIds  ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.MessagesMarkAsRead(
									userId,startMessageId,messageIds
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
												public async Task GetLastActivity(  int userId  ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.MessagesGetLastActivity(
									userId
								)
								)
								;
							}
												public async Task DeleteDialog(  uint userId , uint offset = 0, uint count = 100 ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.MessagesDeleteDialog(
									userId,offset,count
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
									}
						public MethodGroup_newsfeed Newsfeed {get; private set;}
				public partial class MethodGroup_newsfeed {
					private readonly VKApi _parent;
					internal MethodGroup_newsfeed(VKApi parent){_parent=parent;}
												public async Task AddBan(  uint[] userIds = null, uint[] groupIds = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.NewsfeedAddBan(
									userIds,groupIds
								)
								)
								;
							}
												public async Task DeleteBan(  uint[] userIds = null, uint[] groupIds = null ){
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
												public async Task Delete(  uint noteId  ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.NotesDelete(
									noteId
								)
								)
								;
							}
												public async Task DeleteComment(  uint commentId , int? ownerId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.NotesDeleteComment(
									commentId,ownerId
								)
								)
								;
							}
												public async Task RestoreComment(  uint commentId , int? ownerId = null ){
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
												public async Task DeleteComment(  uint commentId , int? ownerId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.PhotosDeleteComment(
									commentId,ownerId
								)
								)
								;
							}
												public async Task RestoreComment(  uint commentId , int? ownerId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.PhotosRestoreComment(
									commentId,ownerId
								)
								)
								;
							}
												public async Task ReportComment(  uint commentId , int? ownerId = null, ReportReason? reason = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.PhotosReportComment(
									commentId,ownerId,reason
								)
								)
								;
							}
												public async Task DeleteAlbum(  long albumId , uint? groupId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.PhotosDeleteAlbum(
									albumId,groupId
								)
								)
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
												public async Task ConfirmTag(  uint tagId , long photoId , int? ownerId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.PhotosConfirmTag(
									tagId,photoId,ownerId
								)
								)
								;
							}
												public async Task RemoveTag(  uint tagId , long photoId , int? ownerId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.PhotosRemoveTag(
									tagId,photoId,ownerId
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
												public async Task Copy(  long photoId , int? ownerId = null, string accessKey = "" ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.PhotosCopy(
									photoId,ownerId,accessKey
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
												public async Task <int>GetAlbumsCount(  uint? userId = null, uint? groupId = null ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.PhotosGetAlbumsCount(
									userId,groupId
								)
								)
																	).Response
								;
							}
												public async Task <PhotoAlbum>CreateAlbum(  string title , string description = "", uint? groupId = null, PrivacyType? privacy = null, PrivacyType? commentPrivacy = null ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.PhotosCreateAlbum(
									title,description,groupId,privacy,commentPrivacy
								)
								)
																	).Response
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
												public async Task <string>GetOwnerPhotoUploadServer(  ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.PhotosGetOwnerPhotoUploadServer(
									
								)
								)
																	).Response
								;
							}
												public async Task <PhotosUploadServer>GetUploadServer(  long albumId , uint? groupId = null ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.PhotosGetUploadServer(
									albumId,groupId
								)
								)
																	).Response
								;
							}
												public async Task <PhotosUploadServer>GetChatUploadServer(  uint chatId , uint? cropX = null, uint? cropY = null, uint? cropWidth = null ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.PhotosGetChatUploadServer(
									chatId,cropX,cropY,cropWidth
								)
								)
																	).Response
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
												public async Task Move(  long targetAlbumId , long photoId , int? ownerId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.PhotosMove(
									targetAlbumId,photoId,ownerId
								)
								)
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
												public async Task <EntityList<Photo>>GetAll(  int? ownerId = null, bool extended = false, bool noServiceAlbums = false, uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.PhotosGetAll(
									ownerId,extended,noServiceAlbums,offset,count
								)
								)
																	).Response
								;
							}
												public async Task <EntityList<Photo>>Get(  long? albumId = null, int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null, uint? feed = null, uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.PhotosGet(
									albumId,ownerId,photoIds,rev,extended,feedType,feed,offset,count
								)
								)
																	).Response
								;
							}
												public async Task <EntityList<Photo>>Get(  SpecialAlbum albumId , int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null, uint? feed = null, uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.PhotosGet(
									albumId,ownerId,photoIds,rev,extended,feedType,feed,offset,count
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
												public async Task <EntityList<PhotoAlbum>>GetAlbums(  int? ownerId = null, bool needSystem = true, bool needCovers = true, uint offset = 0, uint count = 100,params long[] albumIds  ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.PhotosGetAlbums(
									ownerId,needSystem,needCovers,offset,count,albumIds
								)
								)
																	).Response
								;
							}
												public async Task <Photo[]>Save(  long albumId , string server , string photosList , string hash , uint? groupId = null, double? latitude = null, double? longitude = null, string caption = "", string description = "" ){
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
						public MethodGroup_storage Storage {get; private set;}
				public partial class MethodGroup_storage {
					private readonly VKApi _parent;
					internal MethodGroup_storage(VKApi parent){_parent=parent;}
												public async Task <StorageEntry[]>Get(  uint? userId = null, bool global = false,params string[] keys  ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.StorageGet(
									userId,global,keys
								)
								)
																	).Response
								;
							}
												public async Task <string[]>GetKeys(  uint? userId = null, bool global = false, uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.StorageGetKeys(
									userId,global,offset,count
								)
								)
																	).Response
								;
							}
												public async Task <StorageEntry[]>Set(  string key , string value , uint? userId = null, bool global = false ){
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
												public async Task <bool>IsAppUser(  uint? userId = null ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.UsersIsAppUser(
									userId
								)
								)
																	).Response
								;
							}
												public async Task Report(  uint userId , ComplaintType type , string comment  ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.UsersReport(
									userId,type,comment
								)
								)
								;
							}
												public async Task <UserSubscriptions>GetSubscriptions(  uint? userId = null, uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.UsersGetSubscriptions(
									userId,offset,count
								)
								)
																	).Response
								;
							}
												public async Task <User[]>Get(  UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom,params uint[] userIds  ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.UsersGet(
									fields,nameCase,userIds
								)
								)
																	).Response
								;
							}
												public async Task <EntityList<User>>GetFollowers(  uint? userId = null, UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.UsersGetFollowers(
									userId,fields,nameCase,offset,count
								)
								)
																	).Response
								;
							}
												public async Task <EntityList<User>>GetNearby(  double latitude , double longitude , uint? accuracy = null, uint? timeout = null, byte? radius = null, UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.UsersGetNearby(
									latitude,longitude,accuracy,timeout,radius,fields,nameCase,offset,count
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
												public async Task <LinkCheckResult>CheckLink(  string url = "" ){
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
									}
						public MethodGroup_video Video {get; private set;}
				public partial class MethodGroup_video {
					private readonly VKApi _parent;
					internal MethodGroup_video(VKApi parent){_parent=parent;}
												public async Task DeleteComment(  uint commentId , int? ownerId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.VideoDeleteComment(
									commentId,ownerId
								)
								)
								;
							}
												public async Task RestoreComment(  uint commentId , int? ownerId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.VideoRestoreComment(
									commentId,ownerId
								)
								)
								;
							}
												public async Task ReportComment(  uint commentId , int? ownerId = null, ReportReason? reason = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.VideoReportComment(
									commentId,ownerId,reason
								)
								)
								;
							}
												public async Task DeleteAlbum(  long albumId , uint? groupId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.VideoDeleteAlbum(
									albumId,groupId
								)
								)
								;
							}
												public async Task Delete(  ulong videoId , int? ownerId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.VideoDelete(
									videoId,ownerId
								)
								)
								;
							}
												public async Task RemoveTag(  ulong videoId , uint tagId , int? ownerId = null ){
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
									}
						public MethodGroup_wall Wall {get; private set;}
				public partial class MethodGroup_wall {
					private readonly VKApi _parent;
					internal MethodGroup_wall(VKApi parent){_parent=parent;}
												public async Task Delete(  uint postId , int? ownerId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.WallDelete(
									postId,ownerId
								)
								)
								;
							}
												public async Task Restore(  uint postId , int? ownerId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.WallRestore(
									postId,ownerId
								)
								)
								;
							}
												public async Task DeleteComment(  uint commentId , int? ownerId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.WallDeleteComment(
									commentId,ownerId
								)
								)
								;
							}
												public async Task RestoreComment(  uint commentId , int? ownerId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.WallRestoreComment(
									commentId,ownerId
								)
								)
								;
							}
												public async Task ReportPost(  uint postId , int? ownerId = null, ReportReason? reason = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.WallReportPost(
									postId,ownerId,reason
								)
								)
								;
							}
												public async Task ReportComment(  uint commentId , int? ownerId = null, ReportReason? reason = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.WallReportComment(
									commentId,ownerId,reason
								)
								)
								;
							}
												public async Task <Post[]>GetById(  uint copyHistoryDepth = 2,params string[] posts  ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.WallGetById(
									copyHistoryDepth,posts
								)
								)
																	).Response
								;
							}
												public async Task <Post[]>GetById(  uint copyHistoryDepth = 2,params Tuple<int,uint>[] posts  ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.WallGetById(
									copyHistoryDepth,posts
								)
								)
																	).Response
								;
							}
												public async Task <EntityList<Post>>Get(  int? ownerId = null, string domain = "", WallPostFilter filter = WallPostFilter.All, uint offset = 0, uint count = 100 ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.WallGet(
									ownerId,domain,filter,offset,count
								)
								)
																	).Response
								;
							}
												public async Task Pin(  uint postId , int? ownerId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.WallPin(
									postId,ownerId
								)
								)
								;
							}
												public async Task Unpin(  uint postId , int? ownerId = null ){
																await _parent.Executor.ExecAsync(
								_parent._reqapi.WallUnpin(
									postId,ownerId
								)
								)
								;
							}
												public async Task <RepostInfo>Repost(  string @object , string message = "", uint? groupId = null ){
																	return (
																await _parent.Executor.ExecAsync(
								_parent._reqapi.WallRepost(
									@object,message,groupId
								)
								)
																	).Response
								;
							}
									}
			}
}