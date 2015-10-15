
using System;
using System.Collections.Generic;
using System.Linq;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Core.ResponseEntities;
using VKSharp.Data.Api;
using VKSharp.Data.Parameters;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.DataTypes;

// ReSharper disable UnusedMember.Global
// ReSharper disable UseObjectOrCollectionInitializer
namespace VKSharp {
    public partial class RequestApi {
        private void InitializeMethodGroups(){
            this.Account = new MethodGroup_account(this);
            this.Ads = new MethodGroup_ads(this);
            this.Apps = new MethodGroup_apps(this);
            this.Audio = new MethodGroup_audio(this);
            this.Auth = new MethodGroup_auth(this);
            this.Board = new MethodGroup_board(this);
            this.Database = new MethodGroup_database(this);
            this.Docs = new MethodGroup_docs(this);
            this.Fave = new MethodGroup_fave(this);
            this.Friends = new MethodGroup_friends(this);
            this.Groups = new MethodGroup_groups(this);
            this.Messages = new MethodGroup_messages(this);
            this.Newsfeed = new MethodGroup_newsfeed(this);
            this.Notes = new MethodGroup_notes(this);
            this.Notifications = new MethodGroup_notifications(this);
            this.Pages = new MethodGroup_pages(this);
            this.Photos = new MethodGroup_photos(this);
            this.Polls = new MethodGroup_polls(this);
            this.Stats = new MethodGroup_stats(this);
            this.Status = new MethodGroup_status(this);
            this.Storage = new MethodGroup_storage(this);
            this.Users = new MethodGroup_users(this);
            this.Utils = new MethodGroup_utils(this);
            this.Video = new MethodGroup_video(this);
            this.Wall = new MethodGroup_wall(this);
            this.Likes = new MethodGroup_likes(this);
        }
        public MethodGroup_account Account {get; private set;}
        public partial class MethodGroup_account {
            private readonly RequestApi _parent;
            internal MethodGroup_account(RequestApi parent){_parent=parent;}

            public VKRequest<bool> BanUser(
                 int userId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "account.banUser",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<ChangePassword> ChangePassword(
                string restoreSid , string changePasswordHash , string oldPassword ,  string newPassword 
            ) {
                var req = new VKRequest<ChangePassword>{
                    MethodName = "account.changePassword",
                    Parameters = new Dictionary<string, string> {

                        { "restore_sid", restoreSid},
                        { "change_password_hash", changePasswordHash},
                        { "old_password", oldPassword},
                        { "new_password", newPassword},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<Offer>> GetActiveOffers(
                int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<Offer>>{
                    MethodName = "account.getActiveOffers",
                    Parameters = new Dictionary<string, string> {

                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<VKPermission> GetAppPermissions(
                 int? userId = null
            ) {
                var req = new VKRequest<VKPermission>{
                    MethodName = "account.getAppPermissions",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<User[]> GetBanned(
                int offset = 0, int count = 20
            ) {
                var req = new VKRequest<User[]>{
                    MethodName = "account.getBanned",
                    Parameters = new Dictionary<string, string> {

                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<AccountInfo> GetInfo(
                
            ) {
                var req = new VKRequest<AccountInfo>{
                    MethodName = "account.getInfo",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<SaveProfileInfo> SaveProfileInfo(
                string firstName = "", string lastName = "", string maidenName = "", string screenName = "", Sex? sex = null, Relation? relation = null, int? relationPartnerId = null, Date? bdate = null, int? countryId = null, int? cityId = null,  string status = ""
            ) {
                var req = new VKRequest<SaveProfileInfo>{
                    MethodName = "account.saveProfileInfo",
                    Parameters = new Dictionary<string, string> {

                        { "first_name", firstName},
                        { "last_name", lastName},
                        { "maiden_name", maidenName},
                        { "screen_name", screenName},
                        { "sex", MiscTools.NullableString( (int?)sex )},
                        { "relation", MiscTools.NullableString( (int?)relation )},
                        { "relation_partner_id", MiscTools.NullableString(relationPartnerId)},
                        { "bdate", MiscTools.NullableString(bdate)},
                        { "country_id", MiscTools.NullableString(countryId)},
                        { "city_id", MiscTools.NullableString(cityId)},
                        { "status", status},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<User> GetProfileInfo(
                
            ) {
                var req = new VKRequest<User>{
                    MethodName = "account.getProfileInfo",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> SetInfo(
                 int? intro = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "account.setInfo",
                    Parameters = new Dictionary<string, string> {

                        { "intro", MiscTools.NullableString(intro)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> SetNameInMenu(
                 string name 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "account.setNameInMenu",
                    Parameters = new Dictionary<string, string> {

                        { "name", name},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> SetOffline(
                
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "account.setOffline",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> SetOnline(
                 bool voip = true
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "account.setOnline",
                    Parameters = new Dictionary<string, string> {

                        { "voip", (voip?1:0).ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> SetSilenceMode(
                string deviceId , int time , int? chatId = null, int? userId = null,  int sound = 0
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "account.setSilenceMode",
                    Parameters = new Dictionary<string, string> {

                        { "device_id", deviceId},
                        { "time", time.ToNCString()},
                        { "chat_id", MiscTools.NullableString(chatId)},
                        { "user_id", MiscTools.NullableString(userId)},
                        { "sound", sound.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> UnbanUser(
                 int userId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "account.unbanUser",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> RegisterDevice(
                string token , string deviceId , string settings , string deviceModel = "", string systemVersion = "",  bool? sandbox = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "account.registerDevice",
                    Parameters = new Dictionary<string, string> {

                        { "token", token},
                        { "device_id", deviceId},
                        { "settings", settings},
                        { "device_model", deviceModel},
                        { "system_version", systemVersion},
                        { "sandbox", (sandbox != null ? ( sandbox.Value ? 1 : 0 ).ToNCString() : "")},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> UnregisterDevice(
                 string deviceId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "account.unregisterDevice",
                    Parameters = new Dictionary<string, string> {

                        { "device_id", deviceId},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_ads Ads {get; private set;}
        public partial class MethodGroup_ads {
            private readonly RequestApi _parent;
            internal MethodGroup_ads(RequestApi parent){_parent=parent;}

            public VKRequest<int[]> DeleteClients(
                ulong accountId , params ulong[] ids 
            ) {
                var req = new VKRequest<int[]>{
                    MethodName = "ads.deleteClients",
                    Parameters = new Dictionary<string, string> {

                        { "account_id", accountId.ToNCString()},
                        { "ids", (ids??new ulong[]{}).ToNCStringA()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_apps Apps {get; private set;}
        public partial class MethodGroup_apps {
            private readonly RequestApi _parent;
            internal MethodGroup_apps(RequestApi parent){_parent=parent;}

            public VKRequest<bool> DeleteAppRequests(
                
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "apps.deleteAppRequests",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<long> GetScore(
                
            ) {
                var req = new VKRequest<long>{
                    MethodName = "apps.getScore",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<User>> GetLeaderboardExtended(
                LeaderBoardType type ,  bool global = true
            ) {
                var req = new VKRequest<EntityList<User>>{
                    MethodName = "apps.getLeaderboard",
                    Parameters = new Dictionary<string, string> {

                        { "type", type.ToNCString().ToSnake()},
                        { "global", (global?1:0).ToNCString()},
                        {"extended","1"},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<int>> GetLeaderboard(
                LeaderBoardType type ,  bool global = true
            ) {
                var req = new VKRequest<EntityList<int>>{
                    MethodName = "apps.getLeaderboard",
                    Parameters = new Dictionary<string, string> {

                        { "type", type.ToNCString().ToSnake()},
                        { "global", (global?1:0).ToNCString()},
                        {"extended","0"},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_audio Audio {get; private set;}
        public partial class MethodGroup_audio {
            private readonly RequestApi _parent;
            internal MethodGroup_audio(RequestApi parent){_parent=parent;}

            public VKRequest<int> Add(
                int ownerId , long audioId ,  int? groupId = null
            ) {
                var req = new VKRequest<int>{
                    MethodName = "audio.add",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", ownerId.ToNCString()},
                        { "audio_id", audioId.ToNCString()},
                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<AddAlbum> AddAlbum(
                string title ,  int? groupId = 0
            ) {
                var req = new VKRequest<AddAlbum>{
                    MethodName = "audio.addAlbum",
                    Parameters = new Dictionary<string, string> {

                        { "title", title},
                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Delete(
                long audioId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "audio.delete",
                    Parameters = new Dictionary<string, string> {

                        { "audio_id", audioId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> DeleteAlbum(
                long albumId ,  int? groupId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "audio.deleteAlbum",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString()},
                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<int> Edit(
                int ownerId , long audioId , string artist = "", string title = "", string text = "", AudioGenre? genreId = null,  bool? noSearch = null
            ) {
                var req = new VKRequest<int>{
                    MethodName = "audio.edit",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", ownerId.ToNCString()},
                        { "audio_id", audioId.ToNCString()},
                        { "artist", artist},
                        { "title", title},
                        { "text", text},
                        { "genre_id", MiscTools.NullableString( (int?)genreId )},
                        { "no_search", (noSearch != null ? ( noSearch.Value ? 1 : 0 ).ToNCString() : "")},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> EditAlbum(
                long albumId , string title ,  int? groupId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "audio.editAlbum",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString()},
                        { "title", title},
                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> MoveToAlbum(
                long albumId , int? groupId = null, params ulong[] audioIds 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "audio.moveToAlbum",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString()},
                        { "group_id", MiscTools.NullableString(groupId)},
                        { "audio_ids", (audioIds??new ulong[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<Audio>> Get(
                int? ownerId = null, long? albumId = null, ulong[] audioIds = null,  bool needUser = false, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<Audio>>{
                    MethodName = "audio.get",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "album_id", MiscTools.NullableString(albumId)},
                        { "audio_ids", (audioIds??new ulong[]{}).ToNCStringA()},
                        { "need_user", (needUser?1:0).ToNCString()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<Group[]> GetBroadcastListGroups(
                 bool active = true, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<Group[]>{
                    MethodName = "audio.getBroadcastList",
                    Parameters = new Dictionary<string, string> {

                        { "active", (active?1:0).ToNCString()},
                        {"filter","groups"},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<User[]> GetBroadcastListUsers(
                 bool active = true, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<User[]>{
                    MethodName = "audio.getBroadcastList",
                    Parameters = new Dictionary<string, string> {

                        { "active", (active?1:0).ToNCString()},
                        {"filter","friends"},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<Audio>> GetPopular(
                AudioGenre? genreId = null,  bool? onlyEng = null, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<Audio>>{
                    MethodName = "audio.getPopular",
                    Parameters = new Dictionary<string, string> {

                        { "genre_id", MiscTools.NullableString( (int?)genreId )},
                        { "only_eng", (onlyEng != null ? ( onlyEng.Value ? 1 : 0 ).ToNCString() : "")},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<Audio>> GetRecommendations(
                AudioGenre? genreId = null,  bool? onlyEng = null, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<Audio>>{
                    MethodName = "audio.getRecommendations",
                    Parameters = new Dictionary<string, string> {

                        { "genre_id", MiscTools.NullableString( (int?)genreId )},
                        { "only_eng", (onlyEng != null ? ( onlyEng.Value ? 1 : 0 ).ToNCString() : "")},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<AudioAlbum>> GetAlbums(
                 int? ownerId = null, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<AudioAlbum>>{
                    MethodName = "audio.getAlbums",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<Audio[]> GetById(
                bool itunes = false, params string[] audios 
            ) {
                var req = new VKRequest<Audio[]>{
                    MethodName = "audio.getById",
                    Parameters = new Dictionary<string, string> {

                        { "itunes", (itunes?1:0).ToNCString()},
                        { "audios", String.Join(",",audios)},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<Audio[]> GetById(
                bool itunes = false, params Tuple<int, ulong>[] audios 
            ) {
                var req = new VKRequest<Audio[]>{
                    MethodName = "audio.getById",
                    Parameters = new Dictionary<string, string> {

                        { "itunes", (itunes?1:0).ToNCString()},
                        { "audios", String.Join(",",audios.Select(a=>a.Item1 +"_" +a.Item2))},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<int> GetCount(
                 int? ownerId = null
            ) {
                var req = new VKRequest<int>{
                    MethodName = "audio.getCount",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<Lyrics> GetLyrics(
                 long lyricsId 
            ) {
                var req = new VKRequest<Lyrics>{
                    MethodName = "audio.getLyrics",
                    Parameters = new Dictionary<string, string> {

                        { "lyrics_id", lyricsId.ToNCString()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<string> GetUploadServer(
                long albumId ,  int? groupId = null
            ) {
                var req = new VKRequest<string>{
                    MethodName = "audio.getUploadServer",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString()},
                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Reorder(
                long audioId , int? ownerId = null, long? before = null,  long? after = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "audio.reorder",
                    Parameters = new Dictionary<string, string> {

                        { "audio_id", audioId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "before", MiscTools.NullableString(before)},
                        { "after", MiscTools.NullableString(after)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<Audio> Restore(
                long audioId ,  int? ownerId = null
            ) {
                var req = new VKRequest<Audio>{
                    MethodName = "audio.restore",
                    Parameters = new Dictionary<string, string> {

                        { "audio_id", audioId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<Audio[]> Save(
                string server , string audio , string hash , string artist = "",  string title = ""
            ) {
                var req = new VKRequest<Audio[]>{
                    MethodName = "audio.save",
                    Parameters = new Dictionary<string, string> {

                        { "server", server},
                        { "audio", audio},
                        { "hash", hash},
                        { "artist", artist},
                        { "title", title},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<Audio>> Search(
                string q , bool autoComplete = true, bool lyrics = false, bool performerOnly = false, AudioSortOrder sort = AudioSortOrder.ByRating,  bool searchOwn = false, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<Audio>>{
                    MethodName = "audio.search",
                    Parameters = new Dictionary<string, string> {

                        { "q", q},
                        { "auto_complete", (autoComplete?1:0).ToNCString()},
                        { "lyrics", (lyrics?1:0).ToNCString()},
                        { "performer_only", (performerOnly?1:0).ToNCString()},
                        { "sort", ((int)sort).ToNCString()},
                        { "search_own", (searchOwn?1:0).ToNCString()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> SetBroadcast(
                Tuple<int, ulong> audio , params int[] targetIds 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "audio.setBroadcast",
                    Parameters = new Dictionary<string, string> {

                        { "audio", audio.Item1.ToNCString() +"_" + audio.Item2.ToNCString()},
                        { "target_ids", (targetIds??new int[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_auth Auth {get; private set;}
        public partial class MethodGroup_auth {
            private readonly RequestApi _parent;
            internal MethodGroup_auth(RequestApi parent){_parent=parent;}

            public VKRequest<bool> CheckPhone(
                string phone , string clientSecret ,  int? clientId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "auth.checkPhone",
                    Parameters = new Dictionary<string, string> {

                        { "phone", phone},
                        { "client_secret", clientSecret},
                        { "client_id", MiscTools.NullableString(clientId)},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<ConfirmResult> Confirm(
                int clientId , string clientSecret , string phone , string code , string password = "", bool testMode = false,  int? intro = null
            ) {
                var req = new VKRequest<ConfirmResult>{
                    MethodName = "auth.confirm",
                    Parameters = new Dictionary<string, string> {

                        { "client_id", clientId.ToNCString()},
                        { "client_secret", clientSecret},
                        { "phone", phone},
                        { "code", code},
                        { "password", password},
                        { "test_mode", (testMode?1:0).ToNCString()},
                        { "intro", MiscTools.NullableString(intro)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<AuthRestore> Restore(
                 long phone 
            ) {
                var req = new VKRequest<AuthRestore>{
                    MethodName = "auth.restore",
                    Parameters = new Dictionary<string, string> {

                        { "phone", phone.ToNCString()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_board Board {get; private set;}
        public partial class MethodGroup_board {
            private readonly RequestApi _parent;
            internal MethodGroup_board(RequestApi parent){_parent=parent;}

            public VKRequest<bool> CloseTopic(
                int groupId ,  int topicId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "board.closeTopic",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "topic_id", topicId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> DeleteComment(
                int groupId , int topicId ,  int commentId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "board.deleteComment",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "topic_id", topicId.ToNCString()},
                        { "comment_id", commentId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> DeleteTopic(
                int groupId ,  int topicId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "board.deleteTopic",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "topic_id", topicId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> FixTopic(
                int groupId ,  int topicId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "board.fixTopic",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "topic_id", topicId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> RestoreComment(
                int groupId , int topicId ,  int commentId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "board.restoreComment",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "topic_id", topicId.ToNCString()},
                        { "comment_id", commentId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> UnfixTopic(
                int groupId ,  int topicId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "board.unfixTopic",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "topic_id", topicId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_database Database {get; private set;}
        public partial class MethodGroup_database {
            private readonly RequestApi _parent;
            internal MethodGroup_database(RequestApi parent){_parent=parent;}

            public VKRequest<EntityList<DatabaseEntry>> GetChairs(
                 int facultyId , int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<DatabaseEntry>>{
                    MethodName = "database.getChairs",
                    Parameters = new Dictionary<string, string> {

                        { "faculty_id", facultyId.ToNCString()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<DatabaseCity[]> GetCities(
                int countryId , int? regionId = null, string q = "",  bool needAll = false, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<DatabaseCity[]>{
                    MethodName = "database.getCities",
                    Parameters = new Dictionary<string, string> {

                        { "country_id", countryId.ToNCString()},
                        { "region_id", MiscTools.NullableString(regionId)},
                        { "q", q},
                        { "need_all", (needAll?1:0).ToNCString()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<DatabaseCity[]> GetCitiesById(
                params int[] cityIds 
            ) {
                var req = new VKRequest<DatabaseCity[]>{
                    MethodName = "database.getCitiesById",
                    Parameters = new Dictionary<string, string> {

                        { "city_ids", (cityIds??new int[]{}).ToNCStringA()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<DatabaseEntry>> GetCountries(
                string code = "",  bool needAll = false, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<DatabaseEntry>>{
                    MethodName = "database.getCountries",
                    Parameters = new Dictionary<string, string> {

                        { "code", code},
                        { "need_all", (needAll?1:0).ToNCString()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<DatabaseEntry[]> GetCountriesById(
                params int[] countryIds 
            ) {
                var req = new VKRequest<DatabaseEntry[]>{
                    MethodName = "database.getCountriesById",
                    Parameters = new Dictionary<string, string> {

                        { "country_ids", (countryIds??new int[]{}).ToNCStringA()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<DatabaseEntry>> GetFaculties(
                 int universityId , int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<DatabaseEntry>>{
                    MethodName = "database.getFaculties",
                    Parameters = new Dictionary<string, string> {

                        { "university_id", universityId.ToNCString()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<DatabaseEntry>> GetRegions(
                int countryId ,  string q = "", int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<DatabaseEntry>>{
                    MethodName = "database.getRegions",
                    Parameters = new Dictionary<string, string> {

                        { "country_id", countryId.ToNCString()},
                        { "q", q},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<DatabaseEntry[]> GetSchools(
                int? cityId = null,  string q = "", int offset = 0, int count = 100
            ) {
                var req = new VKRequest<DatabaseEntry[]>{
                    MethodName = "database.getSchools",
                    Parameters = new Dictionary<string, string> {

                        { "city_id", MiscTools.NullableString(cityId)},
                        { "q", q},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<DatabaseEntry[]> GetStreetsById(
                params int[] streetIds 
            ) {
                var req = new VKRequest<DatabaseEntry[]>{
                    MethodName = "database.getStreetsById",
                    Parameters = new Dictionary<string, string> {

                        { "street_ids", (streetIds??new int[]{}).ToNCStringA()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<DatabaseEntry[]> GetUniversities(
                int? countryId = null, int? cityId = null,  string q = "", int offset = 0, int count = 100
            ) {
                var req = new VKRequest<DatabaseEntry[]>{
                    MethodName = "database.getUniversities",
                    Parameters = new Dictionary<string, string> {

                        { "country_id", MiscTools.NullableString(countryId)},
                        { "city_id", MiscTools.NullableString(cityId)},
                        { "q", q},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_docs Docs {get; private set;}
        public partial class MethodGroup_docs {
            private readonly RequestApi _parent;
            internal MethodGroup_docs(RequestApi parent){_parent=parent;}

            public VKRequest<int> Add(
                long docId , int ownerId ,  string accessKey = ""
            ) {
                var req = new VKRequest<int>{
                    MethodName = "docs.add",
                    Parameters = new Dictionary<string, string> {

                        { "doc_id", docId.ToNCString()},
                        { "owner_id", ownerId.ToNCString()},
                        { "access_key", accessKey},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Delete(
                long docId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "docs.delete",
                    Parameters = new Dictionary<string, string> {

                        { "doc_id", docId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<Document>> Get(
                 int? ownerId = null, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<Document>>{
                    MethodName = "docs.get",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<Document[]> GetById(
                params Tuple<int,int>[] docs 
            ) {
                var req = new VKRequest<Document[]>{
                    MethodName = "docs.getById",
                    Parameters = new Dictionary<string, string> {

                        { "docs", String.Join(",",docs.Select(a=>a.Item1 +"_" +a.Item2))},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<string> GetUploadServer(
                 int? groupId = null
            ) {
                var req = new VKRequest<string>{
                    MethodName = "docs.getUploadServer",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<string> GetWallUploadServer(
                 int? groupId = null
            ) {
                var req = new VKRequest<string>{
                    MethodName = "docs.getWallUploadServer",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<Document[]> Save(
                string file , string title , params string[] tags 
            ) {
                var req = new VKRequest<Document[]>{
                    MethodName = "docs.save",
                    Parameters = new Dictionary<string, string> {

                        { "file", file},
                        { "title", title},
                        { "tags", String.Join(",",tags)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_fave Fave {get; private set;}
        public partial class MethodGroup_fave {
            private readonly RequestApi _parent;
            internal MethodGroup_fave(RequestApi parent){_parent=parent;}

            public VKRequest<EntityList<Link>> GetLinks(
                int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<Link>>{
                    MethodName = "fave.getLinks",
                    Parameters = new Dictionary<string, string> {

                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<User>> GetUsers(
                int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<User>>{
                    MethodName = "fave.getUsers",
                    Parameters = new Dictionary<string, string> {

                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<Photo>> GetPhotos(
                int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<Photo>>{
                    MethodName = "fave.getPhotos",
                    Parameters = new Dictionary<string, string> {

                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<Post>> GetPosts(
                int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<Post>>{
                    MethodName = "fave.getPosts",
                    Parameters = new Dictionary<string, string> {

                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<Video>> GetVideos(
                int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<Video>>{
                    MethodName = "fave.getVideos",
                    Parameters = new Dictionary<string, string> {

                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> RemoveUser(
                 int userId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "fave.removeUser",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> RemoveLink(
                 int linkId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "fave.removeLink",
                    Parameters = new Dictionary<string, string> {

                        { "link_id", linkId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> RemoveGroup(
                 int groupId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "fave.removeGroup",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> AddGroup(
                 int groupId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "fave.addGroup",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> AddUser(
                 int userId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "fave.addUser",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> AddLink(
                string link ,  string text = ""
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "fave.addLink",
                    Parameters = new Dictionary<string, string> {

                        { "link", link},
                        { "text", text},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_friends Friends {get; private set;}
        public partial class MethodGroup_friends {
            private readonly RequestApi _parent;
            internal MethodGroup_friends(RequestApi parent){_parent=parent;}

            public VKRequest<AddFriendResult> Add(
                int userId ,  string text = ""
            ) {
                var req = new VKRequest<AddFriendResult>{
                    MethodName = "friends.add",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "text", text},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<AddFriendsList> AddList(
                string name , params int[] userIds 
            ) {
                var req = new VKRequest<AddFriendsList>{
                    MethodName = "friends.addList",
                    Parameters = new Dictionary<string, string> {

                        { "name", name},
                        { "user_ids", (userIds??new int[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<FriendshipStatus[]> AreFriends(
                bool needSign = false, params int[] userIds 
            ) {
                var req = new VKRequest<FriendshipStatus[]>{
                    MethodName = "friends.areFriends",
                    Parameters = new Dictionary<string, string> {

                        { "need_sign", (needSign?1:0).ToNCString()},
                        { "user_ids", (userIds??new int[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<FriendsDelete> Delete(
                 int userId 
            ) {
                var req = new VKRequest<FriendsDelete>{
                    MethodName = "friends.delete",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> DeleteAllRequests(
                
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "friends.deleteAllRequests",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> DeleteList(
                 int listId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "friends.deleteList",
                    Parameters = new Dictionary<string, string> {

                        { "list_id", listId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Edit(
                int userId , params long[] listIds 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "friends.edit",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "list_ids", (listIds??new long[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> EditList(
                long listId , string name = "", int[] userIds = null, int[] addUserIds = null, params int[] deleteUserIds 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "friends.editList",
                    Parameters = new Dictionary<string, string> {

                        { "list_id", listId.ToNCString()},
                        { "name", name},
                        { "user_ids", (userIds??new int[]{}).ToNCStringA()},
                        { "add_user_ids", (addUserIds??new int[]{}).ToNCStringA()},
                        { "delete_user_ids", (deleteUserIds??new int[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<FriendsList>> GetLists(
                int? userId = null,  bool returnSystem = true
            ) {
                var req = new VKRequest<EntityList<FriendsList>>{
                    MethodName = "friends.getLists",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "return_system", (returnSystem?1:0).ToNCString()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<User>> Get(
                int? userId = null, int? listId = null, UserFields fields = UserFields.Anything, UserSortOrder order = UserSortOrder.ById,  NameCase nameCase = NameCase.Nom, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<User>>{
                    MethodName = "friends.get",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "list_id", MiscTools.NullableString(listId)},
                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) )},
                        { "order", order.ToNCString().ToSnake()},
                        { "name_case", nameCase.ToNCString().ToSnake()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<int>> GetAvailableForCall(
                
            ) {
                var req = new VKRequest<EntityList<int>>{
                    MethodName = "friends.getAvailableForCall",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<User>> GetAvailableForCall(
                UserFields fields = UserFields.Anything,  NameCase nameCase = NameCase.Nom
            ) {
                var req = new VKRequest<EntityList<User>>{
                    MethodName = "friends.getAvailableForCall",
                    Parameters = new Dictionary<string, string> {

                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) )},
                        { "name_case", nameCase.ToNCString().ToSnake()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<int>> Get(
                int? userId = null, int? listId = null,  UserSortOrder order = UserSortOrder.ById, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<int>>{
                    MethodName = "friends.get",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "list_id", MiscTools.NullableString(listId)},
                        { "order", order.ToNCString().ToSnake()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<int[]> GetAppUsers(
                
            ) {
                var req = new VKRequest<int[]>{
                    MethodName = "friends.getAppUsers",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<User[]> GetByPhones(
                UserFields fields = UserFields.None, params ulong[] phones 
            ) {
                var req = new VKRequest<User[]>{
                    MethodName = "friends.getByPhones",
                    Parameters = new Dictionary<string, string> {

                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) )},
                        { "phones",  String.Join( ",", phones.Select( a => "+" + a ) ) },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<int[]> GetMutual(
                int targetUid , int? sourceUid = null,  bool order = false, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<int[]>{
                    MethodName = "friends.getMutual",
                    Parameters = new Dictionary<string, string> {

                        { "target_uid", targetUid.ToNCString()},
                        { "source_uid", MiscTools.NullableString(sourceUid)},
                        { "order",  order ? "random" : "" },
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<int[]> GetOnline(
                int? userId = null, int? listId = null,  UserSortOrder? order = null, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<int[]>{
                    MethodName = "friends.getOnline",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "list_id", MiscTools.NullableString(listId)},
                        { "order", MiscTools.NullableString( order )},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<int[]> GetRecent(
                 int count = 20
            ) {
                var req = new VKRequest<int[]>{
                    MethodName = "friends.getRecent",
                    Parameters = new Dictionary<string, string> {

                        { "count", count.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<User>> GetSuggestions(
                FriendSuggestionFilters filters = FriendSuggestionFilters.Everything, UserFields fields = UserFields.None,  NameCase nameCase = NameCase.Nom, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<User>>{
                    MethodName = "friends.getSuggestions",
                    Parameters = new Dictionary<string, string> {

                        { "filters", String.Join( ",", MiscTools.GetFilterFields( filters ) )},
                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) )},
                        { "name_case", nameCase.ToNCString().ToSnake()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<User>> Search(
                int userId , string q = "",  NameCase nameCase = NameCase.Nom, int offset = 0, int count = 20
            ) {
                var req = new VKRequest<EntityList<User>>{
                    MethodName = "friends.search",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "q", q},
                        { "name_case", nameCase.ToNCString().ToSnake()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_groups Groups {get; private set;}
        public partial class MethodGroup_groups {
            private readonly RequestApi _parent;
            internal MethodGroup_groups(RequestApi parent){_parent=parent;}

            public VKRequest<Link> AddLink(
                int groupId , string link ,  string text = ""
            ) {
                var req = new VKRequest<Link>{
                    MethodName = "groups.addLink",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "link", link},
                        { "text", text},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> ApproveRequest(
                int groupId ,  int userId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "groups.approveRequest",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> DeleteLink(
                int groupId ,  int linkId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "groups.deleteLink",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "link_id", linkId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<User[]> GetBanned(
                 int groupId , int offset = 0, int count = 100
            ) {
                var req = new VKRequest<User[]>{
                    MethodName = "groups.getBanned",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<Group[]> GetById(
                string[] groupIds ,  GroupFields fields 
            ) {
                var req = new VKRequest<Group[]>{
                    MethodName = "groups.getById",
                    Parameters = new Dictionary<string, string> {

                        { "group_ids", String.Join(",",groupIds)},
                        { "fields", String.Join( ",", MiscTools.GetGroupFields( fields ) )},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<Group[]> GetById(
                int groupId ,  GroupFields fields 
            ) {
                var req = new VKRequest<Group[]>{
                    MethodName = "groups.getById",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "fields", String.Join( ",", MiscTools.GetGroupFields( fields ) )},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<int>> GetMembers(
                string groupId , GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<int>>{
                    MethodName = "groups.getMembers",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId},
                        { "filter", MiscTools.NullableString( (int?)filter )},
                        { "sort", MiscTools.NullableString( (int?)sort )},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<GroupManager>> GetMembersManagers(
                string groupId ,  MembersSortOrder? sort = null, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<GroupManager>>{
                    MethodName = "groups.getMembers",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId},
                        { "sort", MiscTools.NullableString( (int?)sort )},
                        {"filter","managers"},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<User>> GetMembers(
                string groupId , UserFields fields = UserFields.Anything, GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<User>>{
                    MethodName = "groups.getMembers",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId},
                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) )},
                        { "filter", MiscTools.NullableString( (int?)filter )},
                        { "sort", MiscTools.NullableString( (int?)sort )},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> IsMember(
                int groupId ,  int? userId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "groups.isMember",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "user_id", MiscTools.NullableString(userId)},
                        {"extended","0"},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Invite(
                int groupId ,  int userId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "groups.invite",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<MemberShip> IsMemberExtended(
                int groupId ,  int? userId = null
            ) {
                var req = new VKRequest<MemberShip>{
                    MethodName = "groups.isMember",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "user_id", MiscTools.NullableString(userId)},
                        {"extended","1"},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<MemberShip[]> IsMember(
                int groupId , params int[] userIds 
            ) {
                var req = new VKRequest<MemberShip[]>{
                    MethodName = "groups.isMember",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "user_ids", (userIds??new int[]{}).ToNCStringA()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Join(
                int groupId ,  bool notSure = false
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "groups.join",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "not_sure", (notSure?1:0).ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Leave(
                 int groupId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "groups.leave",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> UnbanUser(
                int groupId ,  int userId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "groups.unbanUser",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> RemoveUser(
                int groupId ,  int userId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "groups.removeUser",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> ReorderLink(
                int groupId , long linkId ,  long after = 0
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "groups.reorderLink",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "link_id", linkId.ToNCString()},
                        { "after", after.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_messages Messages {get; private set;}
        public partial class MethodGroup_messages {
            private readonly RequestApi _parent;
            internal MethodGroup_messages(RequestApi parent){_parent=parent;}

            public VKRequest<bool> AddChatUser(
                int userId ,  int? chatId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "messages.addChatUser",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "chat_id", MiscTools.NullableString(chatId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Delete(
                params int[] messageIds 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "messages.delete",
                    Parameters = new Dictionary<string, string> {

                        { "message_ids", (messageIds??new int[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> DeleteChatPhoto(
                 int chatId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "messages.deleteChatPhoto",
                    Parameters = new Dictionary<string, string> {

                        { "chat_id", chatId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> DeleteDialog(
                 int userId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "messages.deleteDialog",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<Message>> Get(
                int @out = 0, int timeOffset = 0, int filters = 0, int previewLength = 0,  long? lastMessageId = null, int offset = 0, int count = 200
            ) {
                var req = new VKRequest<EntityList<Message>>{
                    MethodName = "messages.get",
                    Parameters = new Dictionary<string, string> {

                        { "out", @out.ToNCString()},
                        { "time_offset", timeOffset.ToNCString()},
                        { "filters", filters.ToNCString()},
                        { "preview_length", previewLength.ToNCString()},
                        { "last_message_id", MiscTools.NullableString(lastMessageId)},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<LastActivity> GetLastActivity(
                 int userId 
            ) {
                var req = new VKRequest<LastActivity>{
                    MethodName = "messages.getLastActivity",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> MarkAsImportant(
                bool important , params int[] messageIds 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "messages.markAsImportant",
                    Parameters = new Dictionary<string, string> {

                        { "important", (important?1:0).ToNCString()},
                        { "message_ids", (messageIds??new int[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> MarkAsRead(
                int userId , int? startMessageId = null, params int[] messageIds 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "messages.markAsRead",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "start_message_id", MiscTools.NullableString(startMessageId)},
                        { "message_ids", (messageIds??new int[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<int> Send(
                int? userId = null, int[] userIds = null, string domain = null, int? chatId = null, string message = null, int? guid = null, double? lat = null, double? @long = null, string attachment = null, string forwardMessages = null,  int? stickerId = null
            ) {
                var req = new VKRequest<int>{
                    MethodName = "messages.send",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "user_ids", (userIds??new int[]{}).ToNCStringA()},
                        { "domain", domain},
                        { "chat_id", MiscTools.NullableString(chatId)},
                        { "message", message},
                        { "guid", MiscTools.NullableString(guid)},
                        { "lat", MiscTools.NullableString(lat)},
                        { "long", MiscTools.NullableString(@long)},
                        { "attachment", attachment},
                        { "forward_messages", forwardMessages},
                        { "sticker_id", MiscTools.NullableString(stickerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> RemoveChatUser(
                int userId ,  int chatId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "messages.removeChatUser",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "chat_id", chatId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Restore(
                 int messageId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "messages.restore",
                    Parameters = new Dictionary<string, string> {

                        { "message_id", messageId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> SetActivity(
                int userId ,  ImActivity type = ImActivity.Typing
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "messages.setActivity",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "type", type.ToNCString().ToSnake()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_newsfeed Newsfeed {get; private set;}
        public partial class MethodGroup_newsfeed {
            private readonly RequestApi _parent;
            internal MethodGroup_newsfeed(RequestApi parent){_parent=parent;}

            public VKRequest<bool> AddBan(
                int[] userIds = null, params int[] groupIds 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "newsfeed.addBan",
                    Parameters = new Dictionary<string, string> {

                        { "user_ids", (userIds??new int[]{}).ToNCStringA()},
                        { "group_ids", (groupIds??new int[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> DeleteBan(
                int[] userIds = null, params int[] groupIds 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "newsfeed.deleteBan",
                    Parameters = new Dictionary<string, string> {

                        { "user_ids", (userIds??new int[]{}).ToNCStringA()},
                        { "group_ids", (groupIds??new int[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> DeleteList(
                 int listId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "newsfeed.deleteList",
                    Parameters = new Dictionary<string, string> {

                        { "list_id", listId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_notes Notes {get; private set;}
        public partial class MethodGroup_notes {
            private readonly RequestApi _parent;
            internal MethodGroup_notes(RequestApi parent){_parent=parent;}

            public VKRequest<bool> Delete(
                 int noteId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "notes.delete",
                    Parameters = new Dictionary<string, string> {

                        { "note_id", noteId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> DeleteComment(
                int commentId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "notes.deleteComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> RestoreComment(
                int commentId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "notes.restoreComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_notifications Notifications {get; private set;}
        public partial class MethodGroup_notifications {
            private readonly RequestApi _parent;
            internal MethodGroup_notifications(RequestApi parent){_parent=parent;}

            public VKRequest<bool> MarkAsViewed(
                
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "notifications.markAsViewed",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_pages Pages {get; private set;}
        public partial class MethodGroup_pages {
            private readonly RequestApi _parent;
            internal MethodGroup_pages(RequestApi parent){_parent=parent;}

            public VKRequest<bool> ClearCache(
                 string url 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "pages.clearCache",
                    Parameters = new Dictionary<string, string> {

                        { "url", url},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_photos Photos {get; private set;}
        public partial class MethodGroup_photos {
            private readonly RequestApi _parent;
            internal MethodGroup_photos(RequestApi parent){_parent=parent;}

            public VKRequest<bool> ConfirmTag(
                int tagId , long photoId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "photos.confirmTag",
                    Parameters = new Dictionary<string, string> {

                        { "tag_id", tagId.ToNCString()},
                        { "photo_id", photoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<long> Copy(
                long photoId , int? ownerId = null,  string accessKey = ""
            ) {
                var req = new VKRequest<long>{
                    MethodName = "photos.copy",
                    Parameters = new Dictionary<string, string> {

                        { "photo_id", photoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "access_key", accessKey},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<PhotoAlbum> CreateAlbum(
                string title , string description = "", int? groupId = null, PrivacyType? privacy = null,  PrivacyType? commentPrivacy = null
            ) {
                var req = new VKRequest<PhotoAlbum>{
                    MethodName = "photos.createAlbum",
                    Parameters = new Dictionary<string, string> {

                        { "title", title},
                        { "description", description},
                        { "group_id", MiscTools.NullableString(groupId)},
                        { "privacy", MiscTools.NullableString( (int?)privacy )},
                        { "comment_privacy", MiscTools.NullableString( (int?)commentPrivacy )},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Delete(
                long photoId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "photos.delete",
                    Parameters = new Dictionary<string, string> {

                        { "photo_id", photoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> DeleteAlbum(
                long albumId ,  int? groupId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "photos.deleteAlbum",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString()},
                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> DeleteComment(
                int commentId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "photos.deleteComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Edit(
                long photoId , int? ownerId = null,  string caption = ""
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "photos.edit",
                    Parameters = new Dictionary<string, string> {

                        { "photo_id", photoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "caption", caption},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> EditAlbum(
                long albumId , int? ownerId = null, string title = "", string description = "", PrivacyType? privacy = null,  PrivacyType? commentPrivacy = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "photos.editAlbum",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "title", title},
                        { "description", description},
                        { "privacy", MiscTools.NullableString( (int?)privacy )},
                        { "comment_privacy", MiscTools.NullableString( (int?)commentPrivacy )},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<Photo>> Get(
                long? albumId = null, int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null,  int? feed = null, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<Photo>>{
                    MethodName = "photos.get",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", MiscTools.NullableString(albumId)},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "photo_ids", (photoIds??new int[]{}).ToNCStringA()},
                        { "rev", (rev?1:0).ToNCString()},
                        { "extended", (extended?1:0).ToNCString()},
                        { "feed_type", MiscTools.NullableString( feedType )},
                        { "feed", MiscTools.NullableString(feed)},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<Photo>> Get(
                SpecialAlbum albumId , int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null,  int? feed = null, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<Photo>>{
                    MethodName = "photos.get",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString().ToSnake()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "photo_ids", (photoIds??new int[]{}).ToNCStringA()},
                        { "rev", (rev?1:0).ToNCString()},
                        { "extended", (extended?1:0).ToNCString()},
                        { "feed_type", MiscTools.NullableString( feedType )},
                        { "feed", MiscTools.NullableString(feed)},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<PhotoAlbum>> GetAlbums(
                int? ownerId = null, bool needSystem = true, bool needCovers = true, int offset = 0, int count = 100, params long[] albumIds 
            ) {
                var req = new VKRequest<EntityList<PhotoAlbum>>{
                    MethodName = "photos.getAlbums",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "need_system", (needSystem?1:0).ToNCString()},
                        { "need_covers", (needCovers?1:0).ToNCString()},
                        { "album_ids", (albumIds??new long[]{}).ToNCStringA()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<int> GetAlbumsCount(
                int? userId = null,  int? groupId = null
            ) {
                var req = new VKRequest<int>{
                    MethodName = "photos.getAlbumsCount",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<Photo>> GetAll(
                int? ownerId = null, bool extended = false, bool noServiceAlbums = false, bool? needHidden = null,  bool? skipHidden = null, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<Photo>>{
                    MethodName = "photos.getAll",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "extended", (extended?1:0).ToNCString()},
                        { "no_service_albums", (noServiceAlbums?1:0).ToNCString()},
                        { "need_hidden", (needHidden != null ? ( needHidden.Value ? 1 : 0 ).ToNCString() : "")},
                        { "skip_hidden", (skipHidden != null ? ( skipHidden.Value ? 1 : 0 ).ToNCString() : "")},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<Photo[]> GetById(
                params ContentId[] photos 
            ) {
                var req = new VKRequest<Photo[]>{
                    MethodName = "photos.getById",
                    Parameters = new Dictionary<string, string> {

                        { "photos", (photos??new ContentId[]{}).ToNCStringA()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<PhotosUploadServer> GetChatUploadServer(
                int chatId , int? cropX = null, int? cropY = null,  int? cropWidth = null
            ) {
                var req = new VKRequest<PhotosUploadServer>{
                    MethodName = "photos.getChatUploadServer",
                    Parameters = new Dictionary<string, string> {

                        { "chat_id", chatId.ToNCString()},
                        { "crop_x", MiscTools.NullableString(cropX)},
                        { "crop_y", MiscTools.NullableString(cropY)},
                        { "crop_width", MiscTools.NullableString(cropWidth)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<string> GetOwnerPhotoUploadServer(
                
            ) {
                var req = new VKRequest<string>{
                    MethodName = "photos.getOwnerPhotoUploadServer",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<PhotoTag[]> GetTags(
                long photoId , int? ownerId = null,  string accessKey = ""
            ) {
                var req = new VKRequest<PhotoTag[]>{
                    MethodName = "photos.getTags",
                    Parameters = new Dictionary<string, string> {

                        { "photo_id", photoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "access_key", accessKey},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<PhotosUploadServer> GetUploadServer(
                long albumId ,  int? groupId = null
            ) {
                var req = new VKRequest<PhotosUploadServer>{
                    MethodName = "photos.getUploadServer",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString()},
                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> MakeCover(
                long albumId , long photoId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "photos.makeCover",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString()},
                        { "photo_id", photoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Move(
                long targetAlbumId , long photoId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "photos.move",
                    Parameters = new Dictionary<string, string> {

                        { "target_album_id", targetAlbumId.ToNCString()},
                        { "photo_id", photoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> RemoveTag(
                int tagId , long photoId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "photos.removeTag",
                    Parameters = new Dictionary<string, string> {

                        { "tag_id", tagId.ToNCString()},
                        { "photo_id", photoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> ReorderAlbums(
                long albumId , int? ownerId = null, long? before = null,  long? after = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "photos.reorderAlbums",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "before", MiscTools.NullableString(before)},
                        { "after", MiscTools.NullableString(after)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> ReorderPhotos(
                long photoId , int? ownerId = null, long? before = null,  long? after = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "photos.reorderPhotos",
                    Parameters = new Dictionary<string, string> {

                        { "photo_id", photoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "before", MiscTools.NullableString(before)},
                        { "after", MiscTools.NullableString(after)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Report(
                long photoId , int? ownerId = null,  ReportReason? reason = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "photos.report",
                    Parameters = new Dictionary<string, string> {

                        { "photo_id", photoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "reason", MiscTools.NullableString( (int?)reason )},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> ReportComment(
                int commentId , int? ownerId = null,  ReportReason? reason = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "photos.reportComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "reason", MiscTools.NullableString( (int?)reason )},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> RestoreComment(
                int commentId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "photos.restoreComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Restore(
                int ownerId ,  long photoId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "photos.restore",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", ownerId.ToNCString()},
                        { "photo_id", photoId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<Photo[]> Save(
                long albumId , string server , string photosList , string hash , int? groupId = null, double? latitude = null, double? longitude = null, string caption = "",  string description = ""
            ) {
                var req = new VKRequest<Photo[]>{
                    MethodName = "photos.save",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString()},
                        { "server", server},
                        { "photos_list", photosList},
                        { "hash", hash},
                        { "group_id", MiscTools.NullableString(groupId)},
                        { "latitude", MiscTools.NullableString(latitude)},
                        { "longitude", MiscTools.NullableString(longitude)},
                        { "caption", caption},
                        { "description", description},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_polls Polls {get; private set;}
        public partial class MethodGroup_polls {
            private readonly RequestApi _parent;
            internal MethodGroup_polls(RequestApi parent){_parent=parent;}

            public VKRequest<bool> AddVote(
                long pollId , int answerId , int? ownerId = null,  bool? isBoard = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "polls.addVote",
                    Parameters = new Dictionary<string, string> {

                        { "poll_id", pollId.ToNCString()},
                        { "answer_id", answerId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "is_board", (isBoard != null ? ( isBoard.Value ? 1 : 0 ).ToNCString() : "")},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> DeleteVote(
                long pollId , int answerId , int? ownerId = null,  bool? isBoard = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "polls.deleteVote",
                    Parameters = new Dictionary<string, string> {

                        { "poll_id", pollId.ToNCString()},
                        { "answer_id", answerId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "is_board", (isBoard != null ? ( isBoard.Value ? 1 : 0 ).ToNCString() : "")},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_stats Stats {get; private set;}
        public partial class MethodGroup_stats {
            private readonly RequestApi _parent;
            internal MethodGroup_stats(RequestApi parent){_parent=parent;}

            public VKRequest<bool> TrackVisitor(
                
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "stats.trackVisitor",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_status Status {get; private set;}
        public partial class MethodGroup_status {
            private readonly RequestApi _parent;
            internal MethodGroup_status(RequestApi parent){_parent=parent;}

            public VKRequest<Status[]> Get(
                 int? userId = null
            ) {
                var req = new VKRequest<Status[]>{
                    MethodName = "status.get",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Set(
                 string text 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "status.set",
                    Parameters = new Dictionary<string, string> {

                        { "text", text},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_storage Storage {get; private set;}
        public partial class MethodGroup_storage {
            private readonly RequestApi _parent;
            internal MethodGroup_storage(RequestApi parent){_parent=parent;}

            public VKRequest<StorageEntry[]> Get(
                int? userId = null, bool global = false, params string[] keys 
            ) {
                var req = new VKRequest<StorageEntry[]>{
                    MethodName = "storage.get",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "global", (global?1:0).ToNCString()},
                        { "keys", String.Join(",",keys)},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<string[]> GetKeys(
                int? userId = null,  bool global = false, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<string[]>{
                    MethodName = "storage.getKeys",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "global", (global?1:0).ToNCString()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<StorageEntry[]> Set(
                string key , string value , int? userId = null,  bool global = false
            ) {
                var req = new VKRequest<StorageEntry[]>{
                    MethodName = "storage.set",
                    Parameters = new Dictionary<string, string> {

                        { "key", key},
                        { "value", value},
                        { "user_id", MiscTools.NullableString(userId)},
                        { "global", (global?1:0).ToNCString()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_users Users {get; private set;}
        public partial class MethodGroup_users {
            private readonly RequestApi _parent;
            internal MethodGroup_users(RequestApi parent){_parent=parent;}

            public VKRequest<User[]> Get(
                UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, params int[] userIds 
            ) {
                var req = new VKRequest<User[]>{
                    MethodName = "users.get",
                    Parameters = new Dictionary<string, string> {

                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) )},
                        { "name_case", nameCase.ToNCString().ToSnake()},
                        { "user_ids", (userIds??new int[]{}).ToNCStringA()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<int>> GetFollowers(
                int? userId = null,  NameCase nameCase = NameCase.Nom, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<int>>{
                    MethodName = "users.getFollowers",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "name_case", nameCase.ToNCString().ToSnake()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<User>> GetFollowers(
                int? userId = null, UserFields fields = UserFields.Anything,  NameCase nameCase = NameCase.Nom, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<User>>{
                    MethodName = "users.getFollowers",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) )},
                        { "name_case", nameCase.ToNCString().ToSnake()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<User>> GetNearby(
                double latitude , double longitude , int? accuracy = null, int? timeout = null, byte? radius = null, UserFields fields = UserFields.None,  NameCase nameCase = NameCase.Nom, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<User>>{
                    MethodName = "users.getNearby",
                    Parameters = new Dictionary<string, string> {

                        { "latitude", latitude.ToNCString()},
                        { "longitude", longitude.ToNCString()},
                        { "accuracy", MiscTools.NullableString(accuracy)},
                        { "timeout", MiscTools.NullableString(timeout)},
                        { "radius", MiscTools.NullableString(radius)},
                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) )},
                        { "name_case", nameCase.ToNCString().ToSnake()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<UserSubscriptions> GetSubscriptions(
                 int? userId = null, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<UserSubscriptions>{
                    MethodName = "users.getSubscriptions",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> IsAppUser(
                 int? userId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "users.isAppUser",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Report(
                int userId , ComplaintType type ,  string comment 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "users.report",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "type", type.ToNCString().ToSnake()},
                        { "comment", comment},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<User>> Search(
                string q = "", SearchSortOrder sort = SearchSortOrder.ByRating, UserFields fields = UserFields.None, int? city = null, int? country = null, string hometown = "", int? universityCountry = null, int? university = null, int? universityYear = null, Sex? sex = null, Relation? status = null, byte? ageFrom = null, byte? ageTo = null, byte? birthDay = null, byte? birthMonth = null, ushort? birthYear = null, bool? online = null, bool? hasPhoto = null, int? schoolCountry = null, int? schoolCity = null, int? schoolClass = null, int? school = null, int? schoolYear = null, string religion = "", string interests = "", string company = "", string position = "", int? groupId = null,  FriendshipType? fromList = null, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<User>>{
                    MethodName = "users.search",
                    Parameters = new Dictionary<string, string> {

                        { "q", q},
                        { "sort", ((int)sort).ToNCString()},
                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) )},
                        { "city", MiscTools.NullableString(city)},
                        { "country", MiscTools.NullableString(country)},
                        { "hometown", hometown},
                        { "university_country", MiscTools.NullableString(universityCountry)},
                        { "university", MiscTools.NullableString(university)},
                        { "university_year", MiscTools.NullableString(universityYear)},
                        { "sex", MiscTools.NullableString( (int?)sex )},
                        { "status", MiscTools.NullableString( (int?)status )},
                        { "age_from", MiscTools.NullableString(ageFrom)},
                        { "age_to", MiscTools.NullableString(ageTo)},
                        { "birth_day", MiscTools.NullableString(birthDay)},
                        { "birth_month", MiscTools.NullableString(birthMonth)},
                        { "birth_year", MiscTools.NullableString(birthYear)},
                        { "online", (online != null ? ( online.Value ? 1 : 0 ).ToNCString() : "")},
                        { "has_photo", (hasPhoto != null ? ( hasPhoto.Value ? 1 : 0 ).ToNCString() : "")},
                        { "school_country", MiscTools.NullableString(schoolCountry)},
                        { "school_city", MiscTools.NullableString(schoolCity)},
                        { "school_class", MiscTools.NullableString(schoolClass)},
                        { "school", MiscTools.NullableString(school)},
                        { "school_year", MiscTools.NullableString(schoolYear)},
                        { "religion", religion},
                        { "interests", interests},
                        { "company", company},
                        { "position", position},
                        { "group_id", MiscTools.NullableString(groupId)},
                        { "from_list", MiscTools.NullableString( fromList )},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_utils Utils {get; private set;}
        public partial class MethodGroup_utils {
            private readonly RequestApi _parent;
            internal MethodGroup_utils(RequestApi parent){_parent=parent;}

            public VKRequest<LinkCheckResult> CheckLink(
                 string url 
            ) {
                var req = new VKRequest<LinkCheckResult>{
                    MethodName = "utils.checkLink",
                    Parameters = new Dictionary<string, string> {

                        { "url", url},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<int> GetServerTime(
                
            ) {
                var req = new VKRequest<int>{
                    MethodName = "utils.getServerTime",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<ResolveResult> ResolveScreenName(
                 string screenName 
            ) {
                var req = new VKRequest<ResolveResult>{
                    MethodName = "utils.resolveScreenName",
                    Parameters = new Dictionary<string, string> {

                        { "screen_name", screenName},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_video Video {get; private set;}
        public partial class MethodGroup_video {
            private readonly RequestApi _parent;
            internal MethodGroup_video(RequestApi parent){_parent=parent;}

            public VKRequest<bool> Add(
                ulong videoId ,  int ownerId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "video.add",
                    Parameters = new Dictionary<string, string> {

                        { "video_id", videoId.ToNCString()},
                        { "owner_id", ownerId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Delete(
                ulong videoId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "video.delete",
                    Parameters = new Dictionary<string, string> {

                        { "video_id", videoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> DeleteAlbum(
                long albumId ,  int? groupId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "video.deleteAlbum",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString()},
                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> DeleteComment(
                int commentId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "video.deleteComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> EditComment(
                string message , int commentId ,  int? ownerId 
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "video.editComment",
                    Parameters = new Dictionary<string, string> {

                        { "message", message},
                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<Tag[]> GetTags(
                long videoId ,  int? ownerId = null
            ) {
                var req = new VKRequest<Tag[]>{
                    MethodName = "video.getTags",
                    Parameters = new Dictionary<string, string> {

                        { "video_id", videoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> PutTag(
                int userId , string taggedName , ulong videoId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "video.putTag",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "tagged_name", taggedName},
                        { "video_id", videoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> RemoveTag(
                ulong videoId , int tagId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "video.removeTag",
                    Parameters = new Dictionary<string, string> {

                        { "video_id", videoId.ToNCString()},
                        { "tag_id", tagId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Report(
                ulong videoId , int? ownerId = null, ReportReason? reason = null, string comment = "",  string searchQuery = ""
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "video.report",
                    Parameters = new Dictionary<string, string> {

                        { "video_id", videoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "reason", MiscTools.NullableString( (int?)reason )},
                        { "comment", comment},
                        { "search_query", searchQuery},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> ReportComment(
                int commentId , int? ownerId = null,  ReportReason? reason = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "video.reportComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "reason", MiscTools.NullableString( (int?)reason )},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> RestoreComment(
                int commentId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "video.restoreComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Restore(
                long videoId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "video.restore",
                    Parameters = new Dictionary<string, string> {

                        { "video_id", videoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_wall Wall {get; private set;}
        public partial class MethodGroup_wall {
            private readonly RequestApi _parent;
            internal MethodGroup_wall(RequestApi parent){_parent=parent;}

            public VKRequest<bool> Delete(
                int postId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "wall.delete",
                    Parameters = new Dictionary<string, string> {

                        { "post_id", postId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> DeleteComment(
                int commentId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "wall.deleteComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<Post>> Get(
                int? ownerId = null, string domain = "",  WallPostFilter filter = WallPostFilter.All, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<Post>>{
                    MethodName = "wall.get",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "domain", domain},
                        { "filter", filter.ToNCString().ToSnake()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<Post[]> GetById(
                int copyHistoryDepth = 2, params string[] posts 
            ) {
                var req = new VKRequest<Post[]>{
                    MethodName = "wall.getById",
                    Parameters = new Dictionary<string, string> {

                        { "copy_history_depth", copyHistoryDepth.ToNCString()},
                        { "posts", String.Join(",",posts)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<Post[]> GetById(
                int copyHistoryDepth = 2, params Tuple<int,int>[] posts 
            ) {
                var req = new VKRequest<Post[]>{
                    MethodName = "wall.getById",
                    Parameters = new Dictionary<string, string> {

                        { "copy_history_depth", copyHistoryDepth.ToNCString()},
                        { "posts", String.Join(",",posts.Select(a=>a.Item1 +"_" +a.Item2))},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<EntityList<Comment>> GetComments(
                int postId , string sort , int previewLength , int extended , int? ownerId = null,  bool needLikes = false, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<Comment>>{
                    MethodName = "wall.getComments",
                    Parameters = new Dictionary<string, string> {

                        { "post_id", postId.ToNCString()},
                        { "sort", sort},
                        { "preview_length", previewLength.ToNCString()},
                        { "extended", extended.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "need_likes", (needLikes?1:0).ToNCString()},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Pin(
                int postId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "wall.pin",
                    Parameters = new Dictionary<string, string> {

                        { "post_id", postId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<WallPost> Post(
                string message = "", string attachments = "", int? ownerId = null, bool fromGroup = false, bool signed = false, bool? friendsOnly = false, string services = "", int? publishDate = null, double? lat = null, double? @long = null,  int? placeId = null
            ) {
                var req = new VKRequest<WallPost>{
                    MethodName = "wall.post",
                    Parameters = new Dictionary<string, string> {

                        { "message", message},
                        { "attachments", attachments},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "from_group", (fromGroup?1:0).ToNCString()},
                        { "signed", (signed?1:0).ToNCString()},
                        { "friends_only", (friendsOnly != null ? ( friendsOnly.Value ? 1 : 0 ).ToNCString() : "")},
                        { "services", services},
                        { "publish_date", MiscTools.NullableString(publishDate)},
                        { "lat", MiscTools.NullableString(lat)},
                        { "long", MiscTools.NullableString(@long)},
                        { "place_id", MiscTools.NullableString(placeId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<WallPost> Post(
                int postId ,  int? ownerId = null
            ) {
                var req = new VKRequest<WallPost>{
                    MethodName = "wall.post",
                    Parameters = new Dictionary<string, string> {

                        { "post_id", postId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> ReportComment(
                int commentId , int? ownerId = null,  ReportReason? reason = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "wall.reportComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "reason", MiscTools.NullableString( (int?)reason )},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> ReportPost(
                int postId , int? ownerId = null,  ReportReason? reason = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "wall.reportPost",
                    Parameters = new Dictionary<string, string> {

                        { "post_id", postId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "reason", MiscTools.NullableString( (int?)reason )},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<RepostInfo> Repost(
                string @object , string message = "",  int? groupId = null
            ) {
                var req = new VKRequest<RepostInfo>{
                    MethodName = "wall.repost",
                    Parameters = new Dictionary<string, string> {

                        { "object", @object},
                        { "message", message},
                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Restore(
                int postId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "wall.restore",
                    Parameters = new Dictionary<string, string> {

                        { "post_id", postId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> RestoreComment(
                int commentId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "wall.restoreComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public VKRequest<bool> Unpin(
                int postId ,  int? ownerId = null
            ) {
                var req = new VKRequest<bool>{
                    MethodName = "wall.unpin",
                    Parameters = new Dictionary<string, string> {

                        { "post_id", postId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_likes Likes {get; private set;}
        public partial class MethodGroup_likes {
            private readonly RequestApi _parent;
            internal MethodGroup_likes(RequestApi parent){_parent=parent;}

            public VKRequest<EntityList<int>> GetList(
                string type , string filter , bool friendsOnly , bool skipOwn , bool extended = false, int? ownerId = null, int? itemId = null,  string pageUrl = null, int offset = 0, int count = 100
            ) {
                var req = new VKRequest<EntityList<int>>{
                    MethodName = "likes.getList",
                    Parameters = new Dictionary<string, string> {

                        { "type", type},
                        { "filter", filter},
                        { "friends_only", (friendsOnly?1:0).ToNCString()},
                        { "skip_own", (skipOwn?1:0).ToNCString()},
                        { "extended", (extended?1:0).ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "item_id", MiscTools.NullableString(itemId)},
                        { "page_url", pageUrl},
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
    }
}