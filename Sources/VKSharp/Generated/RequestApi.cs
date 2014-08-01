using System;
using System.Collections.Generic;
using VKSharp.Core.Entities;
using VKSharp.Data.Api;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;
namespace VKSharp {
	public class RequestApi {
		private VKToken CurrentToken {get;set;}
		private bool IsLogged {get;set;}
		public VKRequest<StructEntity<bool>> AccountSetNameInMenuAsync(
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
		public VKRequest<StructEntity<bool>> AccountSetOnlineAsync(
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
		public VKRequest<StructEntity<bool>> AccountSetOfflineAsync(
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "account.setOffline",
				Parameters = new Dictionary<string, string> {
						}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<bool>> AccountUnregisterDeviceAsync(
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
		public VKRequest<StructEntity<bool>> AccountSetSilenceModeAsync(
			string token ,
			int time ,
			int chatId ,
			int userId ,
			int sound 
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "account.setSilenceMode",
				Parameters = new Dictionary<string, string> {
					{ "token", token },
			{ "time", time.ToNCString() },
			{ "chat_id", chatId.ToNCString() },
			{ "user_id", userId.ToNCString() },
			{ "sound", sound.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<long>> AccountGetAppPermissionsAsync(
			uint userId 
			){
			var req = new VKRequest<StructEntity<long>>{
				MethodName = "account.getAppPermissions",
				Parameters = new Dictionary<string, string> {
					{ "user_id", userId.ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<long>> AccountBanUserAsync(
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
		public VKRequest<EntityList<User>> AccountGetBannedAsync(
			uint offset = 0,
			uint count = 20
			){
			var req = new VKRequest<EntityList<User>>{
				MethodName = "account.getBanned",
				Parameters = new Dictionary<string, string> {
					{ "offset", offset.ToNCString() },
			{ "count", count.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<long>> AccountSetInfoAsync(
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
		public VKRequest<User> AccountGetProfileInfoAsync(
			){
			var req = new VKRequest<User>{
				MethodName = "account.getProfileInfo",
				Parameters = new Dictionary<string, string> {
						}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<StructEntity<int>> AudioAddAlbumAsync(
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
		public VKRequest<StructEntity<int>> AudioAddAsync(
			int ownerId ,
			uint audioId ,
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
		public VKRequest<StructEntity<int>> AudioDeleteAlbumAsync(
			uint albumId ,
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
		public VKRequest<StructEntity<int>> AudioDeleteAsync(
			int ownerId ,
			uint audioId 
			){
			var req = new VKRequest<StructEntity<int>>{
				MethodName = "audio.delete",
				Parameters = new Dictionary<string, string> {
					{ "owner_id", ownerId.ToNCString() },
			{ "audio_id", audioId.ToNCString() }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<EntityList<Audio>> AudioGetAsync(
			int? offset = null,
			int? count = null,
			bool needUser = false,
			int? ownerId = null,
			int? albumId = null,
			ulong[] audioIds = null
			){
			var req = new VKRequest<EntityList<Audio>>{
				MethodName = "audio.get",
				Parameters = new Dictionary<string, string> {
					{ "offset", MiscTools.NullableString(offset) },
			{ "count", MiscTools.NullableString(count) },
			{ "need_user", (needUser?1:0).ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "album_id", MiscTools.NullableString(albumId) },
			{ "audio_ids", audioIds.ToNCStringA() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<Audio> AudioGetByIdAsync(
			string[] audios ,
			bool itunes = false
			){
			var req = new VKRequest<Audio>{
				MethodName = "audio.getById",
				Parameters = new Dictionary<string, string> {
					{ "audios", String.Join(",",audios) },
			{ "itunes", (itunes?1:0).ToNCString() }
				}
			};
			if (IsLogged){
				req.Token = CurrentToken;
			}
			return req;
		}
		public VKRequest<StructEntity<int>> AudioGetCountAsync(
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
		public VKRequest<Lyrics> AudioGetLyricsAsync(
			int lyricsId 
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
		public VKRequest<SimpleEntity<string>> AudioGetUploadServerAsync(
			int albumId ,
			int? groupId = null
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
		public VKRequest<StructEntity<bool>> AudioReorderAsync(
			int audioId ,
			int? ownerId = null,
			int? after = null,
			int? before = null
			){
			var req = new VKRequest<StructEntity<bool>>{
				MethodName = "audio.reorder",
				Parameters = new Dictionary<string, string> {
					{ "audio_id", audioId.ToNCString() },
			{ "owner_id", MiscTools.NullableString(ownerId) },
			{ "after", MiscTools.NullableString(after) },
			{ "before", MiscTools.NullableString(before) }
				}
			};
				req.Token = CurrentToken;
			
			return req;
		}
		public VKRequest<Audio> AudioRestoreAsync(
			int audioId ,
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
		public VKRequest<Audio> AudioSaveAsync(
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
	}
}
