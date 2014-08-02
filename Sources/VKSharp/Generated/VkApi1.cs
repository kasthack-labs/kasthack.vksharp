using System;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Core.ResponseEntities;
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
			 int chatId ,
			 int userId ,
			 int sound 
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
			 uint userId 
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
			 uint audioId ,
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
			 uint albumId ,
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
			 uint audioId ,
			 int ownerId 
			){
			await Executor.ExecAsync(
				_reqapi.AudioDelete(
											audioId,
											ownerId
									)
			);
		}
		public async Task<EntityList<Audio>> AudioGetAsync(
			 int? offset = null,
			 int? count = null,
			 bool needUser = false,
			 int? ownerId = null,
			 int? albumId = null,
			 ulong[] audioIds = null
			){
			return (await Executor.ExecAsync(
				_reqapi.AudioGet(
											offset,
											count,
											needUser,
											ownerId,
											albumId,
											audioIds
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
			 int lyricsId 
			){
			return (await Executor.ExecAsync(
				_reqapi.AudioGetLyrics(
											lyricsId
									)
			)).Data.FirstOrDefault();
		}
		public async Task<SimpleEntity<string>> AudioGetUploadServerAsync(
			 int albumId ,
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
			 int audioId ,
			 int? ownerId = null,
			 int? after = null,
			 int? before = null
			){
			await Executor.ExecAsync(
				_reqapi.AudioReorder(
											audioId,
											ownerId,
											after,
											before
									)
			);
		}
		public async Task<Audio> AudioRestoreAsync(
			 int audioId ,
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
			 bool needAll = false,
			 string code = "",
			 uint offset = 0,
			 uint count = 100
			){
			return (await Executor.ExecAsync(
				_reqapi.DatabaseGetCountries(
											needAll,
											code,
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
			 int ownerId ,
			 uint docId ,
			 string accessKey = ""
			){
			return (await Executor.ExecAsync(
				_reqapi.DocsAdd(
											ownerId,
											docId,
											accessKey
									)
			)).Data.FirstOrDefault();
		}
		public async Task DocsDeleteAsync(
			 uint docId ,
			 int ownerId 
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
		public async Task FriendsAddAsync(
			 uint userId ,
			 string text = ""
			){
			await Executor.ExecAsync(
				_reqapi.FriendsAdd(
											userId,
											text
									)
			);
		}
		public async Task FriendsDeleteAllRequestsAsync(
			){
			await Executor.ExecAsync(
				_reqapi.FriendsDeleteAllRequests(
									)
			);
		}
		public async Task FriendsDeleteAsync(
			 uint userId 
			){
			await Executor.ExecAsync(
				_reqapi.FriendsDelete(
											userId
									)
			);
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
			 int? chatId = null
			){
			await Executor.ExecAsync(
				_reqapi.MessagesAddChatUser(
											userId,
											chatId
									)
			);
		}
		public async Task MessagesRemoveChatUserAsync(
			 int userId ,
			 int chatId 
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
			 int userId ,
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
			 int userId ,
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
			 uint[] userIds ,
			 uint[] groupIds 
			){
			await Executor.ExecAsync(
				_reqapi.NewsfeedAddBan(
											userIds,
											groupIds
									)
			);
		}
		public async Task NewsfeedDeleteBanAsync(
			 uint[] userIds ,
			 uint[] groupIds 
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
			 int ownerId ,
			 uint commentId 
			){
			await Executor.ExecAsync(
				_reqapi.NotesDeleteComment(
											ownerId,
											commentId
									)
			);
		}
		public async Task NotesRestoreCommentAsync(
			 int ownerId ,
			 uint commentId 
			){
			await Executor.ExecAsync(
				_reqapi.NotesRestoreComment(
											ownerId,
											commentId
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
			 string url = ""
			){
			await Executor.ExecAsync(
				_reqapi.PagesClearCache(
											url
									)
			);
		}
		public async Task PhotosDeleteCommentAsync(
			 int ownerId ,
			 uint commentId 
			){
			await Executor.ExecAsync(
				_reqapi.PhotosDeleteComment(
											ownerId,
											commentId
									)
			);
		}
		public async Task PhotosRestoreCommentAsync(
			 int ownerId ,
			 uint commentId 
			){
			await Executor.ExecAsync(
				_reqapi.PhotosRestoreComment(
											ownerId,
											commentId
									)
			);
		}
		public async Task PhotosReportCommentAsync(
			 int ownerId ,
			 uint commentId ,
			 ReportReason? reason = null
			){
			await Executor.ExecAsync(
				_reqapi.PhotosReportComment(
											ownerId,
											commentId,
											reason
									)
			);
		}
		public async Task PhotosDeleteAlbumAsync(
			 int albumId ,
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
			 uint photoId ,
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
			 uint photoId ,
			 uint tagId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.PhotosConfirmTag(
											photoId,
											tagId,
											ownerId
									)
			);
		}
		public async Task PhotosRemoveTagAsync(
			 uint photoId ,
			 uint tagId ,
			 int? ownerId = null
			){
			await Executor.ExecAsync(
				_reqapi.PhotosRemoveTag(
											photoId,
											tagId,
											ownerId
									)
			);
		}
		public async Task PhotosReportAsync(
			 int ownerId ,
			 uint photoId ,
			 ReportReason? reason = null
			){
			await Executor.ExecAsync(
				_reqapi.PhotosReport(
											ownerId,
											photoId,
											reason
									)
			);
		}
		public async Task PhotosCopyAsync(
			 uint photoId ,
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
			 uint photoId ,
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
		public async Task<Status[]> StatusGetAsync(
			 int userId 
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
			 int? userId = null,
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
			 int? userId = null,
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
			 int? userId = null,
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
			 int ownerId ,
			 uint commentId 
			){
			await Executor.ExecAsync(
				_reqapi.VideoDeleteComment(
											ownerId,
											commentId
									)
			);
		}
		public async Task VideoRestoreCommentAsync(
			 int ownerId ,
			 uint commentId 
			){
			await Executor.ExecAsync(
				_reqapi.VideoRestoreComment(
											ownerId,
											commentId
									)
			);
		}
		public async Task VideoReportCommentAsync(
			 int ownerId ,
			 uint commentId ,
			 ReportReason? reason = null
			){
			await Executor.ExecAsync(
				_reqapi.VideoReportComment(
											ownerId,
											commentId,
											reason
									)
			);
		}
		public async Task VideoDeleteAlbumAsync(
			 uint albumId ,
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
			 uint videoId ,
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
			 uint videoId ,
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
			 int ownerId ,
			 uint videoId ,
			 ReportReason? reason = null,
			 string comment = "",
			 string searchQuery = ""
			){
			await Executor.ExecAsync(
				_reqapi.VideoReport(
											ownerId,
											videoId,
											reason,
											comment,
											searchQuery
									)
			);
		}
		public async Task WallDeleteAsync(
			 int ownerId ,
			 uint postId 
			){
			await Executor.ExecAsync(
				_reqapi.WallDelete(
											ownerId,
											postId
									)
			);
		}
		public async Task WallRestoreAsync(
			 int ownerId ,
			 uint postId 
			){
			await Executor.ExecAsync(
				_reqapi.WallRestore(
											ownerId,
											postId
									)
			);
		}
		public async Task WallDeleteCommentAsync(
			 int ownerId ,
			 uint commentId 
			){
			await Executor.ExecAsync(
				_reqapi.WallDeleteComment(
											ownerId,
											commentId
									)
			);
		}
		public async Task WallRestoreCommentAsync(
			 int ownerId ,
			 uint commentId 
			){
			await Executor.ExecAsync(
				_reqapi.WallRestoreComment(
											ownerId,
											commentId
									)
			);
		}
		public async Task WallReportPostAsync(
			 int ownerId ,
			 uint postId ,
			 ReportReason? reason = null
			){
			await Executor.ExecAsync(
				_reqapi.WallReportPost(
											ownerId,
											postId,
											reason
									)
			);
		}
		public async Task WallReportCommentAsync(
			 int ownerId ,
			 uint commentId ,
			 ReportReason? reason = null
			){
			await Executor.ExecAsync(
				_reqapi.WallReportComment(
											ownerId,
											commentId,
											reason
									)
			);
		}
	}
}
// ReSharper restore UnusedMember.Global
