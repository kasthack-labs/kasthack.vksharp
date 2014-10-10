
using System;
using System.Threading.Tasks;
using VKSharp.Core.Enums;
using VKSharp.Data.Parameters;

// ReSharper disable UnusedMember.Global
namespace VKSharp {
	public partial class RawApi {
		public async Task<string> AccountSetNameInMenuAsync(
			 string name 
			){
			return await Executor.ExecRawAsync(
				_reqapi.AccountSetNameInMenu(
											name
									)
			);
		}
		public async Task<string> AccountSetOnlineAsync(
			 bool voip = true
			){
			return await Executor.ExecRawAsync(
				_reqapi.AccountSetOnline(
											voip
									)
			);
		}
		public async Task<string> AccountSetOfflineAsync(
			){
			return await Executor.ExecRawAsync(
				_reqapi.AccountSetOffline(
									)
			);
		}
		public async Task<string> AccountUnregisterDeviceAsync(
			 string token 
			){
			return await Executor.ExecRawAsync(
				_reqapi.AccountUnregisterDevice(
											token
									)
			);
		}
		public async Task<string> AccountSetSilenceModeAsync(
			 string token ,
			 int time ,
			 uint? chatId = null,
			 uint? userId = null,
			 int sound = 0
			){
			return await Executor.ExecRawAsync(
				_reqapi.AccountSetSilenceMode(
											token,
											time,
											chatId,
											userId,
											sound
									)
			);
		}
		public async Task<string> AccountGetAppPermissionsAsync(
			 uint? userId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.AccountGetAppPermissions(
											userId
									)
			);
		}
		public async Task<string> AccountBanUserAsync(
			 uint userId 
			){
			return await Executor.ExecRawAsync(
				_reqapi.AccountBanUser(
											userId
									)
			);
		}
		public async Task<string> AccountUnbanUserAsync(
			 uint userId 
			){
			return await Executor.ExecRawAsync(
				_reqapi.AccountUnbanUser(
											userId
									)
			);
		}
		public async Task<string> AccountGetBannedAsync(
			 uint offset = 0,
			 uint count = 20
			){
			return await Executor.ExecRawAsync(
				_reqapi.AccountGetBanned(
											offset,
											count
									)
			);
		}
		public async Task<string> AccountSetInfoAsync(
			 uint? intro = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.AccountSetInfo(
											intro
									)
			);
		}
		public async Task<string> AccountGetProfileInfoAsync(
			){
			return await Executor.ExecRawAsync(
				_reqapi.AccountGetProfileInfo(
									)
			);
		}
		public async Task<string> AudioAddAlbumAsync(
			 string title ,
			 uint? groupId = 0
			){
			return await Executor.ExecRawAsync(
				_reqapi.AudioAddAlbum(
											title,
											groupId
									)
			);
		}
		public async Task<string> AudioAddAsync(
			 int ownerId ,
			 long audioId ,
			 uint? groupId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.AudioAdd(
											ownerId,
											audioId,
											groupId
									)
			);
		}
		public async Task<string> AudioDeleteAlbumAsync(
			 long albumId ,
			 uint? groupId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.AudioDeleteAlbum(
											albumId,
											groupId
									)
			);
		}
		public async Task<string> AudioDeleteAsync(
			 long audioId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.AudioDelete(
											audioId,
											ownerId
									)
			);
		}
		public async Task<string> AudioGetAsync(
			 int? ownerId = null,
			 long? albumId = null,
			 ulong[] audioIds = null,
			 bool needUser = false,
			 uint offset = 0,
			 uint count = 0
			){
			return await Executor.ExecRawAsync(
				_reqapi.AudioGet(
											ownerId,
											albumId,
											audioIds,
											needUser,
											offset,
											count
									)
			);
		}
		public async Task<string> AudioGetByIdAsync(
			 bool itunes = false,
			params string[] audios 
			){
			return await Executor.ExecRawAsync(
				_reqapi.AudioGetById(
											itunes,
											audios
									)
			);
		}
		public async Task<string> AudioGetByIdAsync(
			 bool itunes = false,
			params Tuple<int, long>[] audios 
			){
			return await Executor.ExecRawAsync(
				_reqapi.AudioGetById(
											itunes,
											audios
									)
			);
		}
		public async Task<string> AudioGetCountAsync(
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.AudioGetCount(
											ownerId
									)
			);
		}
		public async Task<string> AudioGetLyricsAsync(
			 long lyricsId 
			){
			return await Executor.ExecRawAsync(
				_reqapi.AudioGetLyrics(
											lyricsId
									)
			);
		}
		public async Task<string> AudioGetUploadServerAsync(
			 long albumId ,
			 uint? groupId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.AudioGetUploadServer(
											albumId,
											groupId
									)
			);
		}
		public async Task<string> AudioReorderAsync(
			 long audioId ,
			 int? ownerId = null,
			 long? before = null,
			 long? after = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.AudioReorder(
											audioId,
											ownerId,
											before,
											after
									)
			);
		}
		public async Task<string> AudioRestoreAsync(
			 long audioId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.AudioRestore(
											audioId,
											ownerId
									)
			);
		}
		public async Task<string> AudioSaveAsync(
			 string server ,
			 string audio ,
			 string hash ,
			 string artist = "",
			 string title = ""
			){
			return await Executor.ExecRawAsync(
				_reqapi.AudioSave(
											server,
											audio,
											hash,
											artist,
											title
									)
			);
		}
		public async Task<string> AudioSearchAsync(
			 string q ,
			 bool autoComplete = true,
			 bool lyrics = false,
			 bool performerOnly = false,
			 AudioSortOrder sort = AudioSortOrder.ByRating,
			 bool searchOwn = false,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
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
			);
		}
		public async Task<string> AuthCheckPhoneAsync(
			 string phone ,
			 string clientSecret ,
			 int? clientId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.AuthCheckPhone(
											phone,
											clientSecret,
											clientId
									)
			);
		}
		public async Task<string> AuthConfirmAsync(
			 uint clientId ,
			 string clientSecret ,
			 string phone ,
			 string code ,
			 string password = "",
			 bool testMode = false,
			 int? intro = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.AuthConfirm(
											clientId,
											clientSecret,
											phone,
											code,
											password,
											testMode,
											intro
									)
			);
		}
		public async Task<string> AuthRestoreAsync(
			 long phone 
			){
			return await Executor.ExecRawAsync(
				_reqapi.AuthRestore(
											phone
									)
			);
		}
		public async Task<string> BoardCloseTopicAsync(
			 uint groupId ,
			 uint topicId 
			){
			return await Executor.ExecRawAsync(
				_reqapi.BoardCloseTopic(
											groupId,
											topicId
									)
			);
		}
		public async Task<string> BoardDeleteCommentAsync(
			 uint groupId ,
			 uint topicId ,
			 uint commentId 
			){
			return await Executor.ExecRawAsync(
				_reqapi.BoardDeleteComment(
											groupId,
											topicId,
											commentId
									)
			);
		}
		public async Task<string> BoardDeleteTopicAsync(
			 uint groupId ,
			 uint topicId 
			){
			return await Executor.ExecRawAsync(
				_reqapi.BoardDeleteTopic(
											groupId,
											topicId
									)
			);
		}
		public async Task<string> BoardFixTopicAsync(
			 uint groupId ,
			 uint topicId 
			){
			return await Executor.ExecRawAsync(
				_reqapi.BoardFixTopic(
											groupId,
											topicId
									)
			);
		}
		public async Task<string> BoardUnfixTopicAsync(
			 uint groupId ,
			 uint topicId 
			){
			return await Executor.ExecRawAsync(
				_reqapi.BoardUnfixTopic(
											groupId,
											topicId
									)
			);
		}
		public async Task<string> BoardRestoreCommentAsync(
			 uint groupId ,
			 uint topicId ,
			 uint commentId 
			){
			return await Executor.ExecRawAsync(
				_reqapi.BoardRestoreComment(
											groupId,
											topicId,
											commentId
									)
			);
		}
		public async Task<string> DatabaseGetCountriesAsync(
			 string code = "",
			 bool needAll = false,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.DatabaseGetCountries(
											code,
											needAll,
											offset,
											count
									)
			);
		}
		public async Task<string> DatabaseGetRegionsAsync(
			 uint countryId ,
			 string q = "",
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.DatabaseGetRegions(
											countryId,
											q,
											offset,
											count
									)
			);
		}
		public async Task<string> DatabaseGetStreetsByIdAsync(
			params uint[] streetIds 
			){
			return await Executor.ExecRawAsync(
				_reqapi.DatabaseGetStreetsById(
											streetIds
									)
			);
		}
		public async Task<string> DatabaseGetCountriesByIdAsync(
			params uint[] countryIds 
			){
			return await Executor.ExecRawAsync(
				_reqapi.DatabaseGetCountriesById(
											countryIds
									)
			);
		}
		public async Task<string> DatabaseGetCitiesByIdAsync(
			params uint[] cityIds 
			){
			return await Executor.ExecRawAsync(
				_reqapi.DatabaseGetCitiesById(
											cityIds
									)
			);
		}
		public async Task<string> DatabaseGetCitiesAsync(
			 uint countryId ,
			 uint? regionId = null,
			 string q = "",
			 bool needAll = false,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.DatabaseGetCities(
											countryId,
											regionId,
											q,
											needAll,
											offset,
											count
									)
			);
		}
		public async Task<string> DatabaseGetUniversitiesAsync(
			 uint? countryId = null,
			 uint? cityId = null,
			 string q = "",
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.DatabaseGetUniversities(
											countryId,
											cityId,
											q,
											offset,
											count
									)
			);
		}
		public async Task<string> DatabaseGetSchoolsAsync(
			 uint? cityId = null,
			 string q = "",
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.DatabaseGetSchools(
											cityId,
											q,
											offset,
											count
									)
			);
		}
		public async Task<string> DatabaseGetFacultiesAsync(
			 uint universityId ,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.DatabaseGetFaculties(
											universityId,
											offset,
											count
									)
			);
		}
		public async Task<string> DatabaseGetChairsAsync(
			 uint facultyId ,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.DatabaseGetChairs(
											facultyId,
											offset,
											count
									)
			);
		}
		public async Task<string> DocsAddAsync(
			 long docId ,
			 int ownerId ,
			 string accessKey = ""
			){
			return await Executor.ExecRawAsync(
				_reqapi.DocsAdd(
											docId,
											ownerId,
											accessKey
									)
			);
		}
		public async Task<string> DocsDeleteAsync(
			 long docId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.DocsDelete(
											docId,
											ownerId
									)
			);
		}
		public async Task<string> DocsGetUploadServerAsync(
			 uint? groupId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.DocsGetUploadServer(
											groupId
									)
			);
		}
		public async Task<string> DocsGetWallUploadServerAsync(
			 uint? groupId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.DocsGetWallUploadServer(
											groupId
									)
			);
		}
		public async Task<string> DocsGetAsync(
			 int? ownerId = null,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.DocsGet(
											ownerId,
											offset,
											count
									)
			);
		}
		public async Task<string> DocsGetByIdAsync(
			params Tuple<int,int>[] docs 
			){
			return await Executor.ExecRawAsync(
				_reqapi.DocsGetById(
											docs
									)
			);
		}
		public async Task<string> DocsSaveAsync(
			 string file ,
			 string title ,
			params string[] tags 
			){
			return await Executor.ExecRawAsync(
				_reqapi.DocsSave(
											file,
											title,
											tags
									)
			);
		}
		public async Task<string> FriendsGetAsync(
			 uint? userId = null,
			 uint? listId = null,
			 UserFields fields = UserFields.None,
			 UserSortOrder order = UserSortOrder.ById,
			 NameCase nameCase = NameCase.Nom,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.FriendsGet(
											userId,
											listId,
											fields,
											order,
											nameCase,
											offset,
											count
									)
			);
		}
		public async Task<string> FriendsGetSuggestionsAsync(
			 FriendSuggestionFilters filters = FriendSuggestionFilters.Everything,
			 UserFields fields = UserFields.None,
			 NameCase nameCase = NameCase.Nom,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.FriendsGetSuggestions(
											filters,
											fields,
											nameCase,
											offset,
											count
									)
			);
		}
		public async Task<string> FriendsGetByPhonesAsync(
			 UserFields fields = UserFields.None,
			 ulong[] phones = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.FriendsGetByPhones(
											fields,
											phones
									)
			);
		}
		public async Task<string> FriendsAddAsync(
			 uint userId ,
			 string text = ""
			){
			return await Executor.ExecRawAsync(
				_reqapi.FriendsAdd(
											userId,
											text
									)
			);
		}
		public async Task<string> FriendsDeleteAllRequestsAsync(
			){
			return await Executor.ExecRawAsync(
				_reqapi.FriendsDeleteAllRequests(
									)
			);
		}
		public async Task<string> FriendsGetRecentAsync(
			 uint count = 20
			){
			return await Executor.ExecRawAsync(
				_reqapi.FriendsGetRecent(
											count
									)
			);
		}
		public async Task<string> FriendsDeleteAsync(
			 uint userId 
			){
			return await Executor.ExecRawAsync(
				_reqapi.FriendsDelete(
											userId
									)
			);
		}
		public async Task<string> FriendsDeleteListAsync(
			 uint listId 
			){
			return await Executor.ExecRawAsync(
				_reqapi.FriendsDeleteList(
											listId
									)
			);
		}
		public async Task<string> FriendsGetAppUsersAsync(
			){
			return await Executor.ExecRawAsync(
				_reqapi.FriendsGetAppUsers(
									)
			);
		}
		public async Task<string> FriendsGetMutualAsync(
			 uint targetUid ,
			 uint? sourceUid = null,
			 bool order = false,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.FriendsGetMutual(
											targetUid,
											sourceUid,
											order,
											offset,
											count
									)
			);
		}
		public async Task<string> GroupsGetBannedAsync(
			 uint groupId ,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.GroupsGetBanned(
											groupId,
											offset,
											count
									)
			);
		}
		public async Task<string> GroupsGetByIdAsync(
			 string[] groupIds ,
			 GroupFields fields 
			){
			return await Executor.ExecRawAsync(
				_reqapi.GroupsGetById(
											groupIds,
											fields
									)
			);
		}
		public async Task<string> GroupsGetByIdAsync(
			 uint groupId ,
			 GroupFields fields 
			){
			return await Executor.ExecRawAsync(
				_reqapi.GroupsGetById(
											groupId,
											fields
									)
			);
		}
		public async Task<string> GroupsGetMembersAsync(
			 uint groupId ,
			 UserFields fields = UserFields.Everything,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.GroupsGetMembers(
											groupId,
											fields,
											offset,
											count
									)
			);
		}
		public async Task<string> GroupsGetMembersAsync(
			 string groupId ,
			 UserFields fields = UserFields.None,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.GroupsGetMembers(
											groupId,
											fields,
											offset,
											count
									)
			);
		}
		public async Task<string> GroupsIsMemberAsync(
			 uint groupId ,
			 bool extended = false,
			params uint[] userIds 
			){
			return await Executor.ExecRawAsync(
				_reqapi.GroupsIsMember(
											groupId,
											extended,
											userIds
									)
			);
		}
		public async Task<string> GroupsJoinAsync(
			 uint groupId ,
			 bool notSure = false
			){
			return await Executor.ExecRawAsync(
				_reqapi.GroupsJoin(
											groupId,
											notSure
									)
			);
		}
		public async Task<string> GroupsLeaveAsync(
			 uint groupId 
			){
			return await Executor.ExecRawAsync(
				_reqapi.GroupsLeave(
											groupId
									)
			);
		}
		public async Task<string> GroupsUnbanUserAsync(
			 uint groupId ,
			 uint userId 
			){
			return await Executor.ExecRawAsync(
				_reqapi.GroupsUnbanUser(
											groupId,
											userId
									)
			);
		}
		public async Task<string> MessagesAddChatUserAsync(
			 uint userId ,
			 uint? chatId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.MessagesAddChatUser(
											userId,
											chatId
									)
			);
		}
		public async Task<string> MessagesRemoveChatUserAsync(
			 uint userId ,
			 uint chatId 
			){
			return await Executor.ExecRawAsync(
				_reqapi.MessagesRemoveChatUser(
											userId,
											chatId
									)
			);
		}
		public async Task<string> MessagesDeleteAsync(
			params int[] messageIds 
			){
			return await Executor.ExecRawAsync(
				_reqapi.MessagesDelete(
											messageIds
									)
			);
		}
		public async Task<string> MessagesMarkAsReadAsync(
			 uint userId ,
			 uint? startMessageId = null,
			params int[] messageIds 
			){
			return await Executor.ExecRawAsync(
				_reqapi.MessagesMarkAsRead(
											userId,
											startMessageId,
											messageIds
									)
			);
		}
		public async Task<string> MessagesRestoreAsync(
			 int messageId 
			){
			return await Executor.ExecRawAsync(
				_reqapi.MessagesRestore(
											messageId
									)
			);
		}
		public async Task<string> MessagesDeleteDialogAsync(
			 uint userId ,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.MessagesDeleteDialog(
											userId,
											offset,
											count
									)
			);
		}
		public async Task<string> MessagesMarkAsImportantAsync(
			 bool important ,
			params int[] messageIds 
			){
			return await Executor.ExecRawAsync(
				_reqapi.MessagesMarkAsImportant(
											important,
											messageIds
									)
			);
		}
		public async Task<string> NewsfeedAddBanAsync(
			 uint[] userIds = null,
			 uint[] groupIds = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.NewsfeedAddBan(
											userIds,
											groupIds
									)
			);
		}
		public async Task<string> NewsfeedDeleteBanAsync(
			 uint[] userIds = null,
			 uint[] groupIds = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.NewsfeedDeleteBan(
											userIds,
											groupIds
									)
			);
		}
		public async Task<string> NotesDeleteAsync(
			 uint noteId 
			){
			return await Executor.ExecRawAsync(
				_reqapi.NotesDelete(
											noteId
									)
			);
		}
		public async Task<string> NotesDeleteCommentAsync(
			 uint commentId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.NotesDeleteComment(
											commentId,
											ownerId
									)
			);
		}
		public async Task<string> NotesRestoreCommentAsync(
			 uint commentId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.NotesRestoreComment(
											commentId,
											ownerId
									)
			);
		}
		public async Task<string> NotificationsMarkAsViewedAsync(
			){
			return await Executor.ExecRawAsync(
				_reqapi.NotificationsMarkAsViewed(
									)
			);
		}
		public async Task<string> PagesClearCacheAsync(
			 string url 
			){
			return await Executor.ExecRawAsync(
				_reqapi.PagesClearCache(
											url
									)
			);
		}
		public async Task<string> PhotosDeleteCommentAsync(
			 uint commentId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosDeleteComment(
											commentId,
											ownerId
									)
			);
		}
		public async Task<string> PhotosRestoreCommentAsync(
			 uint commentId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosRestoreComment(
											commentId,
											ownerId
									)
			);
		}
		public async Task<string> PhotosReportCommentAsync(
			 uint commentId ,
			 int? ownerId = null,
			 ReportReason? reason = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosReportComment(
											commentId,
											ownerId,
											reason
									)
			);
		}
		public async Task<string> PhotosDeleteAlbumAsync(
			 long albumId ,
			 uint? groupId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosDeleteAlbum(
											albumId,
											groupId
									)
			);
		}
		public async Task<string> PhotosDeleteAsync(
			 long photoId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosDelete(
											photoId,
											ownerId
									)
			);
		}
		public async Task<string> PhotosConfirmTagAsync(
			 uint tagId ,
			 long photoId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosConfirmTag(
											tagId,
											photoId,
											ownerId
									)
			);
		}
		public async Task<string> PhotosRemoveTagAsync(
			 uint tagId ,
			 long photoId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosRemoveTag(
											tagId,
											photoId,
											ownerId
									)
			);
		}
		public async Task<string> PhotosReportAsync(
			 long photoId ,
			 int? ownerId = null,
			 ReportReason? reason = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosReport(
											photoId,
											ownerId,
											reason
									)
			);
		}
		public async Task<string> PhotosCopyAsync(
			 long photoId ,
			 int? ownerId = null,
			 string accessKey = ""
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosCopy(
											photoId,
											ownerId,
											accessKey
									)
			);
		}
		public async Task<string> PhotosEditAsync(
			 long photoId ,
			 int? ownerId = null,
			 string caption = ""
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosEdit(
											photoId,
											ownerId,
											caption
									)
			);
		}
		public async Task<string> PhotosGetAlbumsCountAsync(
			 uint? userId = null,
			 uint? groupId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosGetAlbumsCount(
											userId,
											groupId
									)
			);
		}
		public async Task<string> PhotosCreateAlbumAsync(
			 string title ,
			 string description = "",
			 uint? groupId = null,
			 PrivacyType? privacy = null,
			 PrivacyType? commentPrivacy = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosCreateAlbum(
											title,
											description,
											groupId,
											privacy,
											commentPrivacy
									)
			);
		}
		public async Task<string> PhotosEditAlbumAsync(
			 long albumId ,
			 int? ownerId = null,
			 string title = "",
			 string description = "",
			 PrivacyType? privacy = null,
			 PrivacyType? commentPrivacy = null
			){
			return await Executor.ExecRawAsync(
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
		public async Task<string> PhotosGetOwnerPhotoUploadServerAsync(
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosGetOwnerPhotoUploadServer(
									)
			);
		}
		public async Task<string> PhotosGetUploadServerAsync(
			 long albumId ,
			 uint? groupId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosGetUploadServer(
											albumId,
											groupId
									)
			);
		}
		public async Task<string> PhotosGetChatUploadServerAsync(
			 uint chatId ,
			 uint? cropX = null,
			 uint? cropY = null,
			 uint? cropWidth = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosGetChatUploadServer(
											chatId,
											cropX,
											cropY,
											cropWidth
									)
			);
		}
		public async Task<string> PhotosReorderAlbumsAsync(
			 long albumId ,
			 int? ownerId = null,
			 long? before = null,
			 long? after = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosReorderAlbums(
											albumId,
											ownerId,
											before,
											after
									)
			);
		}
		public async Task<string> PhotosReorderPhotosAsync(
			 long photoId ,
			 int? ownerId = null,
			 long? before = null,
			 long? after = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosReorderPhotos(
											photoId,
											ownerId,
											before,
											after
									)
			);
		}
		public async Task<string> PhotosMoveAsync(
			 long targetAlbumId ,
			 long photoId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosMove(
											targetAlbumId,
											photoId,
											ownerId
									)
			);
		}
		public async Task<string> PhotosMakeCoverAsync(
			 long albumId ,
			 long photoId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosMakeCover(
											albumId,
											photoId,
											ownerId
									)
			);
		}
		public async Task<string> PhotosGetAllAsync(
			 int? ownerId = null,
			 bool extended = false,
			 bool noServiceAlbums = false,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosGetAll(
											ownerId,
											extended,
											noServiceAlbums,
											offset,
											count
									)
			);
		}
		public async Task<string> PhotosGetAsync(
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
			return await Executor.ExecRawAsync(
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
			);
		}
		public async Task<string> PhotosGetAsync(
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
			return await Executor.ExecRawAsync(
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
			);
		}
		public async Task<string> PhotosGetAlbumsAsync(
			 int? ownerId = null,
			 bool needSystem = true,
			 bool needCovers = true,
			 uint offset = 0,
			 uint count = 100,
			params long[] albumIds 
			){
			return await Executor.ExecRawAsync(
				_reqapi.PhotosGetAlbums(
											ownerId,
											needSystem,
											needCovers,
											offset,
											count,
											albumIds
									)
			);
		}
		public async Task<string> PhotosSaveAsync(
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
			return await Executor.ExecRawAsync(
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
			);
		}
		public async Task<string> StatusGetAsync(
			 int? userId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.StatusGet(
											userId
									)
			);
		}
		public async Task<string> StatusSetAsync(
			 string text 
			){
			return await Executor.ExecRawAsync(
				_reqapi.StatusSet(
											text
									)
			);
		}
		public async Task<string> StorageGetAsync(
			 uint? userId = null,
			 bool global = false,
			params string[] keys 
			){
			return await Executor.ExecRawAsync(
				_reqapi.StorageGet(
											userId,
											global,
											keys
									)
			);
		}
		public async Task<string> StorageGetKeysAsync(
			 uint? userId = null,
			 bool global = false,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.StorageGetKeys(
											userId,
											global,
											offset,
											count
									)
			);
		}
		public async Task<string> StorageSetAsync(
			 string key ,
			 string value ,
			 uint? userId = null,
			 bool global = false
			){
			return await Executor.ExecRawAsync(
				_reqapi.StorageSet(
											key,
											value,
											userId,
											global
									)
			);
		}
		public async Task<string> UsersIsAppUserAsync(
			 uint? userId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.UsersIsAppUser(
											userId
									)
			);
		}
		public async Task<string> UsersReportAsync(
			 uint userId ,
			 ComplaintType type ,
			 string comment 
			){
			return await Executor.ExecRawAsync(
				_reqapi.UsersReport(
											userId,
											type,
											comment
									)
			);
		}
		public async Task<string> UsersGetSubscriptionsAsync(
			 uint? userId = null,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.UsersGetSubscriptions(
											userId,
											offset,
											count
									)
			);
		}
		public async Task<string> UsersGetAsync(
			 UserFields fields = UserFields.None,
			 NameCase nameCase = NameCase.Nom,
			params uint[] userIds 
			){
			return await Executor.ExecRawAsync(
				_reqapi.UsersGet(
											fields,
											nameCase,
											userIds
									)
			);
		}
		public async Task<string> UsersGetFollowersAsync(
			 uint? userId = null,
			 UserFields fields = UserFields.None,
			 NameCase nameCase = NameCase.Nom,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.UsersGetFollowers(
											userId,
											fields,
											nameCase,
											offset,
											count
									)
			);
		}
		public async Task<string> UsersGetNearbyAsync(
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
			return await Executor.ExecRawAsync(
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
			);
		}
		public async Task<string> UtilsCheckLinkAsync(
			 string url = ""
			){
			return await Executor.ExecRawAsync(
				_reqapi.UtilsCheckLink(
											url
									)
			);
		}
		public async Task<string> UtilsGetServerTimeAsync(
			){
			return await Executor.ExecRawAsync(
				_reqapi.UtilsGetServerTime(
									)
			);
		}
		public async Task<string> VideoDeleteCommentAsync(
			 uint commentId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.VideoDeleteComment(
											commentId,
											ownerId
									)
			);
		}
		public async Task<string> VideoRestoreCommentAsync(
			 uint commentId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.VideoRestoreComment(
											commentId,
											ownerId
									)
			);
		}
		public async Task<string> VideoReportCommentAsync(
			 uint commentId ,
			 int? ownerId = null,
			 ReportReason? reason = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.VideoReportComment(
											commentId,
											ownerId,
											reason
									)
			);
		}
		public async Task<string> VideoDeleteAlbumAsync(
			 long albumId ,
			 uint? groupId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.VideoDeleteAlbum(
											albumId,
											groupId
									)
			);
		}
		public async Task<string> VideoDeleteAsync(
			 ulong videoId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.VideoDelete(
											videoId,
											ownerId
									)
			);
		}
		public async Task<string> VideoRemoveTagAsync(
			 ulong videoId ,
			 uint tagId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.VideoRemoveTag(
											videoId,
											tagId,
											ownerId
									)
			);
		}
		public async Task<string> VideoReportAsync(
			 ulong videoId ,
			 int? ownerId = null,
			 ReportReason? reason = null,
			 string comment = "",
			 string searchQuery = ""
			){
			return await Executor.ExecRawAsync(
				_reqapi.VideoReport(
											videoId,
											ownerId,
											reason,
											comment,
											searchQuery
									)
			);
		}
		public async Task<string> WallDeleteAsync(
			 uint postId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.WallDelete(
											postId,
											ownerId
									)
			);
		}
		public async Task<string> WallRestoreAsync(
			 uint postId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.WallRestore(
											postId,
											ownerId
									)
			);
		}
		public async Task<string> WallDeleteCommentAsync(
			 uint commentId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.WallDeleteComment(
											commentId,
											ownerId
									)
			);
		}
		public async Task<string> WallRestoreCommentAsync(
			 uint commentId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.WallRestoreComment(
											commentId,
											ownerId
									)
			);
		}
		public async Task<string> WallReportPostAsync(
			 uint postId ,
			 int? ownerId = null,
			 ReportReason? reason = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.WallReportPost(
											postId,
											ownerId,
											reason
									)
			);
		}
		public async Task<string> WallReportCommentAsync(
			 uint commentId ,
			 int? ownerId = null,
			 ReportReason? reason = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.WallReportComment(
											commentId,
											ownerId,
											reason
									)
			);
		}
		public async Task<string> WallGetByIdAsync(
			 uint copyHistoryDepth = 2,
			params string[] posts 
			){
			return await Executor.ExecRawAsync(
				_reqapi.WallGetById(
											copyHistoryDepth,
											posts
									)
			);
		}
		public async Task<string> WallGetByIdAsync(
			 uint copyHistoryDepth = 2,
			params Tuple<int,uint>[] posts 
			){
			return await Executor.ExecRawAsync(
				_reqapi.WallGetById(
											copyHistoryDepth,
											posts
									)
			);
		}
		public async Task<string> WallGetAsync(
			 int? ownerId = null,
			 string domain = "",
			 WallPostFilter filter = WallPostFilter.All,
			 uint offset = 0,
			 uint count = 100
			){
			return await Executor.ExecRawAsync(
				_reqapi.WallGet(
											ownerId,
											domain,
											filter,
											offset,
											count
									)
			);
		}
		public async Task<string> WallPinAsync(
			 uint postId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.WallPin(
											postId,
											ownerId
									)
			);
		}
		public async Task<string> WallUnpinAsync(
			 uint postId ,
			 int? ownerId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.WallUnpin(
											postId,
											ownerId
									)
			);
		}
		public async Task<string> WallRepostAsync(
			 string @object ,
			 string message = "",
			 uint? groupId = null
			){
			return await Executor.ExecRawAsync(
				_reqapi.WallRepost(
											@object,
											message,
											groupId
									)
			);
		}
	}
}