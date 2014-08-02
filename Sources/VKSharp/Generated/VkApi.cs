using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Core.ResponseEntities;
using VKSharp.Data.Api;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
	public partial class VKApi {
		public async Task AccountSetNameInMenuAsync(
			 string name 
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AccountSetNameInMenu(
											name
									)
			);
		}
		public async Task AccountSetOnlineAsync(
			 bool voip = true
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AccountSetOnline(
											voip
									)
			);
		}
		public async Task AccountSetOfflineAsync(
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AccountSetOffline(
									)
			);
		}
		public async Task AccountUnregisterDeviceAsync(
			 string token 
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AccountUnregisterDevice(
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
			return _rawapi.Executor.Parse(
				await _rawapi.AccountSetSilenceMode(
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
			return _rawapi.Executor.Parse(
				await _rawapi.AccountGetAppPermissions(
											userId
									)
			);
		}
		public async Task AccountBanUserAsync(
			 uint userId 
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AccountBanUser(
											userId
									)
			);
		}
		public async Task<EntityList<User>> AccountGetBannedAsync(
			 uint offset = 0,
			 uint count = 20
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AccountGetBanned(
											offset,
											count
									)
			);
		}
		public async Task AccountSetInfoAsync(
			 uint? intro = null
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AccountSetInfo(
											intro
									)
			);
		}
		public async Task<User> AccountGetProfileInfoAsync(
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AccountGetProfileInfo(
									)
			);
		}
		public async Task<StructEntity<int>> AudioAddAlbumAsync(
			 string title ,
			 uint? groupId = 0
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AudioAddAlbum(
											title,
											groupId
									)
			);
		}
		public async Task<StructEntity<int>> AudioAddAsync(
			 int ownerId ,
			 uint audioId ,
			 uint? groupId = null
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AudioAdd(
											ownerId,
											audioId,
											groupId
									)
			);
		}
		public async Task AudioDeleteAlbumAsync(
			 uint albumId ,
			 uint? groupId = null
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AudioDeleteAlbum(
											albumId,
											groupId
									)
			);
		}
		public async Task AudioDeleteAsync(
			 int ownerId ,
			 uint audioId 
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AudioDelete(
											ownerId,
											audioId
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
			return _rawapi.Executor.Parse(
				await _rawapi.AudioGet(
											offset,
											count,
											needUser,
											ownerId,
											albumId,
											audioIds
									)
			);
		}
		public async Task<Audio[]> AudioGetByIdAsync(
			 string[] audios ,
			 bool itunes = false
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AudioGetById(
											audios,
											itunes
									)
			);
		}
		public async Task<StructEntity<int>> AudioGetCountAsync(
			 int? ownerId = null
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AudioGetCount(
											ownerId
									)
			);
		}
		public async Task<Lyrics> AudioGetLyricsAsync(
			 int lyricsId 
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AudioGetLyrics(
											lyricsId
									)
			);
		}
		public async Task<SimpleEntity<string>> AudioGetUploadServerAsync(
			 int albumId ,
			 int? groupId = null
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AudioGetUploadServer(
											albumId,
											groupId
									)
			);
		}
		public async Task AudioReorderAsync(
			 int audioId ,
			 int? ownerId = null,
			 int? after = null,
			 int? before = null
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AudioReorder(
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
			return _rawapi.Executor.Parse(
				await _rawapi.AudioRestore(
											audioId,
											ownerId
									)
			);
		}
		public async Task<Audio[]> AudioSaveAsync(
			 string server ,
			 string audio ,
			 string hash ,
			 string artist = "",
			 string title = ""
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AudioSave(
											server,
											audio,
											hash,
											artist,
											title
									)
			);
		}
		public async Task<StructEntity<bool>> AuthCheckPhoneAsync(
			 string phone ,
			 string clientSecret ,
			 int? clientId = null
			){
			return _rawapi.Executor.Parse(
				await _rawapi.AuthCheckPhone(
											phone,
											clientSecret,
											clientId
									)
			);
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
			return _rawapi.Executor.Parse(
				await _rawapi.AuthConfirm(
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
		public async Task BoardCloseTopicAsync(
			 uint groupId ,
			 uint topicId 
			){
			return _rawapi.Executor.Parse(
				await _rawapi.BoardCloseTopic(
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
			return _rawapi.Executor.Parse(
				await _rawapi.BoardDeleteComment(
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
			return _rawapi.Executor.Parse(
				await _rawapi.BoardDeleteTopic(
											groupId,
											topicId
									)
			);
		}
		public async Task BoardFixTopicAsync(
			 uint groupId ,
			 uint topicId 
			){
			return _rawapi.Executor.Parse(
				await _rawapi.BoardFixTopic(
											groupId,
											topicId
									)
			);
		}
		public async Task BoardUnfixTopicAsync(
			 uint groupId ,
			 uint topicId 
			){
			return _rawapi.Executor.Parse(
				await _rawapi.BoardUnfixTopic(
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
			return _rawapi.Executor.Parse(
				await _rawapi.BoardRestoreComment(
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
			return _rawapi.Executor.Parse(
				await _rawapi.DatabaseGetCountries(
											needAll,
											code,
											offset,
											count
									)
			);
		}
		public async Task<EntityList<DatabaseEntry>> DatabaseGetRegionsAsync(
			 uint countryId ,
			 string q = "",
			 uint offset = 0,
			 uint count = 100
			){
			return _rawapi.Executor.Parse(
				await _rawapi.DatabaseGetRegions(
											countryId,
											q,
											offset,
											count
									)
			);
		}
		public async Task<DatabaseEntry[]> DatabaseGetStreetsByIdAsync(
			params uint[] streetIds 
			){
			return _rawapi.Executor.Parse(
				await _rawapi.DatabaseGetStreetsById(
											streetIds
									)
			);
		}
		public async Task<EntityList<DatabaseEntry>[]> DatabaseGetCountriesByIdAsync(
			params uint[] countryIds 
			){
			return _rawapi.Executor.Parse(
				await _rawapi.DatabaseGetCountriesById(
											countryIds
									)
			);
		}
		public async Task<DatabaseCity[]> DatabaseGetCitiesByIdAsync(
			params uint[] cityIds 
			){
			return _rawapi.Executor.Parse(
				await _rawapi.DatabaseGetCitiesById(
											cityIds
									)
			);
		}
		public async Task<DatabaseCity[]> DatabaseGetCitiesAsync(
			 uint countryId ,
			 uint? regionId = null,
			 string q = "",
			 bool needAll = false,
			 uint offset = 0,
			 uint count = 100
			){
			return _rawapi.Executor.Parse(
				await _rawapi.DatabaseGetCities(
											countryId,
											regionId,
											q,
											needAll,
											offset,
											count
									)
			);
		}
		public async Task<DatabaseEntry[]> DatabaseGetUniversitiesAsync(
			 uint? countryId = null,
			 uint? cityId = null,
			 string q = "",
			 uint offset = 0,
			 uint count = 100
			){
			return _rawapi.Executor.Parse(
				await _rawapi.DatabaseGetUniversities(
											countryId,
											cityId,
											q,
											offset,
											count
									)
			);
		}
		public async Task<DatabaseEntry[]> DatabaseGetSchoolsAsync(
			 uint? cityId = null,
			 string q = "",
			 uint offset = 0,
			 uint count = 100
			){
			return _rawapi.Executor.Parse(
				await _rawapi.DatabaseGetSchools(
											cityId,
											q,
											offset,
											count
									)
			);
		}
		public async Task<EntityList<DatabaseEntry>> DatabaseGetFacultiesAsync(
			 uint universityId ,
			 uint offset = 0,
			 uint count = 100
			){
			return _rawapi.Executor.Parse(
				await _rawapi.DatabaseGetFaculties(
											universityId,
											offset,
											count
									)
			);
		}
		public async Task<EntityList<DatabaseEntry>> DatabaseGetChairsAsync(
			 uint facultyId ,
			 uint offset = 0,
			 uint count = 100
			){
			return _rawapi.Executor.Parse(
				await _rawapi.DatabaseGetChairs(
											facultyId,
											offset,
											count
									)
			);
		}
		public async Task<StructEntity<int>> DocsAddAsync(
			 uint docId ,
			 int ownerId ,
			 string accessKey = ""
			){
			return _rawapi.Executor.Parse(
				await _rawapi.DocsAdd(
											docId,
											ownerId,
											accessKey
									)
			);
		}
		public async Task DocsDeleteAsync(
			 uint docId ,
			 int ownerId 
			){
			return _rawapi.Executor.Parse(
				await _rawapi.DocsDelete(
											docId,
											ownerId
									)
			);
		}
		public async Task<SimpleEntity<string>> DocsGetUploadServerAsync(
			 uint? groupId = null
			){
			return _rawapi.Executor.Parse(
				await _rawapi.DocsGetUploadServer(
											groupId
									)
			);
		}
		public async Task<SimpleEntity<string>> DocsGetWallUploadServerAsync(
			 uint? groupId = null
			){
			return _rawapi.Executor.Parse(
				await _rawapi.DocsGetWallUploadServer(
											groupId
									)
			);
		}
		public async Task<EntityList<Document>> DocsGetAsync(
			 int? ownerId = null,
			 uint offset = 0,
			 uint count = 100
			){
			return _rawapi.Executor.Parse(
				await _rawapi.DocsGet(
											ownerId,
											offset,
											count
									)
			);
		}
		public async Task<Document[]> DocsGetByIdAsync(
			params Tuple<int,int>[] docs 
			){
			return _rawapi.Executor.Parse(
				await _rawapi.DocsGetById(
											docs
									)
			);
		}
		public async Task<Document[]> DocsSaveAsync(
			 string file ,
			 string title ,
			params string[] tags 
			){
			return _rawapi.Executor.Parse(
				await _rawapi.DocsSave(
											file,
											title,
											tags
									)
			);
		}
		public async Task FriendsAddAsync(
			 uint userId ,
			 string text = ""
			){
			return _rawapi.Executor.Parse(
				await _rawapi.FriendsAdd(
											userId,
											text
									)
			);
		}
		public async Task FriendsDeleteAllRequestsAsync(
			){
			return _rawapi.Executor.Parse(
				await _rawapi.FriendsDeleteAllRequests(
									)
			);
		}
		public async Task FriendsDeleteAsync(
			 uint userId 
			){
			return _rawapi.Executor.Parse(
				await _rawapi.FriendsDelete(
											userId
									)
			);
		}
		public async Task FriendsDeleteListAsync(
			 uint listId 
			){
			return _rawapi.Executor.Parse(
				await _rawapi.FriendsDeleteList(
											listId
									)
			);
		}
		public async Task<StructEntity<int>[]> FriendsGetAppUsersAsync(
			){
			return _rawapi.Executor.Parse(
				await _rawapi.FriendsGetAppUsers(
									)
			);
		}
		public async Task<StructEntity<int>[]> FriendsGetMutualAsync(
			 uint listId 
			){
			return _rawapi.Executor.Parse(
				await _rawapi.FriendsGetMutual(
											listId
									)
			);
		}
	}
}
