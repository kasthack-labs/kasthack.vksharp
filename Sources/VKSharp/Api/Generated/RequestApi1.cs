
using System;
using System.Collections.Generic;
using System.Linq;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Core.ResponseEntities;
using VKSharp.Data.Parameters;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

// ReSharper disable UnusedMember.Global
// ReSharper disable UseObjectOrCollectionInitializer
namespace VKSharp {
    public partial class RequestApi {
		public VKRequest<StructEntity<bool>> AccountSetNameInMenu(
			 string name 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "account.setNameInMenu",
				Parameters = new Dictionary<string, string> {
					{ "name", name }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> AccountSetOnline(
			 bool voip = true
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "account.setOnline",
				Parameters = new Dictionary<string, string> {
					{ "voip", (voip?1:0).ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> AccountSetOffline(
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "account.setOffline",
				Parameters = new Dictionary<string, string> {
						}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> AccountUnregisterDevice(
			 string token 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "account.unregisterDevice",
				Parameters = new Dictionary<string, string> {
					{ "token", token }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> AccountSetSilenceMode(
			 string token ,
			 int time ,
			 uint? chatId = null,
			 uint? userId = null,
			 int sound = 0
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "account.setSilenceMode",
				Parameters = new Dictionary<string, string> {
					{ "token", token },
			{ "time", time.ToNCString() },
			{ "chat_id", MiscTools.NullableString(chatId) },
			{ "user_id", MiscTools.NullableString(userId) },
			{ "sound", sound.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<long>> AccountGetAppPermissions(
			 uint? userId = null
			){
			var req = new VKRequest<StructEntity<long>>{
				MethodName = "account.getAppPermissions",
				Parameters = new Dictionary<string, string> {
					{ "user_id", MiscTools.NullableString(userId) }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<long>> AccountBanUser(
			 uint userId 
			){
			var req = new VKRequest<StructEntity<long>>{
				MethodName = "account.banUser",
				Parameters = new Dictionary<string, string> {
					{ "user_id", userId.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<long>> AccountUnbanUser(
			 uint userId 
			){
			var req = new VKRequest<StructEntity<long>>{
				MethodName = "account.unbanUser",
				Parameters = new Dictionary<string, string> {
					{ "user_id", userId.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<User> AccountGetBanned(
			 uint offset = 0,
			 uint count = 20
			){
			var req = new VKRequest<User>{
				MethodName = "account.getBanned",
				Parameters = new Dictionary<string, string> {
					{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<long>> AccountSetInfo(
			 uint? intro = null
			){
			var req = new VKRequest<StructEntity<long>>{
				MethodName = "account.setInfo",
				Parameters = new Dictionary<string, string> {
					{ "intro", MiscTools.NullableString(intro) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<User> AccountGetProfileInfo(
			){
			var req = new VKRequest<User>{
				MethodName = "account.getProfileInfo",
				Parameters = new Dictionary<string, string> {
						}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<int>> AudioAddAlbum(
			 string title ,
			 uint? groupId = 0
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "audio.addAlbum",
				Parameters = new Dictionary<string, string> {
					{ "title", title },
			{ "group_id", MiscTools.NullableString(groupId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<int>> AudioAdd(
			 int ownerId ,
			 long audioId ,
			 uint? groupId = null
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "audio.add",
				Parameters = new Dictionary<string, string> {
					{ "owner_id", ownerId.ToNCString() },
			{ "audio_id", audioId.ToNCString() },
			{ "group_id", MiscTools.NullableString(groupId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<int>> AudioDeleteAlbum(
			 long albumId ,
			 uint? groupId = null
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "audio.deleteAlbum",
				Parameters = new Dictionary<string, string> {
					{ "album_id", albumId.ToNCString() },
			{ "group_id", MiscTools.NullableString(groupId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<int>> AudioDelete(
			 long audioId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "audio.delete",
				Parameters = new Dictionary<string, string> {
					{ "audio_id", audioId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<EntityList<Audio>> AudioGet(
			 int? ownerId = null,
			 long? albumId = null,
			 ulong[] audioIds = null,
			 bool needUser = false,
			 uint offset = 0,
			 uint count = 0
			){
			var req = new VKRequest<EntityList<Audio>>{
				MethodName = "audio.get",
				Parameters = new Dictionary<string, string> {
					{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "album_id", MiscTools.NullableString(albumId) },
			{ "audio_ids", (audioIds??new ulong[]{}).ToNCStringA() },
			{ "need_user", (needUser?1:0).ToNCString() },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<Audio> AudioGetById(
			 bool itunes = false,
			params string[] audios 
			){
			var req = new VKRequest<Audio>{
				MethodName = "audio.getById",
				Parameters = new Dictionary<string, string> {
					{ "itunes", (itunes?1:0).ToNCString() },
			{ "audios", String.Join(",",audios) }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<Audio> AudioGetById(
			 bool itunes = false,
			params Tuple<int, long>[] audios 
			){
			var req = new VKRequest<Audio>{
				MethodName = "audio.getById",
				Parameters = new Dictionary<string, string> {
					{ "itunes", (itunes?1:0).ToNCString() },
			{ "audios", String.Join(",",audios.Select(a=>a.Item1 +"_" +a.Item2)) }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<int>> AudioGetCount(
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "audio.getCount",
				Parameters = new Dictionary<string, string> {
					{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<Lyrics> AudioGetLyrics(
			 long lyricsId 
			){
			var req = new VKRequest<Lyrics>{
				MethodName = "audio.getLyrics",
				Parameters = new Dictionary<string, string> {
					{ "lyrics_id", lyricsId.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<SimpleEntity<string>> AudioGetUploadServer(
			 long albumId ,
			 uint? groupId = null
			){
			var req = new VKRequest<SimpleEntity<string>>{
				MethodName = "audio.getUploadServer",
				Parameters = new Dictionary<string, string> {
					{ "album_id", albumId.ToNCString() },
			{ "group_id", MiscTools.NullableString(groupId) }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<bool>> AudioReorder(
			 long audioId ,
			 int? ownerId = null,
			 long? before = null,
			 long? after = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "audio.reorder",
				Parameters = new Dictionary<string, string> {
					{ "audio_id", audioId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "before", MiscTools.NullableString(before) },
			{ "after", MiscTools.NullableString(after) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<Audio> AudioRestore(
			 long audioId ,
			 int? ownerId = null
			){
			var req = new VKRequest<Audio>{
				MethodName = "audio.restore",
				Parameters = new Dictionary<string, string> {
					{ "audio_id", audioId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<Audio> AudioSave(
			 string server ,
			 string audio ,
			 string hash ,
			 string artist = "",
			 string title = ""
			){
			var req = new VKRequest<Audio>{
				MethodName = "audio.save",
				Parameters = new Dictionary<string, string> {
					{ "server", server },
			{ "audio", audio },
			{ "hash", hash },
			{ "artist", artist },
			{ "title", title }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<EntityList<Audio>> AudioSearch(
			 string q ,
			 bool autoComplete = true,
			 bool lyrics = false,
			 bool performerOnly = false,
			 AudioSortOrder sort = AudioSortOrder.ByRating,
			 bool searchOwn = false,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<EntityList<Audio>>{
				MethodName = "audio.search",
				Parameters = new Dictionary<string, string> {
					{ "q", q },
			{ "auto_complete", (autoComplete?1:0).ToNCString() },
			{ "lyrics", (lyrics?1:0).ToNCString() },
			{ "performer_only", (performerOnly?1:0).ToNCString() },
			{ "sort", ((int)sort).ToNCString() },
			{ "search_own", (searchOwn?1:0).ToNCString() },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<bool>> AuthCheckPhone(
			 string phone ,
			 string clientSecret ,
			 int? clientId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "auth.checkPhone",
				Parameters = new Dictionary<string, string> {
					{ "phone", phone },
			{ "client_secret", clientSecret },
			{ "client_id", MiscTools.NullableString(clientId) }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<ConfirmResult> AuthConfirm(
			 uint clientId ,
			 string clientSecret ,
			 string phone ,
			 string code ,
			 string password = "",
			 bool testMode = false,
			 int? intro = null
			){
			var req = new VKRequest<ConfirmResult>{
				MethodName = "auth.confirm",
				Parameters = new Dictionary<string, string> {
					{ "client_id", clientId.ToNCString() },
			{ "client_secret", clientSecret },
			{ "phone", phone },
			{ "code", code },
			{ "password", password },
			{ "test_mode", (testMode?1:0).ToNCString() },
			{ "intro", MiscTools.NullableString(intro) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<AuthRestore> AuthRestore(
			 long phone 
			){
			var req = new VKRequest<AuthRestore>{
				MethodName = "auth.restore",
				Parameters = new Dictionary<string, string> {
					{ "phone", phone.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<bool>> BoardCloseTopic(
			 uint groupId ,
			 uint topicId 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "board.closeTopic",
				Parameters = new Dictionary<string, string> {
					{ "group_id", groupId.ToNCString() },
			{ "topic_id", topicId.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> BoardDeleteComment(
			 uint groupId ,
			 uint topicId ,
			 uint commentId 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "board.deleteComment",
				Parameters = new Dictionary<string, string> {
					{ "group_id", groupId.ToNCString() },
			{ "topic_id", topicId.ToNCString() },
			{ "comment_id", commentId.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> BoardDeleteTopic(
			 uint groupId ,
			 uint topicId 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "board.deleteTopic",
				Parameters = new Dictionary<string, string> {
					{ "group_id", groupId.ToNCString() },
			{ "topic_id", topicId.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> BoardFixTopic(
			 uint groupId ,
			 uint topicId 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "board.fixTopic",
				Parameters = new Dictionary<string, string> {
					{ "group_id", groupId.ToNCString() },
			{ "topic_id", topicId.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> BoardUnfixTopic(
			 uint groupId ,
			 uint topicId 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "board.unfixTopic",
				Parameters = new Dictionary<string, string> {
					{ "group_id", groupId.ToNCString() },
			{ "topic_id", topicId.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> BoardRestoreComment(
			 uint groupId ,
			 uint topicId ,
			 uint commentId 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "board.restoreComment",
				Parameters = new Dictionary<string, string> {
					{ "group_id", groupId.ToNCString() },
			{ "topic_id", topicId.ToNCString() },
			{ "comment_id", commentId.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<EntityList<DatabaseEntry>> DatabaseGetCountries(
			 string code = "",
			 bool needAll = false,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<EntityList<DatabaseEntry>>{
				MethodName = "database.getCountries",
				Parameters = new Dictionary<string, string> {
					{ "code", code },
			{ "need_all", (needAll?1:0).ToNCString() },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<EntityList<DatabaseEntry>> DatabaseGetRegions(
			 uint countryId ,
			 string q = "",
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<EntityList<DatabaseEntry>>{
				MethodName = "database.getRegions",
				Parameters = new Dictionary<string, string> {
					{ "country_id", countryId.ToNCString() },
			{ "q", q },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<DatabaseEntry> DatabaseGetStreetsById(
			params uint[] streetIds 
			){
			var req = new VKRequest<DatabaseEntry>{
				MethodName = "database.getStreetsById",
				Parameters = new Dictionary<string, string> {
					{ "street_ids", (streetIds??new uint[]{}).ToNCStringA() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<EntityList<DatabaseEntry>> DatabaseGetCountriesById(
			params uint[] countryIds 
			){
			var req = new VKRequest<EntityList<DatabaseEntry>>{
				MethodName = "database.getCountriesById",
				Parameters = new Dictionary<string, string> {
					{ "country_ids", (countryIds??new uint[]{}).ToNCStringA() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<DatabaseCity> DatabaseGetCitiesById(
			params uint[] cityIds 
			){
			var req = new VKRequest<DatabaseCity>{
				MethodName = "database.getCitiesById",
				Parameters = new Dictionary<string, string> {
					{ "city_ids", (cityIds??new uint[]{}).ToNCStringA() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<DatabaseCity> DatabaseGetCities(
			 uint countryId ,
			 uint? regionId = null,
			 string q = "",
			 bool needAll = false,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<DatabaseCity>{
				MethodName = "database.getCities",
				Parameters = new Dictionary<string, string> {
					{ "country_id", countryId.ToNCString() },
			{ "region_id", MiscTools.NullableString(regionId) },
			{ "q", q },
			{ "need_all", (needAll?1:0).ToNCString() },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<DatabaseEntry> DatabaseGetUniversities(
			 uint? countryId = null,
			 uint? cityId = null,
			 string q = "",
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<DatabaseEntry>{
				MethodName = "database.getUniversities",
				Parameters = new Dictionary<string, string> {
					{ "country_id", MiscTools.NullableString(countryId) },
			{ "city_id", MiscTools.NullableString(cityId) },
			{ "q", q },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<DatabaseEntry> DatabaseGetSchools(
			 uint? cityId = null,
			 string q = "",
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<DatabaseEntry>{
				MethodName = "database.getSchools",
				Parameters = new Dictionary<string, string> {
					{ "city_id", MiscTools.NullableString(cityId) },
			{ "q", q },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<EntityList<DatabaseEntry>> DatabaseGetFaculties(
			 uint universityId ,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<EntityList<DatabaseEntry>>{
				MethodName = "database.getFaculties",
				Parameters = new Dictionary<string, string> {
					{ "university_id", universityId.ToNCString() },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<EntityList<DatabaseEntry>> DatabaseGetChairs(
			 uint facultyId ,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<EntityList<DatabaseEntry>>{
				MethodName = "database.getChairs",
				Parameters = new Dictionary<string, string> {
					{ "faculty_id", facultyId.ToNCString() },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<int>> DocsAdd(
			 long docId ,
			 int ownerId ,
			 string accessKey = ""
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "docs.add",
				Parameters = new Dictionary<string, string> {
					{ "doc_id", docId.ToNCString() },
			{ "owner_id", ownerId.ToNCString() },
			{ "access_key", accessKey }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> DocsDelete(
			 long docId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "docs.delete",
				Parameters = new Dictionary<string, string> {
					{ "doc_id", docId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<SimpleEntity<string>> DocsGetUploadServer(
			 uint? groupId = null
			){
			var req = new VKRequest<SimpleEntity<string>>{
				MethodName = "docs.getUploadServer",
				Parameters = new Dictionary<string, string> {
					{ "group_id", MiscTools.NullableString(groupId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<SimpleEntity<string>> DocsGetWallUploadServer(
			 uint? groupId = null
			){
			var req = new VKRequest<SimpleEntity<string>>{
				MethodName = "docs.getWallUploadServer",
				Parameters = new Dictionary<string, string> {
					{ "group_id", MiscTools.NullableString(groupId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<EntityList<Document>> DocsGet(
			 int? ownerId = null,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<EntityList<Document>>{
				MethodName = "docs.get",
				Parameters = new Dictionary<string, string> {
					{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<Document> DocsGetById(
			params Tuple<int,int>[] docs 
			){
			var req = new VKRequest<Document>{
				MethodName = "docs.getById",
				Parameters = new Dictionary<string, string> {
					{ "docs", String.Join(",",docs.Select(a=>a.Item1 +"_" +a.Item2)) }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<Document> DocsSave(
			 string file ,
			 string title ,
			params string[] tags 
			){
			var req = new VKRequest<Document>{
				MethodName = "docs.save",
				Parameters = new Dictionary<string, string> {
					{ "file", file },
			{ "title", title },
			{ "tags", String.Join(",",tags) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<EntityList<User>> FriendsGet(
			 uint? userId = null,
			 uint? listId = null,
			 UserFields fields = UserFields.None,
			 UserSortOrder order = UserSortOrder.ById,
			 NameCase nameCase = NameCase.Nom,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<EntityList<User>>{
				MethodName = "friends.get",
				Parameters = new Dictionary<string, string> {
					{ "user_id", MiscTools.NullableString(userId) },
			{ "list_id", MiscTools.NullableString(listId) },
			{ "fields", String.Join( ",", MiscTools.GetUserFields( fields ) ) },
			{ "order", order.ToNClString() },
			{ "name_case", nameCase.ToNClString() },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<EntityList<User>> FriendsGetSuggestions(
			 FriendSuggestionFilters filters = FriendSuggestionFilters.Everything,
			 UserFields fields = UserFields.None,
			 NameCase nameCase = NameCase.Nom,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<EntityList<User>>{
				MethodName = "friends.getSuggestions",
				Parameters = new Dictionary<string, string> {
					{ "filters", String.Join( ",", MiscTools.GetFilterFields( filters ) ) },
			{ "fields", String.Join( ",", MiscTools.GetUserFields( fields ) ) },
			{ "name_case", nameCase.ToNClString() },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<User> FriendsGetByPhones(
			 UserFields fields = UserFields.None,
			 ulong[] phones = null
			){
			var req = new VKRequest<User>{
				MethodName = "friends.getByPhones",
				Parameters = new Dictionary<string, string> {
					{ "fields", String.Join( ",", MiscTools.GetUserFields( fields ) ) },
			{ "phones", String.Join( ",", phones.Select( a => "+" + a ) ) }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<int>> FriendsAdd(
			 uint userId ,
			 string text = ""
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "friends.add",
				Parameters = new Dictionary<string, string> {
					{ "user_id", userId.ToNCString() },
			{ "text", text }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> FriendsDeleteAllRequests(
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "friends.deleteAllRequests",
				Parameters = new Dictionary<string, string> {
						}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<int>> FriendsGetRecent(
			 uint count = 20
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "friends.getRecent",
				Parameters = new Dictionary<string, string> {
					{ "count", count.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<int>> FriendsDelete(
			 uint userId 
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "friends.delete",
				Parameters = new Dictionary<string, string> {
					{ "user_id", userId.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> FriendsDeleteList(
			 uint listId 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "friends.deleteList",
				Parameters = new Dictionary<string, string> {
					{ "list_id", listId.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<int>> FriendsGetAppUsers(
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "friends.getAppUsers",
				Parameters = new Dictionary<string, string> {
						}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<int>> FriendsGetMutual(
			 uint targetUid ,
			 uint? sourceUid = null,
			 bool order = false,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "friends.getMutual",
				Parameters = new Dictionary<string, string> {
					{ "target_uid", targetUid.ToNCString() },
			{ "source_uid", MiscTools.NullableString(sourceUid) },
			{ "order", order ? "random" : "" },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<User> GroupsGetBanned(
			 uint groupId ,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<User>{
				MethodName = "groups.getBanned",
				Parameters = new Dictionary<string, string> {
					{ "group_id", groupId.ToNCString() },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<Group> GroupsGetById(
			 string[] groupIds ,
			 GroupFields fields 
			){
			var req = new VKRequest<Group>{
				MethodName = "groups.getById",
				Parameters = new Dictionary<string, string> {
					{ "group_ids", String.Join(",",groupIds) },
			{ "fields", String.Join( ",", MiscTools.GetGroupFields( fields ) ) }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<Group> GroupsGetById(
			 uint groupId ,
			 GroupFields fields 
			){
			var req = new VKRequest<Group>{
				MethodName = "groups.getById",
				Parameters = new Dictionary<string, string> {
					{ "group_id", groupId.ToNCString() },
			{ "fields", String.Join( ",", MiscTools.GetGroupFields( fields ) ) }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<EntityList<User>> GroupsGetMembers(
			 uint groupId ,
			 UserFields fields = UserFields.Everything,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<EntityList<User>>{
				MethodName = "groups.getMembers",
				Parameters = new Dictionary<string, string> {
					{ "group_id", groupId.ToNCString() },
			{ "fields", String.Join( ",", MiscTools.GetUserFields( fields ) ) },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<EntityList<User>> GroupsGetMembers(
			 string groupId ,
			 UserFields fields = UserFields.None,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<EntityList<User>>{
				MethodName = "groups.getMembers",
				Parameters = new Dictionary<string, string> {
					{ "group_id", groupId },
			{ "fields", String.Join( ",", MiscTools.GetUserFields( fields ) ) },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<MemberShip> GroupsIsMember(
			 uint groupId ,
			 bool extended = false,
			params uint[] userIds 
			){
			var req = new VKRequest<MemberShip>{
				MethodName = "groups.isMember",
				Parameters = new Dictionary<string, string> {
					{ "group_id", groupId.ToNCString() },
			{ "extended", (extended?1:0).ToNCString() },
			{ "user_ids", (userIds??new uint[]{}).ToNCStringA() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<bool>> GroupsJoin(
			 uint groupId ,
			 bool notSure = false
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "groups.join",
				Parameters = new Dictionary<string, string> {
					{ "group_id", groupId.ToNCString() },
			{ "not_sure", (notSure?1:0).ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> GroupsLeave(
			 uint groupId 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "groups.leave",
				Parameters = new Dictionary<string, string> {
					{ "group_id", groupId.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> GroupsUnbanUser(
			 uint groupId ,
			 uint userId 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "groups.unbanUser",
				Parameters = new Dictionary<string, string> {
					{ "group_id", groupId.ToNCString() },
			{ "user_id", userId.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> MessagesAddChatUser(
			 uint userId ,
			 uint? chatId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "messages.addChatUser",
				Parameters = new Dictionary<string, string> {
					{ "user_id", userId.ToNCString() },
			{ "chat_id", MiscTools.NullableString(chatId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> MessagesRemoveChatUser(
			 uint userId ,
			 uint chatId 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "messages.removeChatUser",
				Parameters = new Dictionary<string, string> {
					{ "user_id", userId.ToNCString() },
			{ "chat_id", chatId.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> MessagesDelete(
			params int[] messageIds 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "messages.delete",
				Parameters = new Dictionary<string, string> {
					{ "message_ids", (messageIds??new int[]{}).ToNCStringA() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> MessagesMarkAsRead(
			 uint userId ,
			 uint? startMessageId = null,
			params int[] messageIds 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "messages.markAsRead",
				Parameters = new Dictionary<string, string> {
					{ "user_id", userId.ToNCString() },
			{ "start_message_id", MiscTools.NullableString(startMessageId) },
			{ "message_ids", (messageIds??new int[]{}).ToNCStringA() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> MessagesRestore(
			 int messageId 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "messages.restore",
				Parameters = new Dictionary<string, string> {
					{ "message_id", messageId.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> MessagesDeleteDialog(
			 uint userId ,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "messages.deleteDialog",
				Parameters = new Dictionary<string, string> {
					{ "user_id", userId.ToNCString() },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> MessagesMarkAsImportant(
			 bool important ,
			params int[] messageIds 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "messages.markAsImportant",
				Parameters = new Dictionary<string, string> {
					{ "important", (important?1:0).ToNCString() },
			{ "message_ids", (messageIds??new int[]{}).ToNCStringA() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> NewsfeedAddBan(
			 uint[] userIds = null,
			 uint[] groupIds = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "newsfeed.addBan",
				Parameters = new Dictionary<string, string> {
					{ "user_ids", (userIds??new uint[]{}).ToNCStringA() },
			{ "group_ids", (groupIds??new uint[]{}).ToNCStringA() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> NewsfeedDeleteBan(
			 uint[] userIds = null,
			 uint[] groupIds = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "newsfeed.deleteBan",
				Parameters = new Dictionary<string, string> {
					{ "user_ids", (userIds??new uint[]{}).ToNCStringA() },
			{ "group_ids", (groupIds??new uint[]{}).ToNCStringA() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> NotesDelete(
			 uint noteId 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "notes.delete",
				Parameters = new Dictionary<string, string> {
					{ "note_id", noteId.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> NotesDeleteComment(
			 uint commentId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "notes.deleteComment",
				Parameters = new Dictionary<string, string> {
					{ "comment_id", commentId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> NotesRestoreComment(
			 uint commentId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "notes.restoreComment",
				Parameters = new Dictionary<string, string> {
					{ "comment_id", commentId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> NotificationsMarkAsViewed(
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "notifications.markAsViewed",
				Parameters = new Dictionary<string, string> {
						}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> PagesClearCache(
			 string url 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "pages.clearCache",
				Parameters = new Dictionary<string, string> {
					{ "url", url }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<bool>> PhotosDeleteComment(
			 uint commentId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "photos.deleteComment",
				Parameters = new Dictionary<string, string> {
					{ "comment_id", commentId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> PhotosRestoreComment(
			 uint commentId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "photos.restoreComment",
				Parameters = new Dictionary<string, string> {
					{ "comment_id", commentId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> PhotosReportComment(
			 uint commentId ,
			 int? ownerId = null,
			 ReportReason? reason = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "photos.reportComment",
				Parameters = new Dictionary<string, string> {
					{ "comment_id", commentId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "reason", reason == null ? "" : ( (int)reason ).ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> PhotosDeleteAlbum(
			 long albumId ,
			 uint? groupId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "photos.deleteAlbum",
				Parameters = new Dictionary<string, string> {
					{ "album_id", albumId.ToNCString() },
			{ "group_id", MiscTools.NullableString(groupId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> PhotosDelete(
			 long photoId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "photos.delete",
				Parameters = new Dictionary<string, string> {
					{ "photo_id", photoId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> PhotosConfirmTag(
			 uint tagId ,
			 long photoId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "photos.confirmTag",
				Parameters = new Dictionary<string, string> {
					{ "tag_id", tagId.ToNCString() },
			{ "photo_id", photoId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> PhotosRemoveTag(
			 uint tagId ,
			 long photoId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "photos.removeTag",
				Parameters = new Dictionary<string, string> {
					{ "tag_id", tagId.ToNCString() },
			{ "photo_id", photoId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> PhotosReport(
			 long photoId ,
			 int? ownerId = null,
			 ReportReason? reason = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "photos.report",
				Parameters = new Dictionary<string, string> {
					{ "photo_id", photoId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "reason", reason == null ? "" : ( (int)reason ).ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> PhotosCopy(
			 long photoId ,
			 int? ownerId = null,
			 string accessKey = ""
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "photos.copy",
				Parameters = new Dictionary<string, string> {
					{ "photo_id", photoId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "access_key", accessKey }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> PhotosEdit(
			 long photoId ,
			 int? ownerId = null,
			 string caption = ""
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "photos.edit",
				Parameters = new Dictionary<string, string> {
					{ "photo_id", photoId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "caption", caption }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<int>> PhotosGetAlbumsCount(
			 uint? userId = null,
			 uint? groupId = null
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "photos.getAlbumsCount",
				Parameters = new Dictionary<string, string> {
					{ "user_id", MiscTools.NullableString(userId) },
			{ "group_id", MiscTools.NullableString(groupId) }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<PhotoAlbum> PhotosCreateAlbum(
			 string title ,
			 string description = "",
			 uint? groupId = null,
			 PrivacyType? privacy = null,
			 PrivacyType? commentPrivacy = null
			){
			var req = new VKRequest<PhotoAlbum>{
				MethodName = "photos.createAlbum",
				Parameters = new Dictionary<string, string> {
					{ "title", title },
			{ "description", description },
			{ "group_id", MiscTools.NullableString(groupId) },
			{ "privacy", MiscTools.NullableString( (byte?)privacy ) },
			{ "comment_privacy", MiscTools.NullableString( (byte?)commentPrivacy ) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> PhotosEditAlbum(
			 long albumId ,
			 int? ownerId = null,
			 string title = "",
			 string description = "",
			 PrivacyType? privacy = null,
			 PrivacyType? commentPrivacy = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "photos.editAlbum",
				Parameters = new Dictionary<string, string> {
					{ "album_id", albumId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "title", title },
			{ "description", description },
			{ "privacy", MiscTools.NullableString( (byte?)privacy ) },
			{ "comment_privacy", MiscTools.NullableString( (byte?)commentPrivacy ) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<SimpleEntity<string>> PhotosGetOwnerPhotoUploadServer(
			){
			var req = new VKRequest<SimpleEntity<string>>{
				MethodName = "photos.getOwnerPhotoUploadServer",
				Parameters = new Dictionary<string, string> {
						}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<PhotosUploadServer> PhotosGetUploadServer(
			 long albumId ,
			 uint? groupId = null
			){
			var req = new VKRequest<PhotosUploadServer>{
				MethodName = "photos.getUploadServer",
				Parameters = new Dictionary<string, string> {
					{ "album_id", albumId.ToNCString() },
			{ "group_id", MiscTools.NullableString(groupId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<PhotosUploadServer> PhotosGetChatUploadServer(
			 uint chatId ,
			 uint? cropX = null,
			 uint? cropY = null,
			 uint? cropWidth = null
			){
			var req = new VKRequest<PhotosUploadServer>{
				MethodName = "photos.getChatUploadServer",
				Parameters = new Dictionary<string, string> {
					{ "chat_id", chatId.ToNCString() },
			{ "crop_x", MiscTools.NullableString(cropX) },
			{ "crop_y", MiscTools.NullableString(cropY) },
			{ "crop_width", MiscTools.NullableString(cropWidth) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> PhotosReorderAlbums(
			 long albumId ,
			 int? ownerId = null,
			 long? before = null,
			 long? after = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "photos.reorderAlbums",
				Parameters = new Dictionary<string, string> {
					{ "album_id", albumId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "before", MiscTools.NullableString(before) },
			{ "after", MiscTools.NullableString(after) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> PhotosReorderPhotos(
			 long photoId ,
			 int? ownerId = null,
			 long? before = null,
			 long? after = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "photos.reorderPhotos",
				Parameters = new Dictionary<string, string> {
					{ "photo_id", photoId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "before", MiscTools.NullableString(before) },
			{ "after", MiscTools.NullableString(after) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> PhotosMove(
			 long targetAlbumId ,
			 long photoId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "photos.move",
				Parameters = new Dictionary<string, string> {
					{ "target_album_id", targetAlbumId.ToNCString() },
			{ "photo_id", photoId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> PhotosMakeCover(
			 long albumId ,
			 long photoId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "photos.makeCover",
				Parameters = new Dictionary<string, string> {
					{ "album_id", albumId.ToNCString() },
			{ "photo_id", photoId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<EntityList<Photo>> PhotosGetAll(
			 int? ownerId = null,
			 bool extended = false,
			 bool noServiceAlbums = false,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<EntityList<Photo>>{
				MethodName = "photos.getAll",
				Parameters = new Dictionary<string, string> {
					{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "extended", (extended?1:0).ToNCString() },
			{ "no_service_albums", (noServiceAlbums?1:0).ToNCString() },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<EntityList<Photo>> PhotosGet(
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
			var req = new VKRequest<EntityList<Photo>>{
				MethodName = "photos.get",
				Parameters = new Dictionary<string, string> {
					{ "album_id", MiscTools.NullableString(albumId) },
			{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "photo_ids", (photoIds??new int[]{}).ToNCStringA() },
			{ "rev", (rev?1:0).ToNCString() },
			{ "extended", (extended?1:0).ToNCString() },
			{ "feed_type", MiscTools.NullableString( feedType ) },
			{ "feed", MiscTools.NullableString(feed) },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<EntityList<Photo>> PhotosGet(
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
			var req = new VKRequest<EntityList<Photo>>{
				MethodName = "photos.get",
				Parameters = new Dictionary<string, string> {
					{ "album_id", albumId.ToNClString() },
			{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "photo_ids", (photoIds??new int[]{}).ToNCStringA() },
			{ "rev", (rev?1:0).ToNCString() },
			{ "extended", (extended?1:0).ToNCString() },
			{ "feed_type", MiscTools.NullableString( feedType ) },
			{ "feed", MiscTools.NullableString(feed) },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<EntityList<PhotoAlbum>> PhotosGetAlbums(
			 int? ownerId = null,
			 bool needSystem = true,
			 bool needCovers = true,
			 uint offset = 0,
			 uint count = 100,
			params long[] albumIds 
			){
			var req = new VKRequest<EntityList<PhotoAlbum>>{
				MethodName = "photos.getAlbums",
				Parameters = new Dictionary<string, string> {
					{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "need_system", (needSystem?1:0).ToNCString() },
			{ "need_covers", (needCovers?1:0).ToNCString() },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() },
			{ "album_ids", (albumIds??new long[]{}).ToNCStringA() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<Photo> PhotosSave(
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
			var req = new VKRequest<Photo>{
				MethodName = "photos.save",
				Parameters = new Dictionary<string, string> {
					{ "album_id", albumId.ToNCString() },
			{ "server", server },
			{ "photos_list", photosList },
			{ "hash", hash },
			{ "group_id", MiscTools.NullableString(groupId) },
			{ "latitude", MiscTools.NullableString(latitude) },
			{ "longitude", MiscTools.NullableString(longitude) },
			{ "caption", caption },
			{ "description", description }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<Status> StatusGet(
			 int? userId = null
			){
			var req = new VKRequest<Status>{
				MethodName = "status.get",
				Parameters = new Dictionary<string, string> {
					{ "user_id", MiscTools.NullableString(userId) }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<bool>> StatusSet(
			 string text 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "status.set",
				Parameters = new Dictionary<string, string> {
					{ "text", text }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StorageEntry> StorageGet(
			 uint? userId = null,
			 bool global = false,
			params string[] keys 
			){
			var req = new VKRequest<StorageEntry>{
				MethodName = "storage.get",
				Parameters = new Dictionary<string, string> {
					{ "user_id", MiscTools.NullableString(userId) },
			{ "global", (global?1:0).ToNCString() },
			{ "keys", String.Join(",",keys) }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<SimpleEntity<string>> StorageGetKeys(
			 uint? userId = null,
			 bool global = false,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<SimpleEntity<string>>{
				MethodName = "storage.getKeys",
				Parameters = new Dictionary<string, string> {
					{ "user_id", MiscTools.NullableString(userId) },
			{ "global", (global?1:0).ToNCString() },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StorageEntry> StorageSet(
			 string key ,
			 string value ,
			 uint? userId = null,
			 bool global = false
			){
			var req = new VKRequest<StorageEntry>{
				MethodName = "storage.set",
				Parameters = new Dictionary<string, string> {
					{ "key", key },
			{ "value", value },
			{ "user_id", MiscTools.NullableString(userId) },
			{ "global", (global?1:0).ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<bool>> UsersIsAppUser(
			 uint? userId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "users.isAppUser",
				Parameters = new Dictionary<string, string> {
					{ "user_id", MiscTools.NullableString(userId) }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<int>> UsersReport(
			 uint userId ,
			 ComplaintType type ,
			 string comment 
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "users.report",
				Parameters = new Dictionary<string, string> {
					{ "user_id", userId.ToNCString() },
			{ "type", type.ToNClString() },
			{ "comment", comment }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<UserSubscriptions> UsersGetSubscriptions(
			 uint? userId = null,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<UserSubscriptions>{
				MethodName = "users.getSubscriptions",
				Parameters = new Dictionary<string, string> {
					{ "user_id", MiscTools.NullableString(userId) },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<User> UsersGet(
			 UserFields fields = UserFields.None,
			 NameCase nameCase = NameCase.Nom,
			params uint[] userIds 
			){
			var req = new VKRequest<User>{
				MethodName = "users.get",
				Parameters = new Dictionary<string, string> {
					{ "fields", String.Join( ",", MiscTools.GetUserFields( fields ) ) },
			{ "name_case", nameCase.ToNClString() },
			{ "user_ids", (userIds??new uint[]{}).ToNCStringA() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<EntityList<User>> UsersGetFollowers(
			 uint? userId = null,
			 UserFields fields = UserFields.None,
			 NameCase nameCase = NameCase.Nom,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<EntityList<User>>{
				MethodName = "users.getFollowers",
				Parameters = new Dictionary<string, string> {
					{ "user_id", MiscTools.NullableString(userId) },
			{ "fields", String.Join( ",", MiscTools.GetUserFields( fields ) ) },
			{ "name_case", nameCase.ToNClString() },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<EntityList<User>> UsersGetNearby(
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
			var req = new VKRequest<EntityList<User>>{
				MethodName = "users.getNearby",
				Parameters = new Dictionary<string, string> {
					{ "latitude", latitude.ToNCString() },
			{ "longitude", longitude.ToNCString() },
			{ "accuracy", MiscTools.NullableString(accuracy) },
			{ "timeout", MiscTools.NullableString(timeout) },
			{ "radius", MiscTools.NullableString(radius) },
			{ "fields", String.Join( ",", MiscTools.GetUserFields( fields ) ) },
			{ "name_case", nameCase.ToNClString() },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<LinkCheckResult> UtilsCheckLink(
			 string url = ""
			){
			var req = new VKRequest<LinkCheckResult>{
				MethodName = "utils.checkLink",
				Parameters = new Dictionary<string, string> {
					{ "url", url }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<int>> UtilsGetServerTime(
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "utils.getServerTime",
				Parameters = new Dictionary<string, string> {
						}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<bool>> VideoDeleteComment(
			 uint commentId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "video.deleteComment",
				Parameters = new Dictionary<string, string> {
					{ "comment_id", commentId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> VideoRestoreComment(
			 uint commentId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "video.restoreComment",
				Parameters = new Dictionary<string, string> {
					{ "comment_id", commentId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> VideoReportComment(
			 uint commentId ,
			 int? ownerId = null,
			 ReportReason? reason = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "video.reportComment",
				Parameters = new Dictionary<string, string> {
					{ "comment_id", commentId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "reason", reason == null ? "" : ( (int)reason ).ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<int>> VideoDeleteAlbum(
			 long albumId ,
			 uint? groupId = null
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "video.deleteAlbum",
				Parameters = new Dictionary<string, string> {
					{ "album_id", albumId.ToNCString() },
			{ "group_id", MiscTools.NullableString(groupId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<int>> VideoDelete(
			 ulong videoId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "video.delete",
				Parameters = new Dictionary<string, string> {
					{ "video_id", videoId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<int>> VideoRemoveTag(
			 ulong videoId ,
			 uint tagId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "video.removeTag",
				Parameters = new Dictionary<string, string> {
					{ "video_id", videoId.ToNCString() },
			{ "tag_id", tagId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<int>> VideoReport(
			 ulong videoId ,
			 int? ownerId = null,
			 ReportReason? reason = null,
			 string comment = "",
			 string searchQuery = ""
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "video.report",
				Parameters = new Dictionary<string, string> {
					{ "video_id", videoId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "reason", reason == null ? "" : ( (int)reason ).ToNCString() },
			{ "comment", comment },
			{ "search_query", searchQuery }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> WallDelete(
			 uint postId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "wall.delete",
				Parameters = new Dictionary<string, string> {
					{ "post_id", postId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> WallRestore(
			 uint postId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "wall.restore",
				Parameters = new Dictionary<string, string> {
					{ "post_id", postId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> WallDeleteComment(
			 uint commentId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "wall.deleteComment",
				Parameters = new Dictionary<string, string> {
					{ "comment_id", commentId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> WallRestoreComment(
			 uint commentId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "wall.restoreComment",
				Parameters = new Dictionary<string, string> {
					{ "comment_id", commentId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> WallReportPost(
			 uint postId ,
			 int? ownerId = null,
			 ReportReason? reason = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "wall.reportPost",
				Parameters = new Dictionary<string, string> {
					{ "post_id", postId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "reason", reason == null ? "" : ( (int)reason ).ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> WallReportComment(
			 uint commentId ,
			 int? ownerId = null,
			 ReportReason? reason = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "wall.reportComment",
				Parameters = new Dictionary<string, string> {
					{ "comment_id", commentId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "reason", reason == null ? "" : ( (int)reason ).ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<Post> WallGetById(
			 uint copyHistoryDepth = 2,
			params string[] posts 
			){
			var req = new VKRequest<Post>{
				MethodName = "wall.getById",
				Parameters = new Dictionary<string, string> {
					{ "copy_history_depth", copyHistoryDepth.ToNCString() },
			{ "posts", String.Join(",",posts) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<Post> WallGetById(
			 uint copyHistoryDepth = 2,
			params Tuple<int,uint>[] posts 
			){
			var req = new VKRequest<Post>{
				MethodName = "wall.getById",
				Parameters = new Dictionary<string, string> {
					{ "copy_history_depth", copyHistoryDepth.ToNCString() },
			{ "posts", String.Join(",",posts.Select(a=>a.Item1 +"_" +a.Item2)) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<EntityList<Post>> WallGet(
			 int? ownerId = null,
			 string domain = "",
			 WallPostFilter filter = WallPostFilter.All,
			 uint offset = 0,
			 uint count = 100
			){
			var req = new VKRequest<EntityList<Post>>{
				MethodName = "wall.get",
				Parameters = new Dictionary<string, string> {
					{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "domain", domain },
			{ "filter", filter.ToNClString().ToSnake() },
			{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<bool>> WallPin(
			 uint postId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "wall.pin",
				Parameters = new Dictionary<string, string> {
					{ "post_id", postId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> WallUnpin(
			 uint postId ,
			 int? ownerId = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "wall.unpin",
				Parameters = new Dictionary<string, string> {
					{ "post_id", postId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<RepostInfo> WallRepost(
			 string @object ,
			 string message = "",
			 uint? groupId = null
			){
			var req = new VKRequest<RepostInfo>{
				MethodName = "wall.repost",
				Parameters = new Dictionary<string, string> {
					{ "object", @object },
			{ "message", message },
			{ "group_id", MiscTools.NullableString(groupId) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
	}
}