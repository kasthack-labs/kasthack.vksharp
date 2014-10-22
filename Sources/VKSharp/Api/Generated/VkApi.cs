
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
		public async Task AccountSetNameInMenuAsync(
			 string name 
			){
			await Executor.ExecAsync(
				_reqapi.AccountSetNameInMenu(
											name
									)
			);
		}
		public async Task AccountSetOnlineAsync(
			 bool voip = true
			){
			await Executor.ExecAsync(
				_reqapi.AccountSetOnline(
											voip
									)
			);
		}
		public async Task AccountSetOfflineAsync(
			){
			await Executor.ExecAsync(
				_reqapi.AccountSetOffline(
									)
			);
		}
		public async Task AccountUnregisterDeviceAsync(
			 string token 
			){
			await Executor.ExecAsync(
				_reqapi.AccountUnregisterDevice(
											token
									)
			);
		}
		public async Task AccountSetSilenceModeAsync(
			 string token ,
			 int time ,
			 uint? chatId = null,
			 uint? userId = null,
			 int sound = 0
			){
			await Executor.ExecAsync(
				_reqapi.AccountSetSilenceMode(
											token,
											time,
											chatId,
											userId,
											sound
									)
			);
		}
		public async Task<StructEntity<long>> AccountGetAppPermissionsAsync(
			 uint? userId = null
			){
			return (await Executor.ExecAsync(
				_reqapi.AccountGetAppPermissions(
											userId
									)
			)).Data.FirstOrDefault();
		}
		public async Task AccountBanUserAsync(
			 uint userId 
			){
			await Executor.ExecAsync(
				_reqapi.AccountBanUser(
											userId
									)
			);
		}
		public async Task AccountUnbanUserAsync(
			 uint userId 
			){
			await Executor.ExecAsync(
				_reqapi.AccountUnbanUser(
											userId
									)
			);
		}
		public async Task<User[]> AccountGetBannedAsync(
			 uint offset = 0,
			 uint count = 20
			){
			return (await Executor.ExecAsync(
				_reqapi.AccountGetBanned(
											offset,
											count
									)
			)).Data;
		}
		public async Task AccountSetInfoAsync(
			 uint? intro = null
			){
			await Executor.ExecAsync(
				_reqapi.AccountSetInfo(
											intro
									)
			);
		}
		public async Task<User> AccountGetProfileInfoAsync(
			){
			return (await Executor.ExecAsync(
				_reqapi.AccountGetProfileInfo(
									)
			)).Data.FirstOrDefault();
		}
		public async Task<StructEntity<int>> AudioAddAlbumAsync(
			 string title ,
			 uint? groupId = 0
			){
			return (await Executor.ExecAsync(
				_reqapi.AudioAddAlbum(
											title,
											groupId
									)
			)).Data.FirstOrDefault();
		}
		public async Task<StructEntity<int>> AudioAddAsync(
			 int ownerId ,
			 long audioId ,
			 uint? groupId = null
			){
			return (await Executor.ExecAsync(
				_reqapi.AudioAdd(
											ownerId,
											audioId,
											groupId
									)
			)).Data.FirstOrDefault();
		}
		public async Task AudioDeleteAlbumAsync(
			 long albumId ,
			 uint? groupId = null
			){
			await Executor.ExecAsync(
				_reqapi.AudioDeleteAlbum(
											albumId,
											groupId
									)
			);
		}
		public async Task AudioDeleteAsync(
			 long audioId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.AudioDelete(
											audioId,
											ownerId
									)
			);
		}
		public async Task<StructEntity<int>> AudioEditAsync(
			 int ownerId ,
			 long audioId ,
			 string artist = "",
			 string title = "",
			 string text = "",
			 AudioGenre? genreId = null,
			 bool? noSearch = null
			){
			return (await Executor.ExecAsync(
				_reqapi.AudioEdit(
											ownerId,
											audioId,
											artist,
											title,
											text,
											genreId,
											noSearch
									)
			)).Data.FirstOrDefault();
		}
		public async Task<EntityList<Audio>> AudioGetAsync(
			 int? ownerId = null,
			 long? albumId = null,
			 ulong[] audioIds = null,
			 bool needUser = false,
			 uint offset = 0,
			 uint count = 0
			){
			return (await Executor.ExecAsync(
				_reqapi.AudioGet(
											ownerId,
											albumId,
											audioIds,
											needUser,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task<Audio[]> AudioGetByIdAsync(
			 bool itunes = false,
			params string[] audios 
			){
			return (await Executor.ExecAsync(
				_reqapi.AudioGetById(
											itunes,
											audios
									)
			)).Data;
		}
		public async Task<Audio[]> AudioGetByIdAsync(
			 bool itunes = false,
			params Tuple<int, long>[] audios 
			){
			return (await Executor.ExecAsync(
				_reqapi.AudioGetById(
											itunes,
											audios
									)
			)).Data;
		}
		public async Task<StructEntity<int>> AudioGetCountAsync(
			 int? ownerId = null
			){
			return (await Executor.ExecAsync(
				_reqapi.AudioGetCount(
											ownerId
									)
			)).Data.FirstOrDefault();
		}
		public async Task<Lyrics> AudioGetLyricsAsync(
			 long lyricsId 
			){
			return (await Executor.ExecAsync(
				_reqapi.AudioGetLyrics(
											lyricsId
									)
			)).Data.FirstOrDefault();
		}
		public async Task<SimpleEntity<string>> AudioGetUploadServerAsync(
			 long albumId ,
			 uint? groupId = null
			){
			return (await Executor.ExecAsync(
				_reqapi.AudioGetUploadServer(
											albumId,
											groupId
									)
			)).Data.FirstOrDefault();
		}
		public async Task AudioReorderAsync(
			 long audioId ,
			 int? ownerId = null,
			 long? before = null,
			 long? after = null
			){
			await Executor.ExecAsync(
				_reqapi.AudioReorder(
											audioId,
											ownerId,
											before,
											after
									)
			);
		}
		public async Task<Audio> AudioRestoreAsync(
			 long audioId ,
			 int? ownerId = null
			){
			return (await Executor.ExecAsync(
				_reqapi.AudioRestore(
											audioId,
											ownerId
									)
			)).Data.FirstOrDefault();
		}
		public async Task<Audio[]> AudioSaveAsync(
			 string server ,
			 string audio ,
			 string hash ,
			 string artist = "",
			 string title = ""
			){
			return (await Executor.ExecAsync(
				_reqapi.AudioSave(
											server,
											audio,
											hash,
											artist,
											title
									)
			)).Data;
		}
		public async Task<EntityList<Audio>> AudioSearchAsync(
			 string q ,
			 bool autoComplete = true,
			 bool lyrics = false,
			 bool performerOnly = false,
			 AudioSortOrder sort = AudioSortOrder.ByRating,
			 bool searchOwn = false,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.AudioSearch(
											q,
											autoComplete,
											lyrics,
											performerOnly,
											sort,
											searchOwn,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task<StructEntity<bool>> AuthCheckPhoneAsync(
			 string phone ,
			 string clientSecret ,
			 int? clientId = null
			){
			return (await Executor.ExecAsync(
				_reqapi.AuthCheckPhone(
											phone,
											clientSecret,
											clientId
									)
			)).Data.FirstOrDefault();
		}
		public async Task<ConfirmResult> AuthConfirmAsync(
			 uint clientId ,
			 string clientSecret ,
			 string phone ,
			 string code ,
			 string password = "",
			 bool testMode = false,
			 int? intro = null
			){
			return (await Executor.ExecAsync(
				_reqapi.AuthConfirm(
											clientId,
											clientSecret,
											phone,
											code,
											password,
											testMode,
											intro
									)
			)).Data.FirstOrDefault();
		}
		public async Task<AuthRestore> AuthRestoreAsync(
			 long phone 
			){
			return (await Executor.ExecAsync(
				_reqapi.AuthRestore(
											phone
									)
			)).Data.FirstOrDefault();
		}
		public async Task BoardCloseTopicAsync(
			 uint groupId ,
			 uint topicId 
			){
			await Executor.ExecAsync(
				_reqapi.BoardCloseTopic(
											groupId,
											topicId
									)
			);
		}
		public async Task BoardDeleteCommentAsync(
			 uint groupId ,
			 uint topicId ,
			 uint commentId 
			){
			await Executor.ExecAsync(
				_reqapi.BoardDeleteComment(
											groupId,
											topicId,
											commentId
									)
			);
		}
		public async Task BoardDeleteTopicAsync(
			 uint groupId ,
			 uint topicId 
			){
			await Executor.ExecAsync(
				_reqapi.BoardDeleteTopic(
											groupId,
											topicId
									)
			);
		}
		public async Task BoardFixTopicAsync(
			 uint groupId ,
			 uint topicId 
			){
			await Executor.ExecAsync(
				_reqapi.BoardFixTopic(
											groupId,
											topicId
									)
			);
		}
		public async Task BoardUnfixTopicAsync(
			 uint groupId ,
			 uint topicId 
			){
			await Executor.ExecAsync(
				_reqapi.BoardUnfixTopic(
											groupId,
											topicId
									)
			);
		}
		public async Task BoardRestoreCommentAsync(
			 uint groupId ,
			 uint topicId ,
			 uint commentId 
			){
			await Executor.ExecAsync(
				_reqapi.BoardRestoreComment(
											groupId,
											topicId,
											commentId
									)
			);
		}
		public async Task<EntityList<DatabaseEntry>> DatabaseGetCountriesAsync(
			 string code = "",
			 bool needAll = false,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.DatabaseGetCountries(
											code,
											needAll,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task<EntityList<DatabaseEntry>> DatabaseGetRegionsAsync(
			 uint countryId ,
			 string q = "",
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.DatabaseGetRegions(
											countryId,
											q,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task<DatabaseEntry[]> DatabaseGetStreetsByIdAsync(
			params uint[] streetIds 
			){
			return (await Executor.ExecAsync(
				_reqapi.DatabaseGetStreetsById(
											streetIds
									)
			)).Data;
		}
		public async Task<EntityList<DatabaseEntry>[]> DatabaseGetCountriesByIdAsync(
			params uint[] countryIds 
			){
			return (await Executor.ExecAsync(
				_reqapi.DatabaseGetCountriesById(
											countryIds
									)
			)).Data;
		}
		public async Task<DatabaseCity[]> DatabaseGetCitiesByIdAsync(
			params uint[] cityIds 
			){
			return (await Executor.ExecAsync(
				_reqapi.DatabaseGetCitiesById(
											cityIds
									)
			)).Data;
		}
		public async Task<DatabaseCity[]> DatabaseGetCitiesAsync(
			 uint countryId ,
			 uint? regionId = null,
			 string q = "",
			 bool needAll = false,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.DatabaseGetCities(
											countryId,
											regionId,
											q,
											needAll,
											offset,
											count
									)
			)).Data;
		}
		public async Task<DatabaseEntry[]> DatabaseGetUniversitiesAsync(
			 uint? countryId = null,
			 uint? cityId = null,
			 string q = "",
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.DatabaseGetUniversities(
											countryId,
											cityId,
											q,
											offset,
											count
									)
			)).Data;
		}
		public async Task<DatabaseEntry[]> DatabaseGetSchoolsAsync(
			 uint? cityId = null,
			 string q = "",
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.DatabaseGetSchools(
											cityId,
											q,
											offset,
											count
									)
			)).Data;
		}
		public async Task<EntityList<DatabaseEntry>> DatabaseGetFacultiesAsync(
			 uint universityId ,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.DatabaseGetFaculties(
											universityId,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task<EntityList<DatabaseEntry>> DatabaseGetChairsAsync(
			 uint facultyId ,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.DatabaseGetChairs(
											facultyId,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task<StructEntity<int>> DocsAddAsync(
			 long docId ,
			 int ownerId ,
			 string accessKey = ""
			){
			return (await Executor.ExecAsync(
				_reqapi.DocsAdd(
											docId,
											ownerId,
											accessKey
									)
			)).Data.FirstOrDefault();
		}
		public async Task DocsDeleteAsync(
			 long docId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.DocsDelete(
											docId,
											ownerId
									)
			);
		}
		public async Task<SimpleEntity<string>> DocsGetUploadServerAsync(
			 uint? groupId = null
			){
			return (await Executor.ExecAsync(
				_reqapi.DocsGetUploadServer(
											groupId
									)
			)).Data.FirstOrDefault();
		}
		public async Task<SimpleEntity<string>> DocsGetWallUploadServerAsync(
			 uint? groupId = null
			){
			return (await Executor.ExecAsync(
				_reqapi.DocsGetWallUploadServer(
											groupId
									)
			)).Data.FirstOrDefault();
		}
		public async Task<EntityList<Document>> DocsGetAsync(
			 int? ownerId = null,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.DocsGet(
											ownerId,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task<Document[]> DocsGetByIdAsync(
			params Tuple<int,int>[] docs 
			){
			return (await Executor.ExecAsync(
				_reqapi.DocsGetById(
											docs
									)
			)).Data;
		}
		public async Task<Document[]> DocsSaveAsync(
			 string file ,
			 string title ,
			params string[] tags 
			){
			return (await Executor.ExecAsync(
				_reqapi.DocsSave(
											file,
											title,
											tags
									)
			)).Data;
		}
		public async Task<EntityList<User>> FriendsGetAsync(
			 uint? userId = null,
			 uint? listId = null,
			 UserFields fields = UserFields.None,
			 UserSortOrder order = UserSortOrder.ById,
			 NameCase nameCase = NameCase.Nom,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.FriendsGet(
											userId,
											listId,
											fields,
											order,
											nameCase,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task<EntityList<User>> FriendsGetSuggestionsAsync(
			 FriendSuggestionFilters filters = FriendSuggestionFilters.Everything,
			 UserFields fields = UserFields.None,
			 NameCase nameCase = NameCase.Nom,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.FriendsGetSuggestions(
											filters,
											fields,
											nameCase,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task<User[]> FriendsGetByPhonesAsync(
			 UserFields fields = UserFields.None,
			 ulong[] phones = null
			){
			return (await Executor.ExecAsync(
				_reqapi.FriendsGetByPhones(
											fields,
											phones
									)
			)).Data;
		}
		public async Task<StructEntity<int>> FriendsAddAsync(
			 uint userId ,
			 string text = ""
			){
			return (await Executor.ExecAsync(
				_reqapi.FriendsAdd(
											userId,
											text
									)
			)).Data.FirstOrDefault();
		}
		public async Task FriendsDeleteAllRequestsAsync(
			){
			await Executor.ExecAsync(
				_reqapi.FriendsDeleteAllRequests(
									)
			);
		}
		public async Task<StructEntity<int>[]> FriendsGetRecentAsync(
			 uint count = 20
			){
			return (await Executor.ExecAsync(
				_reqapi.FriendsGetRecent(
											count
									)
			)).Data;
		}
		public async Task<StructEntity<int>> FriendsDeleteAsync(
			 uint userId 
			){
			return (await Executor.ExecAsync(
				_reqapi.FriendsDelete(
											userId
									)
			)).Data.FirstOrDefault();
		}
		public async Task FriendsDeleteListAsync(
			 uint listId 
			){
			await Executor.ExecAsync(
				_reqapi.FriendsDeleteList(
											listId
									)
			);
		}
		public async Task<StructEntity<int>[]> FriendsGetAppUsersAsync(
			){
			return (await Executor.ExecAsync(
				_reqapi.FriendsGetAppUsers(
									)
			)).Data;
		}
		public async Task<StructEntity<int>[]> FriendsGetMutualAsync(
			 uint targetUid ,
			 uint? sourceUid = null,
			 bool order = false,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.FriendsGetMutual(
											targetUid,
											sourceUid,
											order,
											offset,
											count
									)
			)).Data;
		}
		public async Task<User[]> GroupsGetBannedAsync(
			 uint groupId ,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.GroupsGetBanned(
											groupId,
											offset,
											count
									)
			)).Data;
		}
		public async Task<Group[]> GroupsGetByIdAsync(
			 string[] groupIds ,
			 GroupFields fields 
			){
			return (await Executor.ExecAsync(
				_reqapi.GroupsGetById(
											groupIds,
											fields
									)
			)).Data;
		}
		public async Task<Group[]> GroupsGetByIdAsync(
			 uint groupId ,
			 GroupFields fields 
			){
			return (await Executor.ExecAsync(
				_reqapi.GroupsGetById(
											groupId,
											fields
									)
			)).Data;
		}
		public async Task<EntityList<User>> GroupsGetMembersAsync(
			 uint groupId ,
			 UserFields fields = UserFields.Everything,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.GroupsGetMembers(
											groupId,
											fields,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task<EntityList<User>> GroupsGetMembersAsync(
			 string groupId ,
			 UserFields fields = UserFields.None,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.GroupsGetMembers(
											groupId,
											fields,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task<MemberShip[]> GroupsIsMemberAsync(
			 uint groupId ,
			 bool extended = false,
			params uint[] userIds 
			){
			return (await Executor.ExecAsync(
				_reqapi.GroupsIsMember(
											groupId,
											extended,
											userIds
									)
			)).Data;
		}
		public async Task GroupsJoinAsync(
			 uint groupId ,
			 bool notSure = false
			){
			await Executor.ExecAsync(
				_reqapi.GroupsJoin(
											groupId,
											notSure
									)
			);
		}
		public async Task GroupsLeaveAsync(
			 uint groupId 
			){
			await Executor.ExecAsync(
				_reqapi.GroupsLeave(
											groupId
									)
			);
		}
		public async Task GroupsUnbanUserAsync(
			 uint groupId ,
			 uint userId 
			){
			await Executor.ExecAsync(
				_reqapi.GroupsUnbanUser(
											groupId,
											userId
									)
			);
		}
		public async Task MessagesAddChatUserAsync(
			 uint userId ,
			 uint? chatId = null
			){
			await Executor.ExecAsync(
				_reqapi.MessagesAddChatUser(
											userId,
											chatId
									)
			);
		}
		public async Task MessagesRemoveChatUserAsync(
			 uint userId ,
			 uint chatId 
			){
			await Executor.ExecAsync(
				_reqapi.MessagesRemoveChatUser(
											userId,
											chatId
									)
			);
		}
		public async Task MessagesDeleteAsync(
			params int[] messageIds 
			){
			await Executor.ExecAsync(
				_reqapi.MessagesDelete(
											messageIds
									)
			);
		}
		public async Task MessagesMarkAsReadAsync(
			 uint userId ,
			 uint? startMessageId = null,
			params int[] messageIds 
			){
			await Executor.ExecAsync(
				_reqapi.MessagesMarkAsRead(
											userId,
											startMessageId,
											messageIds
									)
			);
		}
		public async Task MessagesRestoreAsync(
			 int messageId 
			){
			await Executor.ExecAsync(
				_reqapi.MessagesRestore(
											messageId
									)
			);
		}
		public async Task MessagesDeleteDialogAsync(
			 uint userId ,
			 uint offset = 0,
			 uint count = 100
			){
			await Executor.ExecAsync(
				_reqapi.MessagesDeleteDialog(
											userId,
											offset,
											count
									)
			);
		}
		public async Task MessagesMarkAsImportantAsync(
			 bool important ,
			params int[] messageIds 
			){
			await Executor.ExecAsync(
				_reqapi.MessagesMarkAsImportant(
											important,
											messageIds
									)
			);
		}
		public async Task NewsfeedAddBanAsync(
			 uint[] userIds = null,
			 uint[] groupIds = null
			){
			await Executor.ExecAsync(
				_reqapi.NewsfeedAddBan(
											userIds,
											groupIds
									)
			);
		}
		public async Task NewsfeedDeleteBanAsync(
			 uint[] userIds = null,
			 uint[] groupIds = null
			){
			await Executor.ExecAsync(
				_reqapi.NewsfeedDeleteBan(
											userIds,
											groupIds
									)
			);
		}
		public async Task NotesDeleteAsync(
			 uint noteId 
			){
			await Executor.ExecAsync(
				_reqapi.NotesDelete(
											noteId
									)
			);
		}
		public async Task NotesDeleteCommentAsync(
			 uint commentId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.NotesDeleteComment(
											commentId,
											ownerId
									)
			);
		}
		public async Task NotesRestoreCommentAsync(
			 uint commentId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.NotesRestoreComment(
											commentId,
											ownerId
									)
			);
		}
		public async Task NotificationsMarkAsViewedAsync(
			){
			await Executor.ExecAsync(
				_reqapi.NotificationsMarkAsViewed(
									)
			);
		}
		public async Task PagesClearCacheAsync(
			 string url 
			){
			await Executor.ExecAsync(
				_reqapi.PagesClearCache(
											url
									)
			);
		}
		public async Task PhotosDeleteCommentAsync(
			 uint commentId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.PhotosDeleteComment(
											commentId,
											ownerId
									)
			);
		}
		public async Task PhotosRestoreCommentAsync(
			 uint commentId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.PhotosRestoreComment(
											commentId,
											ownerId
									)
			);
		}
		public async Task PhotosReportCommentAsync(
			 uint commentId ,
			 int? ownerId = null,
			 ReportReason? reason = null
			){
			await Executor.ExecAsync(
				_reqapi.PhotosReportComment(
											commentId,
											ownerId,
											reason
									)
			);
		}
		public async Task PhotosDeleteAlbumAsync(
			 long albumId ,
			 uint? groupId = null
			){
			await Executor.ExecAsync(
				_reqapi.PhotosDeleteAlbum(
											albumId,
											groupId
									)
			);
		}
		public async Task PhotosDeleteAsync(
			 long photoId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.PhotosDelete(
											photoId,
											ownerId
									)
			);
		}
		public async Task PhotosConfirmTagAsync(
			 uint tagId ,
			 long photoId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.PhotosConfirmTag(
											tagId,
											photoId,
											ownerId
									)
			);
		}
		public async Task PhotosRemoveTagAsync(
			 uint tagId ,
			 long photoId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.PhotosRemoveTag(
											tagId,
											photoId,
											ownerId
									)
			);
		}
		public async Task PhotosReportAsync(
			 long photoId ,
			 int? ownerId = null,
			 ReportReason? reason = null
			){
			await Executor.ExecAsync(
				_reqapi.PhotosReport(
											photoId,
											ownerId,
											reason
									)
			);
		}
		public async Task PhotosCopyAsync(
			 long photoId ,
			 int? ownerId = null,
			 string accessKey = ""
			){
			await Executor.ExecAsync(
				_reqapi.PhotosCopy(
											photoId,
											ownerId,
											accessKey
									)
			);
		}
		public async Task PhotosEditAsync(
			 long photoId ,
			 int? ownerId = null,
			 string caption = ""
			){
			await Executor.ExecAsync(
				_reqapi.PhotosEdit(
											photoId,
											ownerId,
											caption
									)
			);
		}
		public async Task<StructEntity<int>> PhotosGetAlbumsCountAsync(
			 uint? userId = null,
			 uint? groupId = null
			){
			return (await Executor.ExecAsync(
				_reqapi.PhotosGetAlbumsCount(
											userId,
											groupId
									)
			)).Data.FirstOrDefault();
		}
		public async Task<PhotoAlbum> PhotosCreateAlbumAsync(
			 string title ,
			 string description = "",
			 uint? groupId = null,
			 PrivacyType? privacy = null,
			 PrivacyType? commentPrivacy = null
			){
			return (await Executor.ExecAsync(
				_reqapi.PhotosCreateAlbum(
											title,
											description,
											groupId,
											privacy,
											commentPrivacy
									)
			)).Data.FirstOrDefault();
		}
		public async Task PhotosEditAlbumAsync(
			 long albumId ,
			 int? ownerId = null,
			 string title = "",
			 string description = "",
			 PrivacyType? privacy = null,
			 PrivacyType? commentPrivacy = null
			){
			await Executor.ExecAsync(
				_reqapi.PhotosEditAlbum(
											albumId,
											ownerId,
											title,
											description,
											privacy,
											commentPrivacy
									)
			);
		}
		public async Task<SimpleEntity<string>> PhotosGetOwnerPhotoUploadServerAsync(
			){
			return (await Executor.ExecAsync(
				_reqapi.PhotosGetOwnerPhotoUploadServer(
									)
			)).Data.FirstOrDefault();
		}
		public async Task<PhotosUploadServer> PhotosGetUploadServerAsync(
			 long albumId ,
			 uint? groupId = null
			){
			return (await Executor.ExecAsync(
				_reqapi.PhotosGetUploadServer(
											albumId,
											groupId
									)
			)).Data.FirstOrDefault();
		}
		public async Task<PhotosUploadServer> PhotosGetChatUploadServerAsync(
			 uint chatId ,
			 uint? cropX = null,
			 uint? cropY = null,
			 uint? cropWidth = null
			){
			return (await Executor.ExecAsync(
				_reqapi.PhotosGetChatUploadServer(
											chatId,
											cropX,
											cropY,
											cropWidth
									)
			)).Data.FirstOrDefault();
		}
		public async Task PhotosReorderAlbumsAsync(
			 long albumId ,
			 int? ownerId = null,
			 long? before = null,
			 long? after = null
			){
			await Executor.ExecAsync(
				_reqapi.PhotosReorderAlbums(
											albumId,
											ownerId,
											before,
											after
									)
			);
		}
		public async Task PhotosReorderPhotosAsync(
			 long photoId ,
			 int? ownerId = null,
			 long? before = null,
			 long? after = null
			){
			await Executor.ExecAsync(
				_reqapi.PhotosReorderPhotos(
											photoId,
											ownerId,
											before,
											after
									)
			);
		}
		public async Task PhotosMoveAsync(
			 long targetAlbumId ,
			 long photoId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.PhotosMove(
											targetAlbumId,
											photoId,
											ownerId
									)
			);
		}
		public async Task PhotosMakeCoverAsync(
			 long albumId ,
			 long photoId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.PhotosMakeCover(
											albumId,
											photoId,
											ownerId
									)
			);
		}
		public async Task<EntityList<Photo>> PhotosGetAllAsync(
			 int? ownerId = null,
			 bool extended = false,
			 bool noServiceAlbums = false,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.PhotosGetAll(
											ownerId,
											extended,
											noServiceAlbums,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task<EntityList<Photo>> PhotosGetAsync(
			 long? albumId = null,
			 int? ownerId = null,
			 int[] photoIds = null,
			 bool rev = true,
			 bool extended = false,
			 FeedType? feedType = null,
			 uint? feed = null,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.PhotosGet(
											albumId,
											ownerId,
											photoIds,
											rev,
											extended,
											feedType,
											feed,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task<EntityList<Photo>> PhotosGetAsync(
			 SpecialAlbum albumId ,
			 int? ownerId = null,
			 int[] photoIds = null,
			 bool rev = true,
			 bool extended = false,
			 FeedType? feedType = null,
			 uint? feed = null,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.PhotosGet(
											albumId,
											ownerId,
											photoIds,
											rev,
											extended,
											feedType,
											feed,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task<EntityList<PhotoAlbum>> PhotosGetAlbumsAsync(
			 int? ownerId = null,
			 bool needSystem = true,
			 bool needCovers = true,
			 uint offset = 0,
			 uint count = 100,
			params long[] albumIds 
			){
			return (await Executor.ExecAsync(
				_reqapi.PhotosGetAlbums(
											ownerId,
											needSystem,
											needCovers,
											offset,
											count,
											albumIds
									)
			)).Data.FirstOrDefault();
		}
		public async Task<Photo[]> PhotosSaveAsync(
			 long albumId ,
			 string server ,
			 string photosList ,
			 string hash ,
			 uint? groupId = null,
			 double? latitude = null,
			 double? longitude = null,
			 string caption = "",
			 string description = ""
			){
			return (await Executor.ExecAsync(
				_reqapi.PhotosSave(
											albumId,
											server,
											photosList,
											hash,
											groupId,
											latitude,
											longitude,
											caption,
											description
									)
			)).Data;
		}
		public async Task<Status[]> StatusGetAsync(
			 int? userId = null
			){
			return (await Executor.ExecAsync(
				_reqapi.StatusGet(
											userId
									)
			)).Data;
		}
		public async Task StatusSetAsync(
			 string text 
			){
			await Executor.ExecAsync(
				_reqapi.StatusSet(
											text
									)
			);
		}
		public async Task<StorageEntry[]> StorageGetAsync(
			 uint? userId = null,
			 bool global = false,
			params string[] keys 
			){
			return (await Executor.ExecAsync(
				_reqapi.StorageGet(
											userId,
											global,
											keys
									)
			)).Data;
		}
		public async Task<SimpleEntity<string>[]> StorageGetKeysAsync(
			 uint? userId = null,
			 bool global = false,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.StorageGetKeys(
											userId,
											global,
											offset,
											count
									)
			)).Data;
		}
		public async Task<StorageEntry[]> StorageSetAsync(
			 string key ,
			 string value ,
			 uint? userId = null,
			 bool global = false
			){
			return (await Executor.ExecAsync(
				_reqapi.StorageSet(
											key,
											value,
											userId,
											global
									)
			)).Data;
		}
		public async Task<StructEntity<bool>> UsersIsAppUserAsync(
			 uint? userId = null
			){
			return (await Executor.ExecAsync(
				_reqapi.UsersIsAppUser(
											userId
									)
			)).Data.FirstOrDefault();
		}
		public async Task UsersReportAsync(
			 uint userId ,
			 ComplaintType type ,
			 string comment 
			){
			await Executor.ExecAsync(
				_reqapi.UsersReport(
											userId,
											type,
											comment
									)
			);
		}
		public async Task<UserSubscriptions> UsersGetSubscriptionsAsync(
			 uint? userId = null,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.UsersGetSubscriptions(
											userId,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task<User[]> UsersGetAsync(
			 UserFields fields = UserFields.None,
			 NameCase nameCase = NameCase.Nom,
			params uint[] userIds 
			){
			return (await Executor.ExecAsync(
				_reqapi.UsersGet(
											fields,
											nameCase,
											userIds
									)
			)).Data;
		}
		public async Task<EntityList<User>> UsersGetFollowersAsync(
			 uint? userId = null,
			 UserFields fields = UserFields.None,
			 NameCase nameCase = NameCase.Nom,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.UsersGetFollowers(
											userId,
											fields,
											nameCase,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task<EntityList<User>> UsersGetNearbyAsync(
			 double latitude ,
			 double longitude ,
			 uint? accuracy = null,
			 uint? timeout = null,
			 byte? radius = null,
			 UserFields fields = UserFields.None,
			 NameCase nameCase = NameCase.Nom,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.UsersGetNearby(
											latitude,
											longitude,
											accuracy,
											timeout,
											radius,
											fields,
											nameCase,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task<LinkCheckResult> UtilsCheckLinkAsync(
			 string url = ""
			){
			return (await Executor.ExecAsync(
				_reqapi.UtilsCheckLink(
											url
									)
			)).Data.FirstOrDefault();
		}
		public async Task<StructEntity<int>> UtilsGetServerTimeAsync(
			){
			return (await Executor.ExecAsync(
				_reqapi.UtilsGetServerTime(
									)
			)).Data.FirstOrDefault();
		}
		public async Task VideoDeleteCommentAsync(
			 uint commentId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.VideoDeleteComment(
											commentId,
											ownerId
									)
			);
		}
		public async Task VideoRestoreCommentAsync(
			 uint commentId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.VideoRestoreComment(
											commentId,
											ownerId
									)
			);
		}
		public async Task VideoReportCommentAsync(
			 uint commentId ,
			 int? ownerId = null,
			 ReportReason? reason = null
			){
			await Executor.ExecAsync(
				_reqapi.VideoReportComment(
											commentId,
											ownerId,
											reason
									)
			);
		}
		public async Task VideoDeleteAlbumAsync(
			 long albumId ,
			 uint? groupId = null
			){
			await Executor.ExecAsync(
				_reqapi.VideoDeleteAlbum(
											albumId,
											groupId
									)
			);
		}
		public async Task VideoDeleteAsync(
			 ulong videoId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.VideoDelete(
											videoId,
											ownerId
									)
			);
		}
		public async Task VideoRemoveTagAsync(
			 ulong videoId ,
			 uint tagId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.VideoRemoveTag(
											videoId,
											tagId,
											ownerId
									)
			);
		}
		public async Task VideoReportAsync(
			 ulong videoId ,
			 int? ownerId = null,
			 ReportReason? reason = null,
			 string comment = "",
			 string searchQuery = ""
			){
			await Executor.ExecAsync(
				_reqapi.VideoReport(
											videoId,
											ownerId,
											reason,
											comment,
											searchQuery
									)
			);
		}
		public async Task WallDeleteAsync(
			 uint postId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.WallDelete(
											postId,
											ownerId
									)
			);
		}
		public async Task WallRestoreAsync(
			 uint postId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.WallRestore(
											postId,
											ownerId
									)
			);
		}
		public async Task WallDeleteCommentAsync(
			 uint commentId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.WallDeleteComment(
											commentId,
											ownerId
									)
			);
		}
		public async Task WallRestoreCommentAsync(
			 uint commentId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.WallRestoreComment(
											commentId,
											ownerId
									)
			);
		}
		public async Task WallReportPostAsync(
			 uint postId ,
			 int? ownerId = null,
			 ReportReason? reason = null
			){
			await Executor.ExecAsync(
				_reqapi.WallReportPost(
											postId,
											ownerId,
											reason
									)
			);
		}
		public async Task WallReportCommentAsync(
			 uint commentId ,
			 int? ownerId = null,
			 ReportReason? reason = null
			){
			await Executor.ExecAsync(
				_reqapi.WallReportComment(
											commentId,
											ownerId,
											reason
									)
			);
		}
		public async Task<Post[]> WallGetByIdAsync(
			 uint copyHistoryDepth = 2,
			params string[] posts 
			){
			return (await Executor.ExecAsync(
				_reqapi.WallGetById(
											copyHistoryDepth,
											posts
									)
			)).Data;
		}
		public async Task<Post[]> WallGetByIdAsync(
			 uint copyHistoryDepth = 2,
			params Tuple<int,uint>[] posts 
			){
			return (await Executor.ExecAsync(
				_reqapi.WallGetById(
											copyHistoryDepth,
											posts
									)
			)).Data;
		}
		public async Task<EntityList<Post>> WallGetAsync(
			 int? ownerId = null,
			 string domain = "",
			 WallPostFilter filter = WallPostFilter.All,
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.WallGet(
											ownerId,
											domain,
											filter,
											offset,
											count
									)
			)).Data.FirstOrDefault();
		}
		public async Task WallPinAsync(
			 uint postId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.WallPin(
											postId,
											ownerId
									)
			);
		}
		public async Task WallUnpinAsync(
			 uint postId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.WallUnpin(
											postId,
											ownerId
									)
			);
		}
		public async Task<RepostInfo> WallRepostAsync(
			 string @object ,
			 string message = "",
			 uint? groupId = null
			){
			return (await Executor.ExecAsync(
				_reqapi.WallRepost(
											@object,
											message,
											groupId
									)
			)).Data.FirstOrDefault();
		}
	}
}