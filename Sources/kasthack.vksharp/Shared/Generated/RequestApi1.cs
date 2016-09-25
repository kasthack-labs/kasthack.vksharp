
using System;
using System.Collections.Generic;
using System.Linq;
using kasthack.vksharp.DataTypes;
using kasthack.vksharp.DataTypes.Entities;
using kasthack.vksharp.DataTypes.ResponseEntities;
using kasthack.vksharp.DataTypes.Enums;
using kasthack.vksharp.DataTypes.EntityFragments;
using kasthack.vksharp.DataTypes.Interfaces;
using kasthack.vksharp.Implementation;
using kasthack.vksharp.Internal;

// ReSharper disable UnusedMember.Global
// ReSharper disable UseObjectOrCollectionInitializer
namespace kasthack.vksharp {
    public partial class RequestApi {
        private void InitializeMethodGroups(){
            this.Account = new MethodGroup_account(this);
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

            ///<summary>
            ///Добавляет пользователя в черный список.Если указанный пользователь является другом текущего пользователя или имеет от него входящую или исходящую заявку в друзья, то для добавления пользователя в черный список Ваше приложение должно иметь права: friends.
            ///</summary>
            ///<param name="userId">Идентификатор пользователя, которого нужно добавить в черный список</param>
            public Request<bool> BanUser(
                 int userId 
            ) {
                var req = new Request<bool>{
                    MethodName = "account.banUser",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Позволяет сменить пароль пользователя после успешного восстановления доступа к аккаунту через СМС, используя метод auth.restore
            ///      
            ///</summary>
            ///<param name="restoreSid">Идентификатор сессии, полученный при восстановлении доступа используя метод auth.restore. (В случае если пароль меняется сразу после восстановления доступа)</param>
            ///<param name="changePasswordHash">Хэш, полученный при успешной OAuth авторизации по коду полученному по СМС (В случае если пароль меняется сразу после восстановления доступа)</param>
            ///<param name="oldPassword">Текущий пароль пользователя</param>
            ///<param name="newPassword">Новый пароль, который будет установлен в качестве текущего</param>
            public Request<ChangePassword> ChangePassword(
                string restoreSid , string changePasswordHash , string oldPassword ,  string newPassword 
            ) {
                var req = new Request<ChangePassword>{
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

            ///<summary>
            ///        Возвращает список активных рекламных предложений (офферов), выполнив которые пользователь сможет получить соответствующее количество голосов на свой счёт внутри приложения
            ///      
            ///</summary>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public Request<EntityList<Offer>> GetActiveOffers(
                int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<Offer>>{
                    MethodName = "account.getActiveOffers",
                    Parameters = new Dictionary<string, string> {

                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Получает настройки текущего пользователя в данном приложении
            ///      
            ///</summary>
            ///<returns>
            ///        После успешного выполнения возвращает битовую маску настроек текущего пользователя в данном приложении
            ///      
            ///</returns>
            ///<param name="userId">Идентификатор пользователя, информацию о настройках которого необходимо получить. По умолчанию — текущий пользователь</param>
            public Request<Permission> GetAppPermissions(
                 int? userId = null
            ) {
                var req = new Request<Permission>{
                    MethodName = "account.getAppPermissions",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///      Возвращает список пользователей, находящихся в черном списке
            ///    
            ///</summary>
            ///<returns>
            ///      Возвращает набор объектов пользователей, находящихся в черном списке
            ///    
            ///</returns>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public Request<User[]> GetBanned(
                int? offset = null, int? count = 20
            ) {
                var req = new Request<User[]>{
                    MethodName = "account.getBanned",
                    Parameters = new Dictionary<string, string> {

                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Возвращает информацию о текущем аккаунте
            ///      
            ///</summary>
            ///<returns>
            ///        Возвращает объект AccountInfo
            ///      
            ///</returns>
            public Request<AccountInfo> GetInfo(
                
            ) {
                var req = new Request<AccountInfo>{
                    MethodName = "account.getInfo",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Отменяет редактирование профиля
            ///      
            ///</summary>
            ///<param name="cancelRequestId">идентификатор заявки на смену имени, которую необходимо отменить</param>
            public Request<SaveProfileInfo> SaveProfileInfo(
                 int cancelRequestId 
            ) {
                var req = new Request<SaveProfileInfo>{
                    MethodName = "account.saveProfileInfo",
                    Parameters = new Dictionary<string, string> {

                        { "cancel_request_id", cancelRequestId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Редактирует информацию текущего профиля
            ///      
            ///</summary>
            ///<param name="firstName">имя пользователя</param>
            ///<param name="lastName">фамилия пользователя.</param>
            ///<param name="maidenName">девичья фамилия пользователя (только для женского пола)</param>
            ///<param name="screenName">короткое имя страницы</param>
            ///<param name="sex">пол пользователя</param>
            ///<param name="relation">семейное положение пользователя</param>
            ///<param name="relationPartnerId">идентификатор пользователя, с которым связано семейное положение</param>
            ///<param name="bdate">дата рождения пользователя</param>
            ///<param name="homeTown">родной город пользователя</param>
            ///<param name="countryId">идентификатор страны пользователя</param>
            ///<param name="cityId">идентификатор города пользователя</param>
            ///<param name="status">статус пользователя, который также может быть изменен методом status.set</param>
            public Request<SaveProfileInfo> SaveProfileInfo(
                string firstName = "", string lastName = "", string maidenName = "", string screenName = "", Sex? sex = null, Relation? relation = null, int? relationPartnerId = null, Date? bdate = null, string homeTown = "", int? countryId = null, int? cityId = null,  string status = ""
            ) {
                var req = new Request<SaveProfileInfo>{
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
                        { "home_town", homeTown},
                        { "country_id", MiscTools.NullableString(countryId)},
                        { "city_id", MiscTools.NullableString(cityId)},
                        { "status", status},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Возвращает информацию о текущем профиле
            ///      
            ///</summary>
            public Request<User> GetProfileInfo(
                
            ) {
                var req = new Request<User>{
                    MethodName = "account.getProfileInfo",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Позволяет редактировать информацию о текущем аккаунте.
            ///      
            ///</summary>
            ///<param name="intro">битовая маска, отвечающая за прохождение обучения в мобильных клиентах</param>
            ///<param name="ownPostsDefault">Отображать по дефолту только записи пользователя</param>
            ///<param name="noWallReplies">отключить комментирование записей на стене</param>
            public Request<bool> SetInfo(
                int? intro = null, bool? ownPostsDefault = null,  bool? noWallReplies = null
            ) {
                var req = new Request<bool>{
                    MethodName = "account.setInfo",
                    Parameters = new Dictionary<string, string> {

                        { "intro", MiscTools.NullableString(intro)},
                        { "own_posts_default", (ownPostsDefault != null ? ( ownPostsDefault.Value ? 1 : 0 ).ToNCString() : "")},
                        { "no_wall_replies", (noWallReplies != null ? ( noWallReplies.Value ? 1 : 0 ).ToNCString() : "")},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Устанавливает короткое название приложения (до 17 символов), которое выводится пользователю в левом меню
            ///      
            ///</summary>
            ///<param name="name">короткое название приложения</param>
            ///<param name="userId">идентификатор пользователя</param>
            public Request<bool> SetNameInMenu(
                string name ,  string userId 
            ) {
                var req = new Request<bool>{
                    MethodName = "account.setNameInMenu",
                    Parameters = new Dictionary<string, string> {

                        { "name", name},
                        { "user_id", userId},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Помечает текущего пользователя как offline
            ///      
            ///</summary>
            public Request<bool> SetOffline(
                
            ) {
                var req = new Request<bool>{
                    MethodName = "account.setOffline",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Помечает текущего пользователя как online на 15 минут
            ///      
            ///</summary>
            ///<param name="voip">возможны ли видеозвонки для данного устройства</param>
            public Request<bool> SetOnline(
                 bool voip = true
            ) {
                var req = new Request<bool>{
                    MethodName = "account.setOnline",
                    Parameters = new Dictionary<string, string> {

                        { "voip", (voip?1:0).ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Отключает push-уведомления на заданный промежуток времени
            ///      
            ///</summary>
            ///<param name="deviceId">уникальный идентификатор устройства</param>
            ///<param name="time">время в секундах на которое требуется отключить уведомления, -1 отключить навсегда</param>
            ///<param name="chatId"></param>
            ///<param name="userId">идентификатор пользователя</param>
            ///<param name="sound">включить/отключить звук в данном диалоге</param>
            public Request<bool> SetSilenceMode(
                string deviceId , int time , int? chatId = null, int? userId = null,  int sound = 0
            ) {
                var req = new Request<bool>{
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

            ///<summary>
            ///        Убирает пользователя из черного списка
            ///      
            ///</summary>
            ///<param name="userId">идентификатор пользователя, которого нужно убрать из черного списка</param>
            public Request<bool> UnbanUser(
                 int userId 
            ) {
                var req = new Request<bool>{
                    MethodName = "account.unbanUser",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Подписывает устройство на базе iOS, Android или Windows Phone на получение Push-уведомлений
            ///      
            ///</summary>
            ///<param name="token">Идентификатор устройства, используемый для отправки уведомлений. (для mpns идентификатор должен представлять из себя URL для отправки уведомлений)</param>
            ///<param name="deviceId">уникальный идентификатор устройства</param>
            ///<param name="settings">сериализованный JSON-объект, описывающий настройки уведомлений в специальном формате</param>
            ///<param name="deviceYear">год устройства</param>
            ///<param name="deviceModel">cтроковое название модели устройства</param>
            ///<param name="systemVersion">строковая версия операционной системы устройства</param>
            ///<param name="sandbox">(iOS) использовать sandbox сервер для отправки push-уведомлений</param>
            public Request<bool> RegisterDevice(
                string token , string deviceId , string settings , int? deviceYear = null, string deviceModel = "", string systemVersion = "",  bool? sandbox = null
            ) {
                var req = new Request<bool>{
                    MethodName = "account.registerDevice",
                    Parameters = new Dictionary<string, string> {

                        { "token", token},
                        { "device_id", deviceId},
                        { "settings", settings},
                        { "device_year", MiscTools.NullableString(deviceYear)},
                        { "device_model", deviceModel},
                        { "system_version", systemVersion},
                        { "sandbox", (sandbox != null ? ( sandbox.Value ? 1 : 0 ).ToNCString() : "")},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Отписывает устройство от Push уведомлений
            ///      
            ///</summary>
            ///<param name="deviceId">уникальный идентификатор устройства</param>
            ///<param name="sandbox">отписать устройство, использующее sandbox сервер для отправки push-уведомлений</param>
            public Request<bool> UnregisterDevice(
                string deviceId ,  bool? sandbox = null
            ) {
                var req = new Request<bool>{
                    MethodName = "account.unregisterDevice",
                    Parameters = new Dictionary<string, string> {

                        { "device_id", deviceId},
                        { "sandbox", (sandbox != null ? ( sandbox.Value ? 1 : 0 ).ToNCString() : "")},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
        public MethodGroup_apps Apps {get; private set;}
        public partial class MethodGroup_apps {
            private readonly RequestApi _parent;
            internal MethodGroup_apps(RequestApi parent){_parent=parent;}

            ///<summary>
            ///        Удаляет все уведомления о запросах, отправленных из текущего приложения
            ///      
            ///</summary>
            public Request<bool> DeleteAppRequests(
                
            ) {
                var req = new Request<bool>{
                    MethodName = "apps.deleteAppRequests",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Метод возвращает количество очков пользователя в этой игре
            ///      
            ///</summary>
            public Request<long> GetScore(
                
            ) {
                var req = new Request<long>{
                    MethodName = "apps.getScore",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Возвращает рейтинг пользователей в игре
            ///      
            ///</summary>
            ///<param name="type">Тип рейтинга</param>
            ///<param name="global">Глобальный/только друзья</param>
            public Request<EntityList<User>> GetLeaderboardExtended(
                LeaderBoardType type ,  bool global = true
            ) {
                var req = new Request<EntityList<User>>{
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

            ///<summary>
            ///        Возвращает рейтинг пользователей в игре
            ///      
            ///</summary>
            ///<param name="type">Тип рейтинга</param>
            ///<param name="global">Глобальный/только друзья</param>
            public Request<EntityList<int>> GetLeaderboard(
                LeaderBoardType type ,  bool global = true
            ) {
                var req = new Request<EntityList<int>>{
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

            ///<summary>
            ///        Копирует аудиозапись на страницу пользователя или группы
            ///      
            ///</summary>
            ///<param name="ownerId">идентификатор владельца аудиозаписи (пользователь или сообщество)</param>
            ///<param name="audioId">Идентификатор аудиозаписи</param>
            ///<param name="groupId">идентификатор сообщества (если аудиозапись необходимо скопировать в список сообщества)</param>
            ///<param name="albumId">идентификатор альбома, в который нужно переместить аудиозапись</param>
            public Request<int> Add(
                int ownerId , long audioId , int? groupId = null,  long? albumId = null
            ) {
                var req = new Request<int>{
                    MethodName = "audio.add",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", ownerId.ToNCString()},
                        { "audio_id", audioId.ToNCString()},
                        { "group_id", MiscTools.NullableString(groupId)},
                        { "album_id", MiscTools.NullableString(albumId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Создает пустой альбом аудиозаписей
            ///      
            ///</summary>
            ///<param name="title">название альбома</param>
            ///<param name="groupId">идентификатор сообщества (если альбом нужно создать в сообществе)</param>
            public Request<AddAlbum> AddAlbum(
                string title ,  int? groupId = 0
            ) {
                var req = new Request<AddAlbum>{
                    MethodName = "audio.addAlbum",
                    Parameters = new Dictionary<string, string> {

                        { "title", title},
                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Удаляет аудиозапись со страницы пользователя или сообщества
            ///      
            ///</summary>
            ///<param name="audioId">идентификатор аудиозаписи</param>
            ///<param name="ownerId">идентификатор владельца аудиозаписи (пользователь или сообщество)</param>
            public Request<bool> Delete(
                long audioId ,  int ownerId 
            ) {
                var req = new Request<bool>{
                    MethodName = "audio.delete",
                    Parameters = new Dictionary<string, string> {

                        { "audio_id", audioId.ToNCString()},
                        { "owner_id", ownerId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Удаляет альбом аудиозаписей
            ///      
            ///</summary>
            ///<param name="albumId">идентификатор альбома</param>
            ///<param name="groupId">идентификатор сообщества, которому принадлежит альбом</param>
            public Request<bool> DeleteAlbum(
                long albumId ,  int? groupId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "audio.deleteAlbum",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString()},
                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<int> Edit(
                int ownerId , long audioId , string artist = "", string title = "", string text = "", AudioGenre? genreId = null,  bool? noSearch = null
            ) {
                var req = new Request<int>{
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

            public Request<bool> EditAlbum(
                long albumId , string title ,  int? groupId = null
            ) {
                var req = new Request<bool>{
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

            public Request<bool> MoveToAlbum(
                long albumId , int? groupId = null, params long[] audioIds 
            ) {
                var req = new Request<bool>{
                    MethodName = "audio.moveToAlbum",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString()},
                        { "group_id", MiscTools.NullableString(groupId)},
                        { "audio_ids", (audioIds??new long[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<Audio>> Get(
                int? ownerId = null, long? albumId = null, int? offset = null, int? count = 100, params long[] audioIds 
            ) {
                var req = new Request<EntityList<Audio>>{
                    MethodName = "audio.get",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "album_id", MiscTools.NullableString(albumId)},
                        { "audio_ids", (audioIds??new long[]{}).ToNCStringA()},
                        {"need_user","false"},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<Group[]> GetBroadcastListGroups(
                 bool active = true, int? offset = null, int? count = 100
            ) {
                var req = new Request<Group[]>{
                    MethodName = "audio.getBroadcastList",
                    Parameters = new Dictionary<string, string> {

                        { "active", (active?1:0).ToNCString()},
                        {"filter","groups"},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<User[]> GetBroadcastListUsers(
                 bool active = true, int? offset = null, int? count = 100
            ) {
                var req = new Request<User[]>{
                    MethodName = "audio.getBroadcastList",
                    Parameters = new Dictionary<string, string> {

                        { "active", (active?1:0).ToNCString()},
                        {"filter","friends"},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<Audio>> GetPopular(
                AudioGenre? genreId = null,  bool? onlyEng = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<Audio>>{
                    MethodName = "audio.getPopular",
                    Parameters = new Dictionary<string, string> {

                        { "genre_id", MiscTools.NullableString( (int?)genreId )},
                        { "only_eng", (onlyEng != null ? ( onlyEng.Value ? 1 : 0 ).ToNCString() : "")},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<Audio>> GetRecommendations(
                AudioGenre? genreId = null,  bool? onlyEng = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<Audio>>{
                    MethodName = "audio.getRecommendations",
                    Parameters = new Dictionary<string, string> {

                        { "genre_id", MiscTools.NullableString( (int?)genreId )},
                        { "only_eng", (onlyEng != null ? ( onlyEng.Value ? 1 : 0 ).ToNCString() : "")},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<AudioAlbum>> GetAlbums(
                 int? ownerId = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<AudioAlbum>>{
                    MethodName = "audio.getAlbums",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<Audio[]> GetById(
                bool itunes = false, params ContentId[] audios 
            ) {
                var req = new Request<Audio[]>{
                    MethodName = "audio.getById",
                    Parameters = new Dictionary<string, string> {

                        { "itunes", (itunes?1:0).ToNCString()},
                        { "audios",  String.Join(",",audios.Select(a=>a.ToIdString()).ToArray()) },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<int> GetCount(
                 int? ownerId = null
            ) {
                var req = new Request<int>{
                    MethodName = "audio.getCount",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<Lyrics> GetLyrics(
                 long lyricsId 
            ) {
                var req = new Request<Lyrics>{
                    MethodName = "audio.getLyrics",
                    Parameters = new Dictionary<string, string> {

                        { "lyrics_id", lyricsId.ToNCString()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<string> GetUploadServer(
                long albumId ,  int? groupId = null
            ) {
                var req = new Request<string>{
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

            public Request<bool> Reorder(
                long audioId , int? ownerId = null, long? before = null,  long? after = null
            ) {
                var req = new Request<bool>{
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

            public Request<Audio> Restore(
                long audioId ,  int? ownerId = null
            ) {
                var req = new Request<Audio>{
                    MethodName = "audio.restore",
                    Parameters = new Dictionary<string, string> {

                        { "audio_id", audioId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<Audio[]> Save(
                string server , string audio , string hash , string artist = "",  string title = ""
            ) {
                var req = new Request<Audio[]>{
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

            public Request<EntityList<Audio>> Search(
                string q , bool autoComplete = true, bool lyrics = false, bool performerOnly = false, AudioSortOrder sort = AudioSortOrder.ByRating,  bool searchOwn = false, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<Audio>>{
                    MethodName = "audio.search",
                    Parameters = new Dictionary<string, string> {

                        { "q", q},
                        { "auto_complete", (autoComplete?1:0).ToNCString()},
                        { "lyrics", (lyrics?1:0).ToNCString()},
                        { "performer_only", (performerOnly?1:0).ToNCString()},
                        { "sort", ((int)sort).ToNCString()},
                        { "search_own", (searchOwn?1:0).ToNCString()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> SetBroadcast(
                ContentId audio , params int[] targetIds 
            ) {
                var req = new Request<bool>{
                    MethodName = "audio.setBroadcast",
                    Parameters = new Dictionary<string, string> {

                        { "audio",  audio.ToIdString() },
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

            public Request<bool> CheckPhone(
                string phone , string clientSecret ,  int? clientId = null
            ) {
                var req = new Request<bool>{
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

            public Request<ConfirmResult> Confirm(
                int clientId , string clientSecret , string phone , string code , string password = "", bool testMode = false,  int? intro = null
            ) {
                var req = new Request<ConfirmResult>{
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

            public Request<AuthRestore> Restore(
                 long phone 
            ) {
                var req = new Request<AuthRestore>{
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

            public Request<bool> CloseTopic(
                int groupId ,  int topicId 
            ) {
                var req = new Request<bool>{
                    MethodName = "board.closeTopic",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "topic_id", topicId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> DeleteComment(
                int groupId , int topicId ,  int commentId 
            ) {
                var req = new Request<bool>{
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

            public Request<bool> DeleteTopic(
                int groupId ,  int topicId 
            ) {
                var req = new Request<bool>{
                    MethodName = "board.deleteTopic",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "topic_id", topicId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> FixTopic(
                int groupId ,  int topicId 
            ) {
                var req = new Request<bool>{
                    MethodName = "board.fixTopic",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "topic_id", topicId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> RestoreComment(
                int groupId , int topicId ,  int commentId 
            ) {
                var req = new Request<bool>{
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

            public Request<bool> UnfixTopic(
                int groupId ,  int topicId 
            ) {
                var req = new Request<bool>{
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

            public Request<EntityList<DatabaseEntry>> GetChairs(
                 int facultyId , int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<DatabaseEntry>>{
                    MethodName = "database.getChairs",
                    Parameters = new Dictionary<string, string> {

                        { "faculty_id", facultyId.ToNCString()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<DatabaseCity[]> GetCities(
                int countryId , int? regionId = null, string q = "",  bool needAll = false, int? offset = null, int? count = 100
            ) {
                var req = new Request<DatabaseCity[]>{
                    MethodName = "database.getCities",
                    Parameters = new Dictionary<string, string> {

                        { "country_id", countryId.ToNCString()},
                        { "region_id", MiscTools.NullableString(regionId)},
                        { "q", q},
                        { "need_all", (needAll?1:0).ToNCString()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<DatabaseCity[]> GetCitiesById(
                params int[] cityIds 
            ) {
                var req = new Request<DatabaseCity[]>{
                    MethodName = "database.getCitiesById",
                    Parameters = new Dictionary<string, string> {

                        { "city_ids", (cityIds??new int[]{}).ToNCStringA()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<DatabaseEntry>> GetCountries(
                string code = "",  bool needAll = false, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<DatabaseEntry>>{
                    MethodName = "database.getCountries",
                    Parameters = new Dictionary<string, string> {

                        { "code", code},
                        { "need_all", (needAll?1:0).ToNCString()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<DatabaseEntry[]> GetCountriesById(
                params int[] countryIds 
            ) {
                var req = new Request<DatabaseEntry[]>{
                    MethodName = "database.getCountriesById",
                    Parameters = new Dictionary<string, string> {

                        { "country_ids", (countryIds??new int[]{}).ToNCStringA()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<DatabaseEntry>> GetFaculties(
                 int universityId , int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<DatabaseEntry>>{
                    MethodName = "database.getFaculties",
                    Parameters = new Dictionary<string, string> {

                        { "university_id", universityId.ToNCString()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<DatabaseEntry>> GetRegions(
                int countryId ,  string q = "", int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<DatabaseEntry>>{
                    MethodName = "database.getRegions",
                    Parameters = new Dictionary<string, string> {

                        { "country_id", countryId.ToNCString()},
                        { "q", q},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<DatabaseEntry[]> GetSchools(
                int? cityId = null,  string q = "", int? offset = null, int? count = 100
            ) {
                var req = new Request<DatabaseEntry[]>{
                    MethodName = "database.getSchools",
                    Parameters = new Dictionary<string, string> {

                        { "city_id", MiscTools.NullableString(cityId)},
                        { "q", q},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<DatabaseClass[]> GetSchoolClasses(
                 int countryId 
            ) {
                var req = new Request<DatabaseClass[]>{
                    MethodName = "database.getSchoolClasses",
                    Parameters = new Dictionary<string, string> {

                        { "country_id", countryId.ToNCString()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<DatabaseEntry[]> GetStreetsById(
                params int[] streetIds 
            ) {
                var req = new Request<DatabaseEntry[]>{
                    MethodName = "database.getStreetsById",
                    Parameters = new Dictionary<string, string> {

                        { "street_ids", (streetIds??new int[]{}).ToNCStringA()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<DatabaseEntry[]> GetUniversities(
                int? countryId = null, int? cityId = null,  string q = "", int? offset = null, int? count = 100
            ) {
                var req = new Request<DatabaseEntry[]>{
                    MethodName = "database.getUniversities",
                    Parameters = new Dictionary<string, string> {

                        { "country_id", MiscTools.NullableString(countryId)},
                        { "city_id", MiscTools.NullableString(cityId)},
                        { "q", q},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

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

            public Request<int> Add(
                long docId , int ownerId ,  string accessKey = ""
            ) {
                var req = new Request<int>{
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

            public Request<bool> Delete(
                long docId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "docs.delete",
                    Parameters = new Dictionary<string, string> {

                        { "doc_id", docId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<Document>> Get(
                 int? ownerId = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<Document>>{
                    MethodName = "docs.get",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<Document[]> GetById(
                params ContentId[] docs 
            ) {
                var req = new Request<Document[]>{
                    MethodName = "docs.getById",
                    Parameters = new Dictionary<string, string> {

                        { "docs",  String.Join(",",docs.Select(a=>a.ToIdString()).ToArray()) },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<string> GetUploadServer(
                 int? groupId = null
            ) {
                var req = new Request<string>{
                    MethodName = "docs.getUploadServer",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<string> GetWallUploadServer(
                 int? groupId = null
            ) {
                var req = new Request<string>{
                    MethodName = "docs.getWallUploadServer",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<Document[]> Save(
                string file , string title , params string[] tags 
            ) {
                var req = new Request<Document[]>{
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

            public Request<EntityList<Link>> GetLinks(
                int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<Link>>{
                    MethodName = "fave.getLinks",
                    Parameters = new Dictionary<string, string> {

                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<User>> GetUsers(
                int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<User>>{
                    MethodName = "fave.getUsers",
                    Parameters = new Dictionary<string, string> {

                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<Photo>> GetPhotos(
                int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<Photo>>{
                    MethodName = "fave.getPhotos",
                    Parameters = new Dictionary<string, string> {

                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<Post>> GetPosts(
                int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<Post>>{
                    MethodName = "fave.getPosts",
                    Parameters = new Dictionary<string, string> {

                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<Video>> GetVideos(
                int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<Video>>{
                    MethodName = "fave.getVideos",
                    Parameters = new Dictionary<string, string> {

                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> RemoveUser(
                 int userId 
            ) {
                var req = new Request<bool>{
                    MethodName = "fave.removeUser",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> RemoveLink(
                 int linkId 
            ) {
                var req = new Request<bool>{
                    MethodName = "fave.removeLink",
                    Parameters = new Dictionary<string, string> {

                        { "link_id", linkId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> RemoveGroup(
                 int groupId 
            ) {
                var req = new Request<bool>{
                    MethodName = "fave.removeGroup",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> AddGroup(
                 int groupId 
            ) {
                var req = new Request<bool>{
                    MethodName = "fave.addGroup",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> AddUser(
                 int userId 
            ) {
                var req = new Request<bool>{
                    MethodName = "fave.addUser",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> AddLink(
                string link ,  string text = ""
            ) {
                var req = new Request<bool>{
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

            public Request<AddFriendResult> Add(
                int userId ,  string text = ""
            ) {
                var req = new Request<AddFriendResult>{
                    MethodName = "friends.add",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "text", text},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<AddFriendsList> AddList(
                string name , params int[] userIds 
            ) {
                var req = new Request<AddFriendsList>{
                    MethodName = "friends.addList",
                    Parameters = new Dictionary<string, string> {

                        { "name", name},
                        { "user_ids", (userIds??new int[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<FriendshipStatus[]> AreFriends(
                bool needSign = false, params int[] userIds 
            ) {
                var req = new Request<FriendshipStatus[]>{
                    MethodName = "friends.areFriends",
                    Parameters = new Dictionary<string, string> {

                        { "need_sign", (needSign?1:0).ToNCString()},
                        { "user_ids", (userIds??new int[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<FriendsDelete> Delete(
                 int userId 
            ) {
                var req = new Request<FriendsDelete>{
                    MethodName = "friends.delete",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> DeleteAllRequests(
                
            ) {
                var req = new Request<bool>{
                    MethodName = "friends.deleteAllRequests",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> DeleteList(
                 int listId 
            ) {
                var req = new Request<bool>{
                    MethodName = "friends.deleteList",
                    Parameters = new Dictionary<string, string> {

                        { "list_id", listId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> Edit(
                int userId , params long[] listIds 
            ) {
                var req = new Request<bool>{
                    MethodName = "friends.edit",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "list_ids", (listIds??new long[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> EditList(
                long listId , string name = "", int[] userIds = null, int[] addUserIds = null, params int[] deleteUserIds 
            ) {
                var req = new Request<bool>{
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

            public Request<EntityList<FriendsList>> GetLists(
                int? userId = null,  bool returnSystem = true
            ) {
                var req = new Request<EntityList<FriendsList>>{
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

            public Request<EntityList<User>> Get(
                int? userId = null, int? listId = null, UserFields fields = UserFields.Anything, UserSortOrder order = UserSortOrder.ById,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<User>>{
                    MethodName = "friends.get",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "list_id", MiscTools.NullableString(listId)},
                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) )},
                        { "order", order.ToNCString().ToSnake()},
                        { "name_case", nameCase.ToNCString().ToSnake()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<int>> GetIds(
                int? userId = null, int? listId = null,  UserSortOrder order = UserSortOrder.ById, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<int>>{
                    MethodName = "friends.get",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "list_id", MiscTools.NullableString(listId)},
                        { "order", order.ToNCString().ToSnake()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<int>> GetAvailableForCallIds(
                
            ) {
                var req = new Request<EntityList<int>>{
                    MethodName = "friends.getAvailableForCall",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<User>> GetAvailableForCall(
                UserFields fields = UserFields.Anything,  NameCase nameCase = NameCase.Nom
            ) {
                var req = new Request<EntityList<User>>{
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

            public Request<EntityList<int>> Get(
                int? userId = null, int? listId = null,  UserSortOrder order = UserSortOrder.ById, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<int>>{
                    MethodName = "friends.get",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "list_id", MiscTools.NullableString(listId)},
                        { "order", order.ToNCString().ToSnake()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<int[]> GetAppUsers(
                
            ) {
                var req = new Request<int[]>{
                    MethodName = "friends.getAppUsers",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<User[]> GetByPhones(
                UserFields fields = UserFields.None, params ulong[] phones 
            ) {
                var req = new Request<User[]>{
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

            public Request<int[]> GetMutual(
                int targetUid , int? sourceUid = null,  bool order = false, int? offset = null, int? count = 100
            ) {
                var req = new Request<int[]>{
                    MethodName = "friends.getMutual",
                    Parameters = new Dictionary<string, string> {

                        { "target_uid", targetUid.ToNCString()},
                        { "source_uid", MiscTools.NullableString(sourceUid)},
                        { "order",  order ? "random" : "" },
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<int[]> GetOnline(
                int? userId = null, int? listId = null,  UserSortOrder? order = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<int[]>{
                    MethodName = "friends.getOnline",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "list_id", MiscTools.NullableString(listId)},
                        { "order", order?.ToNCString()?.ToSnake()??""},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<int[]> GetRecent(
                 int count = 20
            ) {
                var req = new Request<int[]>{
                    MethodName = "friends.getRecent",
                    Parameters = new Dictionary<string, string> {

                        { "count", count.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<User>> GetSuggestions(
                FriendSuggestionFilters filters = FriendSuggestionFilters.Everything, UserFields fields = UserFields.None,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<User>>{
                    MethodName = "friends.getSuggestions",
                    Parameters = new Dictionary<string, string> {

                        { "filters", String.Join( ",", MiscTools.GetFilterFields( filters ) )},
                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) )},
                        { "name_case", nameCase.ToNCString().ToSnake()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<User>> Search(
                int userId , string q = "",  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 20
            ) {
                var req = new Request<EntityList<User>>{
                    MethodName = "friends.search",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "q", q},
                        { "name_case", nameCase.ToNCString().ToSnake()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

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

            public Request<Link> AddLink(
                int groupId , string link ,  string text = ""
            ) {
                var req = new Request<Link>{
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

            public Request<bool> ApproveRequest(
                int groupId ,  int userId 
            ) {
                var req = new Request<bool>{
                    MethodName = "groups.approveRequest",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<Group> Create(
                string title , PageType type = PageType.Group, PageSubtype? subtype = null,  string description = ""
            ) {
                var req = new Request<Group>{
                    MethodName = "groups.create",
                    Parameters = new Dictionary<string, string> {

                        { "title", title},
                        { "type", type.ToNCString().ToSnake()},
                        { "subtype", MiscTools.NullableString( (int?)subtype )},
                        { "description", description},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> DeleteLink(
                int groupId ,  int linkId 
            ) {
                var req = new Request<bool>{
                    MethodName = "groups.deleteLink",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "link_id", linkId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> Edit(
                int groupId , string title = "", string description = "", string screenName = "", string website = "", string email = "", string phone = "", string rss = "", DateTimeOffset? eventStartDate = null, DateTimeOffset? eventFinishDate = null, DateTimeOffset? eventGroupId = null, int? subject = null, int? publicCategory = null, int? publicSubcategory = null, GroupAccess? access = null, AccessType? wall = null, AccessType? topics = null, AccessType? photos = null, AccessType? video = null, AccessType? audio = null, Date? publicDate = null, bool? links = null, bool? events = null, bool? places = null,  bool? contacts = null
            ) {
                var req = new Request<bool>{
                    MethodName = "groups.edit",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "title", title},
                        { "description", description},
                        { "screen_name", screenName},
                        { "website", website},
                        { "email", email},
                        { "phone", phone},
                        { "rss", rss},
                        { "event_start_date", MiscTools.NullableString(eventStartDate?.ToUnixTimeSeconds())},
                        { "event_finish_date", MiscTools.NullableString(eventFinishDate?.ToUnixTimeSeconds())},
                        { "event_group_id", MiscTools.NullableString(eventGroupId?.ToUnixTimeSeconds())},
                        { "subject", MiscTools.NullableString(subject)},
                        { "public_category", MiscTools.NullableString(publicCategory)},
                        { "public_subcategory", MiscTools.NullableString(publicSubcategory)},
                        { "access", MiscTools.NullableString( (int?)access )},
                        { "wall", MiscTools.NullableString( (int?)wall )},
                        { "topics", MiscTools.NullableString( (int?)topics )},
                        { "photos", MiscTools.NullableString( (int?)photos )},
                        { "video", MiscTools.NullableString( (int?)video )},
                        { "audio", MiscTools.NullableString( (int?)audio )},
                        { "public_date", MiscTools.NullableString(publicDate)},
                        { "links", (links != null ? ( links.Value ? 1 : 0 ).ToNCString() : "")},
                        { "events", (events != null ? ( events.Value ? 1 : 0 ).ToNCString() : "")},
                        { "places", (places != null ? ( places.Value ? 1 : 0 ).ToNCString() : "")},
                        { "contacts", (contacts != null ? ( contacts.Value ? 1 : 0 ).ToNCString() : "")},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> EditLink(
                int groupId , int linkId ,  string text = ""
            ) {
                var req = new Request<bool>{
                    MethodName = "groups.editLink",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "link_id", linkId.ToNCString()},
                        { "text", text},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<int>> Get(
                int userId ,  GroupsGetFilter? filter = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<int>>{
                    MethodName = "groups.get",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "filter", filter?.ToNCString()?.ToSnake()??""},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<User[]> GetBanned(
                 int groupId , int? offset = null, int? count = 100
            ) {
                var req = new Request<User[]>{
                    MethodName = "groups.getBanned",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<Group[]> GetById(
                string[] groupIds ,  GroupFields fields 
            ) {
                var req = new Request<Group[]>{
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

            public Request<Group[]> GetById(
                int groupId ,  GroupFields fields 
            ) {
                var req = new Request<Group[]>{
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

            public Request<Group[]> GetById(
                string groupId ,  GroupFields fields 
            ) {
                var req = new Request<Group[]>{
                    MethodName = "groups.getById",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId},
                        { "fields", String.Join( ",", MiscTools.GetGroupFields( fields ) )},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<Group[]> GetById(
                int[] groupIds ,  GroupFields fields 
            ) {
                var req = new Request<Group[]>{
                    MethodName = "groups.getById",
                    Parameters = new Dictionary<string, string> {

                        { "group_ids", (groupIds??new int[]{}).ToNCStringA()},
                        { "fields", String.Join( ",", MiscTools.GetGroupFields( fields ) )},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<int>> GetMembers(
                string groupId , GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<int>>{
                    MethodName = "groups.getMembers",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId},
                        { "filter", MiscTools.NullableString( (int?)filter )},
                        { "sort", MiscTools.NullableString( (int?)sort )},
                        {"fields",""},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<int>> GetMembers(
                int groupId , GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<int>>{
                    MethodName = "groups.getMembers",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "filter", MiscTools.NullableString( (int?)filter )},
                        { "sort", MiscTools.NullableString( (int?)sort )},
                        {"fields",""},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<GroupManager>> GetMembersManagers(
                string groupId ,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<GroupManager>>{
                    MethodName = "groups.getMembers",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId},
                        { "sort", MiscTools.NullableString( (int?)sort )},
                        {"filter","managers"},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<GroupManager>> GetMembersManagers(
                int groupId ,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<GroupManager>>{
                    MethodName = "groups.getMembers",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "sort", MiscTools.NullableString( (int?)sort )},
                        {"filter","managers"},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<User>> GetMembers(
                string groupId , UserFields fields = UserFields.Anything, GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<User>>{
                    MethodName = "groups.getMembers",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId},
                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) )},
                        { "filter", MiscTools.NullableString( (int?)filter )},
                        { "sort", MiscTools.NullableString( (int?)sort )},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<User>> GetMembers(
                int groupId , UserFields fields = UserFields.Anything, GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<User>>{
                    MethodName = "groups.getMembers",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) )},
                        { "filter", MiscTools.NullableString( (int?)filter )},
                        { "sort", MiscTools.NullableString( (int?)sort )},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> IsMember(
                int groupId ,  int? userId = null
            ) {
                var req = new Request<bool>{
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

            public Request<bool> Invite(
                int groupId ,  int userId 
            ) {
                var req = new Request<bool>{
                    MethodName = "groups.invite",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<MemberShip> IsMemberExtended(
                int groupId ,  int? userId = null
            ) {
                var req = new Request<MemberShip>{
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

            public Request<MemberShip[]> IsMember(
                int groupId , params int[] userIds 
            ) {
                var req = new Request<MemberShip[]>{
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

            public Request<bool> Join(
                int groupId ,  bool notSure = false
            ) {
                var req = new Request<bool>{
                    MethodName = "groups.join",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "not_sure", (notSure?1:0).ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> Leave(
                 int groupId 
            ) {
                var req = new Request<bool>{
                    MethodName = "groups.leave",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> UnbanUser(
                int groupId ,  int userId 
            ) {
                var req = new Request<bool>{
                    MethodName = "groups.unbanUser",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> RemoveUser(
                int groupId ,  int userId 
            ) {
                var req = new Request<bool>{
                    MethodName = "groups.removeUser",
                    Parameters = new Dictionary<string, string> {

                        { "group_id", groupId.ToNCString()},
                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> ReorderLink(
                int groupId , long linkId ,  long after = 0
            ) {
                var req = new Request<bool>{
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

            public Request<bool> AddChatUser(
                int userId ,  int? chatId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "messages.addChatUser",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "chat_id", MiscTools.NullableString(chatId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> Delete(
                params int[] messageIds 
            ) {
                var req = new Request<bool>{
                    MethodName = "messages.delete",
                    Parameters = new Dictionary<string, string> {

                        { "message_ids", (messageIds??new int[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> DeleteChatPhoto(
                 int chatId 
            ) {
                var req = new Request<bool>{
                    MethodName = "messages.deleteChatPhoto",
                    Parameters = new Dictionary<string, string> {

                        { "chat_id", chatId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> DeleteDialog(
                 int userId 
            ) {
                var req = new Request<bool>{
                    MethodName = "messages.deleteDialog",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<Message>> Get(
                int @out = 0, int timeOffset = 0, int filters = 0, int previewLength = 0,  long? lastMessageId = null, int? offset = null, int? count = 200
            ) {
                var req = new Request<EntityList<Message>>{
                    MethodName = "messages.get",
                    Parameters = new Dictionary<string, string> {

                        { "out", @out.ToNCString()},
                        { "time_offset", timeOffset.ToNCString()},
                        { "filters", filters.ToNCString()},
                        { "preview_length", previewLength.ToNCString()},
                        { "last_message_id", MiscTools.NullableString(lastMessageId)},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<Message>> GetHistoryChat(
                int chatId , bool rev = false,  long? startMessageId = null, int? offset = null, int? count = 200
            ) {
                var req = new Request<EntityList<Message>>{
                    MethodName = "messages.getHistory",
                    Parameters = new Dictionary<string, string> {

                        { "chat_id", chatId.ToNCString()},
                        { "rev", (rev?1:0).ToNCString()},
                        { "start_message_id", MiscTools.NullableString(startMessageId)},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<Message>> GetHistoryUser(
                int userId , bool rev = false,  long? startMessageId = null, int? offset = null, int? count = 200
            ) {
                var req = new Request<EntityList<Message>>{
                    MethodName = "messages.getHistory",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "rev", (rev?1:0).ToNCString()},
                        { "start_message_id", MiscTools.NullableString(startMessageId)},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<LastActivity> GetLastActivity(
                 int userId 
            ) {
                var req = new Request<LastActivity>{
                    MethodName = "messages.getLastActivity",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> MarkAsImportant(
                bool important , params int[] messageIds 
            ) {
                var req = new Request<bool>{
                    MethodName = "messages.markAsImportant",
                    Parameters = new Dictionary<string, string> {

                        { "important", (important?1:0).ToNCString()},
                        { "message_ids", (messageIds??new int[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> MarkAsRead(
                int userId , int? startMessageId = null, params int[] messageIds 
            ) {
                var req = new Request<bool>{
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

            public Request<int> Send(
                int userId , string message = null, int? guid = null, double? lat = null, double? @long = null, ContentId[] attachment = null, long[] forwardMessages = null, int? stickerId = null,  long? randomId = null
            ) {
                var req = new Request<int>{
                    MethodName = "messages.send",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "message", message},
                        { "guid", MiscTools.NullableString(guid)},
                        { "lat", MiscTools.NullableString(lat)},
                        { "long", MiscTools.NullableString(@long)},
                        { "attachment", (attachment??new ContentId[]{}).ToNCStringA()},
                        { "forward_messages", (forwardMessages??new long[]{}).ToNCStringA()},
                        { "sticker_id", MiscTools.NullableString(stickerId)},
                        { "random_id", MiscTools.NullableString(randomId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<int> Send(
                int[] userIds , string message = null, int? guid = null, double? lat = null, double? @long = null, ContentId[] attachment = null, long[] forwardMessages = null, int? stickerId = null,  long? randomId = null
            ) {
                var req = new Request<int>{
                    MethodName = "messages.send",
                    Parameters = new Dictionary<string, string> {

                        { "user_ids", (userIds??new int[]{}).ToNCStringA()},
                        { "message", message},
                        { "guid", MiscTools.NullableString(guid)},
                        { "lat", MiscTools.NullableString(lat)},
                        { "long", MiscTools.NullableString(@long)},
                        { "attachment", (attachment??new ContentId[]{}).ToNCStringA()},
                        { "forward_messages", (forwardMessages??new long[]{}).ToNCStringA()},
                        { "sticker_id", MiscTools.NullableString(stickerId)},
                        { "random_id", MiscTools.NullableString(randomId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<int> Send(
                string domain , string message = null, int? guid = null, double? lat = null, double? @long = null, ContentId[] attachment = null, long[] forwardMessages = null, int? stickerId = null,  long? randomId = null
            ) {
                var req = new Request<int>{
                    MethodName = "messages.send",
                    Parameters = new Dictionary<string, string> {

                        { "domain", domain},
                        { "message", message},
                        { "guid", MiscTools.NullableString(guid)},
                        { "lat", MiscTools.NullableString(lat)},
                        { "long", MiscTools.NullableString(@long)},
                        { "attachment", (attachment??new ContentId[]{}).ToNCStringA()},
                        { "forward_messages", (forwardMessages??new long[]{}).ToNCStringA()},
                        { "sticker_id", MiscTools.NullableString(stickerId)},
                        { "random_id", MiscTools.NullableString(randomId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<int> SendChat(
                int chatId , string message = null, int? guid = null, double? lat = null, double? @long = null, ContentId[] attachment = null, long[] forwardMessages = null, int? stickerId = null,  long? randomId = null
            ) {
                var req = new Request<int>{
                    MethodName = "messages.send",
                    Parameters = new Dictionary<string, string> {

                        { "chat_id", chatId.ToNCString()},
                        { "message", message},
                        { "guid", MiscTools.NullableString(guid)},
                        { "lat", MiscTools.NullableString(lat)},
                        { "long", MiscTools.NullableString(@long)},
                        { "attachment", (attachment??new ContentId[]{}).ToNCStringA()},
                        { "forward_messages", (forwardMessages??new long[]{}).ToNCStringA()},
                        { "sticker_id", MiscTools.NullableString(stickerId)},
                        { "random_id", MiscTools.NullableString(randomId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<int> SendPeer(
                long peerId , string message = null, int? guid = null, double? lat = null, double? @long = null, ContentId[] attachment = null, long[] forwardMessages = null, int? stickerId = null,  long? randomId = null
            ) {
                var req = new Request<int>{
                    MethodName = "messages.send",
                    Parameters = new Dictionary<string, string> {

                        { "peer_id", peerId.ToNCString()},
                        { "message", message},
                        { "guid", MiscTools.NullableString(guid)},
                        { "lat", MiscTools.NullableString(lat)},
                        { "long", MiscTools.NullableString(@long)},
                        { "attachment", (attachment??new ContentId[]{}).ToNCStringA()},
                        { "forward_messages", (forwardMessages??new long[]{}).ToNCStringA()},
                        { "sticker_id", MiscTools.NullableString(stickerId)},
                        { "random_id", MiscTools.NullableString(randomId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> RemoveChatUser(
                int userId ,  int chatId 
            ) {
                var req = new Request<bool>{
                    MethodName = "messages.removeChatUser",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "chat_id", chatId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> Restore(
                 int messageId 
            ) {
                var req = new Request<bool>{
                    MethodName = "messages.restore",
                    Parameters = new Dictionary<string, string> {

                        { "message_id", messageId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> SetActivity(
                int userId ,  ImActivity type = ImActivity.Typing
            ) {
                var req = new Request<bool>{
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

            public Request<bool> AddBan(
                int[] userIds = null, params int[] groupIds 
            ) {
                var req = new Request<bool>{
                    MethodName = "newsfeed.addBan",
                    Parameters = new Dictionary<string, string> {

                        { "user_ids", (userIds??new int[]{}).ToNCStringA()},
                        { "group_ids", (groupIds??new int[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> DeleteBan(
                int[] userIds = null, params int[] groupIds 
            ) {
                var req = new Request<bool>{
                    MethodName = "newsfeed.deleteBan",
                    Parameters = new Dictionary<string, string> {

                        { "user_ids", (userIds??new int[]{}).ToNCStringA()},
                        { "group_ids", (groupIds??new int[]{}).ToNCStringA()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> DeleteList(
                 int listId 
            ) {
                var req = new Request<bool>{
                    MethodName = "newsfeed.deleteList",
                    Parameters = new Dictionary<string, string> {

                        { "list_id", listId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<NewsfeedBanned> GetBanned(
                
            ) {
                var req = new Request<NewsfeedBanned>{
                    MethodName = "newsfeed.getBanned",
                    Parameters = new Dictionary<string, string> {

                        {"extended","false"},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<NewsfeedBannedExtended> GetBannedExtended(
                UserFields fields = UserFields.None,  NameCase nameCase = NameCase.Nom
            ) {
                var req = new Request<NewsfeedBannedExtended>{
                    MethodName = "newsfeed.getBanned",
                    Parameters = new Dictionary<string, string> {

                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) )},
                        { "name_case", nameCase.ToNCString().ToSnake()},
                        {"extended","true"},

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

            public Request<bool> Delete(
                 int noteId 
            ) {
                var req = new Request<bool>{
                    MethodName = "notes.delete",
                    Parameters = new Dictionary<string, string> {

                        { "note_id", noteId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> DeleteComment(
                int commentId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "notes.deleteComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> RestoreComment(
                int commentId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
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

            public Request<bool> MarkAsViewed(
                
            ) {
                var req = new Request<bool>{
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

            public Request<bool> ClearCache(
                 string url 
            ) {
                var req = new Request<bool>{
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

            public Request<bool> ConfirmTag(
                int tagId , long photoId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
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

            public Request<long> Copy(
                long photoId , int? ownerId = null,  string accessKey = ""
            ) {
                var req = new Request<long>{
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

            public Request<PhotoAlbum> CreateAlbum(
                string title , string description = "", int? groupId = null, PrivacyType? privacy = null,  PrivacyType? commentPrivacy = null
            ) {
                var req = new Request<PhotoAlbum>{
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

            public Request<bool> Delete(
                long photoId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "photos.delete",
                    Parameters = new Dictionary<string, string> {

                        { "photo_id", photoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> DeleteAlbum(
                long albumId ,  int? groupId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "photos.deleteAlbum",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString()},
                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> DeleteComment(
                int commentId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "photos.deleteComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> Edit(
                long photoId , int? ownerId = null,  string caption = ""
            ) {
                var req = new Request<bool>{
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

            public Request<bool> EditAlbum(
                long albumId , int? ownerId = null, string title = "", string description = "", PrivacyType? privacy = null,  PrivacyType? commentPrivacy = null
            ) {
                var req = new Request<bool>{
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

            public Request<EntityList<Photo>> Get(
                long? albumId = null, int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null,  int? feed = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<Photo>>{
                    MethodName = "photos.get",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", MiscTools.NullableString(albumId)},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "photo_ids", (photoIds??new int[]{}).ToNCStringA()},
                        { "rev", (rev?1:0).ToNCString()},
                        { "extended", (extended?1:0).ToNCString()},
                        { "feed_type", feedType?.ToNCString()?.ToSnake()??""},
                        { "feed", MiscTools.NullableString(feed)},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<Photo>> Get(
                SpecialAlbum albumId , int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null,  int? feed = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<Photo>>{
                    MethodName = "photos.get",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString().ToSnake()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "photo_ids", (photoIds??new int[]{}).ToNCStringA()},
                        { "rev", (rev?1:0).ToNCString()},
                        { "extended", (extended?1:0).ToNCString()},
                        { "feed_type", feedType?.ToNCString()?.ToSnake()??""},
                        { "feed", MiscTools.NullableString(feed)},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<PhotoAlbum>> GetAlbums(
                int? ownerId = null, bool needSystem = true, bool needCovers = true, int? offset = null, int? count = 100, params long[] albumIds 
            ) {
                var req = new Request<EntityList<PhotoAlbum>>{
                    MethodName = "photos.getAlbums",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "need_system", (needSystem?1:0).ToNCString()},
                        { "need_covers", (needCovers?1:0).ToNCString()},
                        { "album_ids", (albumIds??new long[]{}).ToNCStringA()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<int> GetAlbumsCount(
                int? userId = null,  int? groupId = null
            ) {
                var req = new Request<int>{
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

            public Request<EntityList<Photo>> GetAll(
                int? ownerId = null, bool extended = false, bool noServiceAlbums = false, bool? needHidden = null,  bool? skipHidden = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<Photo>>{
                    MethodName = "photos.getAll",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "extended", (extended?1:0).ToNCString()},
                        { "no_service_albums", (noServiceAlbums?1:0).ToNCString()},
                        { "need_hidden", (needHidden != null ? ( needHidden.Value ? 1 : 0 ).ToNCString() : "")},
                        { "skip_hidden", (skipHidden != null ? ( skipHidden.Value ? 1 : 0 ).ToNCString() : "")},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<Photo[]> GetById(
                params ContentId[] photos 
            ) {
                var req = new Request<Photo[]>{
                    MethodName = "photos.getById",
                    Parameters = new Dictionary<string, string> {

                        { "photos", (photos??new ContentId[]{}).ToNCStringA()},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<PhotosUploadServer> GetChatUploadServer(
                int chatId , int? cropX = null, int? cropY = null,  int? cropWidth = null
            ) {
                var req = new Request<PhotosUploadServer>{
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

            public Request<string> GetOwnerPhotoUploadServer(
                
            ) {
                var req = new Request<string>{
                    MethodName = "photos.getOwnerPhotoUploadServer",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<PhotoTag[]> GetTags(
                long photoId , int? ownerId = null,  string accessKey = ""
            ) {
                var req = new Request<PhotoTag[]>{
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

            public Request<PhotosUploadServer> GetUploadServer(
                long albumId ,  int? groupId = null
            ) {
                var req = new Request<PhotosUploadServer>{
                    MethodName = "photos.getUploadServer",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString()},
                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> MakeCover(
                long albumId , long photoId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
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

            public Request<bool> Move(
                long targetAlbumId , long photoId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
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

            public Request<bool> RemoveTag(
                int tagId , long photoId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
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

            public Request<bool> ReorderAlbums(
                long albumId , int? ownerId = null, long? before = null,  long? after = null
            ) {
                var req = new Request<bool>{
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

            public Request<bool> ReorderPhotos(
                long photoId , int? ownerId = null, long? before = null,  long? after = null
            ) {
                var req = new Request<bool>{
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

            public Request<bool> Report(
                long photoId , int? ownerId = null,  ReportReason? reason = null
            ) {
                var req = new Request<bool>{
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

            public Request<bool> ReportComment(
                int commentId , int? ownerId = null,  ReportReason? reason = null
            ) {
                var req = new Request<bool>{
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

            public Request<bool> RestoreComment(
                int commentId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "photos.restoreComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> Restore(
                int ownerId ,  long photoId 
            ) {
                var req = new Request<bool>{
                    MethodName = "photos.restore",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", ownerId.ToNCString()},
                        { "photo_id", photoId.ToNCString()},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<Photo[]> Save(
                long albumId , string server , string photosList , string hash , int? groupId = null, double? latitude = null, double? longitude = null, string caption = "",  string description = ""
            ) {
                var req = new Request<Photo[]>{
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

            public Request<bool> AddVote(
                long pollId , int answerId , int? ownerId = null,  bool? isBoard = null
            ) {
                var req = new Request<bool>{
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

            public Request<bool> DeleteVote(
                long pollId , int answerId , int? ownerId = null,  bool? isBoard = null
            ) {
                var req = new Request<bool>{
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

            public Request<bool> TrackVisitor(
                
            ) {
                var req = new Request<bool>{
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

            public Request<Status[]> Get(
                 int? userId = null
            ) {
                var req = new Request<Status[]>{
                    MethodName = "status.get",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<bool> Set(
                 string text 
            ) {
                var req = new Request<bool>{
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

            public Request<StorageEntry[]> Get(
                int? userId = null, bool global = false, params string[] keys 
            ) {
                var req = new Request<StorageEntry[]>{
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

            public Request<string[]> GetKeys(
                int? userId = null,  bool global = false, int? offset = null, int? count = 100
            ) {
                var req = new Request<string[]>{
                    MethodName = "storage.getKeys",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "global", (global?1:0).ToNCString()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<StorageEntry[]> Set(
                string key , string value , int? userId = null,  bool global = false
            ) {
                var req = new Request<StorageEntry[]>{
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

            public Request<User[]> Get(
                UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, params int[] userIds 
            ) {
                var req = new Request<User[]>{
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

            public Request<User[]> Get(
                UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, params string[] userIds 
            ) {
                var req = new Request<User[]>{
                    MethodName = "users.get",
                    Parameters = new Dictionary<string, string> {

                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) )},
                        { "name_case", nameCase.ToNCString().ToSnake()},
                        { "user_ids", String.Join(",",userIds)},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<int>> GetFollowers(
                int? userId = null,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<int>>{
                    MethodName = "users.getFollowers",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "name_case", nameCase.ToNCString().ToSnake()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<User>> GetFollowers(
                int? userId = null, UserFields fields = UserFields.Anything,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<User>>{
                    MethodName = "users.getFollowers",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) )},
                        { "name_case", nameCase.ToNCString().ToSnake()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            public Request<EntityList<User>> GetNearby(
                double latitude , double longitude , int? accuracy = null, int? timeout = null, byte? radius = null, UserFields fields = UserFields.None,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<User>>{
                    MethodName = "users.getNearby",
                    Parameters = new Dictionary<string, string> {

                        { "latitude", latitude.ToNCString()},
                        { "longitude", longitude.ToNCString()},
                        { "accuracy", MiscTools.NullableString(accuracy)},
                        { "timeout", MiscTools.NullableString(timeout)},
                        { "radius", MiscTools.NullableString(radius)},
                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) )},
                        { "name_case", nameCase.ToNCString().ToSnake()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Возвращает список идентификаторов пользователей и сообществ, которые входят в список подписок пользователя
            ///      
            ///</summary>
            ///<param name="userId">идентификатор пользователя</param>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public Request<UserSubscriptions> GetSubscriptions(
                 int? userId = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<UserSubscriptions>{
                    MethodName = "users.getSubscriptions",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Возвращает информацию о том, установил ли пользователь приложение
            ///      
            ///</summary>
            ///<param name="userId">идентификатор пользователя</param>
            public Request<bool> IsAppUser(
                 int? userId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "users.isAppUser",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", MiscTools.NullableString(userId)},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Позволяет пожаловаться на пользователя
            ///      
            ///</summary>
            ///<param name="userId">идентификатор пользователя, на которого нужно подать жалобу</param>
            ///<param name="type">тип жалобы</param>
            ///<param name="comment">комментарий к жалобе на пользователя</param>
            public Request<bool> Report(
                int userId , ComplaintType type ,  string comment 
            ) {
                var req = new Request<bool>{
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

            ///<summary>
            ///        Возвращает список пользователей в соответствии с заданным критерием поиска
            ///      
            ///</summary>
            ///<param name="q">строка поискового запроса</param>
            ///<param name="sort">порядок сортировки</param>
            ///<param name="fields">список дополнительных полей профилей, которые необходимо вернуть</param>
            ///<param name="city">идентификатор города</param>
            ///<param name="country">идентификатор страны</param>
            ///<param name="hometown">название города строкой</param>
            ///<param name="universityCountry">идентификатор страны, в которой пользователи закончили ВУЗ</param>
            ///<param name="university">идентификатор ВУЗа</param>
            ///<param name="universityYear">год окончания ВУЗа</param>
            ///<param name="universityFaculty">идентификатор факультета</param>
            ///<param name="universityChair">идентификатор кафедры</param>
            ///<param name="sex">пол</param>
            ///<param name="status">семейное положение</param>
            ///<param name="ageFrom">начиная с какого возраста</param>
            ///<param name="ageTo">до какого возраста</param>
            ///<param name="birthDay">день рождения</param>
            ///<param name="birthMonth">месяц рождения</param>
            ///<param name="birthYear">год рождения</param>
            ///<param name="online">только в сети</param>
            ///<param name="hasPhoto">только с фотографией</param>
            ///<param name="schoolCountry">идентификатор страны, в которой пользователи закончили школу</param>
            ///<param name="schoolCity">идентификатор города, в котором пользователи закончили школу</param>
            ///<param name="schoolClass"></param>
            ///<param name="school">идентификатор школы, которую закончили пользователи</param>
            ///<param name="schoolYear">год окончания школы</param>
            ///<param name="religion">религиозные взгляды</param>
            ///<param name="interests">интересы</param>
            ///<param name="company">название компании, в которой работают пользователи</param>
            ///<param name="position">название должности</param>
            ///<param name="groupId">идентификатор группы, среди пользователей которой необходимо проводить поиск</param>
            ///<param name="fromList">Разделы среди которых нужно осуществить поиск</param>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public Request<EntityList<User>> Search(
                string q = "", SearchSortOrder sort = SearchSortOrder.ByRating, UserFields fields = UserFields.None, int? city = null, int? country = null, string hometown = "", int? universityCountry = null, int? university = null, int? universityYear = null, int? universityFaculty = null, int? universityChair = null, Sex? sex = null, Relation? status = null, byte? ageFrom = null, byte? ageTo = null, byte? birthDay = null, byte? birthMonth = null, ushort? birthYear = null, bool? online = null, bool? hasPhoto = null, int? schoolCountry = null, int? schoolCity = null, int? schoolClass = null, int? school = null, int? schoolYear = null, string religion = "", string interests = "", string company = "", string position = "", int? groupId = null,  FriendshipType? fromList = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<User>>{
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
                        { "university_faculty", MiscTools.NullableString(universityFaculty)},
                        { "university_chair", MiscTools.NullableString(universityChair)},
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
                        { "from_list", fromList?.ToNCString()?.ToSnake()??""},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

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

            ///<summary>
            ///        Возвращает информацию о том, является ли внешняя ссылка заблокированной на сайте ВКонтакте
            ///      
            ///</summary>
            public Request<LinkCheckResult> CheckLink(
                 string url 
            ) {
                var req = new Request<LinkCheckResult>{
                    MethodName = "utils.checkLink",
                    Parameters = new Dictionary<string, string> {

                        { "url", url},

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Возвращает текущее время на сервере ВКонтакте
            ///      
            ///</summary>
            public Request<DateTimeOffset> GetServerTime(
                
            ) {
                var req = new Request<DateTimeOffset>{
                    MethodName = "utils.getServerTime",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Возвращает текущее время на сервере ВКонтакте в unixtime
            ///      
            ///</summary>
            public Request<int> GetServerTimeRaw(
                
            ) {
                var req = new Request<int>{
                    MethodName = "utils.getServerTime",
                    Parameters = new Dictionary<string, string> {


                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Определяет тип объекта (пользователь, сообщество, приложение) и его идентификатор по короткому имени screen_name
            ///      
            ///</summary>
            public Request<ResolveResult> ResolveScreenName(
                 string screenName 
            ) {
                var req = new Request<ResolveResult>{
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

            ///<summary>
            ///        Добавляет видеозапись в список пользователя
            ///      
            ///</summary>
            ///<param name="videoId">идентификатор видеозаписи</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи, по умолчанию идентификатор текущего пользователя</param>
            ///<param name="targetId">идентификатор пользователя или сообщества, в которое нужно добавить видео</param>
            public Request<bool> Add(
                long videoId , int? ownerId = null,  int? targetId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "video.add",
                    Parameters = new Dictionary<string, string> {

                        { "video_id", videoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "target_id", MiscTools.NullableString(targetId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///          Удаляет видеозапись
            ///      
            ///</summary>
            ///<param name="videoId">идентификатор видеозаписи</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи, по умолчанию идентификатор текущего пользователя</param>
            ///<param name="targetId">идентификатор пользователя или сообщества, для которого нужно удалить видеозапись</param>
            public Request<bool> Delete(
                long videoId , int? ownerId = null,  int? targetId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "video.delete",
                    Parameters = new Dictionary<string, string> {

                        { "video_id", videoId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "target_id", MiscTools.NullableString(targetId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///          Удаляет альбом видеозаписей
            ///      
            ///</summary>
            ///<param name="albumId">идентификатор альбома</param>
            ///<param name="groupId">идентификатор сообщества (если альбом, который необходимо удалить, принадлежит сообществу)</param>
            public Request<bool> DeleteAlbum(
                long albumId ,  int? groupId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "video.deleteAlbum",
                    Parameters = new Dictionary<string, string> {

                        { "album_id", albumId.ToNCString()},
                        { "group_id", MiscTools.NullableString(groupId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///          Удаляет комментарий к видеозаписи
            ///      
            ///</summary>
            ///<param name="commentId">идентификатор комментария</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи, по умолчанию идентификатор текущего пользователя</param>
            public Request<bool> DeleteComment(
                int commentId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "video.deleteComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///          Изменяет текст комментария к видеозаписи
            ///      
            ///</summary>
            ///<param name="message">новый текст комментария (является обязательным, если не задан параметр attachments)</param>
            ///<param name="commentId">идентификатор комментария</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи, по умолчанию идентификатор текущего пользователя</param>
            public Request<bool> EditComment(
                string message , int commentId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
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

            ///<summary>
            ///          Возвращает информацию о видеозаписях
            ///      
            ///</summary>
            ///<param name="ownerId">идентификатор пользователя или сообщества, которому принадлежат видеозаписи</param>
            ///<param name="albumId">идентификатор альбома, видеозаписи из которого нужно вернуть</param>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public Request<EntityList<Video>> Get(
                int ownerId , long? albumId = null,  bool extended = true, int? offset = null, int? count = 200
            ) {
                var req = new Request<EntityList<Video>>{
                    MethodName = "video.get",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", ownerId.ToNCString()},
                        { "album_id", MiscTools.NullableString(albumId)},
                        { "extended", (extended?1:0).ToNCString()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///          Возвращает информацию о видеозаписях
            ///      
            ///</summary>
            ///<param name="videos">идентификатор видеозаписей</param>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public Request<EntityList<Video>> Get(
                bool extended = true, int? offset = null, int? count = 200, params ContentId[] videos 
            ) {
                var req = new Request<EntityList<Video>>{
                    MethodName = "video.get",
                    Parameters = new Dictionary<string, string> {

                        { "extended", (extended?1:0).ToNCString()},
                        { "videos", (videos??new ContentId[]{}).ToNCStringA()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///          Возвращает список видеозаписей, на которых есть непросмотренные отметки
            ///      
            ///</summary>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public Request<EntityList<TaggedVideo>> GetNewTags(
                int? offset = null, int? count = 20
            ) {
                var req = new Request<EntityList<TaggedVideo>>{
                    MethodName = "video.getNewTags",
                    Parameters = new Dictionary<string, string> {

                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///          Добавляет отметку на видеозапись
            ///      
            ///</summary>
            ///<param name="videoId">идентификатор видеозаписи</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи, по умолчанию идентификатор текущего пользователя</param>
            public Request<Tag[]> GetTags(
                long videoId ,  int? ownerId = null
            ) {
                var req = new Request<Tag[]>{
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

            ///<summary>
            ///          Добавляет отметку на видеозапись
            ///      
            ///</summary>
            ///<param name="userId">идентификатор пользователя, которого нужно отметить</param>
            ///<param name="videoId">идентификатор видеозаписи</param>
            ///<param name="taggedName">текст отметки</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи, по умолчанию идентификатор текущего пользователя</param>
            public Request<bool> PutTag(
                int userId , long videoId , string taggedName ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "video.putTag",
                    Parameters = new Dictionary<string, string> {

                        { "user_id", userId.ToNCString()},
                        { "video_id", videoId.ToNCString()},
                        { "tagged_name", taggedName},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///          Удаляет отметку с видеозаписи
            ///      
            ///</summary>
            ///<param name="videoId">идентификатор видеозаписи</param>
            ///<param name="tagId">идентификатор отметки</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи (пользователь или сообщество), по умолчанию идентификатор текущего пользователя</param>
            public Request<bool> RemoveTag(
                long videoId , int tagId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
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

            ///<summary>
            ///          Позволяет пожаловаться на видеозапись
            ///      
            ///</summary>
            ///<param name="videoId">идентификатор видеозаписи</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, которому принадлежит видеозапись</param>
            ///<param name="reason">тип жалобы</param>
            ///<param name="comment">комментарий для жалобы</param>
            ///<param name="searchQuery">поисковой запрос, если видеозапись была найдена через поиск</param>
            public Request<bool> Report(
                long videoId , int? ownerId = null, ReportReason? reason = null, string comment = "",  string searchQuery = ""
            ) {
                var req = new Request<bool>{
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

            ///<summary>
            ///          Позволяет пожаловаться на комментарий к видеозаписи
            ///      
            ///</summary>
            ///<param name="commentId">идентификатор комментария</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи, к которой оставлен комментарий</param>
            ///<param name="reason">тип жалобы</param>
            public Request<bool> ReportComment(
                int commentId , int? ownerId = null,  ReportReason? reason = null
            ) {
                var req = new Request<bool>{
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

            public Request<bool> RestoreComment(
                int commentId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "video.restoreComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///          Восстанавливает удаленную видеозапись
            ///      
            ///</summary>
            ///<param name="videoId">идентификатор видеозаписи</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи, по умолчанию идентификатор текущего пользователя</param>
            public Request<bool> Restore(
                long videoId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
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

            ///<summary>
            ///          Удаляет запись со стены
            ///      
            ///</summary>
            ///<param name="postId">идентификатор записи на стене</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находится запись, по умолчанию идентификатор текущего пользователя</param>
            public Request<bool> Delete(
                int postId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "wall.delete",
                    Parameters = new Dictionary<string, string> {

                        { "post_id", postId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///          Удаляет комментарий текущего пользователя к записи на своей или чужой стене
            ///      
            ///</summary>
            ///<param name="commentId">идентификатор комментария</param>
            ///<param name="ownerId">идентификатор пользователя, на чьей стене находится комментарий к записи, по умолчанию идентификатор текущего пользователя</param>
            public Request<bool> DeleteComment(
                int commentId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "wall.deleteComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///          Возвращает список записей со стен пользователей или сообществ по их идентификаторам
            ///      
            ///</summary>
            ///<param name="ownerId">идентификатор пользователя или сообщества</param>
            ///<param name="filter">определяет, какие типы записей на стене необходимо получить</param>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public Request<EntityList<Post>> Get(
                int ownerId ,  WallPostFilter filter = WallPostFilter.All, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<Post>>{
                    MethodName = "wall.get",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", ownerId.ToNCString()},
                        { "filter", filter.ToNCString().ToSnake()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///          Возвращает список записей со стен пользователей или сообществ по их идентификаторам
            ///      
            ///</summary>
            ///<param name="domain">короткий адрес пользователя или сообщества</param>
            ///<param name="filter">определяет, какие типы записей на стене необходимо получить</param>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public Request<EntityList<Post>> Get(
                string domain ,  WallPostFilter filter = WallPostFilter.All, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<Post>>{
                    MethodName = "wall.get",
                    Parameters = new Dictionary<string, string> {

                        { "domain", domain},
                        { "filter", filter.ToNCString().ToSnake()},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Возвращает список записей со стен пользователей или сообществ по их идентификаторам
            ///      
            ///</summary>
            ///<param name="copyHistoryDepth">идентификаторы постов</param>
            ///<param name="posts">глубина показа репостов</param>
            public Request<Post[]> GetById(
                int copyHistoryDepth = 2, params ContentId[] posts 
            ) {
                var req = new Request<Post[]>{
                    MethodName = "wall.getById",
                    Parameters = new Dictionary<string, string> {

                        { "copy_history_depth", copyHistoryDepth.ToNCString()},
                        { "posts",  String.Join(",",posts.Select(a=>a.ToIdString()).ToArray()) },

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Возвращает список комментариев к записи на стене
            ///      
            ///</summary>
            ///<param name="postId">идентификатор записи на стене</param>
            ///<param name="sort">порядок сортировки комментариев</param>
            ///<param name="previewLength">количество символов, по которому нужно обрезать текст комментария, 0 - не обрезать</param>
            ///<param name="ownerId">идентификатор владельца страницы</param>
            ///<param name="needLikes">возвращать информацию о лайках</param>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public Request<EntityList<Comment>> GetComments(
                int postId , string sort , int previewLength = 0, int? ownerId = null,  bool needLikes = false, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<Comment>>{
                    MethodName = "wall.getComments",
                    Parameters = new Dictionary<string, string> {

                        { "post_id", postId.ToNCString()},
                        { "sort", sort},
                        { "preview_length", previewLength.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "need_likes", (needLikes?1:0).ToNCString()},
                        {"extended","0"},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Возвращает список комментариев к записи на стене
            ///      
            ///</summary>
            ///<param name="postId">идентификатор записи на стене</param>
            ///<param name="sort">порядок сортировки комментариев</param>
            ///<param name="previewLength">количество символов, по которому нужно обрезать текст комментария, 0 - не обрезать</param>
            ///<param name="ownerId">идентификатор владельца страницы</param>
            ///<param name="needLikes">возвращать информацию о лайках</param>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public Request<EntityListExtended<Comment>> GetCommentsExtended(
                int postId , string sort , int previewLength = 0, int? ownerId = null,  bool needLikes = false, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityListExtended<Comment>>{
                    MethodName = "wall.getComments",
                    Parameters = new Dictionary<string, string> {

                        { "post_id", postId.ToNCString()},
                        { "sort", sort},
                        { "preview_length", previewLength.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "need_likes", (needLikes?1:0).ToNCString()},
                        {"extended","1"},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Позволяет получать список репостов заданной записи
            ///      
            ///</summary>
            ///<param name="postId">идентификатор записи на стене</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находится запись, по умолчанию идентификатор текущего пользователя</param>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public Request<EntityListExtended<Post>> GetReposts(
                int postId ,  int? ownerId = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityListExtended<Post>>{
                    MethodName = "wall.getReposts",
                    Parameters = new Dictionary<string, string> {

                        { "post_id", postId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Закрепляет запись на стене
            ///      
            ///</summary>
            ///<param name="postId">идентификатор записи на стене</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находится запись, по умолчанию идентификатор текущего пользователя</param>
            public Request<bool> Pin(
                int postId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "wall.pin",
                    Parameters = new Dictionary<string, string> {

                        { "post_id", postId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Публикует запись на своей или чужой стене
            ///      
            ///</summary>
            ///<returns>
            ///        После успешного выполнения возвращает идентификатор созданной записи
            ///      
            ///</returns>
            ///<param name="message">текст сообщения (является обязательным, если не задан параметр attachments)</param>
            ///<param name="attachments">список объектов, приложенных к записи</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого должна быть опубликована запись</param>
            ///<param name="fromGroup">Опубликовать от имени группы</param>
            ///<param name="signed">у записи, размещенной от имени сообщества, будет добавлена подпись</param>
            ///<param name="friendsOnly">запись будет доступна только друзьям</param>
            ///<param name="services">список сервисов или сайтов, на которые необходимо экспортировать запись, в случае если пользователь настроил соответствующую опцию</param>
            ///<param name="publishDate">дата публикации записи в формате unixtime. Если параметр указан, публикация записи будет отложена до указанного времени.</param>
            ///<param name="lat">географическая широта отметки, заданная в градусах (от -90 до 90)</param>
            ///<param name="@long">географическая долгота отметки, заданная в градусах (от -180 до 180)</param>
            ///<param name="placeId">идентификатор места, в котором отмечен пользователь</param>
            public Request<WallPost> Post(
                string message = "", ContentId[] attachments = null, int? ownerId = null, bool fromGroup = false, bool signed = false, bool? friendsOnly = false, string services = "", DateTimeOffset? publishDate = null, double? lat = null, double? @long = null,  int? placeId = null
            ) {
                var req = new Request<WallPost>{
                    MethodName = "wall.post",
                    Parameters = new Dictionary<string, string> {

                        { "message", message},
                        { "attachments", (attachments??new ContentId[]{}).ToNCStringA()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "from_group", (fromGroup?1:0).ToNCString()},
                        { "signed", (signed?1:0).ToNCString()},
                        { "friends_only", (friendsOnly != null ? ( friendsOnly.Value ? 1 : 0 ).ToNCString() : "")},
                        { "services", services},
                        { "publish_date", MiscTools.NullableString(publishDate?.ToUnixTimeSeconds())},
                        { "lat", MiscTools.NullableString(lat)},
                        { "long", MiscTools.NullableString(@long)},
                        { "place_id", MiscTools.NullableString(placeId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Публикует комментарий на своей или чужой стене
            ///      
            ///</summary>
            ///<returns>
            ///</returns>
            public Request<CommentPost> AddComment(
                int ownerId , int postId , string text , bool fromGroup = false, long? replyToComment = null, ContentId[] attachments = null, long? stickerId = null, string @ref = "",  string guid = ""
            ) {
                var req = new Request<CommentPost>{
                    MethodName = "wall.addComment",
                    Parameters = new Dictionary<string, string> {

                        { "owner_id", ownerId.ToNCString()},
                        { "post_id", postId.ToNCString()},
                        { "text", text},
                        { "from_group", (fromGroup?1:0).ToNCString()},
                        { "reply_to_comment", MiscTools.NullableString(replyToComment)},
                        { "attachments", (attachments??new ContentId[]{}).ToNCStringA()},
                        { "sticker_id", MiscTools.NullableString(stickerId)},
                        { "ref", @ref},
                        { "guid", guid},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Публикует отложенную запись на своей или чужой стене
            ///      
            ///</summary>
            ///<returns>
            ///        После успешного выполнения возвращает идентификатор созданной записи
            ///      
            ///</returns>
            ///<param name="postId">идентификатор записи, которую необходимо опубликовать</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого должна быть опубликована запись</param>
            public Request<WallPost> Post(
                int postId ,  int? ownerId = null
            ) {
                var req = new Request<WallPost>{
                    MethodName = "wall.post",
                    Parameters = new Dictionary<string, string> {

                        { "post_id", postId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Позволяет пожаловаться на комментарий к записи
            ///      
            ///</summary>
            ///<param name="commentId">идентификатор комментария</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, которому принадлежит комментарий</param>
            ///<param name="reason">причина жалобы</param>
            public Request<bool> ReportComment(
                int commentId , int? ownerId = null,  ReportReason? reason = null
            ) {
                var req = new Request<bool>{
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

            ///<summary>
            ///        Позволяет пожаловаться на запись.
            ///      
            ///</summary>
            ///<param name="postId">идентификатор пользователя или сообщества, которому принадлежит запись</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, которому принадлежит запись</param>
            ///<param name="reason">причина жалобы</param>
            public Request<bool> ReportPost(
                int postId , int? ownerId = null,  ReportReason? reason = null
            ) {
                var req = new Request<bool>{
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

            ///<summary>
            ///        Копирует объект на стену пользователя или сообщества
            ///      
            ///</summary>
            ///<param name="@object">идентификатор объекта, который необходимо разместить на стене</param>
            ///<param name="message">сопроводительный текст, который будет добавлен к записи с объектом</param>
            ///<param name="groupId">идентификатор сообщества, на стене которого будет размещена запись с объектом. Если не указан, запись будет размещена на стене текущего пользователя</param>
            public Request<RepostInfo> Repost(
                string @object , string message = "", int? groupId = null,  string @ref = ""
            ) {
                var req = new Request<RepostInfo>{
                    MethodName = "wall.repost",
                    Parameters = new Dictionary<string, string> {

                        { "object", @object},
                        { "message", message},
                        { "group_id", MiscTools.NullableString(groupId)},
                        { "ref", @ref},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Восстанавливает удаленную запись на стене пользователя или сообщества
            ///      
            ///</summary>
            ///<param name="postId">идентификатор записи на стене</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находилась удаленная запись, по умолчанию идентификатор текущего пользователя</param>
            public Request<bool> Restore(
                int postId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "wall.restore",
                    Parameters = new Dictionary<string, string> {

                        { "post_id", postId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Восстанавливает комментарий текущего пользователя к записи на своей или чужой стене
            ///      
            ///</summary>
            ///<param name="commentId">идентификатор комментария на стене</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находится комментарий к записи, по умолчанию идентификатор текущего пользователя</param>
            public Request<bool> RestoreComment(
                int commentId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
                    MethodName = "wall.restoreComment",
                    Parameters = new Dictionary<string, string> {

                        { "comment_id", commentId.ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},

                    }
                };
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Отменяет закрепление записи на стене
            ///      
            ///</summary>
            ///<param name="postId">идентификатор записи на стене</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находится запись, по умолчанию идентификатор текущего пользователя</param>
            public Request<bool> Unpin(
                int postId ,  int? ownerId = null
            ) {
                var req = new Request<bool>{
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

            ///<summary>
            ///        Получает список идентификаторов пользователей, которые добавили заданный объект в свой список "Мне нравится"
            ///      
            ///</summary>
            ///<param name="type">тип объекта</param>
            ///<param name="filter">указывает, следует ли вернуть всех пользователей, добавивших объект в список "Мне нравится" или только тех, которые рассказали о нем друзьям</param>
            ///<param name="friendsOnly">указывает, необходимо ли возвращать только пользователей, которые являются друзьями текущего пользователя</param>
            ///<param name="skipOwn">не возвращать самого пользователя</param>
            ///<param name="ownerId">идентификатор владельца Like-объекта</param>
            ///<param name="itemId">идентификатор Like-объекта. Если type равен sitepage, то параметр item_id может содержать значение параметра page_id, используемый при инициализации виджета «Мне нравится»</param>
            ///<param name="pageUrl">url страницы, на которой установлен виджет «Мне нравится». Используется вместо параметра item_id, если при размещении виджета не был указан page_id.</param>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public Request<EntityList<int>> GetList(
                string type , string filter , bool friendsOnly , bool skipOwn , int? ownerId = null, int? itemId = null,  string pageUrl = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<int>>{
                    MethodName = "likes.getList",
                    Parameters = new Dictionary<string, string> {

                        { "type", type},
                        { "filter", filter},
                        { "friends_only", (friendsOnly?1:0).ToNCString()},
                        { "skip_own", (skipOwn?1:0).ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "item_id", MiscTools.NullableString(itemId)},
                        { "page_url", pageUrl},
                        {"extended","false"},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }

            ///<summary>
            ///        Получает список идентификаторов пользователей, которые добавили заданный объект в свой список "Мне нравится"
            ///      
            ///</summary>
            ///<param name="type">тип объекта</param>
            ///<param name="filter">указывает, следует ли вернуть всех пользователей, добавивших объект в список "Мне нравится" или только тех, которые рассказали о нем друзьям</param>
            ///<param name="friendsOnly">указывает, необходимо ли возвращать только пользователей, которые являются друзьями текущего пользователя</param>
            ///<param name="skipOwn">не возвращать самого пользователя</param>
            ///<param name="ownerId">идентификатор владельца Like-объекта</param>
            ///<param name="itemId">идентификатор Like-объекта. Если type равен sitepage, то параметр item_id может содержать значение параметра page_id, используемый при инициализации виджета «Мне нравится»</param>
            ///<param name="pageUrl">url страницы, на которой установлен виджет «Мне нравится». Используется вместо параметра item_id, если при размещении виджета не был указан page_id.</param>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public Request<EntityList<User>> GetListExtended(
                string type , string filter , bool friendsOnly , bool skipOwn , int? ownerId = null, int? itemId = null,  string pageUrl = null, int? offset = null, int? count = 100
            ) {
                var req = new Request<EntityList<User>>{
                    MethodName = "likes.getList",
                    Parameters = new Dictionary<string, string> {

                        { "type", type},
                        { "filter", filter},
                        { "friends_only", (friendsOnly?1:0).ToNCString()},
                        { "skip_own", (skipOwn?1:0).ToNCString()},
                        { "owner_id", MiscTools.NullableString(ownerId)},
                        { "item_id", MiscTools.NullableString(itemId)},
                        { "page_url", pageUrl},
                        {"extended","true"},
                        { "offset", offset.NullableString() },
                        { "count", count.NullableString() },

                    }
                };
                if (_parent.IsLogged)
                    req.Token = _parent.CurrentToken;
                return req;
            }
        }
    }
}