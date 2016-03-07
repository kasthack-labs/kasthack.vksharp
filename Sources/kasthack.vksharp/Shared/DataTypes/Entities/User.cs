using System;
using kasthack.vksharp.DataTypes.EntityFragments;
using kasthack.vksharp.DataTypes.Enums;
using kasthack.vksharp.DataTypes.ResponseEntities;
using kasthack.vksharp.Internal.Converters;
using Newtonsoft.Json;

namespace kasthack.vksharp.DataTypes.Entities {
#pragma warning disable 660,661
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User : IEquatable<User> {
#pragma warning restore 660, 661
        /// <summary>
        /// 
        /// </summary>
        public Audio StatusAudio { get; set; }
        /// <summary>
        /// текущий пользователь находится в черном списке у запрашиваемого пользователя
        /// </summary>
        public bool? Blacklisted { get; set; }
        /// <summary>
        /// текущий пользователь находится в черном списке у запрашиваемого пользователя
        /// </summary>
        public bool? BlacklistedByMe { get; set; }
        /// <summary>
        /// разрешено ли оставлять записи на стене у пользователя
        /// </summary>
        public bool? CanPost { get; set; }
        /// <summary>
        /// разрешено ли видеть чужие записи на стене пользователя
        /// </summary>
        public bool? CanSeeAllPosts { get; set; }
        /// <summary>
        /// разрешено ли видеть чужие аудиозаписи на стене пользователя
        /// </summary>
        public bool? CanSeeAudio { get; set; }
        /// <summary>
        /// разрешено ли написание личных сообщений данному пользователю
        /// </summary>
        public bool? CanWritePrivateMessage { get; set; }
        /// <summary>
        /// страница пользователя удалена или заблокирована
        /// </summary>
        public Deleted? Deactivated { get; set; }
        /// <summary>
        /// известен ли номер мобильного телефона пользователя
        /// </summary>
        public bool? HasMobile { get; set; }
        /// <summary>
        /// возвращается при вызове без access_token, если пользователь установил настройку «Кому в интернете видна моя страница» — «Только пользователям ВКонтакте»
        /// </summary>
        public bool Hidden { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Online { get; set; }
        /// <summary>
        /// находится ли пользователь сейчас на сайте
        /// </summary>
        public bool? OnlineMobile { get; set; }
        /// <summary>
        ///  страница пользователя верифицирована
        /// </summary>
        public bool? Verified { get; set; }
        /// <summary>
        /// доступно ли комментирование стены 
        /// </summary>
        public bool? WallComments { get; set; }
        /// <summary>
        /// временная зона пользователя
        /// </summary>
        public byte? Timezone { get; set; }
        /// <summary>
        /// дата рождения
        /// </summary>
        public Date? Bdate { get; set; }
        /// <summary>
        /// внешние сервисы, в которые настроен экспорт из ВК
        /// </summary>
        public Exports Exports { get; set; } = new Exports();
        /// <summary>
        /// время последнего посещения
        /// </summary>
        public LastSeen LastSeen { get; set; }
        /// <summary>
        /// информация о текущем роде занятия пользователя
        /// </summary>
        public Occupation Occupation { get; set; }
        /// <summary>
        /// количество различных объектов у пользователя.
        /// </summary>
        public ProfileCounters Counters { get; set; } = new ProfileCounters();
        /// <summary>
        /// фотографии пользователя
        /// </summary>
        [FlatMap]
        public ProfilePhotos ProfilePhotos { get; set; } = new ProfilePhotos();

        #region ProfilePhotos proxies
        private string Photo50 { get { return ProfilePhotos.Photo50; } set { ProfilePhotos.Photo50 = value; } }
        private string Photo100 { get { return ProfilePhotos.Photo100; } set { ProfilePhotos.Photo100 = value; } }
        private string Photo200 { get { return ProfilePhotos.Photo200; } set { ProfilePhotos.Photo200 = value; } }
        private string PhotoMax { get { return ProfilePhotos.PhotoMax; } set { ProfilePhotos.PhotoMax = value; } }
        private string Photo400Orig { get { return ProfilePhotos.Photo400Orig; } set { ProfilePhotos.Photo400Orig = value; } }
        private string Photo200Orig { get { return ProfilePhotos.Photo200Orig; } set { ProfilePhotos.Photo200Orig = value; } }
        private string PhotoMaxOrig { get { return ProfilePhotos.PhotoMaxOrig; } set { ProfilePhotos.PhotoMaxOrig = value; } }
        private string PhotoId { get { return ProfilePhotos.PhotoId; } set { ProfilePhotos.PhotoId = value; } }
        #endregion
        /// <summary>
        /// семейное положение пользователя
        /// </summary>
        public Relation? Relation { get; set; }

        //todo: move to separate class
        #region account.getProfileInfo
        /// <summary>
        /// 
        /// </summary>
        public bool RelationPending { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public User RelationPartner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public User[] RelationRequests { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NameRequest NameRequest { get; set; }
        //todo: bdate visibility
        #endregion
        /// <summary>
        /// список родственников текущего пользователя
        /// </summary>
        public Relative[] Relatives { get; set; }
        /// <summary>
        /// список школ, в которых учился пользователь
        /// </summary>
        public School[] Schools { get; set; }
        /// <summary>
        /// пол пользователя
        /// </summary>
        public Sex? Sex { get; set; }
        /// <summary>
        /// возвращает данные об указанных в профиле сервисах пользователя
        /// </summary>
        [FlatMap]
        public SiteProfiles Connections { get; set; } = new SiteProfiles();
        //todo: fix serializer & remove code

        #region SiteProfiles proxies
        private string Skype { get { return Connections.Skype; } set { Connections.Skype = value; } }
        private ulong? Facebook { get { return Connections.Facebook; } set { Connections.Facebook = value; } }
        private string FacebookName { get { return Connections.FacebookName; } set { Connections.FacebookName = value; } }
        private string Twitter { get { return Connections.Twitter; } set { Connections.Twitter = value; } }
        private string Instagram { get { return Connections.Instagram; } set { Connections.Instagram = value; } }
        private string LiveJournal { get { return Connections.LiveJournal; } set { Connections.LiveJournal = value; } }
        #endregion
        /// <summary>
        /// «О себе».
        /// </summary>
        public string About { get; set; }
        /// <summary>
        /// деятельность
        /// </summary>
        public string Activities { get; set; }
        /// <summary>
        /// любимые книги
        /// </summary>
        public string Books { get; set; }
        /// <summary>
        /// короткий адрес страницы
        /// </summary>
        public string Domain { get; set; }
        /// <summary>
        /// имя пользователя
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// любимые игры
        /// </summary>
        public string Games { get; set; }
        /// <summary>
        /// дополнительный номер телефона пользователя
        /// </summary>
        public string HomePhone { get; set; }
        /// <summary>
        /// родной город
        /// </summary>
        public string HomeTown { get; set; }
        /// <summary>
        /// интересы
        /// </summary>
        public string Interests { get; set; }
        /// <summary>
        /// фамилия пользователя
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// девичья фамилия
        /// </summary>
        public string MaidenName { get; set; }
        /// <summary>
        /// номер мобильного телефона пользователя
        /// </summary>
        public string MobilePhone { get; set; }
        /// <summary>
        /// любимые фильмы
        /// </summary>
        public string Movies { get; set; }
        /// <summary>
        /// любимая музыка
        /// </summary>
        public string Music { get; set; }
        /// <summary>
        /// никнейм (отчество) пользователя
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// любимые цитаты
        /// </summary>
        public string Quotes { get; set; }
        /// <summary>
        /// короткое имя (поддомен) страницы пользователя
        /// </summary>
        public string ScreenName { get; set;}
        /// <summary>
        /// указанный в профиле сайт пользователя
        /// </summary>
        public string Site { get; set; }
        /// <summary>
        /// статус пользователя
        /// </summary>
        public string Status { get; set; }
        public string Tv { get; set; }
        [JsonConverter(typeof(ObjectArrConverter<StandInLife>))]
        public StandInLife Personal { get; set; }
        public uint? CommonCount { get; set; }
        public int Id { get; set; }
        public GeoEntry City { get; set; }
        public GeoEntry Country { get; set; }

        public University MainUniversity { get; set; } = new University();
        #region Main university
        private string UniversityName {
            get
            {
                CreateUniversityIfNotExists();
                return MainUniversity?.Name;
            }
            set {
                MainUniversity.Name = value;
            }
        }
        private string FacultyName {
            get {
                return MainUniversity?.FacultyName;
            }
            set
            {
                CreateUniversityIfNotExists();
                MainUniversity.FacultyName = value;
            }
        }
        private int? Faculty {
            get {
                return MainUniversity?.Faculty;
            }
            set
            {
                CreateUniversityIfNotExists();
                MainUniversity.Faculty = value;
            }
        }
        private int? University {
            get {
                return MainUniversity?.Id;
            }
            set
            {
                if ( value == null) {
                    MainUniversity = null;
                    return;
                }
                CreateUniversityIfNotExists();
                MainUniversity.Id = (int) value;
            }
        }
        private ushort? Graduation {
            get {
                return MainUniversity?.Graduation;
            }
            set
            {
                CreateUniversityIfNotExists();
                MainUniversity.Graduation = value;
            }
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public Career[] Career { get; set; }
        /// <summary>
        /// информация о военной службе пользователя
        /// </summary>
        public Military[] Military { get; set; }
        /// <summary>
        /// количество подписчиков пользователя
        /// </summary>
        public int? FollowersCount { get; set; }
        public int? OnlineApp { get; set; }
        /// <summary>
        /// идентификаторы списков друзей, в которых состоит пользователь
        /// </summary>
        public int[] Lists { get; set; }
        /// <summary>
        /// список высших учебных заведений, в которых учился текущий пользователь
        /// </summary>
        public University[] Universities { get; set; }
        /// <summary>
        /// пользователь находится в закладках у текущего пользователя
        /// </summary>
        public bool? IsFavorite { get; set; }
        /// <summary>
        /// возвращает данные о точках, по которым вырезаны профильная и миниатюрная фотографии пользователя
        /// </summary>
        public CropPhoto CropPhoto { get; set; }

        /// <summary>
        /// является ли пользователь другом
        /// </summary>
        [JsonConverter(typeof(OneTwoFUConverter))]
        public bool? IsFriend { get; set; }
        public FriendshipStatusEnum FriendStatus { get; set; }
        /// <summary>
        /// роль пользователя в сообществе
        /// </summary>
        public GroupRole? Role { get; set; }
        private void CreateUniversityIfNotExists() {
            if (MainUniversity == null)
                MainUniversity = new University();
        }

        public bool Equals( User other ) => !ReferenceEquals( other, null ) && Id == other.Id;

        public static bool operator ==( User a, User b ) => ReferenceEquals( a, null )
                                                                ? ReferenceEquals( b, null )
                                                                : ( a.Equals( b ) );

        public static bool operator !=( User a, User b ) => !( a == b );

        public override int GetHashCode() => Id;
        public override string ToString() => "ID :" + Id;
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class FlatMap : Attribute { }
}
