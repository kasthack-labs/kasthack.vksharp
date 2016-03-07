
using System;
using System.Linq;
using System.Threading.Tasks;
using kasthack.vksharp.DataTypes;
using kasthack.vksharp.DataTypes.ResponseEntities;
using kasthack.vksharp.DataTypes.Entities;
using kasthack.vksharp.DataTypes.Enums;
using kasthack.vksharp.DataTypes.EntityFragments;
using kasthack.vksharp.DataTypes.Interfaces;

// ReSharper disable UnusedMember.Global
namespace kasthack.vksharp {
    public partial class Api {
            private void InitializeMethodGroups(){
                this.Account = new MethodGroup_Account(this);
                this.Apps = new MethodGroup_Apps(this);
                this.Audio = new MethodGroup_Audio(this);
                this.Auth = new MethodGroup_Auth(this);
                this.Board = new MethodGroup_Board(this);
                this.Database = new MethodGroup_Database(this);
                this.Docs = new MethodGroup_Docs(this);
                this.Fave = new MethodGroup_Fave(this);
                this.Friends = new MethodGroup_Friends(this);
                this.Groups = new MethodGroup_Groups(this);
                this.Messages = new MethodGroup_Messages(this);
                this.Newsfeed = new MethodGroup_Newsfeed(this);
                this.Notes = new MethodGroup_Notes(this);
                this.Notifications = new MethodGroup_Notifications(this);
                this.Pages = new MethodGroup_Pages(this);
                this.Photos = new MethodGroup_Photos(this);
                this.Polls = new MethodGroup_Polls(this);
                this.Stats = new MethodGroup_Stats(this);
                this.Status = new MethodGroup_Status(this);
                this.Storage = new MethodGroup_Storage(this);
                this.Users = new MethodGroup_Users(this);
                this.Utils = new MethodGroup_Utils(this);
                this.Video = new MethodGroup_Video(this);
                this.Wall = new MethodGroup_Wall(this);
                this.Likes = new MethodGroup_Likes(this);
            }


            public MethodGroup_Account Account {get; private set;}

            public partial class MethodGroup_Account {
                private readonly Api _parent;
                internal MethodGroup_Account(Api parent){_parent=parent;}
                ///<summary>
                ///Добавляет пользователя в черный список.Если указанный пользователь является другом текущего пользователя или имеет от него входящую или исходящую заявку в друзья, то для добавления пользователя в черный список Ваше приложение должно иметь права: friends.
                ///</summary>
                ///<param name="userId">Идентификатор пользователя, которого нужно добавить в черный список</param>
                public async Task  BanUser(
                     int userId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.BanUser(
                                userId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                ///<summary>
                ///Добавляет пользователя в черный список.Если указанный пользователь является другом текущего пользователя или имеет от него входящую или исходящую заявку в друзья, то для добавления пользователя в черный список Ваше приложение должно иметь права: friends.
                ///</summary>
                ///<param name="userId">Идентификатор пользователя, которого нужно добавить в черный список</param>
                public void BanUserSync(
                     int userId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.BanUser(
                                userId
                            )
                        );
                    task.Wait();
                    
                }
                ///<summary>
                ///        Позволяет сменить пароль пользователя после успешного восстановления доступа к аккаунту через СМС, используя метод auth.restore
                ///      
                ///</summary>
                ///<param name="restoreSid">Идентификатор сессии, полученный при восстановлении доступа используя метод auth.restore. (В случае если пароль меняется сразу после восстановления доступа)</param>
                ///<param name="changePasswordHash">Хэш, полученный при успешной OAuth авторизации по коду полученному по СМС (В случае если пароль меняется сразу после восстановления доступа)</param>
                ///<param name="oldPassword">Текущий пароль пользователя</param>
                ///<param name="newPassword">Новый пароль, который будет установлен в качестве текущего</param>
                public async Task <ChangePassword> ChangePassword(
                    string restoreSid , string changePasswordHash , string oldPassword ,  string newPassword 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.ChangePassword(
                                restoreSid,changePasswordHash,oldPassword,newPassword
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                ///<summary>
                ///        Позволяет сменить пароль пользователя после успешного восстановления доступа к аккаунту через СМС, используя метод auth.restore
                ///      
                ///</summary>
                ///<param name="restoreSid">Идентификатор сессии, полученный при восстановлении доступа используя метод auth.restore. (В случае если пароль меняется сразу после восстановления доступа)</param>
                ///<param name="changePasswordHash">Хэш, полученный при успешной OAuth авторизации по коду полученному по СМС (В случае если пароль меняется сразу после восстановления доступа)</param>
                ///<param name="oldPassword">Текущий пароль пользователя</param>
                ///<param name="newPassword">Новый пароль, который будет установлен в качестве текущего</param>
                public ChangePassword ChangePasswordSync(
                    string restoreSid , string changePasswordHash , string oldPassword ,  string newPassword 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.ChangePassword(
                                restoreSid,changePasswordHash,oldPassword,newPassword
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                ///<summary>
                ///        Возвращает список активных рекламных предложений (офферов), выполнив которые пользователь сможет получить соответствующее количество голосов на свой счёт внутри приложения
                ///      
                ///</summary>
                public async Task <EntityList<Offer>> GetActiveOffers(
                    int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.GetActiveOffers(
                                offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                ///<summary>
                ///        Возвращает список активных рекламных предложений (офферов), выполнив которые пользователь сможет получить соответствующее количество голосов на свой счёт внутри приложения
                ///      
                ///</summary>
                public EntityList<Offer> GetActiveOffersSync(
                    int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.GetActiveOffers(
                                offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
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
                public async Task <Permission> GetAppPermissions(
                     int? userId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.GetAppPermissions(
                                userId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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
                public Permission GetAppPermissionsSync(
                     int? userId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.GetAppPermissions(
                                userId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                ///<summary>
                ///      Возвращает список пользователей, находящихся в черном списке
                ///    
                ///</summary>
                ///<returns>
                ///      Возвращает набор объектов пользователей, находящихся в черном списке
                ///    
                ///</returns>
                public async Task <User[]> GetBanned(
                    int? offset = null, int? count = 20
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.GetBanned(
                                offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                ///<summary>
                ///      Возвращает список пользователей, находящихся в черном списке
                ///    
                ///</summary>
                ///<returns>
                ///      Возвращает набор объектов пользователей, находящихся в черном списке
                ///    
                ///</returns>
                public User[] GetBannedSync(
                    int? offset = null, int? count = 20
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.GetBanned(
                                offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                ///<summary>
                ///        Возвращает информацию о текущем аккаунте
                ///      
                ///</summary>
                ///<returns>
                ///        Возвращает объект AccountInfo
                ///      
                ///</returns>
                public async Task <AccountInfo> GetInfo(
                    
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.GetInfo(
                                
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                ///<summary>
                ///        Возвращает информацию о текущем аккаунте
                ///      
                ///</summary>
                ///<returns>
                ///        Возвращает объект AccountInfo
                ///      
                ///</returns>
                public AccountInfo GetInfoSync(
                    
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.GetInfo(
                                
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                ///<summary>
                ///        Отменяет редактирование профиля
                ///      
                ///</summary>
                ///<param name="cancelRequestId">идентификатор заявки на смену имени, которую необходимо отменить</param>
                public async Task <SaveProfileInfo> SaveProfileInfo(
                     int cancelRequestId 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SaveProfileInfo(
                                cancelRequestId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                ///<summary>
                ///        Отменяет редактирование профиля
                ///      
                ///</summary>
                ///<param name="cancelRequestId">идентификатор заявки на смену имени, которую необходимо отменить</param>
                public SaveProfileInfo SaveProfileInfoSync(
                     int cancelRequestId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SaveProfileInfo(
                                cancelRequestId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
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
                public async Task <SaveProfileInfo> SaveProfileInfo(
                    string firstName = "", string lastName = "", string maidenName = "", string screenName = "", Sex? sex = null, Relation? relation = null, int? relationPartnerId = null, Date? bdate = null, string homeTown = "", int? countryId = null, int? cityId = null,  string status = ""
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SaveProfileInfo(
                                firstName,lastName,maidenName,screenName,sex,relation,relationPartnerId,bdate,homeTown,countryId,cityId,status
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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
                public SaveProfileInfo SaveProfileInfoSync(
                    string firstName = "", string lastName = "", string maidenName = "", string screenName = "", Sex? sex = null, Relation? relation = null, int? relationPartnerId = null, Date? bdate = null, string homeTown = "", int? countryId = null, int? cityId = null,  string status = ""
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SaveProfileInfo(
                                firstName,lastName,maidenName,screenName,sex,relation,relationPartnerId,bdate,homeTown,countryId,cityId,status
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                ///<summary>
                ///        Возвращает информацию о текущем профиле
                ///      
                ///</summary>
                public async Task <User> GetProfileInfo(
                    
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.GetProfileInfo(
                                
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                ///<summary>
                ///        Возвращает информацию о текущем профиле
                ///      
                ///</summary>
                public User GetProfileInfoSync(
                    
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.GetProfileInfo(
                                
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                ///<summary>
                ///        Позволяет редактировать информацию о текущем аккаунте.
                ///      
                ///</summary>
                ///<param name="intro">битовая маска, отвечающая за прохождение обучения в мобильных клиентах</param>
                ///<param name="ownPostsDefault">Отображать по дефолту только записи пользователя</param>
                ///<param name="noWallReplies">отключить комментирование записей на стене</param>
                public async Task  SetInfo(
                    int? intro = null, bool? ownPostsDefault = null,  bool? noWallReplies = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SetInfo(
                                intro,ownPostsDefault,noWallReplies
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                ///<summary>
                ///        Позволяет редактировать информацию о текущем аккаунте.
                ///      
                ///</summary>
                ///<param name="intro">битовая маска, отвечающая за прохождение обучения в мобильных клиентах</param>
                ///<param name="ownPostsDefault">Отображать по дефолту только записи пользователя</param>
                ///<param name="noWallReplies">отключить комментирование записей на стене</param>
                public void SetInfoSync(
                    int? intro = null, bool? ownPostsDefault = null,  bool? noWallReplies = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SetInfo(
                                intro,ownPostsDefault,noWallReplies
                            )
                        );
                    task.Wait();
                    
                }
                ///<summary>
                ///        Устанавливает короткое название приложения (до 17 символов), которое выводится пользователю в левом меню
                ///      
                ///</summary>
                ///<param name="name">короткое название приложения</param>
                ///<param name="userId">идентификатор пользователя</param>
                public async Task  SetNameInMenu(
                    string name ,  string userId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SetNameInMenu(
                                name,userId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                ///<summary>
                ///        Устанавливает короткое название приложения (до 17 символов), которое выводится пользователю в левом меню
                ///      
                ///</summary>
                ///<param name="name">короткое название приложения</param>
                ///<param name="userId">идентификатор пользователя</param>
                public void SetNameInMenuSync(
                    string name ,  string userId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SetNameInMenu(
                                name,userId
                            )
                        );
                    task.Wait();
                    
                }
                ///<summary>
                ///        Помечает текущего пользователя как offline
                ///      
                ///</summary>
                public async Task  SetOffline(
                    
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SetOffline(
                                
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                ///<summary>
                ///        Помечает текущего пользователя как offline
                ///      
                ///</summary>
                public void SetOfflineSync(
                    
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SetOffline(
                                
                            )
                        );
                    task.Wait();
                    
                }
                ///<summary>
                ///        Помечает текущего пользователя как online на 15 минут
                ///      
                ///</summary>
                ///<param name="voip">возможны ли видеозвонки для данного устройства</param>
                public async Task  SetOnline(
                     bool voip = true
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SetOnline(
                                voip
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                ///<summary>
                ///        Помечает текущего пользователя как online на 15 минут
                ///      
                ///</summary>
                ///<param name="voip">возможны ли видеозвонки для данного устройства</param>
                public void SetOnlineSync(
                     bool voip = true
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SetOnline(
                                voip
                            )
                        );
                    task.Wait();
                    
                }
                ///<summary>
                ///        Отключает push-уведомления на заданный промежуток времени
                ///      
                ///</summary>
                ///<param name="deviceId">уникальный идентификатор устройства</param>
                ///<param name="time">время в секундах на которое требуется отключить уведомления, -1 отключить навсегда</param>
                ///<param name="chatId"></param>
                ///<param name="sound">включить/отключить звук в данном диалоге</param>
                public async Task  SetSilenceMode(
                    string deviceId , int time , int? chatId = null, int? userId = null,  int sound = 0
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SetSilenceMode(
                                deviceId,time,chatId,userId,sound
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                ///<summary>
                ///        Отключает push-уведомления на заданный промежуток времени
                ///      
                ///</summary>
                ///<param name="deviceId">уникальный идентификатор устройства</param>
                ///<param name="time">время в секундах на которое требуется отключить уведомления, -1 отключить навсегда</param>
                ///<param name="chatId"></param>
                ///<param name="sound">включить/отключить звук в данном диалоге</param>
                public void SetSilenceModeSync(
                    string deviceId , int time , int? chatId = null, int? userId = null,  int sound = 0
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SetSilenceMode(
                                deviceId,time,chatId,userId,sound
                            )
                        );
                    task.Wait();
                    
                }
                ///<summary>
                ///        Убирает пользователя из черного списка
                ///      
                ///</summary>
                ///<param name="userId">идентификатор пользователя, которого нужно убрать из черного списка</param>
                public async Task  UnbanUser(
                     int userId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.UnbanUser(
                                userId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                ///<summary>
                ///        Убирает пользователя из черного списка
                ///      
                ///</summary>
                ///<param name="userId">идентификатор пользователя, которого нужно убрать из черного списка</param>
                public void UnbanUserSync(
                     int userId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.UnbanUser(
                                userId
                            )
                        );
                    task.Wait();
                    
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
                public async Task  RegisterDevice(
                    string token , string deviceId , string settings , int? deviceYear = null, string deviceModel = "", string systemVersion = "",  bool? sandbox = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.RegisterDevice(
                                token,deviceId,settings,deviceYear,deviceModel,systemVersion,sandbox
                            )
                        ).ConfigureAwait(false)
                    ;
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
                public void RegisterDeviceSync(
                    string token , string deviceId , string settings , int? deviceYear = null, string deviceModel = "", string systemVersion = "",  bool? sandbox = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.RegisterDevice(
                                token,deviceId,settings,deviceYear,deviceModel,systemVersion,sandbox
                            )
                        );
                    task.Wait();
                    
                }
                ///<summary>
                ///        Отписывает устройство от Push уведомлений
                ///      
                ///</summary>
                ///<param name="deviceId">уникальный идентификатор устройства</param>
                ///<param name="sandbox">отписать устройство, использующее sandbox сервер для отправки push-уведомлений</param>
                public async Task  UnregisterDevice(
                    string deviceId ,  bool? sandbox = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.UnregisterDevice(
                                deviceId,sandbox
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                ///<summary>
                ///        Отписывает устройство от Push уведомлений
                ///      
                ///</summary>
                ///<param name="deviceId">уникальный идентификатор устройства</param>
                ///<param name="sandbox">отписать устройство, использующее sandbox сервер для отправки push-уведомлений</param>
                public void UnregisterDeviceSync(
                    string deviceId ,  bool? sandbox = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.UnregisterDevice(
                                deviceId,sandbox
                            )
                        );
                    task.Wait();
                    
                }
            }

            public MethodGroup_Apps Apps {get; private set;}

            public partial class MethodGroup_Apps {
                private readonly Api _parent;
                internal MethodGroup_Apps(Api parent){_parent=parent;}
                ///<summary>
                ///        Удаляет все уведомления о запросах, отправленных из текущего приложения
                ///      
                ///</summary>
                public async Task  DeleteAppRequests(
                    
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Apps.DeleteAppRequests(
                                
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                ///<summary>
                ///        Удаляет все уведомления о запросах, отправленных из текущего приложения
                ///      
                ///</summary>
                public void DeleteAppRequestsSync(
                    
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Apps.DeleteAppRequests(
                                
                            )
                        );
                    task.Wait();
                    
                }
                ///<summary>
                ///        Метод возвращает количество очков пользователя в этой игре
                ///      
                ///</summary>
                public async Task <long> GetScore(
                    
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Apps.GetScore(
                                
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                ///<summary>
                ///        Метод возвращает количество очков пользователя в этой игре
                ///      
                ///</summary>
                public long GetScoreSync(
                    
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Apps.GetScore(
                                
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                ///<summary>
                ///        Возвращает рейтинг пользователей в игре
                ///      
                ///</summary>
                ///<param name="type">Тип рейтинга</param>
                ///<param name="global">Глобальный/только друзья</param>
                public async Task <EntityList<User>> GetLeaderboardExtended(
                    LeaderBoardType type ,  bool global = true
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Apps.GetLeaderboardExtended(
                                type,global
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                ///<summary>
                ///        Возвращает рейтинг пользователей в игре
                ///      
                ///</summary>
                ///<param name="type">Тип рейтинга</param>
                ///<param name="global">Глобальный/только друзья</param>
                public EntityList<User> GetLeaderboardExtendedSync(
                    LeaderBoardType type ,  bool global = true
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Apps.GetLeaderboardExtended(
                                type,global
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                ///<summary>
                ///        Возвращает рейтинг пользователей в игре
                ///      
                ///</summary>
                ///<param name="type">Тип рейтинга</param>
                ///<param name="global">Глобальный/только друзья</param>
                public async Task <EntityList<int>> GetLeaderboard(
                    LeaderBoardType type ,  bool global = true
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Apps.GetLeaderboard(
                                type,global
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                ///<summary>
                ///        Возвращает рейтинг пользователей в игре
                ///      
                ///</summary>
                ///<param name="type">Тип рейтинга</param>
                ///<param name="global">Глобальный/только друзья</param>
                public EntityList<int> GetLeaderboardSync(
                    LeaderBoardType type ,  bool global = true
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Apps.GetLeaderboard(
                                type,global
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
            }

            public MethodGroup_Audio Audio {get; private set;}

            public partial class MethodGroup_Audio {
                private readonly Api _parent;
                internal MethodGroup_Audio(Api parent){_parent=parent;}
                ///<summary>
                ///        Копирует аудиозапись на страницу пользователя или группы
                ///      
                ///</summary>
                ///<param name="ownerId">идентификатор владельца аудиозаписи (пользователь или сообщество)</param>
                ///<param name="audioId">Идентификатор аудиозаписи</param>
                ///<param name="groupId">идентификатор сообщества (если аудиозапись необходимо скопировать в список сообщества)</param>
                ///<param name="albumId">идентификатор альбома, в который нужно переместить аудиозапись</param>
                public async Task <int> Add(
                    int ownerId , long audioId , int? groupId = null,  long? albumId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Add(
                                ownerId,audioId,groupId,albumId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                ///<summary>
                ///        Копирует аудиозапись на страницу пользователя или группы
                ///      
                ///</summary>
                ///<param name="ownerId">идентификатор владельца аудиозаписи (пользователь или сообщество)</param>
                ///<param name="audioId">Идентификатор аудиозаписи</param>
                ///<param name="groupId">идентификатор сообщества (если аудиозапись необходимо скопировать в список сообщества)</param>
                ///<param name="albumId">идентификатор альбома, в который нужно переместить аудиозапись</param>
                public int AddSync(
                    int ownerId , long audioId , int? groupId = null,  long? albumId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Add(
                                ownerId,audioId,groupId,albumId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                ///<summary>
                ///        Создает пустой альбом аудиозаписей
                ///      
                ///</summary>
                ///<param name="title">название альбома</param>
                ///<param name="groupId">идентификатор сообщества (если альбом нужно создать в сообществе)</param>
                public async Task <AddAlbum> AddAlbum(
                    string title ,  int? groupId = 0
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.AddAlbum(
                                title,groupId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                ///<summary>
                ///        Создает пустой альбом аудиозаписей
                ///      
                ///</summary>
                ///<param name="title">название альбома</param>
                ///<param name="groupId">идентификатор сообщества (если альбом нужно создать в сообществе)</param>
                public AddAlbum AddAlbumSync(
                    string title ,  int? groupId = 0
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.AddAlbum(
                                title,groupId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                ///<summary>
                ///        Удаляет аудиозапись со страницы пользователя или сообщества
                ///      
                ///</summary>
                ///<param name="audioId">идентификатор аудиозаписи</param>
                ///<param name="ownerId">идентификатор владельца аудиозаписи (пользователь или сообщество)</param>
                public async Task  Delete(
                    long audioId ,  int ownerId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Delete(
                                audioId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                ///<summary>
                ///        Удаляет аудиозапись со страницы пользователя или сообщества
                ///      
                ///</summary>
                ///<param name="audioId">идентификатор аудиозаписи</param>
                ///<param name="ownerId">идентификатор владельца аудиозаписи (пользователь или сообщество)</param>
                public void DeleteSync(
                    long audioId ,  int ownerId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Delete(
                                audioId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                ///<summary>
                ///        Удаляет альбом аудиозаписей
                ///      
                ///</summary>
                ///<param name="albumId">идентификатор альбома</param>
                ///<param name="groupId">идентификатор сообщества, которому принадлежит альбом</param>
                public async Task  DeleteAlbum(
                    long albumId ,  int? groupId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.DeleteAlbum(
                                albumId,groupId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                ///<summary>
                ///        Удаляет альбом аудиозаписей
                ///      
                ///</summary>
                ///<param name="albumId">идентификатор альбома</param>
                ///<param name="groupId">идентификатор сообщества, которому принадлежит альбом</param>
                public void DeleteAlbumSync(
                    long albumId ,  int? groupId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.DeleteAlbum(
                                albumId,groupId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task <int> Edit(
                    int ownerId , long audioId , string artist = "", string title = "", string text = "", AudioGenre? genreId = null,  bool? noSearch = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Edit(
                                ownerId,audioId,artist,title,text,genreId,noSearch
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public int EditSync(
                    int ownerId , long audioId , string artist = "", string title = "", string text = "", AudioGenre? genreId = null,  bool? noSearch = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Edit(
                                ownerId,audioId,artist,title,text,genreId,noSearch
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task  EditAlbum(
                    long albumId , string title ,  int? groupId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.EditAlbum(
                                albumId,title,groupId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void EditAlbumSync(
                    long albumId , string title ,  int? groupId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.EditAlbum(
                                albumId,title,groupId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  MoveToAlbum(
                    long albumId , int? groupId = null, params ulong[] audioIds 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.MoveToAlbum(
                                albumId,groupId,audioIds
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void MoveToAlbumSync(
                    long albumId , int? groupId = null, params ulong[] audioIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.MoveToAlbum(
                                albumId,groupId,audioIds
                            )
                        );
                    task.Wait();
                    
                }
                public async Task <EntityList<Audio>> Get(
                    int? ownerId = null, long? albumId = null, int? offset = null, int? count = 100, params ulong[] audioIds 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Get(
                                ownerId,albumId,offset, count,audioIds
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<Audio> GetSync(
                    int? ownerId = null, long? albumId = null, int? offset = null, int? count = 100, params ulong[] audioIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Get(
                                ownerId,albumId,offset, count,audioIds
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <Group[]> GetBroadcastListGroups(
                     bool active = true, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetBroadcastListGroups(
                                active,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public Group[] GetBroadcastListGroupsSync(
                     bool active = true, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetBroadcastListGroups(
                                active,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <User[]> GetBroadcastListUsers(
                     bool active = true, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetBroadcastListUsers(
                                active,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public User[] GetBroadcastListUsersSync(
                     bool active = true, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetBroadcastListUsers(
                                active,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<Audio>> GetPopular(
                    AudioGenre? genreId = null,  bool? onlyEng = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetPopular(
                                genreId,onlyEng,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<Audio> GetPopularSync(
                    AudioGenre? genreId = null,  bool? onlyEng = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetPopular(
                                genreId,onlyEng,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<Audio>> GetRecommendations(
                    AudioGenre? genreId = null,  bool? onlyEng = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetRecommendations(
                                genreId,onlyEng,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<Audio> GetRecommendationsSync(
                    AudioGenre? genreId = null,  bool? onlyEng = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetRecommendations(
                                genreId,onlyEng,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<AudioAlbum>> GetAlbums(
                     int? ownerId = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetAlbums(
                                ownerId,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<AudioAlbum> GetAlbumsSync(
                     int? ownerId = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetAlbums(
                                ownerId,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <Audio[]> GetById(
                    bool itunes = false, params ContentId[] audios 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetById(
                                itunes,audios
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public Audio[] GetByIdSync(
                    bool itunes = false, params ContentId[] audios 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetById(
                                itunes,audios
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <int> GetCount(
                     int? ownerId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetCount(
                                ownerId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public int GetCountSync(
                     int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetCount(
                                ownerId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <Lyrics> GetLyrics(
                     long lyricsId 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetLyrics(
                                lyricsId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public Lyrics GetLyricsSync(
                     long lyricsId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetLyrics(
                                lyricsId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <string> GetUploadServer(
                    long albumId ,  int? groupId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetUploadServer(
                                albumId,groupId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public string GetUploadServerSync(
                    long albumId ,  int? groupId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetUploadServer(
                                albumId,groupId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task  Reorder(
                    long audioId , int? ownerId = null, long? before = null,  long? after = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Reorder(
                                audioId,ownerId,before,after
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void ReorderSync(
                    long audioId , int? ownerId = null, long? before = null,  long? after = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Reorder(
                                audioId,ownerId,before,after
                            )
                        );
                    task.Wait();
                    
                }
                public async Task <Audio> Restore(
                    long audioId ,  int? ownerId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Restore(
                                audioId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public Audio RestoreSync(
                    long audioId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Restore(
                                audioId,ownerId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <Audio[]> Save(
                    string server , string audio , string hash , string artist = "",  string title = ""
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Save(
                                server,audio,hash,artist,title
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public Audio[] SaveSync(
                    string server , string audio , string hash , string artist = "",  string title = ""
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Save(
                                server,audio,hash,artist,title
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<Audio>> Search(
                    string q , bool autoComplete = true, bool lyrics = false, bool performerOnly = false, AudioSortOrder sort = AudioSortOrder.ByRating,  bool searchOwn = false, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Search(
                                q,autoComplete,lyrics,performerOnly,sort,searchOwn,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<Audio> SearchSync(
                    string q , bool autoComplete = true, bool lyrics = false, bool performerOnly = false, AudioSortOrder sort = AudioSortOrder.ByRating,  bool searchOwn = false, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Search(
                                q,autoComplete,lyrics,performerOnly,sort,searchOwn,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task  SetBroadcast(
                    ContentId audio , params int[] targetIds 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.SetBroadcast(
                                audio,targetIds
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void SetBroadcastSync(
                    ContentId audio , params int[] targetIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.SetBroadcast(
                                audio,targetIds
                            )
                        );
                    task.Wait();
                    
                }
            }

            public MethodGroup_Auth Auth {get; private set;}

            public partial class MethodGroup_Auth {
                private readonly Api _parent;
                internal MethodGroup_Auth(Api parent){_parent=parent;}
                public async Task <bool> CheckPhone(
                    string phone , string clientSecret ,  int? clientId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Auth.CheckPhone(
                                phone,clientSecret,clientId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public bool CheckPhoneSync(
                    string phone , string clientSecret ,  int? clientId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Auth.CheckPhone(
                                phone,clientSecret,clientId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <ConfirmResult> Confirm(
                    int clientId , string clientSecret , string phone , string code , string password = "", bool testMode = false,  int? intro = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Auth.Confirm(
                                clientId,clientSecret,phone,code,password,testMode,intro
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public ConfirmResult ConfirmSync(
                    int clientId , string clientSecret , string phone , string code , string password = "", bool testMode = false,  int? intro = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Auth.Confirm(
                                clientId,clientSecret,phone,code,password,testMode,intro
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <AuthRestore> Restore(
                     long phone 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Auth.Restore(
                                phone
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public AuthRestore RestoreSync(
                     long phone 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Auth.Restore(
                                phone
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
            }

            public MethodGroup_Board Board {get; private set;}

            public partial class MethodGroup_Board {
                private readonly Api _parent;
                internal MethodGroup_Board(Api parent){_parent=parent;}
                public async Task  CloseTopic(
                    int groupId ,  int topicId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Board.CloseTopic(
                                groupId,topicId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void CloseTopicSync(
                    int groupId ,  int topicId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Board.CloseTopic(
                                groupId,topicId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  DeleteComment(
                    int groupId , int topicId ,  int commentId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Board.DeleteComment(
                                groupId,topicId,commentId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteCommentSync(
                    int groupId , int topicId ,  int commentId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Board.DeleteComment(
                                groupId,topicId,commentId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  DeleteTopic(
                    int groupId ,  int topicId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Board.DeleteTopic(
                                groupId,topicId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteTopicSync(
                    int groupId ,  int topicId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Board.DeleteTopic(
                                groupId,topicId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  FixTopic(
                    int groupId ,  int topicId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Board.FixTopic(
                                groupId,topicId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void FixTopicSync(
                    int groupId ,  int topicId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Board.FixTopic(
                                groupId,topicId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  RestoreComment(
                    int groupId , int topicId ,  int commentId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Board.RestoreComment(
                                groupId,topicId,commentId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void RestoreCommentSync(
                    int groupId , int topicId ,  int commentId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Board.RestoreComment(
                                groupId,topicId,commentId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  UnfixTopic(
                    int groupId ,  int topicId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Board.UnfixTopic(
                                groupId,topicId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void UnfixTopicSync(
                    int groupId ,  int topicId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Board.UnfixTopic(
                                groupId,topicId
                            )
                        );
                    task.Wait();
                    
                }
            }

            public MethodGroup_Database Database {get; private set;}

            public partial class MethodGroup_Database {
                private readonly Api _parent;
                internal MethodGroup_Database(Api parent){_parent=parent;}
                public async Task <EntityList<DatabaseEntry>> GetChairs(
                     int facultyId , int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetChairs(
                                facultyId,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<DatabaseEntry> GetChairsSync(
                     int facultyId , int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetChairs(
                                facultyId,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <DatabaseCity[]> GetCities(
                    int countryId , int? regionId = null, string q = "",  bool needAll = false, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetCities(
                                countryId,regionId,q,needAll,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public DatabaseCity[] GetCitiesSync(
                    int countryId , int? regionId = null, string q = "",  bool needAll = false, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetCities(
                                countryId,regionId,q,needAll,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <DatabaseCity[]> GetCitiesById(
                    params int[] cityIds 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetCitiesById(
                                cityIds
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public DatabaseCity[] GetCitiesByIdSync(
                    params int[] cityIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetCitiesById(
                                cityIds
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<DatabaseEntry>> GetCountries(
                    string code = "",  bool needAll = false, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetCountries(
                                code,needAll,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<DatabaseEntry> GetCountriesSync(
                    string code = "",  bool needAll = false, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetCountries(
                                code,needAll,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <DatabaseEntry[]> GetCountriesById(
                    params int[] countryIds 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetCountriesById(
                                countryIds
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public DatabaseEntry[] GetCountriesByIdSync(
                    params int[] countryIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetCountriesById(
                                countryIds
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<DatabaseEntry>> GetFaculties(
                     int universityId , int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetFaculties(
                                universityId,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<DatabaseEntry> GetFacultiesSync(
                     int universityId , int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetFaculties(
                                universityId,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<DatabaseEntry>> GetRegions(
                    int countryId ,  string q = "", int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetRegions(
                                countryId,q,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<DatabaseEntry> GetRegionsSync(
                    int countryId ,  string q = "", int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetRegions(
                                countryId,q,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <DatabaseEntry[]> GetSchools(
                    int? cityId = null,  string q = "", int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetSchools(
                                cityId,q,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public DatabaseEntry[] GetSchoolsSync(
                    int? cityId = null,  string q = "", int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetSchools(
                                cityId,q,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <DatabaseClass[]> GetSchoolClasses(
                     int countryId 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetSchoolClasses(
                                countryId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public DatabaseClass[] GetSchoolClassesSync(
                     int countryId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetSchoolClasses(
                                countryId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <DatabaseEntry[]> GetStreetsById(
                    params int[] streetIds 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetStreetsById(
                                streetIds
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public DatabaseEntry[] GetStreetsByIdSync(
                    params int[] streetIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetStreetsById(
                                streetIds
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <DatabaseEntry[]> GetUniversities(
                    int? countryId = null, int? cityId = null,  string q = "", int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetUniversities(
                                countryId,cityId,q,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public DatabaseEntry[] GetUniversitiesSync(
                    int? countryId = null, int? cityId = null,  string q = "", int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetUniversities(
                                countryId,cityId,q,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
            }

            public MethodGroup_Docs Docs {get; private set;}

            public partial class MethodGroup_Docs {
                private readonly Api _parent;
                internal MethodGroup_Docs(Api parent){_parent=parent;}
                public async Task <int> Add(
                    long docId , int ownerId ,  string accessKey = ""
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Docs.Add(
                                docId,ownerId,accessKey
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public int AddSync(
                    long docId , int ownerId ,  string accessKey = ""
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Docs.Add(
                                docId,ownerId,accessKey
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task  Delete(
                    long docId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Docs.Delete(
                                docId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteSync(
                    long docId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Docs.Delete(
                                docId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task <EntityList<Document>> Get(
                     int? ownerId = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Docs.Get(
                                ownerId,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<Document> GetSync(
                     int? ownerId = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Docs.Get(
                                ownerId,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <Document[]> GetById(
                    params ContentId[] docs 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Docs.GetById(
                                docs
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public Document[] GetByIdSync(
                    params ContentId[] docs 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Docs.GetById(
                                docs
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <string> GetUploadServer(
                     int? groupId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Docs.GetUploadServer(
                                groupId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public string GetUploadServerSync(
                     int? groupId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Docs.GetUploadServer(
                                groupId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <string> GetWallUploadServer(
                     int? groupId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Docs.GetWallUploadServer(
                                groupId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public string GetWallUploadServerSync(
                     int? groupId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Docs.GetWallUploadServer(
                                groupId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <Document[]> Save(
                    string file , string title , params string[] tags 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Docs.Save(
                                file,title,tags
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public Document[] SaveSync(
                    string file , string title , params string[] tags 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Docs.Save(
                                file,title,tags
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
            }

            public MethodGroup_Fave Fave {get; private set;}

            public partial class MethodGroup_Fave {
                private readonly Api _parent;
                internal MethodGroup_Fave(Api parent){_parent=parent;}
                public async Task <EntityList<Link>> GetLinks(
                    int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.GetLinks(
                                offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<Link> GetLinksSync(
                    int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.GetLinks(
                                offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<User>> GetUsers(
                    int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.GetUsers(
                                offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<User> GetUsersSync(
                    int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.GetUsers(
                                offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<Photo>> GetPhotos(
                    int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.GetPhotos(
                                offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<Photo> GetPhotosSync(
                    int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.GetPhotos(
                                offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<Post>> GetPosts(
                    int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.GetPosts(
                                offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<Post> GetPostsSync(
                    int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.GetPosts(
                                offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<Video>> GetVideos(
                    int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.GetVideos(
                                offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<Video> GetVideosSync(
                    int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.GetVideos(
                                offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task  RemoveUser(
                     int userId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.RemoveUser(
                                userId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void RemoveUserSync(
                     int userId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.RemoveUser(
                                userId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  RemoveLink(
                     int linkId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.RemoveLink(
                                linkId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void RemoveLinkSync(
                     int linkId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.RemoveLink(
                                linkId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  RemoveGroup(
                     int groupId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.RemoveGroup(
                                groupId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void RemoveGroupSync(
                     int groupId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.RemoveGroup(
                                groupId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  AddGroup(
                     int groupId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.AddGroup(
                                groupId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void AddGroupSync(
                     int groupId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.AddGroup(
                                groupId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  AddUser(
                     int userId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.AddUser(
                                userId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void AddUserSync(
                     int userId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.AddUser(
                                userId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  AddLink(
                    string link ,  string text = ""
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.AddLink(
                                link,text
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void AddLinkSync(
                    string link ,  string text = ""
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.AddLink(
                                link,text
                            )
                        );
                    task.Wait();
                    
                }
            }

            public MethodGroup_Friends Friends {get; private set;}

            public partial class MethodGroup_Friends {
                private readonly Api _parent;
                internal MethodGroup_Friends(Api parent){_parent=parent;}
                public async Task <AddFriendResult> Add(
                    int userId ,  string text = ""
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.Add(
                                userId,text
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public AddFriendResult AddSync(
                    int userId ,  string text = ""
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.Add(
                                userId,text
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <AddFriendsList> AddList(
                    string name , params int[] userIds 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.AddList(
                                name,userIds
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public AddFriendsList AddListSync(
                    string name , params int[] userIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.AddList(
                                name,userIds
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <FriendshipStatus[]> AreFriends(
                    bool needSign = false, params int[] userIds 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.AreFriends(
                                needSign,userIds
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public FriendshipStatus[] AreFriendsSync(
                    bool needSign = false, params int[] userIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.AreFriends(
                                needSign,userIds
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <FriendsDelete> Delete(
                     int userId 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.Delete(
                                userId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public FriendsDelete DeleteSync(
                     int userId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.Delete(
                                userId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task  DeleteAllRequests(
                    
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.DeleteAllRequests(
                                
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteAllRequestsSync(
                    
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.DeleteAllRequests(
                                
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  DeleteList(
                     int listId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.DeleteList(
                                listId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteListSync(
                     int listId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.DeleteList(
                                listId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  Edit(
                    int userId , params long[] listIds 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.Edit(
                                userId,listIds
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void EditSync(
                    int userId , params long[] listIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.Edit(
                                userId,listIds
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  EditList(
                    long listId , string name = "", int[] userIds = null, int[] addUserIds = null, params int[] deleteUserIds 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.EditList(
                                listId,name,userIds,addUserIds,deleteUserIds
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void EditListSync(
                    long listId , string name = "", int[] userIds = null, int[] addUserIds = null, params int[] deleteUserIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.EditList(
                                listId,name,userIds,addUserIds,deleteUserIds
                            )
                        );
                    task.Wait();
                    
                }
                public async Task <EntityList<FriendsList>> GetLists(
                    int? userId = null,  bool returnSystem = true
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetLists(
                                userId,returnSystem
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<FriendsList> GetListsSync(
                    int? userId = null,  bool returnSystem = true
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetLists(
                                userId,returnSystem
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<User>> Get(
                    int? userId = null, int? listId = null, UserFields fields = UserFields.Anything, UserSortOrder order = UserSortOrder.ById,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.Get(
                                userId,listId,fields,order,nameCase,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<User> GetSync(
                    int? userId = null, int? listId = null, UserFields fields = UserFields.Anything, UserSortOrder order = UserSortOrder.ById,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.Get(
                                userId,listId,fields,order,nameCase,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<int>> GetIds(
                    int? userId = null, int? listId = null,  UserSortOrder order = UserSortOrder.ById, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetIds(
                                userId,listId,order,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<int> GetIdsSync(
                    int? userId = null, int? listId = null,  UserSortOrder order = UserSortOrder.ById, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetIds(
                                userId,listId,order,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<int>> GetAvailableForCallIds(
                    
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetAvailableForCallIds(
                                
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<int> GetAvailableForCallIdsSync(
                    
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetAvailableForCallIds(
                                
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<User>> GetAvailableForCall(
                    UserFields fields = UserFields.Anything,  NameCase nameCase = NameCase.Nom
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetAvailableForCall(
                                fields,nameCase
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<User> GetAvailableForCallSync(
                    UserFields fields = UserFields.Anything,  NameCase nameCase = NameCase.Nom
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetAvailableForCall(
                                fields,nameCase
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<int>> Get(
                    int? userId = null, int? listId = null,  UserSortOrder order = UserSortOrder.ById, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.Get(
                                userId,listId,order,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<int> GetSync(
                    int? userId = null, int? listId = null,  UserSortOrder order = UserSortOrder.ById, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.Get(
                                userId,listId,order,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <int[]> GetAppUsers(
                    
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetAppUsers(
                                
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public int[] GetAppUsersSync(
                    
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetAppUsers(
                                
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <User[]> GetByPhones(
                    UserFields fields = UserFields.None, params ulong[] phones 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetByPhones(
                                fields,phones
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public User[] GetByPhonesSync(
                    UserFields fields = UserFields.None, params ulong[] phones 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetByPhones(
                                fields,phones
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <int[]> GetMutual(
                    int targetUid , int? sourceUid = null,  bool order = false, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetMutual(
                                targetUid,sourceUid,order,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public int[] GetMutualSync(
                    int targetUid , int? sourceUid = null,  bool order = false, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetMutual(
                                targetUid,sourceUid,order,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <int[]> GetOnline(
                    int? userId = null, int? listId = null,  UserSortOrder? order = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetOnline(
                                userId,listId,order,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public int[] GetOnlineSync(
                    int? userId = null, int? listId = null,  UserSortOrder? order = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetOnline(
                                userId,listId,order,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <int[]> GetRecent(
                     int count = 20
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetRecent(
                                count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public int[] GetRecentSync(
                     int count = 20
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetRecent(
                                count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<User>> GetSuggestions(
                    FriendSuggestionFilters filters = FriendSuggestionFilters.Everything, UserFields fields = UserFields.None,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetSuggestions(
                                filters,fields,nameCase,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<User> GetSuggestionsSync(
                    FriendSuggestionFilters filters = FriendSuggestionFilters.Everything, UserFields fields = UserFields.None,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetSuggestions(
                                filters,fields,nameCase,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<User>> Search(
                    int userId , string q = "",  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 20
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.Search(
                                userId,q,nameCase,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<User> SearchSync(
                    int userId , string q = "",  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 20
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.Search(
                                userId,q,nameCase,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
            }

            public MethodGroup_Groups Groups {get; private set;}

            public partial class MethodGroup_Groups {
                private readonly Api _parent;
                internal MethodGroup_Groups(Api parent){_parent=parent;}
                public async Task <Link> AddLink(
                    int groupId , string link ,  string text = ""
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.AddLink(
                                groupId,link,text
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public Link AddLinkSync(
                    int groupId , string link ,  string text = ""
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.AddLink(
                                groupId,link,text
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task  ApproveRequest(
                    int groupId ,  int userId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.ApproveRequest(
                                groupId,userId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void ApproveRequestSync(
                    int groupId ,  int userId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.ApproveRequest(
                                groupId,userId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task <Group> Create(
                    string title , PageType type = PageType.Group, PageSubtype? subtype = null,  string description = ""
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.Create(
                                title,type,subtype,description
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public Group CreateSync(
                    string title , PageType type = PageType.Group, PageSubtype? subtype = null,  string description = ""
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.Create(
                                title,type,subtype,description
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task  DeleteLink(
                    int groupId ,  int linkId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.DeleteLink(
                                groupId,linkId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteLinkSync(
                    int groupId ,  int linkId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.DeleteLink(
                                groupId,linkId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  Edit(
                    int groupId , string title = "", string description = "", string screenName = "", string website = "", string email = "", string phone = "", string rss = "", DateTimeOffset? eventStartDate = null, DateTimeOffset? eventFinishDate = null, DateTimeOffset? eventGroupId = null, int? subject = null, int? publicCategory = null, int? publicSubcategory = null, GroupAccess? access = null, AccessType? wall = null, AccessType? topics = null, AccessType? photos = null, AccessType? video = null, AccessType? audio = null, Date? publicDate = null, bool? links = null, bool? events = null, bool? places = null,  bool? contacts = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.Edit(
                                groupId,title,description,screenName,website,email,phone,rss,eventStartDate,eventFinishDate,eventGroupId,subject,publicCategory,publicSubcategory,access,wall,topics,photos,video,audio,publicDate,links,events,places,contacts
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void EditSync(
                    int groupId , string title = "", string description = "", string screenName = "", string website = "", string email = "", string phone = "", string rss = "", DateTimeOffset? eventStartDate = null, DateTimeOffset? eventFinishDate = null, DateTimeOffset? eventGroupId = null, int? subject = null, int? publicCategory = null, int? publicSubcategory = null, GroupAccess? access = null, AccessType? wall = null, AccessType? topics = null, AccessType? photos = null, AccessType? video = null, AccessType? audio = null, Date? publicDate = null, bool? links = null, bool? events = null, bool? places = null,  bool? contacts = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.Edit(
                                groupId,title,description,screenName,website,email,phone,rss,eventStartDate,eventFinishDate,eventGroupId,subject,publicCategory,publicSubcategory,access,wall,topics,photos,video,audio,publicDate,links,events,places,contacts
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  EditLink(
                    int groupId , int linkId ,  string text = ""
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.EditLink(
                                groupId,linkId,text
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void EditLinkSync(
                    int groupId , int linkId ,  string text = ""
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.EditLink(
                                groupId,linkId,text
                            )
                        );
                    task.Wait();
                    
                }
                public async Task <EntityList<int>> Get(
                    int userId ,  GroupsGetFilter? filter = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.Get(
                                userId,filter,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<int> GetSync(
                    int userId ,  GroupsGetFilter? filter = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.Get(
                                userId,filter,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <User[]> GetBanned(
                     int groupId , int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetBanned(
                                groupId,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public User[] GetBannedSync(
                     int groupId , int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetBanned(
                                groupId,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <Group[]> GetById(
                    string[] groupIds ,  GroupFields fields 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetById(
                                groupIds,fields
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public Group[] GetByIdSync(
                    string[] groupIds ,  GroupFields fields 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetById(
                                groupIds,fields
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <Group[]> GetById(
                    int groupId ,  GroupFields fields 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetById(
                                groupId,fields
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public Group[] GetByIdSync(
                    int groupId ,  GroupFields fields 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetById(
                                groupId,fields
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<int>> GetMembers(
                    string groupId , GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetMembers(
                                groupId,filter,sort,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<int> GetMembersSync(
                    string groupId , GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetMembers(
                                groupId,filter,sort,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<int>> GetMembers(
                    int groupId , GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetMembers(
                                groupId,filter,sort,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<int> GetMembersSync(
                    int groupId , GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetMembers(
                                groupId,filter,sort,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<GroupManager>> GetMembersManagers(
                    string groupId ,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetMembersManagers(
                                groupId,sort,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<GroupManager> GetMembersManagersSync(
                    string groupId ,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetMembersManagers(
                                groupId,sort,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<GroupManager>> GetMembersManagers(
                    int groupId ,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetMembersManagers(
                                groupId,sort,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<GroupManager> GetMembersManagersSync(
                    int groupId ,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetMembersManagers(
                                groupId,sort,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<User>> GetMembers(
                    string groupId , UserFields fields = UserFields.Anything, GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetMembers(
                                groupId,fields,filter,sort,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<User> GetMembersSync(
                    string groupId , UserFields fields = UserFields.Anything, GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetMembers(
                                groupId,fields,filter,sort,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<User>> GetMembers(
                    int groupId , UserFields fields = UserFields.Anything, GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetMembers(
                                groupId,fields,filter,sort,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<User> GetMembersSync(
                    int groupId , UserFields fields = UserFields.Anything, GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetMembers(
                                groupId,fields,filter,sort,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <bool> IsMember(
                    int groupId ,  int? userId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.IsMember(
                                groupId,userId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public bool IsMemberSync(
                    int groupId ,  int? userId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.IsMember(
                                groupId,userId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task  Invite(
                    int groupId ,  int userId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.Invite(
                                groupId,userId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void InviteSync(
                    int groupId ,  int userId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.Invite(
                                groupId,userId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task <MemberShip> IsMemberExtended(
                    int groupId ,  int? userId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.IsMemberExtended(
                                groupId,userId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public MemberShip IsMemberExtendedSync(
                    int groupId ,  int? userId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.IsMemberExtended(
                                groupId,userId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <MemberShip[]> IsMember(
                    int groupId , params int[] userIds 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.IsMember(
                                groupId,userIds
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public MemberShip[] IsMemberSync(
                    int groupId , params int[] userIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.IsMember(
                                groupId,userIds
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task  Join(
                    int groupId ,  bool notSure = false
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.Join(
                                groupId,notSure
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void JoinSync(
                    int groupId ,  bool notSure = false
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.Join(
                                groupId,notSure
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  Leave(
                     int groupId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.Leave(
                                groupId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void LeaveSync(
                     int groupId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.Leave(
                                groupId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  UnbanUser(
                    int groupId ,  int userId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.UnbanUser(
                                groupId,userId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void UnbanUserSync(
                    int groupId ,  int userId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.UnbanUser(
                                groupId,userId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  RemoveUser(
                    int groupId ,  int userId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.RemoveUser(
                                groupId,userId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void RemoveUserSync(
                    int groupId ,  int userId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.RemoveUser(
                                groupId,userId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  ReorderLink(
                    int groupId , long linkId ,  long after = 0
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.ReorderLink(
                                groupId,linkId,after
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void ReorderLinkSync(
                    int groupId , long linkId ,  long after = 0
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.ReorderLink(
                                groupId,linkId,after
                            )
                        );
                    task.Wait();
                    
                }
            }

            public MethodGroup_Messages Messages {get; private set;}

            public partial class MethodGroup_Messages {
                private readonly Api _parent;
                internal MethodGroup_Messages(Api parent){_parent=parent;}
                public async Task  AddChatUser(
                    int userId ,  int? chatId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.AddChatUser(
                                userId,chatId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void AddChatUserSync(
                    int userId ,  int? chatId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.AddChatUser(
                                userId,chatId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  Delete(
                    params int[] messageIds 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.Delete(
                                messageIds
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteSync(
                    params int[] messageIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.Delete(
                                messageIds
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  DeleteChatPhoto(
                     int chatId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.DeleteChatPhoto(
                                chatId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteChatPhotoSync(
                     int chatId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.DeleteChatPhoto(
                                chatId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  DeleteDialog(
                     int userId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.DeleteDialog(
                                userId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteDialogSync(
                     int userId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.DeleteDialog(
                                userId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task <EntityList<Message>> Get(
                    int @out = 0, int timeOffset = 0, int filters = 0, int previewLength = 0,  long? lastMessageId = null, int? offset = null, int? count = 200
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.Get(
                                @out,timeOffset,filters,previewLength,lastMessageId,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<Message> GetSync(
                    int @out = 0, int timeOffset = 0, int filters = 0, int previewLength = 0,  long? lastMessageId = null, int? offset = null, int? count = 200
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.Get(
                                @out,timeOffset,filters,previewLength,lastMessageId,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<Message>> GetHistoryChat(
                    int chatId , bool rev = false,  long? startMessageId = null, int? offset = null, int? count = 200
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.GetHistoryChat(
                                chatId,rev,startMessageId,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<Message> GetHistoryChatSync(
                    int chatId , bool rev = false,  long? startMessageId = null, int? offset = null, int? count = 200
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.GetHistoryChat(
                                chatId,rev,startMessageId,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<Message>> GetHistoryUser(
                    int userId , bool rev = false,  long? startMessageId = null, int? offset = null, int? count = 200
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.GetHistoryUser(
                                userId,rev,startMessageId,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<Message> GetHistoryUserSync(
                    int userId , bool rev = false,  long? startMessageId = null, int? offset = null, int? count = 200
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.GetHistoryUser(
                                userId,rev,startMessageId,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <LastActivity> GetLastActivity(
                     int userId 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.GetLastActivity(
                                userId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public LastActivity GetLastActivitySync(
                     int userId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.GetLastActivity(
                                userId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task  MarkAsImportant(
                    bool important , params int[] messageIds 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.MarkAsImportant(
                                important,messageIds
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void MarkAsImportantSync(
                    bool important , params int[] messageIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.MarkAsImportant(
                                important,messageIds
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  MarkAsRead(
                    int userId , int? startMessageId = null, params int[] messageIds 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.MarkAsRead(
                                userId,startMessageId,messageIds
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void MarkAsReadSync(
                    int userId , int? startMessageId = null, params int[] messageIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.MarkAsRead(
                                userId,startMessageId,messageIds
                            )
                        );
                    task.Wait();
                    
                }
                public async Task <int> Send(
                    int? userId = null, int[] userIds = null, string domain = null, int? chatId = null, string message = null, int? guid = null, double? lat = null, double? @long = null, ContentId[] attachment = null, long[] forwardMessages = null,  int? stickerId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.Send(
                                userId,userIds,domain,chatId,message,guid,lat,@long,attachment,forwardMessages,stickerId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public int SendSync(
                    int? userId = null, int[] userIds = null, string domain = null, int? chatId = null, string message = null, int? guid = null, double? lat = null, double? @long = null, ContentId[] attachment = null, long[] forwardMessages = null,  int? stickerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.Send(
                                userId,userIds,domain,chatId,message,guid,lat,@long,attachment,forwardMessages,stickerId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task  RemoveChatUser(
                    int userId ,  int chatId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.RemoveChatUser(
                                userId,chatId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void RemoveChatUserSync(
                    int userId ,  int chatId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.RemoveChatUser(
                                userId,chatId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  Restore(
                     int messageId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.Restore(
                                messageId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void RestoreSync(
                     int messageId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.Restore(
                                messageId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  SetActivity(
                    int userId ,  ImActivity type = ImActivity.Typing
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.SetActivity(
                                userId,type
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void SetActivitySync(
                    int userId ,  ImActivity type = ImActivity.Typing
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.SetActivity(
                                userId,type
                            )
                        );
                    task.Wait();
                    
                }
            }

            public MethodGroup_Newsfeed Newsfeed {get; private set;}

            public partial class MethodGroup_Newsfeed {
                private readonly Api _parent;
                internal MethodGroup_Newsfeed(Api parent){_parent=parent;}
                public async Task  AddBan(
                    int[] userIds = null, params int[] groupIds 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Newsfeed.AddBan(
                                userIds,groupIds
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void AddBanSync(
                    int[] userIds = null, params int[] groupIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Newsfeed.AddBan(
                                userIds,groupIds
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  DeleteBan(
                    int[] userIds = null, params int[] groupIds 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Newsfeed.DeleteBan(
                                userIds,groupIds
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteBanSync(
                    int[] userIds = null, params int[] groupIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Newsfeed.DeleteBan(
                                userIds,groupIds
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  DeleteList(
                     int listId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Newsfeed.DeleteList(
                                listId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteListSync(
                     int listId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Newsfeed.DeleteList(
                                listId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task <NewsfeedBanned> GetBanned(
                    
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Newsfeed.GetBanned(
                                
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public NewsfeedBanned GetBannedSync(
                    
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Newsfeed.GetBanned(
                                
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <NewsfeedBannedExtended> GetBannedExtended(
                    UserFields fields = UserFields.None,  NameCase nameCase = NameCase.Nom
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Newsfeed.GetBannedExtended(
                                fields,nameCase
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public NewsfeedBannedExtended GetBannedExtendedSync(
                    UserFields fields = UserFields.None,  NameCase nameCase = NameCase.Nom
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Newsfeed.GetBannedExtended(
                                fields,nameCase
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
            }

            public MethodGroup_Notes Notes {get; private set;}

            public partial class MethodGroup_Notes {
                private readonly Api _parent;
                internal MethodGroup_Notes(Api parent){_parent=parent;}
                public async Task  Delete(
                     int noteId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Notes.Delete(
                                noteId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteSync(
                     int noteId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Notes.Delete(
                                noteId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  DeleteComment(
                    int commentId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Notes.DeleteComment(
                                commentId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteCommentSync(
                    int commentId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Notes.DeleteComment(
                                commentId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  RestoreComment(
                    int commentId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Notes.RestoreComment(
                                commentId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void RestoreCommentSync(
                    int commentId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Notes.RestoreComment(
                                commentId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
            }

            public MethodGroup_Notifications Notifications {get; private set;}

            public partial class MethodGroup_Notifications {
                private readonly Api _parent;
                internal MethodGroup_Notifications(Api parent){_parent=parent;}
                public async Task  MarkAsViewed(
                    
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Notifications.MarkAsViewed(
                                
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void MarkAsViewedSync(
                    
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Notifications.MarkAsViewed(
                                
                            )
                        );
                    task.Wait();
                    
                }
            }

            public MethodGroup_Pages Pages {get; private set;}

            public partial class MethodGroup_Pages {
                private readonly Api _parent;
                internal MethodGroup_Pages(Api parent){_parent=parent;}
                public async Task  ClearCache(
                     string url 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Pages.ClearCache(
                                url
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void ClearCacheSync(
                     string url 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Pages.ClearCache(
                                url
                            )
                        );
                    task.Wait();
                    
                }
            }

            public MethodGroup_Photos Photos {get; private set;}

            public partial class MethodGroup_Photos {
                private readonly Api _parent;
                internal MethodGroup_Photos(Api parent){_parent=parent;}
                public async Task  ConfirmTag(
                    int tagId , long photoId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.ConfirmTag(
                                tagId,photoId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void ConfirmTagSync(
                    int tagId , long photoId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.ConfirmTag(
                                tagId,photoId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task <long> Copy(
                    long photoId , int? ownerId = null,  string accessKey = ""
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Copy(
                                photoId,ownerId,accessKey
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public long CopySync(
                    long photoId , int? ownerId = null,  string accessKey = ""
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Copy(
                                photoId,ownerId,accessKey
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <PhotoAlbum> CreateAlbum(
                    string title , string description = "", int? groupId = null, PrivacyType? privacy = null,  PrivacyType? commentPrivacy = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.CreateAlbum(
                                title,description,groupId,privacy,commentPrivacy
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public PhotoAlbum CreateAlbumSync(
                    string title , string description = "", int? groupId = null, PrivacyType? privacy = null,  PrivacyType? commentPrivacy = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.CreateAlbum(
                                title,description,groupId,privacy,commentPrivacy
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task  Delete(
                    long photoId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Delete(
                                photoId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteSync(
                    long photoId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Delete(
                                photoId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  DeleteAlbum(
                    long albumId ,  int? groupId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.DeleteAlbum(
                                albumId,groupId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteAlbumSync(
                    long albumId ,  int? groupId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.DeleteAlbum(
                                albumId,groupId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  DeleteComment(
                    int commentId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.DeleteComment(
                                commentId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteCommentSync(
                    int commentId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.DeleteComment(
                                commentId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  Edit(
                    long photoId , int? ownerId = null,  string caption = ""
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Edit(
                                photoId,ownerId,caption
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void EditSync(
                    long photoId , int? ownerId = null,  string caption = ""
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Edit(
                                photoId,ownerId,caption
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  EditAlbum(
                    long albumId , int? ownerId = null, string title = "", string description = "", PrivacyType? privacy = null,  PrivacyType? commentPrivacy = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.EditAlbum(
                                albumId,ownerId,title,description,privacy,commentPrivacy
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void EditAlbumSync(
                    long albumId , int? ownerId = null, string title = "", string description = "", PrivacyType? privacy = null,  PrivacyType? commentPrivacy = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.EditAlbum(
                                albumId,ownerId,title,description,privacy,commentPrivacy
                            )
                        );
                    task.Wait();
                    
                }
                public async Task <EntityList<Photo>> Get(
                    long? albumId = null, int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null,  int? feed = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Get(
                                albumId,ownerId,photoIds,rev,extended,feedType,feed,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<Photo> GetSync(
                    long? albumId = null, int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null,  int? feed = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Get(
                                albumId,ownerId,photoIds,rev,extended,feedType,feed,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<Photo>> Get(
                    SpecialAlbum albumId , int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null,  int? feed = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Get(
                                albumId,ownerId,photoIds,rev,extended,feedType,feed,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<Photo> GetSync(
                    SpecialAlbum albumId , int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null,  int? feed = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Get(
                                albumId,ownerId,photoIds,rev,extended,feedType,feed,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<PhotoAlbum>> GetAlbums(
                    int? ownerId = null, bool needSystem = true, bool needCovers = true, int? offset = null, int? count = 100, params long[] albumIds 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetAlbums(
                                ownerId,needSystem,needCovers,offset, count,albumIds
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<PhotoAlbum> GetAlbumsSync(
                    int? ownerId = null, bool needSystem = true, bool needCovers = true, int? offset = null, int? count = 100, params long[] albumIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetAlbums(
                                ownerId,needSystem,needCovers,offset, count,albumIds
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <int> GetAlbumsCount(
                    int? userId = null,  int? groupId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetAlbumsCount(
                                userId,groupId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public int GetAlbumsCountSync(
                    int? userId = null,  int? groupId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetAlbumsCount(
                                userId,groupId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<Photo>> GetAll(
                    int? ownerId = null, bool extended = false, bool noServiceAlbums = false, bool? needHidden = null,  bool? skipHidden = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetAll(
                                ownerId,extended,noServiceAlbums,needHidden,skipHidden,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<Photo> GetAllSync(
                    int? ownerId = null, bool extended = false, bool noServiceAlbums = false, bool? needHidden = null,  bool? skipHidden = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetAll(
                                ownerId,extended,noServiceAlbums,needHidden,skipHidden,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <Photo[]> GetById(
                    params ContentId[] photos 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetById(
                                photos
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public Photo[] GetByIdSync(
                    params ContentId[] photos 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetById(
                                photos
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <PhotosUploadServer> GetChatUploadServer(
                    int chatId , int? cropX = null, int? cropY = null,  int? cropWidth = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetChatUploadServer(
                                chatId,cropX,cropY,cropWidth
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public PhotosUploadServer GetChatUploadServerSync(
                    int chatId , int? cropX = null, int? cropY = null,  int? cropWidth = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetChatUploadServer(
                                chatId,cropX,cropY,cropWidth
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <string> GetOwnerPhotoUploadServer(
                    
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetOwnerPhotoUploadServer(
                                
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public string GetOwnerPhotoUploadServerSync(
                    
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetOwnerPhotoUploadServer(
                                
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <PhotoTag[]> GetTags(
                    long photoId , int? ownerId = null,  string accessKey = ""
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetTags(
                                photoId,ownerId,accessKey
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public PhotoTag[] GetTagsSync(
                    long photoId , int? ownerId = null,  string accessKey = ""
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetTags(
                                photoId,ownerId,accessKey
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <PhotosUploadServer> GetUploadServer(
                    long albumId ,  int? groupId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetUploadServer(
                                albumId,groupId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public PhotosUploadServer GetUploadServerSync(
                    long albumId ,  int? groupId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetUploadServer(
                                albumId,groupId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task  MakeCover(
                    long albumId , long photoId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.MakeCover(
                                albumId,photoId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void MakeCoverSync(
                    long albumId , long photoId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.MakeCover(
                                albumId,photoId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  Move(
                    long targetAlbumId , long photoId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Move(
                                targetAlbumId,photoId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void MoveSync(
                    long targetAlbumId , long photoId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Move(
                                targetAlbumId,photoId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  RemoveTag(
                    int tagId , long photoId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.RemoveTag(
                                tagId,photoId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void RemoveTagSync(
                    int tagId , long photoId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.RemoveTag(
                                tagId,photoId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  ReorderAlbums(
                    long albumId , int? ownerId = null, long? before = null,  long? after = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.ReorderAlbums(
                                albumId,ownerId,before,after
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void ReorderAlbumsSync(
                    long albumId , int? ownerId = null, long? before = null,  long? after = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.ReorderAlbums(
                                albumId,ownerId,before,after
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  ReorderPhotos(
                    long photoId , int? ownerId = null, long? before = null,  long? after = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.ReorderPhotos(
                                photoId,ownerId,before,after
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void ReorderPhotosSync(
                    long photoId , int? ownerId = null, long? before = null,  long? after = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.ReorderPhotos(
                                photoId,ownerId,before,after
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  Report(
                    long photoId , int? ownerId = null,  ReportReason? reason = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Report(
                                photoId,ownerId,reason
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void ReportSync(
                    long photoId , int? ownerId = null,  ReportReason? reason = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Report(
                                photoId,ownerId,reason
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  ReportComment(
                    int commentId , int? ownerId = null,  ReportReason? reason = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.ReportComment(
                                commentId,ownerId,reason
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void ReportCommentSync(
                    int commentId , int? ownerId = null,  ReportReason? reason = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.ReportComment(
                                commentId,ownerId,reason
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  RestoreComment(
                    int commentId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.RestoreComment(
                                commentId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void RestoreCommentSync(
                    int commentId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.RestoreComment(
                                commentId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  Restore(
                    int ownerId ,  long photoId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Restore(
                                ownerId,photoId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void RestoreSync(
                    int ownerId ,  long photoId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Restore(
                                ownerId,photoId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task <Photo[]> Save(
                    long albumId , string server , string photosList , string hash , int? groupId = null, double? latitude = null, double? longitude = null, string caption = "",  string description = ""
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Save(
                                albumId,server,photosList,hash,groupId,latitude,longitude,caption,description
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public Photo[] SaveSync(
                    long albumId , string server , string photosList , string hash , int? groupId = null, double? latitude = null, double? longitude = null, string caption = "",  string description = ""
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Save(
                                albumId,server,photosList,hash,groupId,latitude,longitude,caption,description
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
            }

            public MethodGroup_Polls Polls {get; private set;}

            public partial class MethodGroup_Polls {
                private readonly Api _parent;
                internal MethodGroup_Polls(Api parent){_parent=parent;}
                public async Task <bool> AddVote(
                    long pollId , int answerId , int? ownerId = null,  bool? isBoard = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Polls.AddVote(
                                pollId,answerId,ownerId,isBoard
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public bool AddVoteSync(
                    long pollId , int answerId , int? ownerId = null,  bool? isBoard = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Polls.AddVote(
                                pollId,answerId,ownerId,isBoard
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <bool> DeleteVote(
                    long pollId , int answerId , int? ownerId = null,  bool? isBoard = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Polls.DeleteVote(
                                pollId,answerId,ownerId,isBoard
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public bool DeleteVoteSync(
                    long pollId , int answerId , int? ownerId = null,  bool? isBoard = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Polls.DeleteVote(
                                pollId,answerId,ownerId,isBoard
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
            }

            public MethodGroup_Stats Stats {get; private set;}

            public partial class MethodGroup_Stats {
                private readonly Api _parent;
                internal MethodGroup_Stats(Api parent){_parent=parent;}
                public async Task  TrackVisitor(
                    
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Stats.TrackVisitor(
                                
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void TrackVisitorSync(
                    
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Stats.TrackVisitor(
                                
                            )
                        );
                    task.Wait();
                    
                }
            }

            public MethodGroup_Status Status {get; private set;}

            public partial class MethodGroup_Status {
                private readonly Api _parent;
                internal MethodGroup_Status(Api parent){_parent=parent;}
                public async Task <Status[]> Get(
                     int? userId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Status.Get(
                                userId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public Status[] GetSync(
                     int? userId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Status.Get(
                                userId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task  Set(
                     string text 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Status.Set(
                                text
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void SetSync(
                     string text 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Status.Set(
                                text
                            )
                        );
                    task.Wait();
                    
                }
            }

            public MethodGroup_Storage Storage {get; private set;}

            public partial class MethodGroup_Storage {
                private readonly Api _parent;
                internal MethodGroup_Storage(Api parent){_parent=parent;}
                public async Task <StorageEntry[]> Get(
                    int? userId = null, bool global = false, params string[] keys 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Storage.Get(
                                userId,global,keys
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public StorageEntry[] GetSync(
                    int? userId = null, bool global = false, params string[] keys 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Storage.Get(
                                userId,global,keys
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <string[]> GetKeys(
                    int? userId = null,  bool global = false, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Storage.GetKeys(
                                userId,global,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public string[] GetKeysSync(
                    int? userId = null,  bool global = false, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Storage.GetKeys(
                                userId,global,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <StorageEntry[]> Set(
                    string key , string value , int? userId = null,  bool global = false
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Storage.Set(
                                key,value,userId,global
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public StorageEntry[] SetSync(
                    string key , string value , int? userId = null,  bool global = false
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Storage.Set(
                                key,value,userId,global
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
            }

            public MethodGroup_Users Users {get; private set;}

            public partial class MethodGroup_Users {
                private readonly Api _parent;
                internal MethodGroup_Users(Api parent){_parent=parent;}
                public async Task <User[]> Get(
                    UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, params int[] userIds 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.Get(
                                fields,nameCase,userIds
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public User[] GetSync(
                    UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, params int[] userIds 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.Get(
                                fields,nameCase,userIds
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<int>> GetFollowers(
                    int? userId = null,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.GetFollowers(
                                userId,nameCase,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<int> GetFollowersSync(
                    int? userId = null,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.GetFollowers(
                                userId,nameCase,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<User>> GetFollowers(
                    int? userId = null, UserFields fields = UserFields.Anything,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.GetFollowers(
                                userId,fields,nameCase,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<User> GetFollowersSync(
                    int? userId = null, UserFields fields = UserFields.Anything,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.GetFollowers(
                                userId,fields,nameCase,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<User>> GetNearby(
                    double latitude , double longitude , int? accuracy = null, int? timeout = null, byte? radius = null, UserFields fields = UserFields.None,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.GetNearby(
                                latitude,longitude,accuracy,timeout,radius,fields,nameCase,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<User> GetNearbySync(
                    double latitude , double longitude , int? accuracy = null, int? timeout = null, byte? radius = null, UserFields fields = UserFields.None,  NameCase nameCase = NameCase.Nom, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.GetNearby(
                                latitude,longitude,accuracy,timeout,radius,fields,nameCase,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <UserSubscriptions> GetSubscriptions(
                     int? userId = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.GetSubscriptions(
                                userId,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public UserSubscriptions GetSubscriptionsSync(
                     int? userId = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.GetSubscriptions(
                                userId,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <bool> IsAppUser(
                     int? userId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.IsAppUser(
                                userId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public bool IsAppUserSync(
                     int? userId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.IsAppUser(
                                userId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task  Report(
                    int userId , ComplaintType type ,  string comment 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.Report(
                                userId,type,comment
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void ReportSync(
                    int userId , ComplaintType type ,  string comment 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.Report(
                                userId,type,comment
                            )
                        );
                    task.Wait();
                    
                }
                public async Task <EntityList<User>> Search(
                    string q = "", SearchSortOrder sort = SearchSortOrder.ByRating, UserFields fields = UserFields.None, int? city = null, int? country = null, string hometown = "", int? universityCountry = null, int? university = null, int? universityYear = null, Sex? sex = null, Relation? status = null, byte? ageFrom = null, byte? ageTo = null, byte? birthDay = null, byte? birthMonth = null, ushort? birthYear = null, bool? online = null, bool? hasPhoto = null, int? schoolCountry = null, int? schoolCity = null, int? schoolClass = null, int? school = null, int? schoolYear = null, string religion = "", string interests = "", string company = "", string position = "", int? groupId = null,  FriendshipType? fromList = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.Search(
                                q,sort,fields,city,country,hometown,universityCountry,university,universityYear,sex,status,ageFrom,ageTo,birthDay,birthMonth,birthYear,online,hasPhoto,schoolCountry,schoolCity,schoolClass,school,schoolYear,religion,interests,company,position,groupId,fromList,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<User> SearchSync(
                    string q = "", SearchSortOrder sort = SearchSortOrder.ByRating, UserFields fields = UserFields.None, int? city = null, int? country = null, string hometown = "", int? universityCountry = null, int? university = null, int? universityYear = null, Sex? sex = null, Relation? status = null, byte? ageFrom = null, byte? ageTo = null, byte? birthDay = null, byte? birthMonth = null, ushort? birthYear = null, bool? online = null, bool? hasPhoto = null, int? schoolCountry = null, int? schoolCity = null, int? schoolClass = null, int? school = null, int? schoolYear = null, string religion = "", string interests = "", string company = "", string position = "", int? groupId = null,  FriendshipType? fromList = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.Search(
                                q,sort,fields,city,country,hometown,universityCountry,university,universityYear,sex,status,ageFrom,ageTo,birthDay,birthMonth,birthYear,online,hasPhoto,schoolCountry,schoolCity,schoolClass,school,schoolYear,religion,interests,company,position,groupId,fromList,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
            }

            public MethodGroup_Utils Utils {get; private set;}

            public partial class MethodGroup_Utils {
                private readonly Api _parent;
                internal MethodGroup_Utils(Api parent){_parent=parent;}
                public async Task <LinkCheckResult> CheckLink(
                     string url 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Utils.CheckLink(
                                url
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public LinkCheckResult CheckLinkSync(
                     string url 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Utils.CheckLink(
                                url
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <int> GetServerTime(
                    
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Utils.GetServerTime(
                                
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public int GetServerTimeSync(
                    
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Utils.GetServerTime(
                                
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <ResolveResult> ResolveScreenName(
                     string screenName 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Utils.ResolveScreenName(
                                screenName
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public ResolveResult ResolveScreenNameSync(
                     string screenName 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Utils.ResolveScreenName(
                                screenName
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
            }

            public MethodGroup_Video Video {get; private set;}

            public partial class MethodGroup_Video {
                private readonly Api _parent;
                internal MethodGroup_Video(Api parent){_parent=parent;}
                public async Task  Add(
                    ulong videoId ,  int ownerId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.Add(
                                videoId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void AddSync(
                    ulong videoId ,  int ownerId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.Add(
                                videoId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  Delete(
                    ulong videoId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.Delete(
                                videoId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteSync(
                    ulong videoId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.Delete(
                                videoId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  DeleteAlbum(
                    long albumId ,  int? groupId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.DeleteAlbum(
                                albumId,groupId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteAlbumSync(
                    long albumId ,  int? groupId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.DeleteAlbum(
                                albumId,groupId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  DeleteComment(
                    int commentId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.DeleteComment(
                                commentId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteCommentSync(
                    int commentId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.DeleteComment(
                                commentId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  EditComment(
                    string message , int commentId ,  int? ownerId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.EditComment(
                                message,commentId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void EditCommentSync(
                    string message , int commentId ,  int? ownerId 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.EditComment(
                                message,commentId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task <EntityList<TaggedVideo>> GetNewTags(
                    int? offset = null, int? count = 20
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.GetNewTags(
                                offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<TaggedVideo> GetNewTagsSync(
                    int? offset = null, int? count = 20
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.GetNewTags(
                                offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <Tag[]> GetTags(
                    long videoId ,  int? ownerId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.GetTags(
                                videoId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public Tag[] GetTagsSync(
                    long videoId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.GetTags(
                                videoId,ownerId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task  PutTag(
                    int userId , string taggedName , ulong videoId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.PutTag(
                                userId,taggedName,videoId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void PutTagSync(
                    int userId , string taggedName , ulong videoId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.PutTag(
                                userId,taggedName,videoId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  RemoveTag(
                    ulong videoId , int tagId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.RemoveTag(
                                videoId,tagId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void RemoveTagSync(
                    ulong videoId , int tagId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.RemoveTag(
                                videoId,tagId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  Report(
                    ulong videoId , int? ownerId = null, ReportReason? reason = null, string comment = "",  string searchQuery = ""
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.Report(
                                videoId,ownerId,reason,comment,searchQuery
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void ReportSync(
                    ulong videoId , int? ownerId = null, ReportReason? reason = null, string comment = "",  string searchQuery = ""
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.Report(
                                videoId,ownerId,reason,comment,searchQuery
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  ReportComment(
                    int commentId , int? ownerId = null,  ReportReason? reason = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.ReportComment(
                                commentId,ownerId,reason
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void ReportCommentSync(
                    int commentId , int? ownerId = null,  ReportReason? reason = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.ReportComment(
                                commentId,ownerId,reason
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  RestoreComment(
                    int commentId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.RestoreComment(
                                commentId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void RestoreCommentSync(
                    int commentId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.RestoreComment(
                                commentId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  Restore(
                    long videoId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.Restore(
                                videoId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void RestoreSync(
                    long videoId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Video.Restore(
                                videoId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
            }

            public MethodGroup_Wall Wall {get; private set;}

            public partial class MethodGroup_Wall {
                private readonly Api _parent;
                internal MethodGroup_Wall(Api parent){_parent=parent;}
                public async Task  Delete(
                    int postId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Delete(
                                postId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteSync(
                    int postId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Delete(
                                postId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task  DeleteComment(
                    int commentId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.DeleteComment(
                                commentId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                public void DeleteCommentSync(
                    int commentId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.DeleteComment(
                                commentId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                public async Task <EntityList<Post>> Get(
                    int ownerId ,  WallPostFilter filter = WallPostFilter.All, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Get(
                                ownerId,filter,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<Post> GetSync(
                    int ownerId ,  WallPostFilter filter = WallPostFilter.All, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Get(
                                ownerId,filter,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityList<Post>> Get(
                    string domain ,  WallPostFilter filter = WallPostFilter.All, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Get(
                                domain,filter,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityList<Post> GetSync(
                    string domain ,  WallPostFilter filter = WallPostFilter.All, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Get(
                                domain,filter,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <Post[]> GetById(
                    int copyHistoryDepth = 2, params ContentId[] posts 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.GetById(
                                copyHistoryDepth,posts
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public Post[] GetByIdSync(
                    int copyHistoryDepth = 2, params ContentId[] posts 
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.GetById(
                                copyHistoryDepth,posts
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                public async Task <EntityListExtended<Comment>> GetComments(
                    int postId , string sort , int previewLength , int extended , int? ownerId = null,  bool needLikes = false, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.GetComments(
                                postId,sort,previewLength,extended,ownerId,needLikes,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                public EntityListExtended<Comment> GetCommentsSync(
                    int postId , string sort , int previewLength , int extended , int? ownerId = null,  bool needLikes = false, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.GetComments(
                                postId,sort,previewLength,extended,ownerId,needLikes,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                ///<summary>
                ///        Позволяет получать список репостов заданной записи
                ///      
                ///</summary>
                ///<param name="postId">идентификатор записи на стене</param>
                ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находится запись, по умолчанию идентификатор текущего пользователя</param>
                public async Task <EntityListExtended<Post>> GetReposts(
                    int postId ,  int? ownerId = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.GetReposts(
                                postId,ownerId,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                ///<summary>
                ///        Позволяет получать список репостов заданной записи
                ///      
                ///</summary>
                ///<param name="postId">идентификатор записи на стене</param>
                ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находится запись, по умолчанию идентификатор текущего пользователя</param>
                public EntityListExtended<Post> GetRepostsSync(
                    int postId ,  int? ownerId = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.GetReposts(
                                postId,ownerId,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                ///<summary>
                ///        Закрепляет запись на стене
                ///      
                ///</summary>
                ///<param name="postId">идентификатор записи на стене</param>
                ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находится запись, по умолчанию идентификатор текущего пользователя</param>
                public async Task  Pin(
                    int postId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Pin(
                                postId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                ///<summary>
                ///        Закрепляет запись на стене
                ///      
                ///</summary>
                ///<param name="postId">идентификатор записи на стене</param>
                ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находится запись, по умолчанию идентификатор текущего пользователя</param>
                public void PinSync(
                    int postId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Pin(
                                postId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                ///<summary>
                ///        Публикует отложенную запись на своей или чужой стене
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
                public async Task <WallPost> Post(
                    string message = "", string attachments = "", int? ownerId = null, bool fromGroup = false, bool signed = false, bool? friendsOnly = false, string services = "", int? publishDate = null, double? lat = null, double? @long = null,  int? placeId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Post(
                                message,attachments,ownerId,fromGroup,signed,friendsOnly,services,publishDate,lat,@long,placeId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                ///<summary>
                ///        Публикует отложенную запись на своей или чужой стене
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
                public WallPost PostSync(
                    string message = "", string attachments = "", int? ownerId = null, bool fromGroup = false, bool signed = false, bool? friendsOnly = false, string services = "", int? publishDate = null, double? lat = null, double? @long = null,  int? placeId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Post(
                                message,attachments,ownerId,fromGroup,signed,friendsOnly,services,publishDate,lat,@long,placeId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
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
                public async Task <WallPost> Post(
                    int postId ,  int? ownerId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Post(
                                postId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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
                public WallPost PostSync(
                    int postId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Post(
                                postId,ownerId
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                ///<summary>
                ///        Позволяет пожаловаться на комментарий к записи
                ///      
                ///</summary>
                ///<param name="commentId">идентификатор комментария</param>
                ///<param name="ownerId">идентификатор пользователя или сообщества, которому принадлежит комментарий</param>
                ///<param name="reason">причина жалобы</param>
                public async Task  ReportComment(
                    int commentId , int? ownerId = null,  ReportReason? reason = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.ReportComment(
                                commentId,ownerId,reason
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                ///<summary>
                ///        Позволяет пожаловаться на комментарий к записи
                ///      
                ///</summary>
                ///<param name="commentId">идентификатор комментария</param>
                ///<param name="ownerId">идентификатор пользователя или сообщества, которому принадлежит комментарий</param>
                ///<param name="reason">причина жалобы</param>
                public void ReportCommentSync(
                    int commentId , int? ownerId = null,  ReportReason? reason = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.ReportComment(
                                commentId,ownerId,reason
                            )
                        );
                    task.Wait();
                    
                }
                ///<summary>
                ///        Позволяет пожаловаться на запись.
                ///      
                ///</summary>
                ///<param name="postId">идентификатор пользователя или сообщества, которому принадлежит запись</param>
                ///<param name="ownerId">идентификатор пользователя или сообщества, которому принадлежит запись</param>
                ///<param name="reason">причина жалобы</param>
                public async Task  ReportPost(
                    int postId , int? ownerId = null,  ReportReason? reason = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.ReportPost(
                                postId,ownerId,reason
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                ///<summary>
                ///        Позволяет пожаловаться на запись.
                ///      
                ///</summary>
                ///<param name="postId">идентификатор пользователя или сообщества, которому принадлежит запись</param>
                ///<param name="ownerId">идентификатор пользователя или сообщества, которому принадлежит запись</param>
                ///<param name="reason">причина жалобы</param>
                public void ReportPostSync(
                    int postId , int? ownerId = null,  ReportReason? reason = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.ReportPost(
                                postId,ownerId,reason
                            )
                        );
                    task.Wait();
                    
                }
                ///<summary>
                ///        Копирует объект на стену пользователя или сообщества
                ///      
                ///</summary>
                ///<param name="@object">идентификатор объекта, который необходимо разместить на стене</param>
                ///<param name="message">сопроводительный текст, который будет добавлен к записи с объектом</param>
                ///<param name="groupId">идентификатор сообщества, на стене которого будет размещена запись с объектом. Если не указан, запись будет размещена на стене текущего пользователя</param>
                public async Task <RepostInfo> Repost(
                    string @object , string message = "", int? groupId = null,  string @ref = ""
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Repost(
                                @object,message,groupId,@ref
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
                ///<summary>
                ///        Копирует объект на стену пользователя или сообщества
                ///      
                ///</summary>
                ///<param name="@object">идентификатор объекта, который необходимо разместить на стене</param>
                ///<param name="message">сопроводительный текст, который будет добавлен к записи с объектом</param>
                ///<param name="groupId">идентификатор сообщества, на стене которого будет размещена запись с объектом. Если не указан, запись будет размещена на стене текущего пользователя</param>
                public RepostInfo RepostSync(
                    string @object , string message = "", int? groupId = null,  string @ref = ""
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Repost(
                                @object,message,groupId,@ref
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
                ///<summary>
                ///        Восстанавливает удаленную запись на стене пользователя или сообщества
                ///      
                ///</summary>
                ///<param name="postId">идентификатор записи на стене</param>
                ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находилась удаленная запись, по умолчанию идентификатор текущего пользователя</param>
                public async Task  Restore(
                    int postId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Restore(
                                postId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                ///<summary>
                ///        Восстанавливает удаленную запись на стене пользователя или сообщества
                ///      
                ///</summary>
                ///<param name="postId">идентификатор записи на стене</param>
                ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находилась удаленная запись, по умолчанию идентификатор текущего пользователя</param>
                public void RestoreSync(
                    int postId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Restore(
                                postId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                ///<summary>
                ///        Восстанавливает комментарий текущего пользователя к записи на своей или чужой стене
                ///      
                ///</summary>
                ///<param name="commentId">идентификатор комментария на стене</param>
                ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находится комментарий к записи, по умолчанию идентификатор текущего пользователя</param>
                public async Task  RestoreComment(
                    int commentId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.RestoreComment(
                                commentId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                ///<summary>
                ///        Восстанавливает комментарий текущего пользователя к записи на своей или чужой стене
                ///      
                ///</summary>
                ///<param name="commentId">идентификатор комментария на стене</param>
                ///<param name="ownerId">идентификатор пользователя или сообщества, на стене которого находится комментарий к записи, по умолчанию идентификатор текущего пользователя</param>
                public void RestoreCommentSync(
                    int commentId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.RestoreComment(
                                commentId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
                ///<summary>
                ///        Отменяет закрепление записи на стене
                ///      
                ///</summary>
                ///<param name="postId">идентификатор записи на стене</param>
                ///<param name="ownerId">Bдентификатор пользователя или сообщества, на стене которого находится запись, по умолчанию идентификатор текущего пользователя</param>
                public async Task  Unpin(
                    int postId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Unpin(
                                postId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
                ///<summary>
                ///        Отменяет закрепление записи на стене
                ///      
                ///</summary>
                ///<param name="postId">идентификатор записи на стене</param>
                ///<param name="ownerId">Bдентификатор пользователя или сообщества, на стене которого находится запись, по умолчанию идентификатор текущего пользователя</param>
                public void UnpinSync(
                    int postId ,  int? ownerId = null
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Unpin(
                                postId,ownerId
                            )
                        );
                    task.Wait();
                    
                }
            }

            public MethodGroup_Likes Likes {get; private set;}

            public partial class MethodGroup_Likes {
                private readonly Api _parent;
                internal MethodGroup_Likes(Api parent){_parent=parent;}
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
                public async Task <EntityList<int>> GetList(
                    string type , string filter , bool friendsOnly , bool skipOwn , int? ownerId = null, int? itemId = null,  string pageUrl = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Likes.GetList(
                                type,filter,friendsOnly,skipOwn,ownerId,itemId,pageUrl,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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
                public EntityList<int> GetListSync(
                    string type , string filter , bool friendsOnly , bool skipOwn , int? ownerId = null, int? itemId = null,  string pageUrl = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Likes.GetList(
                                type,filter,friendsOnly,skipOwn,ownerId,itemId,pageUrl,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
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
                public async Task <EntityList<User>> GetListExtended(
                    string type , string filter , bool friendsOnly , bool skipOwn , int? ownerId = null, int? itemId = null,  string pageUrl = null, int? offset = null, int? count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Likes.GetListExtended(
                                type,filter,friendsOnly,skipOwn,ownerId,itemId,pageUrl,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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
                public EntityList<User> GetListExtendedSync(
                    string type , string filter , bool friendsOnly , bool skipOwn , int? ownerId = null, int? itemId = null,  string pageUrl = null, int? offset = null, int? count = 100
                ) {
                    var task = _parent.Executor.ExecAsync(
                            _parent._reqapi.Likes.GetListExtended(
                                type,filter,friendsOnly,skipOwn,ownerId,itemId,pageUrl,offset, count
                            )
                        );
                    task.Wait();
                    return task.Result.Response;
                }
            }
    }
}