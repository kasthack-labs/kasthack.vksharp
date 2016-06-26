
using System;
using System.Linq;
using System.Threading.Tasks;
using kasthack.vksharp.DataTypes;
using kasthack.vksharp.DataTypes.Entities;
using kasthack.vksharp.DataTypes.Enums;
using kasthack.vksharp.DataTypes.EntityFragments;
using kasthack.vksharp.DataTypes.Interfaces;

// ReSharper disable UnusedMember.Global
namespace kasthack.vksharp {
    public partial class RawApi {
        private void InitializeMethodGroups(){
            Account = new MethodGroup_Account(this);
            Apps = new MethodGroup_Apps(this);
            Audio = new MethodGroup_Audio(this);
            Auth = new MethodGroup_Auth(this);
            Board = new MethodGroup_Board(this);
            Database = new MethodGroup_Database(this);
            Docs = new MethodGroup_Docs(this);
            Fave = new MethodGroup_Fave(this);
            Friends = new MethodGroup_Friends(this);
            Groups = new MethodGroup_Groups(this);
            Messages = new MethodGroup_Messages(this);
            Newsfeed = new MethodGroup_Newsfeed(this);
            Notes = new MethodGroup_Notes(this);
            Notifications = new MethodGroup_Notifications(this);
            Pages = new MethodGroup_Pages(this);
            Photos = new MethodGroup_Photos(this);
            Polls = new MethodGroup_Polls(this);
            Stats = new MethodGroup_Stats(this);
            Status = new MethodGroup_Status(this);
            Storage = new MethodGroup_Storage(this);
            Users = new MethodGroup_Users(this);
            Utils = new MethodGroup_Utils(this);
            Video = new MethodGroup_Video(this);
            Wall = new MethodGroup_Wall(this);
            Likes = new MethodGroup_Likes(this);
        }

        public MethodGroup_Account Account {get; private set;}
        public partial class MethodGroup_Account {
            private readonly RawApi _parent;
            internal MethodGroup_Account(RawApi parent){_parent=parent;}

            ///<summary>
            ///Добавляет пользователя в черный список.Если указанный пользователь является другом текущего пользователя или имеет от него входящую или исходящую заявку в друзья, то для добавления пользователя в черный список Ваше приложение должно иметь права: friends.
            ///</summary>
            ///<param name="userId">Идентификатор пользователя, которого нужно добавить в черный список</param>
            public async Task<string> BanUser(
                 int userId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Account.BanUser(
                           userId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Позволяет сменить пароль пользователя после успешного восстановления доступа к аккаунту через СМС, используя метод auth.restore
            ///      
            ///</summary>
            ///<param name="restoreSid">Идентификатор сессии, полученный при восстановлении доступа используя метод auth.restore. (В случае если пароль меняется сразу после восстановления доступа)</param>
            ///<param name="changePasswordHash">Хэш, полученный при успешной OAuth авторизации по коду полученному по СМС (В случае если пароль меняется сразу после восстановления доступа)</param>
            ///<param name="oldPassword">Текущий пароль пользователя</param>
            ///<param name="newPassword">Новый пароль, который будет установлен в качестве текущего</param>
            public async Task<string> ChangePassword(
                string restoreSid , string changePasswordHash , string oldPassword ,  string newPassword 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Account.ChangePassword(
                           restoreSid,changePasswordHash,oldPassword,newPassword
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Возвращает список активных рекламных предложений (офферов), выполнив которые пользователь сможет получить соответствующее количество голосов на свой счёт внутри приложения
            ///      
            ///</summary>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public async Task<string> GetActiveOffers(
                int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Account.GetActiveOffers(
                           offset, count
                    )
                ).ConfigureAwait(false);
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
            public async Task<string> GetAppPermissions(
                 int? userId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Account.GetAppPermissions(
                           userId
                    )
                ).ConfigureAwait(false);
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
            public async Task<string> GetBanned(
                int? offset = null, int? count = 20
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Account.GetBanned(
                           offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Возвращает информацию о текущем аккаунте
            ///      
            ///</summary>
            ///<returns>
            ///        Возвращает объект AccountInfo
            ///      
            ///</returns>
            public async Task<string> GetInfo(
                
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Account.GetInfo(
                           
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Отменяет редактирование профиля
            ///      
            ///</summary>
            ///<param name="cancelRequestId">идентификатор заявки на смену имени, которую необходимо отменить</param>
            public async Task<string> SaveProfileInfo(
                 int cancelRequestId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Account.SaveProfileInfo(
                           cancelRequestId
                    )
                ).ConfigureAwait(false);
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
            public async Task<string> SaveProfileInfo(
                string firstName = "", string lastName = "", string maidenName = "", string screenName = "", Sex? sex = null, Relation? relation = null, int? relationPartnerId = null, Date? bdate = null, string homeTown = "", int? countryId = null, int? cityId = null,  string status = ""
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Account.SaveProfileInfo(
                           firstName,lastName,maidenName,screenName,sex,relation,relationPartnerId,bdate,homeTown,countryId,cityId,status
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Возвращает информацию о текущем профиле
            ///      
            ///</summary>
            public async Task<string> GetProfileInfo(
                
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Account.GetProfileInfo(
                           
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Позволяет редактировать информацию о текущем аккаунте.
            ///      
            ///</summary>
            ///<param name="intro">битовая маска, отвечающая за прохождение обучения в мобильных клиентах</param>
            ///<param name="ownPostsDefault">Отображать по дефолту только записи пользователя</param>
            ///<param name="noWallReplies">отключить комментирование записей на стене</param>
            public async Task<string> SetInfo(
                int? intro = null, bool? ownPostsDefault = null,  bool? noWallReplies = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Account.SetInfo(
                           intro,ownPostsDefault,noWallReplies
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Устанавливает короткое название приложения (до 17 символов), которое выводится пользователю в левом меню
            ///      
            ///</summary>
            ///<param name="name">короткое название приложения</param>
            ///<param name="userId">идентификатор пользователя</param>
            public async Task<string> SetNameInMenu(
                string name ,  string userId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Account.SetNameInMenu(
                           name,userId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Помечает текущего пользователя как offline
            ///      
            ///</summary>
            public async Task<string> SetOffline(
                
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Account.SetOffline(
                           
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Помечает текущего пользователя как online на 15 минут
            ///      
            ///</summary>
            ///<param name="voip">возможны ли видеозвонки для данного устройства</param>
            public async Task<string> SetOnline(
                 bool voip = true
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Account.SetOnline(
                           voip
                    )
                ).ConfigureAwait(false);
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
            public async Task<string> SetSilenceMode(
                string deviceId , int time , int? chatId = null, int? userId = null,  int sound = 0
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Account.SetSilenceMode(
                           deviceId,time,chatId,userId,sound
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Убирает пользователя из черного списка
            ///      
            ///</summary>
            ///<param name="userId">идентификатор пользователя, которого нужно убрать из черного списка</param>
            public async Task<string> UnbanUser(
                 int userId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Account.UnbanUser(
                           userId
                    )
                ).ConfigureAwait(false);
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
            public async Task<string> RegisterDevice(
                string token , string deviceId , string settings , int? deviceYear = null, string deviceModel = "", string systemVersion = "",  bool? sandbox = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Account.RegisterDevice(
                           token,deviceId,settings,deviceYear,deviceModel,systemVersion,sandbox
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Отписывает устройство от Push уведомлений
            ///      
            ///</summary>
            ///<param name="deviceId">уникальный идентификатор устройства</param>
            ///<param name="sandbox">отписать устройство, использующее sandbox сервер для отправки push-уведомлений</param>
            public async Task<string> UnregisterDevice(
                string deviceId ,  bool? sandbox = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Account.UnregisterDevice(
                           deviceId,sandbox
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Apps Apps {get; private set;}
        public partial class MethodGroup_Apps {
            private readonly RawApi _parent;
            internal MethodGroup_Apps(RawApi parent){_parent=parent;}

            ///<summary>
            ///        Удаляет все уведомления о запросах, отправленных из текущего приложения
            ///      
            ///</summary>
            public async Task<string> DeleteAppRequests(
                
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Apps.DeleteAppRequests(
                           
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Метод возвращает количество очков пользователя в этой игре
            ///      
            ///</summary>
            public async Task<string> GetScore(
                
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Apps.GetScore(
                           
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Возвращает рейтинг пользователей в игре
            ///      
            ///</summary>
            ///<param name="type">Тип рейтинга</param>
            ///<param name="global">Глобальный/только друзья</param>
            public async Task<string> GetLeaderboardExtended(
                LeaderBoardType type ,  bool global = true
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Apps.GetLeaderboardExtended(
                           type,global
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Возвращает рейтинг пользователей в игре
            ///      
            ///</summary>
            ///<param name="type">Тип рейтинга</param>
            ///<param name="global">Глобальный/только друзья</param>
            public async Task<string> GetLeaderboard(
                LeaderBoardType type ,  bool global = true
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Apps.GetLeaderboard(
                           type,global
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Audio Audio {get; private set;}
        public partial class MethodGroup_Audio {
            private readonly RawApi _parent;
            internal MethodGroup_Audio(RawApi parent){_parent=parent;}

            ///<summary>
            ///        Копирует аудиозапись на страницу пользователя или группы
            ///      
            ///</summary>
            ///<param name="ownerId">идентификатор владельца аудиозаписи (пользователь или сообщество)</param>
            ///<param name="audioId">Идентификатор аудиозаписи</param>
            ///<param name="groupId">идентификатор сообщества (если аудиозапись необходимо скопировать в список сообщества)</param>
            ///<param name="albumId">идентификатор альбома, в который нужно переместить аудиозапись</param>
            public async Task<string> Add(
                int ownerId , long audioId , int? groupId = null,  long? albumId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.Add(
                           ownerId,audioId,groupId,albumId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Создает пустой альбом аудиозаписей
            ///      
            ///</summary>
            ///<param name="title">название альбома</param>
            ///<param name="groupId">идентификатор сообщества (если альбом нужно создать в сообществе)</param>
            public async Task<string> AddAlbum(
                string title ,  int? groupId = 0
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.AddAlbum(
                           title,groupId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Удаляет аудиозапись со страницы пользователя или сообщества
            ///      
            ///</summary>
            ///<param name="audioId">идентификатор аудиозаписи</param>
            ///<param name="ownerId">идентификатор владельца аудиозаписи (пользователь или сообщество)</param>
            public async Task<string> Delete(
                long audioId ,  int ownerId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.Delete(
                           audioId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Удаляет альбом аудиозаписей
            ///      
            ///</summary>
            ///<param name="albumId">идентификатор альбома</param>
            ///<param name="groupId">идентификатор сообщества, которому принадлежит альбом</param>
            public async Task<string> DeleteAlbum(
                long albumId ,  int? groupId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.DeleteAlbum(
                           albumId,groupId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Edit(
                int ownerId , long audioId , string artist = "", string title = "", string text = "", AudioGenre? genreId = null,  bool? noSearch = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.Edit(
                           ownerId,audioId,artist,title,text,genreId,noSearch
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> EditAlbum(
                long albumId , string title ,  int? groupId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.EditAlbum(
                           albumId,title,groupId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> MoveToAlbum(
                long albumId , int? groupId = null, params long[] audioIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.MoveToAlbum(
                           albumId,groupId,audioIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Get(
                int? ownerId = null, long? albumId = null, int? offset = null, int? count = 100, params long[] audioIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.Get(
                           ownerId,albumId,offset, count,audioIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetBroadcastListGroups(
                 bool active = true, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.GetBroadcastListGroups(
                           active,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetBroadcastListUsers(
                 bool active = true, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.GetBroadcastListUsers(
                           active,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetPopular(
                AudioGenre? genreId = null,  bool? onlyEng = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.GetPopular(
                           genreId,onlyEng,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetRecommendations(
                AudioGenre? genreId = null,  bool? onlyEng = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.GetRecommendations(
                           genreId,onlyEng,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetAlbums(
                 int? ownerId = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.GetAlbums(
                           ownerId,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetById(
                bool itunes = false, params ContentId[] audios 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.GetById(
                           itunes,audios
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetCount(
                 int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.GetCount(
                           ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetLyrics(
                 long lyricsId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.GetLyrics(
                           lyricsId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetUploadServer(
                long albumId ,  int? groupId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.GetUploadServer(
                           albumId,groupId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Reorder(
                long audioId , int? ownerId = null, long? before = null,  long? after = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.Reorder(
                           audioId,ownerId,before,after
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Restore(
                long audioId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.Restore(
                           audioId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Save(
                string server , string audio , string hash , string artist = "",  string title = ""
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.Save(
                           server,audio,hash,artist,title
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Search(
                string q , bool autoComplete = true, bool lyrics = false, bool performerOnly = false, AudioSortOrder sort = AudioSortOrder.ByRating,  bool searchOwn = false, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.Search(
                           q,autoComplete,lyrics,performerOnly,sort,searchOwn,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> SetBroadcast(
                ContentId audio , params int[] targetIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Audio.SetBroadcast(
                           audio,targetIds
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Auth Auth {get; private set;}
        public partial class MethodGroup_Auth {
            private readonly RawApi _parent;
            internal MethodGroup_Auth(RawApi parent){_parent=parent;}

            public async Task<string> CheckPhone(
                string phone , string clientSecret ,  int? clientId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Auth.CheckPhone(
                           phone,clientSecret,clientId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Confirm(
                int clientId , string clientSecret , string phone , string code , string password = "", bool testMode = false,  int? intro = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Auth.Confirm(
                           clientId,clientSecret,phone,code,password,testMode,intro
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Restore(
                 long phone 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Auth.Restore(
                           phone
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Board Board {get; private set;}
        public partial class MethodGroup_Board {
            private readonly RawApi _parent;
            internal MethodGroup_Board(RawApi parent){_parent=parent;}

            public async Task<string> CloseTopic(
                int groupId ,  int topicId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Board.CloseTopic(
                           groupId,topicId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> DeleteComment(
                int groupId , int topicId ,  int commentId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Board.DeleteComment(
                           groupId,topicId,commentId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> DeleteTopic(
                int groupId ,  int topicId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Board.DeleteTopic(
                           groupId,topicId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> FixTopic(
                int groupId ,  int topicId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Board.FixTopic(
                           groupId,topicId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> RestoreComment(
                int groupId , int topicId ,  int commentId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Board.RestoreComment(
                           groupId,topicId,commentId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> UnfixTopic(
                int groupId ,  int topicId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Board.UnfixTopic(
                           groupId,topicId
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Database Database {get; private set;}
        public partial class MethodGroup_Database {
            private readonly RawApi _parent;
            internal MethodGroup_Database(RawApi parent){_parent=parent;}

            public async Task<string> GetChairs(
                 int facultyId , int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Database.GetChairs(
                           facultyId,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetCities(
                int countryId , int? regionId = null, string q = "",  bool needAll = false, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Database.GetCities(
                           countryId,regionId,q,needAll,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetCitiesById(
                params int[] cityIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Database.GetCitiesById(
                           cityIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetCountries(
                string code = "",  bool needAll = false, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Database.GetCountries(
                           code,needAll,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetCountriesById(
                params int[] countryIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Database.GetCountriesById(
                           countryIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetFaculties(
                 int universityId , int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Database.GetFaculties(
                           universityId,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetRegions(
                int countryId ,  string q = "", int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Database.GetRegions(
                           countryId,q,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetSchools(
                int? cityId = null,  string q = "", int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Database.GetSchools(
                           cityId,q,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetSchoolClasses(
                 int countryId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Database.GetSchoolClasses(
                           countryId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetStreetsById(
                params int[] streetIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Database.GetStreetsById(
                           streetIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetUniversities(
                int? countryId = null, int? cityId = null,  string q = "", int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Database.GetUniversities(
                           countryId,cityId,q,offset, count
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Docs Docs {get; private set;}
        public partial class MethodGroup_Docs {
            private readonly RawApi _parent;
            internal MethodGroup_Docs(RawApi parent){_parent=parent;}

            public async Task<string> Add(
                long docId , int ownerId ,  string accessKey = ""
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Docs.Add(
                           docId,ownerId,accessKey
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Delete(
                long docId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Docs.Delete(
                           docId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Get(
                 int? ownerId = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Docs.Get(
                           ownerId,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetById(
                params ContentId[] docs 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Docs.GetById(
                           docs
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetUploadServer(
                 int? groupId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Docs.GetUploadServer(
                           groupId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetWallUploadServer(
                 int? groupId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Docs.GetWallUploadServer(
                           groupId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Save(
                string file , string title , params string[] tags 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Docs.Save(
                           file,title,tags
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Fave Fave {get; private set;}
        public partial class MethodGroup_Fave {
            private readonly RawApi _parent;
            internal MethodGroup_Fave(RawApi parent){_parent=parent;}

            public async Task<string> GetLinks(
                int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Fave.GetLinks(
                           offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetUsers(
                int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Fave.GetUsers(
                           offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetPhotos(
                int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Fave.GetPhotos(
                           offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetPosts(
                int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Fave.GetPosts(
                           offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetVideos(
                int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Fave.GetVideos(
                           offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> RemoveUser(
                 int userId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Fave.RemoveUser(
                           userId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> RemoveLink(
                 int linkId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Fave.RemoveLink(
                           linkId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> RemoveGroup(
                 int groupId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Fave.RemoveGroup(
                           groupId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> AddGroup(
                 int groupId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Fave.AddGroup(
                           groupId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> AddUser(
                 int userId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Fave.AddUser(
                           userId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> AddLink(
                string link ,  string text = ""
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Fave.AddLink(
                           link,text
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Friends Friends {get; private set;}
        public partial class MethodGroup_Friends {
            private readonly RawApi _parent;
            internal MethodGroup_Friends(RawApi parent){_parent=parent;}

            public async Task<string> Add(
                int userId ,  string text = ""
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.Add(
                           userId,text
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> AddList(
                string name , params int[] userIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.AddList(
                           name,userIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> AreFriends(
                bool needSign = false, params int[] userIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.AreFriends(
                           needSign,userIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Delete(
                 int userId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.Delete(
                           userId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> DeleteAllRequests(
                
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.DeleteAllRequests(
                           
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> DeleteList(
                 int listId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.DeleteList(
                           listId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Edit(
                int userId , params long[] listIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.Edit(
                           userId,listIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> EditList(
                long listId , string name = "", int[] userIds = null, int[] addUserIds = null, params int[] deleteUserIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.EditList(
                           listId,name,userIds,addUserIds,deleteUserIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetLists(
                int? userId = null,  bool returnSystem = true
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.GetLists(
                           userId,returnSystem
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Get(
                int? userId = null, int? listId = null, UserFields fields = UserFields.Anything, UserSortOrder order = UserSortOrder.ById,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.Get(
                           userId,listId,fields,order,nameCase,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetIds(
                int? userId = null, int? listId = null,  UserSortOrder order = UserSortOrder.ById, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.GetIds(
                           userId,listId,order,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetAvailableForCallIds(
                
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.GetAvailableForCallIds(
                           
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetAvailableForCall(
                UserFields fields = UserFields.Anything,  NameCase nameCase = NameCase.Nom
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.GetAvailableForCall(
                           fields,nameCase
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Get(
                int? userId = null, int? listId = null,  UserSortOrder order = UserSortOrder.ById, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.Get(
                           userId,listId,order,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetAppUsers(
                
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.GetAppUsers(
                           
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetByPhones(
                UserFields fields = UserFields.None, params ulong[] phones 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.GetByPhones(
                           fields,phones
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetMutual(
                int targetUid , int? sourceUid = null,  bool order = false, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.GetMutual(
                           targetUid,sourceUid,order,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetOnline(
                int? userId = null, int? listId = null,  UserSortOrder? order = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.GetOnline(
                           userId,listId,order,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetRecent(
                 int count = 20
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.GetRecent(
                           count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetSuggestions(
                FriendSuggestionFilters filters = FriendSuggestionFilters.Everything, UserFields fields = UserFields.None,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.GetSuggestions(
                           filters,fields,nameCase,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Search(
                int userId , string q = "",  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 20
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Friends.Search(
                           userId,q,nameCase,offset, count
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Groups Groups {get; private set;}
        public partial class MethodGroup_Groups {
            private readonly RawApi _parent;
            internal MethodGroup_Groups(RawApi parent){_parent=parent;}

            public async Task<string> AddLink(
                int groupId , string link ,  string text = ""
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.AddLink(
                           groupId,link,text
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> ApproveRequest(
                int groupId ,  int userId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.ApproveRequest(
                           groupId,userId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Create(
                string title , PageType type = PageType.Group, PageSubtype? subtype = null,  string description = ""
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.Create(
                           title,type,subtype,description
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> DeleteLink(
                int groupId ,  int linkId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.DeleteLink(
                           groupId,linkId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Edit(
                int groupId , string title = "", string description = "", string screenName = "", string website = "", string email = "", string phone = "", string rss = "", DateTimeOffset? eventStartDate = null, DateTimeOffset? eventFinishDate = null, DateTimeOffset? eventGroupId = null, int? subject = null, int? publicCategory = null, int? publicSubcategory = null, GroupAccess? access = null, AccessType? wall = null, AccessType? topics = null, AccessType? photos = null, AccessType? video = null, AccessType? audio = null, Date? publicDate = null, bool? links = null, bool? events = null, bool? places = null,  bool? contacts = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.Edit(
                           groupId,title,description,screenName,website,email,phone,rss,eventStartDate,eventFinishDate,eventGroupId,subject,publicCategory,publicSubcategory,access,wall,topics,photos,video,audio,publicDate,links,events,places,contacts
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> EditLink(
                int groupId , int linkId ,  string text = ""
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.EditLink(
                           groupId,linkId,text
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Get(
                int userId ,  GroupsGetFilter? filter = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.Get(
                           userId,filter,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetBanned(
                 int groupId , int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.GetBanned(
                           groupId,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetById(
                string[] groupIds ,  GroupFields fields 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.GetById(
                           groupIds,fields
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetById(
                int groupId ,  GroupFields fields 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.GetById(
                           groupId,fields
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetById(
                string groupId ,  GroupFields fields 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.GetById(
                           groupId,fields
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetById(
                int[] groupIds ,  GroupFields fields 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.GetById(
                           groupIds,fields
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetMembers(
                string groupId , GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.GetMembers(
                           groupId,filter,sort,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetMembers(
                int groupId , GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.GetMembers(
                           groupId,filter,sort,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetMembersManagers(
                string groupId ,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.GetMembersManagers(
                           groupId,sort,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetMembersManagers(
                int groupId ,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.GetMembersManagers(
                           groupId,sort,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetMembers(
                string groupId , UserFields fields = UserFields.Anything, GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.GetMembers(
                           groupId,fields,filter,sort,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetMembers(
                int groupId , UserFields fields = UserFields.Anything, GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.GetMembers(
                           groupId,fields,filter,sort,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> IsMember(
                int groupId ,  int? userId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.IsMember(
                           groupId,userId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Invite(
                int groupId ,  int userId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.Invite(
                           groupId,userId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> IsMemberExtended(
                int groupId ,  int? userId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.IsMemberExtended(
                           groupId,userId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> IsMember(
                int groupId , params int[] userIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.IsMember(
                           groupId,userIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Join(
                int groupId ,  bool notSure = false
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.Join(
                           groupId,notSure
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Leave(
                 int groupId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.Leave(
                           groupId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> UnbanUser(
                int groupId ,  int userId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.UnbanUser(
                           groupId,userId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> RemoveUser(
                int groupId ,  int userId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.RemoveUser(
                           groupId,userId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> ReorderLink(
                int groupId , long linkId ,  long after = 0
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Groups.ReorderLink(
                           groupId,linkId,after
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Messages Messages {get; private set;}
        public partial class MethodGroup_Messages {
            private readonly RawApi _parent;
            internal MethodGroup_Messages(RawApi parent){_parent=parent;}

            public async Task<string> AddChatUser(
                int userId ,  int? chatId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.AddChatUser(
                           userId,chatId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Delete(
                params int[] messageIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.Delete(
                           messageIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> DeleteChatPhoto(
                 int chatId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.DeleteChatPhoto(
                           chatId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> DeleteDialog(
                 int userId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.DeleteDialog(
                           userId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Get(
                int @out = 0, int timeOffset = 0, int filters = 0, int previewLength = 0,  long? lastMessageId = null, int? offset = null, int? count = 200
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.Get(
                           @out,timeOffset,filters,previewLength,lastMessageId,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetHistoryChat(
                int chatId , bool rev = false,  long? startMessageId = null, int? offset = null, int? count = 200
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.GetHistoryChat(
                           chatId,rev,startMessageId,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetHistoryUser(
                int userId , bool rev = false,  long? startMessageId = null, int? offset = null, int? count = 200
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.GetHistoryUser(
                           userId,rev,startMessageId,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetLastActivity(
                 int userId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.GetLastActivity(
                           userId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> MarkAsImportant(
                bool important , params int[] messageIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.MarkAsImportant(
                           important,messageIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> MarkAsRead(
                int userId , int? startMessageId = null, params int[] messageIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.MarkAsRead(
                           userId,startMessageId,messageIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Send(
                int userId , string message = null, int? guid = null, double? lat = null, double? @long = null, ContentId[] attachment = null, long[] forwardMessages = null, int? stickerId = null,  long? randomId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.Send(
                           userId,message,guid,lat,@long,attachment,forwardMessages,stickerId,randomId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Send(
                int[] userIds , string message = null, int? guid = null, double? lat = null, double? @long = null, ContentId[] attachment = null, long[] forwardMessages = null, int? stickerId = null,  long? randomId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.Send(
                           userIds,message,guid,lat,@long,attachment,forwardMessages,stickerId,randomId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Send(
                string domain , string message = null, int? guid = null, double? lat = null, double? @long = null, ContentId[] attachment = null, long[] forwardMessages = null, int? stickerId = null,  long? randomId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.Send(
                           domain,message,guid,lat,@long,attachment,forwardMessages,stickerId,randomId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> SendChat(
                int chatId , string message = null, int? guid = null, double? lat = null, double? @long = null, ContentId[] attachment = null, long[] forwardMessages = null, int? stickerId = null,  long? randomId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.SendChat(
                           chatId,message,guid,lat,@long,attachment,forwardMessages,stickerId,randomId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> SendPeer(
                long peerId , string message = null, int? guid = null, double? lat = null, double? @long = null, ContentId[] attachment = null, long[] forwardMessages = null, int? stickerId = null,  long? randomId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.SendPeer(
                           peerId,message,guid,lat,@long,attachment,forwardMessages,stickerId,randomId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> RemoveChatUser(
                int userId ,  int chatId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.RemoveChatUser(
                           userId,chatId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Restore(
                 int messageId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.Restore(
                           messageId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> SetActivity(
                int userId ,  ImActivity type = ImActivity.Typing
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Messages.SetActivity(
                           userId,type
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Newsfeed Newsfeed {get; private set;}
        public partial class MethodGroup_Newsfeed {
            private readonly RawApi _parent;
            internal MethodGroup_Newsfeed(RawApi parent){_parent=parent;}

            public async Task<string> AddBan(
                int[] userIds = null, params int[] groupIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Newsfeed.AddBan(
                           userIds,groupIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> DeleteBan(
                int[] userIds = null, params int[] groupIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Newsfeed.DeleteBan(
                           userIds,groupIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> DeleteList(
                 int listId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Newsfeed.DeleteList(
                           listId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetBanned(
                
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Newsfeed.GetBanned(
                           
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetBannedExtended(
                UserFields fields = UserFields.None,  NameCase nameCase = NameCase.Nom
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Newsfeed.GetBannedExtended(
                           fields,nameCase
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Notes Notes {get; private set;}
        public partial class MethodGroup_Notes {
            private readonly RawApi _parent;
            internal MethodGroup_Notes(RawApi parent){_parent=parent;}

            public async Task<string> Delete(
                 int noteId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Notes.Delete(
                           noteId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> DeleteComment(
                int commentId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Notes.DeleteComment(
                           commentId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> RestoreComment(
                int commentId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Notes.RestoreComment(
                           commentId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Notifications Notifications {get; private set;}
        public partial class MethodGroup_Notifications {
            private readonly RawApi _parent;
            internal MethodGroup_Notifications(RawApi parent){_parent=parent;}

            public async Task<string> MarkAsViewed(
                
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Notifications.MarkAsViewed(
                           
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Pages Pages {get; private set;}
        public partial class MethodGroup_Pages {
            private readonly RawApi _parent;
            internal MethodGroup_Pages(RawApi parent){_parent=parent;}

            public async Task<string> ClearCache(
                 string url 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Pages.ClearCache(
                           url
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Photos Photos {get; private set;}
        public partial class MethodGroup_Photos {
            private readonly RawApi _parent;
            internal MethodGroup_Photos(RawApi parent){_parent=parent;}

            public async Task<string> ConfirmTag(
                int tagId , long photoId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.ConfirmTag(
                           tagId,photoId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Copy(
                long photoId , int? ownerId = null,  string accessKey = ""
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.Copy(
                           photoId,ownerId,accessKey
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> CreateAlbum(
                string title , string description = "", int? groupId = null, PrivacyType? privacy = null,  PrivacyType? commentPrivacy = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.CreateAlbum(
                           title,description,groupId,privacy,commentPrivacy
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Delete(
                long photoId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.Delete(
                           photoId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> DeleteAlbum(
                long albumId ,  int? groupId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.DeleteAlbum(
                           albumId,groupId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> DeleteComment(
                int commentId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.DeleteComment(
                           commentId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Edit(
                long photoId , int? ownerId = null,  string caption = ""
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.Edit(
                           photoId,ownerId,caption
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> EditAlbum(
                long albumId , int? ownerId = null, string title = "", string description = "", PrivacyType? privacy = null,  PrivacyType? commentPrivacy = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.EditAlbum(
                           albumId,ownerId,title,description,privacy,commentPrivacy
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Get(
                long? albumId = null, int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null,  int? feed = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.Get(
                           albumId,ownerId,photoIds,rev,extended,feedType,feed,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Get(
                SpecialAlbum albumId , int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null,  int? feed = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.Get(
                           albumId,ownerId,photoIds,rev,extended,feedType,feed,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetAlbums(
                int? ownerId = null, bool needSystem = true, bool needCovers = true, int? offset = null, int? count = 100, params long[] albumIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.GetAlbums(
                           ownerId,needSystem,needCovers,offset, count,albumIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetAlbumsCount(
                int? userId = null,  int? groupId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.GetAlbumsCount(
                           userId,groupId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetAll(
                int? ownerId = null, bool extended = false, bool noServiceAlbums = false, bool? needHidden = null,  bool? skipHidden = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.GetAll(
                           ownerId,extended,noServiceAlbums,needHidden,skipHidden,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetById(
                params ContentId[] photos 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.GetById(
                           photos
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetChatUploadServer(
                int chatId , int? cropX = null, int? cropY = null,  int? cropWidth = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.GetChatUploadServer(
                           chatId,cropX,cropY,cropWidth
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetOwnerPhotoUploadServer(
                
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.GetOwnerPhotoUploadServer(
                           
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetTags(
                long photoId , int? ownerId = null,  string accessKey = ""
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.GetTags(
                           photoId,ownerId,accessKey
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetUploadServer(
                long albumId ,  int? groupId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.GetUploadServer(
                           albumId,groupId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> MakeCover(
                long albumId , long photoId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.MakeCover(
                           albumId,photoId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Move(
                long targetAlbumId , long photoId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.Move(
                           targetAlbumId,photoId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> RemoveTag(
                int tagId , long photoId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.RemoveTag(
                           tagId,photoId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> ReorderAlbums(
                long albumId , int? ownerId = null, long? before = null,  long? after = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.ReorderAlbums(
                           albumId,ownerId,before,after
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> ReorderPhotos(
                long photoId , int? ownerId = null, long? before = null,  long? after = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.ReorderPhotos(
                           photoId,ownerId,before,after
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Report(
                long photoId , int? ownerId = null,  ReportReason? reason = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.Report(
                           photoId,ownerId,reason
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> ReportComment(
                int commentId , int? ownerId = null,  ReportReason? reason = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.ReportComment(
                           commentId,ownerId,reason
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> RestoreComment(
                int commentId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.RestoreComment(
                           commentId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Restore(
                int ownerId ,  long photoId 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.Restore(
                           ownerId,photoId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Save(
                long albumId , string server , string photosList , string hash , int? groupId = null, double? latitude = null, double? longitude = null, string caption = "",  string description = ""
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Photos.Save(
                           albumId,server,photosList,hash,groupId,latitude,longitude,caption,description
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Polls Polls {get; private set;}
        public partial class MethodGroup_Polls {
            private readonly RawApi _parent;
            internal MethodGroup_Polls(RawApi parent){_parent=parent;}

            public async Task<string> AddVote(
                long pollId , int answerId , int? ownerId = null,  bool? isBoard = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Polls.AddVote(
                           pollId,answerId,ownerId,isBoard
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> DeleteVote(
                long pollId , int answerId , int? ownerId = null,  bool? isBoard = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Polls.DeleteVote(
                           pollId,answerId,ownerId,isBoard
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Stats Stats {get; private set;}
        public partial class MethodGroup_Stats {
            private readonly RawApi _parent;
            internal MethodGroup_Stats(RawApi parent){_parent=parent;}

            public async Task<string> TrackVisitor(
                
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Stats.TrackVisitor(
                           
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Status Status {get; private set;}
        public partial class MethodGroup_Status {
            private readonly RawApi _parent;
            internal MethodGroup_Status(RawApi parent){_parent=parent;}

            public async Task<string> Get(
                 int? userId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Status.Get(
                           userId
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Set(
                 string text 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Status.Set(
                           text
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Storage Storage {get; private set;}
        public partial class MethodGroup_Storage {
            private readonly RawApi _parent;
            internal MethodGroup_Storage(RawApi parent){_parent=parent;}

            public async Task<string> Get(
                int? userId = null, bool global = false, params string[] keys 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Storage.Get(
                           userId,global,keys
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetKeys(
                int? userId = null,  bool global = false, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Storage.GetKeys(
                           userId,global,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Set(
                string key , string value , int? userId = null,  bool global = false
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Storage.Set(
                           key,value,userId,global
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Users Users {get; private set;}
        public partial class MethodGroup_Users {
            private readonly RawApi _parent;
            internal MethodGroup_Users(RawApi parent){_parent=parent;}

            public async Task<string> Get(
                UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, params int[] userIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Users.Get(
                           fields,nameCase,userIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> Get(
                UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, params string[] userIds 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Users.Get(
                           fields,nameCase,userIds
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetFollowers(
                int? userId = null,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Users.GetFollowers(
                           userId,nameCase,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetFollowers(
                int? userId = null, UserFields fields = UserFields.Anything,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Users.GetFollowers(
                           userId,fields,nameCase,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> GetNearby(
                double latitude , double longitude , int? accuracy = null, int? timeout = null, byte? radius = null, UserFields fields = UserFields.None,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Users.GetNearby(
                           latitude,longitude,accuracy,timeout,radius,fields,nameCase,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Возвращает список идентификаторов пользователей и сообществ, которые входят в список подписок пользователя
            ///      
            ///</summary>
            ///<param name="userId">идентификатор пользователя</param>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public async Task<string> GetSubscriptions(
                 int? userId = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Users.GetSubscriptions(
                           userId,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Возвращает информацию о том, установил ли пользователь приложение
            ///      
            ///</summary>
            ///<param name="userId">идентификатор пользователя</param>
            public async Task<string> IsAppUser(
                 int? userId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Users.IsAppUser(
                           userId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Позволяет пожаловаться на пользователя
            ///      
            ///</summary>
            ///<param name="userId">идентификатор пользователя, на которого нужно подать жалобу</param>
            ///<param name="type">тип жалобы</param>
            ///<param name="comment">комментарий к жалобе на пользователя</param>
            public async Task<string> Report(
                int userId , ComplaintType type ,  string comment 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Users.Report(
                           userId,type,comment
                    )
                ).ConfigureAwait(false);
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
            public async Task<string> Search(
                string q = "", SearchSortOrder sort = SearchSortOrder.ByRating, UserFields fields = UserFields.None, int? city = null, int? country = null, string hometown = "", int? universityCountry = null, int? university = null, int? universityYear = null, int? universityFaculty = null, int? universityChair = null, Sex? sex = null, Relation? status = null, byte? ageFrom = null, byte? ageTo = null, byte? birthDay = null, byte? birthMonth = null, ushort? birthYear = null, bool? online = null, bool? hasPhoto = null, int? schoolCountry = null, int? schoolCity = null, int? schoolClass = null, int? school = null, int? schoolYear = null, string religion = "", string interests = "", string company = "", string position = "", int? groupId = null,  FriendshipType? fromList = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Users.Search(
                           q,sort,fields,city,country,hometown,universityCountry,university,universityYear,universityFaculty,universityChair,sex,status,ageFrom,ageTo,birthDay,birthMonth,birthYear,online,hasPhoto,schoolCountry,schoolCity,schoolClass,school,schoolYear,religion,interests,company,position,groupId,fromList,offset, count
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Utils Utils {get; private set;}
        public partial class MethodGroup_Utils {
            private readonly RawApi _parent;
            internal MethodGroup_Utils(RawApi parent){_parent=parent;}

            ///<summary>
            ///        Возвращает информацию о том, является ли внешняя ссылка заблокированной на сайте ВКонтакте
            ///      
            ///</summary>
            public async Task<string> CheckLink(
                 string url 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Utils.CheckLink(
                           url
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Возвращает текущее время на сервере ВКонтакте
            ///      
            ///</summary>
            public async Task<string> GetServerTime(
                
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Utils.GetServerTime(
                           
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Возвращает текущее время на сервере ВКонтакте в unixtime
            ///      
            ///</summary>
            public async Task<string> GetServerTimeRaw(
                
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Utils.GetServerTimeRaw(
                           
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Определяет тип объекта (пользователь, сообщество, приложение) и его идентификатор по короткому имени screen_name
            ///      
            ///</summary>
            public async Task<string> ResolveScreenName(
                 string screenName 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Utils.ResolveScreenName(
                           screenName
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Video Video {get; private set;}
        public partial class MethodGroup_Video {
            private readonly RawApi _parent;
            internal MethodGroup_Video(RawApi parent){_parent=parent;}

            ///<summary>
            ///        Добавляет видеозапись в список пользователя
            ///      
            ///</summary>
            ///<param name="videoId">идентификатор видеозаписи</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи, по умолчанию идентификатор текущего пользователя</param>
            ///<param name="targetId">идентификатор пользователя или сообщества, в которое нужно добавить видео</param>
            public async Task<string> Add(
                long videoId , int? ownerId = null,  int? targetId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Video.Add(
                           videoId,ownerId,targetId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///          Удаляет видеозапись
            ///      
            ///</summary>
            ///<param name="videoId">идентификатор видеозаписи</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи, по умолчанию идентификатор текущего пользователя</param>
            public async Task<string> Delete(
                long videoId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Video.Delete(
                           videoId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///          Удаляет альбом видеозаписей
            ///      
            ///</summary>
            ///<param name="albumId">идентификатор альбома</param>
            ///<param name="groupId">идентификатор сообщества (если альбом, который необходимо удалить, принадлежит сообществу)</param>
            public async Task<string> DeleteAlbum(
                long albumId ,  int? groupId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Video.DeleteAlbum(
                           albumId,groupId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///          Удаляет комментарий к видеозаписи
            ///      
            ///</summary>
            ///<param name="commentId">идентификатор комментария</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи, по умолчанию идентификатор текущего пользователя</param>
            public async Task<string> DeleteComment(
                int commentId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Video.DeleteComment(
                           commentId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///          Изменяет текст комментария к видеозаписи
            ///      
            ///</summary>
            ///<param name="message">новый текст комментария (является обязательным, если не задан параметр attachments)</param>
            ///<param name="commentId">идентификатор комментария</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи, по умолчанию идентификатор текущего пользователя</param>
            public async Task<string> EditComment(
                string message , int commentId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Video.EditComment(
                           message,commentId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///          Возвращает информацию о видеозаписях
            ///      
            ///</summary>
            ///<param name="ownerId">идентификатор пользователя или сообщества, которому принадлежат видеозаписи</param>
            ///<param name="albumId">идентификатор альбома, видеозаписи из которого нужно вернуть</param>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public async Task<string> Get(
                int ownerId ,  long? albumId = null, int? offset = null, int? count = 200
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Video.Get(
                           ownerId,albumId,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///          Возвращает информацию о видеозаписях
            ///      
            ///</summary>
            ///<param name="videos">идентификатор видеозаписей</param>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public async Task<string> Get(
                int? offset = null, int? count = 200, params ContentId[] videos 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Video.Get(
                           offset, count,videos
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///          Возвращает список видеозаписей, на которых есть непросмотренные отметки
            ///      
            ///</summary>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public async Task<string> GetNewTags(
                int? offset = null, int? count = 20
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Video.GetNewTags(
                           offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///          Добавляет отметку на видеозапись
            ///      
            ///</summary>
            ///<param name="videoId">идентификатор видеозаписи</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи, по умолчанию идентификатор текущего пользователя</param>
            public async Task<string> GetTags(
                long videoId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Video.GetTags(
                           videoId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///          Добавляет отметку на видеозапись
            ///      
            ///</summary>
            ///<param name="userId">идентификатор пользователя, которого нужно отметить</param>
            ///<param name="videoId">идентификатор видеозаписи</param>
            ///<param name="taggedName">текст отметки</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи, по умолчанию идентификатор текущего пользователя</param>
            public async Task<string> PutTag(
                int userId , long videoId , string taggedName ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Video.PutTag(
                           userId,videoId,taggedName,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///          Удаляет отметку с видеозаписи
            ///      
            ///</summary>
            ///<param name="videoId">идентификатор видеозаписи</param>
            ///<param name="tagId">идентификатор отметки</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи (пользователь или сообщество), по умолчанию идентификатор текущего пользователя</param>
            public async Task<string> RemoveTag(
                long videoId , int tagId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Video.RemoveTag(
                           videoId,tagId,ownerId
                    )
                ).ConfigureAwait(false);
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
            public async Task<string> Report(
                long videoId , int? ownerId = null, ReportReason? reason = null, string comment = "",  string searchQuery = ""
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Video.Report(
                           videoId,ownerId,reason,comment,searchQuery
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///          Позволяет пожаловаться на комментарий к видеозаписи
            ///      
            ///</summary>
            ///<param name="commentId">идентификатор комментария</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи, к которой оставлен комментарий</param>
            ///<param name="reason">тип жалобы</param>
            public async Task<string> ReportComment(
                int commentId , int? ownerId = null,  ReportReason? reason = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Video.ReportComment(
                           commentId,ownerId,reason
                    )
                ).ConfigureAwait(false);
            }
                    
            public async Task<string> RestoreComment(
                int commentId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Video.RestoreComment(
                           commentId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///          Восстанавливает удаленную видеозапись
            ///      
            ///</summary>
            ///<param name="videoId">идентификатор видеозаписи</param>
            ///<param name="ownerId">идентификатор владельца видеозаписи, по умолчанию идентификатор текущего пользователя</param>
            public async Task<string> Restore(
                long videoId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Video.Restore(
                           videoId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Wall Wall {get; private set;}
        public partial class MethodGroup_Wall {
            private readonly RawApi _parent;
            internal MethodGroup_Wall(RawApi parent){_parent=parent;}

            ///<summary>
            ///          Удаляет запись со стены
            ///      
            ///</summary>
            ///<param name="postId">идентификатор записи на стене</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находится запись, по умолчанию идентификатор текущего пользователя</param>
            public async Task<string> Delete(
                int postId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.Delete(
                           postId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///          Удаляет комментарий текущего пользователя к записи на своей или чужой стене
            ///      
            ///</summary>
            ///<param name="commentId">идентификатор комментария</param>
            ///<param name="ownerId">идентификатор пользователя, на чьей стене находится комментарий к записи, по умолчанию идентификатор текущего пользователя</param>
            public async Task<string> DeleteComment(
                int commentId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.DeleteComment(
                           commentId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///          Возвращает список записей со стен пользователей или сообществ по их идентификаторам
            ///      
            ///</summary>
            ///<param name="ownerId">идентификатор пользователя или сообщества</param>
            ///<param name="filter">определяет, какие типы записей на стене необходимо получить</param>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public async Task<string> Get(
                int ownerId ,  WallPostFilter filter = WallPostFilter.All, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.Get(
                           ownerId,filter,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///          Возвращает список записей со стен пользователей или сообществ по их идентификаторам
            ///      
            ///</summary>
            ///<param name="domain">короткий адрес пользователя или сообщества</param>
            ///<param name="filter">определяет, какие типы записей на стене необходимо получить</param>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public async Task<string> Get(
                string domain ,  WallPostFilter filter = WallPostFilter.All, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.Get(
                           domain,filter,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Возвращает список записей со стен пользователей или сообществ по их идентификаторам
            ///      
            ///</summary>
            ///<param name="copyHistoryDepth">идентификаторы постов</param>
            ///<param name="posts">глубина показа репостов</param>
            public async Task<string> GetById(
                int copyHistoryDepth = 2, params ContentId[] posts 
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.GetById(
                           copyHistoryDepth,posts
                    )
                ).ConfigureAwait(false);
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
            public async Task<string> GetComments(
                int postId , string sort , int previewLength = 0, int? ownerId = null,  bool needLikes = false, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.GetComments(
                           postId,sort,previewLength,ownerId,needLikes,offset, count
                    )
                ).ConfigureAwait(false);
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
            public async Task<string> GetCommentsExtended(
                int postId , string sort , int previewLength = 0, int? ownerId = null,  bool needLikes = false, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.GetCommentsExtended(
                           postId,sort,previewLength,ownerId,needLikes,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Позволяет получать список репостов заданной записи
            ///      
            ///</summary>
            ///<param name="postId">идентификатор записи на стене</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находится запись, по умолчанию идентификатор текущего пользователя</param>
            ///<param name="offset">Оффсет для возврата результатов</param>
            ///<param name="count">Количество записей, которые необходимо вернуть</param>
            public async Task<string> GetReposts(
                int postId ,  int? ownerId = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.GetReposts(
                           postId,ownerId,offset, count
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Закрепляет запись на стене
            ///      
            ///</summary>
            ///<param name="postId">идентификатор записи на стене</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находится запись, по умолчанию идентификатор текущего пользователя</param>
            public async Task<string> Pin(
                int postId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.Pin(
                           postId,ownerId
                    )
                ).ConfigureAwait(false);
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
            public async Task<string> Post(
                string message = "", ContentId[] attachments = null, int? ownerId = null, bool fromGroup = false, bool signed = false, bool? friendsOnly = false, string services = "", DateTimeOffset? publishDate = null, double? lat = null, double? @long = null,  int? placeId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.Post(
                           message,attachments,ownerId,fromGroup,signed,friendsOnly,services,publishDate,lat,@long,placeId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Публикует комментарий на своей или чужой стене
            ///      
            ///</summary>
            ///<returns>
            ///</returns>
            public async Task<string> AddComment(
                int ownerId , int postId , string text , bool fromGroup = false, long? replyToComment = null, ContentId[] attachments = null, long? stickerId = null, string @ref = "",  string guid = ""
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.AddComment(
                           ownerId,postId,text,fromGroup,replyToComment,attachments,stickerId,@ref,guid
                    )
                ).ConfigureAwait(false);
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
            public async Task<string> Post(
                int postId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.Post(
                           postId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Позволяет пожаловаться на комментарий к записи
            ///      
            ///</summary>
            ///<param name="commentId">идентификатор комментария</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, которому принадлежит комментарий</param>
            ///<param name="reason">причина жалобы</param>
            public async Task<string> ReportComment(
                int commentId , int? ownerId = null,  ReportReason? reason = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.ReportComment(
                           commentId,ownerId,reason
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Позволяет пожаловаться на запись.
            ///      
            ///</summary>
            ///<param name="postId">идентификатор пользователя или сообщества, которому принадлежит запись</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, которому принадлежит запись</param>
            ///<param name="reason">причина жалобы</param>
            public async Task<string> ReportPost(
                int postId , int? ownerId = null,  ReportReason? reason = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.ReportPost(
                           postId,ownerId,reason
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Копирует объект на стену пользователя или сообщества
            ///      
            ///</summary>
            ///<param name="@object">идентификатор объекта, который необходимо разместить на стене</param>
            ///<param name="message">сопроводительный текст, который будет добавлен к записи с объектом</param>
            ///<param name="groupId">идентификатор сообщества, на стене которого будет размещена запись с объектом. Если не указан, запись будет размещена на стене текущего пользователя</param>
            public async Task<string> Repost(
                string @object , string message = "", int? groupId = null,  string @ref = ""
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.Repost(
                           @object,message,groupId,@ref
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Восстанавливает удаленную запись на стене пользователя или сообщества
            ///      
            ///</summary>
            ///<param name="postId">идентификатор записи на стене</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находилась удаленная запись, по умолчанию идентификатор текущего пользователя</param>
            public async Task<string> Restore(
                int postId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.Restore(
                           postId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Восстанавливает комментарий текущего пользователя к записи на своей или чужой стене
            ///      
            ///</summary>
            ///<param name="commentId">идентификатор комментария на стене</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находится комментарий к записи, по умолчанию идентификатор текущего пользователя</param>
            public async Task<string> RestoreComment(
                int commentId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.RestoreComment(
                           commentId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                    
            ///<summary>
            ///        Отменяет закрепление записи на стене
            ///      
            ///</summary>
            ///<param name="postId">идентификатор записи на стене</param>
            ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находится запись, по умолчанию идентификатор текущего пользователя</param>
            public async Task<string> Unpin(
                int postId ,  int? ownerId = null
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Wall.Unpin(
                           postId,ownerId
                    )
                ).ConfigureAwait(false);
            }
                                }

        public MethodGroup_Likes Likes {get; private set;}
        public partial class MethodGroup_Likes {
            private readonly RawApi _parent;
            internal MethodGroup_Likes(RawApi parent){_parent=parent;}

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
            public async Task<string> GetList(
                string type , string filter , bool friendsOnly , bool skipOwn , int? ownerId = null, int? itemId = null,  string pageUrl = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Likes.GetList(
                           type,filter,friendsOnly,skipOwn,ownerId,itemId,pageUrl,offset, count
                    )
                ).ConfigureAwait(false);
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
            public async Task<string> GetListExtended(
                string type , string filter , bool friendsOnly , bool skipOwn , int? ownerId = null, int? itemId = null,  string pageUrl = null, int? offset = null, int? count = 100
            ){
                return await _parent.Executor.ExecRawAsync(
                    _parent._reqapi.Likes.GetListExtended(
                           type,filter,friendsOnly,skipOwn,ownerId,itemId,pageUrl,offset, count
                    )
                ).ConfigureAwait(false);
            }
                                }

    }
}