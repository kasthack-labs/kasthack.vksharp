
using System;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Core.ResponseEntities;
using VKSharp.Data.Parameters;
using VKSharp.Helpers.DataTypes;

// ReSharper disable UnusedMember.Global
namespace VKSharp {
    public partial class VKApi {
            private void InitializeMethodGroups(){
                this.Account = new MethodGroup_Account(this);
                this.Ads = new MethodGroup_Ads(this);
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
                private readonly VKApi _parent;
                internal MethodGroup_Account(VKApi parent){_parent=parent;}

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

                public async Task <EntityList<Offer>> GetAppPermissions(
                    int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.GetAppPermissions(
                                offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <long> GetAppPermissions(
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

                public async Task <User[]> GetBanned(
                    int offset = 0, int count = 20
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.GetBanned(
                                offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <AccountInfo> GetInfo(
                    
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.GetInfo(
                                
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <SaveProfileInfo> SaveProfileInfo(
                    string firstName = "", string lastName = "", string maidenName = "", string screenName = "", Sex? sex = null, Relation? relation = null, int? relationPartnerId = null, Date? bdate = null, int? countryId = null, int? cityId = null,  string status = ""
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SaveProfileInfo(
                                firstName,lastName,maidenName,screenName,sex,relation,relationPartnerId,bdate,countryId,cityId,status
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <User> GetProfileInfo(
                    
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.GetProfileInfo(
                                
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task  SetInfo(
                     int? intro = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SetInfo(
                                intro
                            )
                        ).ConfigureAwait(false)
                    ;
                }

                public async Task  SetNameInMenu(
                     string name 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SetNameInMenu(
                                name
                            )
                        ).ConfigureAwait(false)
                    ;
                }

                public async Task  SetOffline(
                    
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.SetOffline(
                                
                            )
                        ).ConfigureAwait(false)
                    ;
                }

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

                public async Task  RegisterDevice(
                    string token , string deviceId , string settings , string deviceModel = "", string systemVersion = "",  bool? sandbox = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.RegisterDevice(
                                token,deviceId,settings,deviceModel,systemVersion,sandbox
                            )
                        ).ConfigureAwait(false)
                    ;
                }

                public async Task  UnregisterDevice(
                     string deviceId 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Account.UnregisterDevice(
                                deviceId
                            )
                        ).ConfigureAwait(false)
                    ;
                }
            }

            public MethodGroup_Ads Ads {get; private set;}

            public partial class MethodGroup_Ads {
                private readonly VKApi _parent;
                internal MethodGroup_Ads(VKApi parent){_parent=parent;}

                public async Task <int[]> DeleteClients(
                    ulong accountId , params ulong[] ids 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Ads.DeleteClients(
                                accountId,ids
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
            }

            public MethodGroup_Apps Apps {get; private set;}

            public partial class MethodGroup_Apps {
                private readonly VKApi _parent;
                internal MethodGroup_Apps(VKApi parent){_parent=parent;}

                public async Task  DeleteAppRequests(
                    
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Apps.DeleteAppRequests(
                                
                            )
                        ).ConfigureAwait(false)
                    ;
                }

                public async Task <long> GetScore(
                    
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Apps.GetScore(
                                
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
            }

            public MethodGroup_Audio Audio {get; private set;}

            public partial class MethodGroup_Audio {
                private readonly VKApi _parent;
                internal MethodGroup_Audio(VKApi parent){_parent=parent;}

                public async Task <int> Add(
                    int ownerId , long audioId ,  int? groupId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Add(
                                ownerId,audioId,groupId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

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

                public async Task  Delete(
                    long audioId ,  int? ownerId = null
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Delete(
                                audioId,ownerId
                            )
                        ).ConfigureAwait(false)
                    ;
                }

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

                public async Task <EntityList<Audio>> Get(
                    int? ownerId = null, long? albumId = null, ulong[] audioIds = null,  bool needUser = false, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Get(
                                ownerId,albumId,audioIds,needUser,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <EntityList<Audio>> GetPopular(
                    AudioGenre? genreId = null,  bool? onlyEng = null, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetPopular(
                                genreId,onlyEng,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <EntityList<Audio>> GetRecommendations(
                    AudioGenre? genreId = null,  bool? onlyEng = null, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetRecommendations(
                                genreId,onlyEng,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <EntityList<AudioAlbum>> GetAlbums(
                     int? ownerId = null, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetAlbums(
                                ownerId,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <Audio[]> GetById(
                    bool itunes = false, params string[] audios 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetById(
                                itunes,audios
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <Audio[]> GetById(
                    bool itunes = false, params Tuple<int, ulong>[] audios 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.GetById(
                                itunes,audios
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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

                public async Task <EntityList<Audio>> Search(
                    string q , bool autoComplete = true, bool lyrics = false, bool performerOnly = false, AudioSortOrder sort = AudioSortOrder.ByRating,  bool searchOwn = false, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.Search(
                                q,autoComplete,lyrics,performerOnly,sort,searchOwn,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task  SetBroadcast(
                    Tuple<int, ulong> audio , params int[] targetIds 
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Audio.SetBroadcast(
                                audio,targetIds
                            )
                        ).ConfigureAwait(false)
                    ;
                }
            }

            public MethodGroup_Auth Auth {get; private set;}

            public partial class MethodGroup_Auth {
                private readonly VKApi _parent;
                internal MethodGroup_Auth(VKApi parent){_parent=parent;}

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
            }

            public MethodGroup_Board Board {get; private set;}

            public partial class MethodGroup_Board {
                private readonly VKApi _parent;
                internal MethodGroup_Board(VKApi parent){_parent=parent;}

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
            }

            public MethodGroup_Database Database {get; private set;}

            public partial class MethodGroup_Database {
                private readonly VKApi _parent;
                internal MethodGroup_Database(VKApi parent){_parent=parent;}

                public async Task <EntityList<DatabaseEntry>> GetChairs(
                     int facultyId , int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetChairs(
                                facultyId,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <DatabaseCity[]> GetCities(
                    int countryId , int? regionId = null, string q = "",  bool needAll = false, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetCities(
                                countryId,regionId,q,needAll,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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

                public async Task <EntityList<DatabaseEntry>> GetCountries(
                    string code = "",  bool needAll = false, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetCountries(
                                code,needAll,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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

                public async Task <EntityList<DatabaseEntry>> GetFaculties(
                     int universityId , int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetFaculties(
                                universityId,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <EntityList<DatabaseEntry>> GetRegions(
                    int countryId ,  string q = "", int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetRegions(
                                countryId,q,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <DatabaseEntry[]> GetSchools(
                    int? cityId = null,  string q = "", int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetSchools(
                                cityId,q,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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

                public async Task <DatabaseEntry[]> GetUniversities(
                    int? countryId = null, int? cityId = null,  string q = "", int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Database.GetUniversities(
                                countryId,cityId,q,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
            }

            public MethodGroup_Docs Docs {get; private set;}

            public partial class MethodGroup_Docs {
                private readonly VKApi _parent;
                internal MethodGroup_Docs(VKApi parent){_parent=parent;}

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

                public async Task <EntityList<Document>> Get(
                     int? ownerId = null, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Docs.Get(
                                ownerId,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <Document[]> GetById(
                    params Tuple<int,int>[] docs 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Docs.GetById(
                                docs
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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
            }

            public MethodGroup_Fave Fave {get; private set;}

            public partial class MethodGroup_Fave {
                private readonly VKApi _parent;
                internal MethodGroup_Fave(VKApi parent){_parent=parent;}

                public async Task <EntityList<Link>> GetLinks(
                    int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.GetLinks(
                                offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <EntityList<User>> GetUsers(
                    int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.GetUsers(
                                offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <EntityList<Photo>> GetPhotos(
                    int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.GetPhotos(
                                offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <EntityList<Video>> GetVideos(
                    int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Fave.GetVideos(
                                offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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
            }

            public MethodGroup_Friends Friends {get; private set;}

            public partial class MethodGroup_Friends {
                private readonly VKApi _parent;
                internal MethodGroup_Friends(VKApi parent){_parent=parent;}

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

                public async Task  DeleteAllRequests(
                    
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.DeleteAllRequests(
                                
                            )
                        ).ConfigureAwait(false)
                    ;
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

                public async Task <EntityList<User>> Get(
                    int? userId = null, int? listId = null, UserFields fields = UserFields.Anything, UserSortOrder order = UserSortOrder.ById,  NameCase nameCase = NameCase.Nom, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.Get(
                                userId,listId,fields,order,nameCase,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <EntityList<int>> GetAvailableForCall(
                    
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetAvailableForCall(
                                
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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

                public async Task <EntityList<int>> Get(
                    int? userId = null, int? listId = null,  UserSortOrder order = UserSortOrder.ById, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.Get(
                                userId,listId,order,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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

                public async Task <int[]> GetMutual(
                    int targetUid , int? sourceUid = null,  bool order = false, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetMutual(
                                targetUid,sourceUid,order,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <int[]> GetOnline(
                    int? userId = null, int? listId = null,  UserSortOrder? order = null, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetOnline(
                                userId,listId,order,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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

                public async Task <EntityList<User>> GetSuggestions(
                    FriendSuggestionFilters filters = FriendSuggestionFilters.Everything, UserFields fields = UserFields.None,  NameCase nameCase = NameCase.Nom, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.GetSuggestions(
                                filters,fields,nameCase,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <EntityList<User>> Search(
                    int userId , string q = "",  NameCase nameCase = NameCase.Nom, int offset = 0, int count = 20
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Friends.Search(
                                userId,q,nameCase,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
            }

            public MethodGroup_Groups Groups {get; private set;}

            public partial class MethodGroup_Groups {
                private readonly VKApi _parent;
                internal MethodGroup_Groups(VKApi parent){_parent=parent;}

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

                public async Task <User[]> GetBanned(
                     int groupId , int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetBanned(
                                groupId,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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

                public async Task <EntityList<int>> GetMembers(
                    string groupId , GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetMembers(
                                groupId,filter,sort,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <EntityList<User>> GetMembers(
                    string groupId , UserFields fields = UserFields.Anything, GroupMembersFilter? filter = null,  MembersSortOrder? sort = null, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Groups.GetMembers(
                                groupId,fields,filter,sort,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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
            }

            public MethodGroup_Messages Messages {get; private set;}

            public partial class MethodGroup_Messages {
                private readonly VKApi _parent;
                internal MethodGroup_Messages(VKApi parent){_parent=parent;}

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

                public async Task <EntityList<Message>> Get(
                    int @out = 0, int timeOffset = 0, int filters = 0, int previewLength = 0,  long? lastMessageId = null, int offset = 0, int count = 200
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.Get(
                                @out,timeOffset,filters,previewLength,lastMessageId,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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

                public async Task <int> Send(
                    int? userId = null, int[] userIds = null, string domain = null, int? chatId = null, string message = null, int? guid = null, double? lat = null, double? @long = null, string attachment = null, string forwardMessages = null,  int? stickerId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Messages.Send(
                                userId,userIds,domain,chatId,message,guid,lat,@long,attachment,forwardMessages,stickerId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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
            }

            public MethodGroup_Newsfeed Newsfeed {get; private set;}

            public partial class MethodGroup_Newsfeed {
                private readonly VKApi _parent;
                internal MethodGroup_Newsfeed(VKApi parent){_parent=parent;}

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
            }

            public MethodGroup_Notes Notes {get; private set;}

            public partial class MethodGroup_Notes {
                private readonly VKApi _parent;
                internal MethodGroup_Notes(VKApi parent){_parent=parent;}

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
            }

            public MethodGroup_Notifications Notifications {get; private set;}

            public partial class MethodGroup_Notifications {
                private readonly VKApi _parent;
                internal MethodGroup_Notifications(VKApi parent){_parent=parent;}

                public async Task  MarkAsViewed(
                    
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Notifications.MarkAsViewed(
                                
                            )
                        ).ConfigureAwait(false)
                    ;
                }
            }

            public MethodGroup_Pages Pages {get; private set;}

            public partial class MethodGroup_Pages {
                private readonly VKApi _parent;
                internal MethodGroup_Pages(VKApi parent){_parent=parent;}

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
            }

            public MethodGroup_Photos Photos {get; private set;}

            public partial class MethodGroup_Photos {
                private readonly VKApi _parent;
                internal MethodGroup_Photos(VKApi parent){_parent=parent;}

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

                public async Task <EntityList<Photo>> Get(
                    long? albumId = null, int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null,  int? feed = null, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Get(
                                albumId,ownerId,photoIds,rev,extended,feedType,feed,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <EntityList<Photo>> Get(
                    SpecialAlbum albumId , int? ownerId = null, int[] photoIds = null, bool rev = true, bool extended = false, FeedType? feedType = null,  int? feed = null, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.Get(
                                albumId,ownerId,photoIds,rev,extended,feedType,feed,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <EntityList<PhotoAlbum>> GetAlbums(
                    int? ownerId = null, bool needSystem = true, bool needCovers = true, int offset = 0, int count = 100, params long[] albumIds 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetAlbums(
                                ownerId,needSystem,needCovers,offset, count,albumIds
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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

                public async Task <EntityList<Photo>> GetAll(
                    int? ownerId = null, bool extended = false, bool noServiceAlbums = false, bool? needHidden = null,  bool? skipHidden = null, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetAll(
                                ownerId,extended,noServiceAlbums,needHidden,skipHidden,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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

                public async Task <string> GetOwnerPhotoUploadServer(
                    
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Photos.GetOwnerPhotoUploadServer(
                                
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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
            }

            public MethodGroup_Polls Polls {get; private set;}

            public partial class MethodGroup_Polls {
                private readonly VKApi _parent;
                internal MethodGroup_Polls(VKApi parent){_parent=parent;}

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
            }

            public MethodGroup_Stats Stats {get; private set;}

            public partial class MethodGroup_Stats {
                private readonly VKApi _parent;
                internal MethodGroup_Stats(VKApi parent){_parent=parent;}

                public async Task  TrackVisitor(
                    
                ) {
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Stats.TrackVisitor(
                                
                            )
                        ).ConfigureAwait(false)
                    ;
                }
            }

            public MethodGroup_Status Status {get; private set;}

            public partial class MethodGroup_Status {
                private readonly VKApi _parent;
                internal MethodGroup_Status(VKApi parent){_parent=parent;}

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
            }

            public MethodGroup_Storage Storage {get; private set;}

            public partial class MethodGroup_Storage {
                private readonly VKApi _parent;
                internal MethodGroup_Storage(VKApi parent){_parent=parent;}

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

                public async Task <string[]> GetKeys(
                    int? userId = null,  bool global = false, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Storage.GetKeys(
                                userId,global,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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
            }

            public MethodGroup_Users Users {get; private set;}

            public partial class MethodGroup_Users {
                private readonly VKApi _parent;
                internal MethodGroup_Users(VKApi parent){_parent=parent;}

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

                public async Task <EntityList<int>> GetFollowers(
                    int? userId = null,  NameCase nameCase = NameCase.Nom, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.GetFollowers(
                                userId,nameCase,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <EntityList<User>> GetFollowers(
                    int? userId = null, UserFields fields = UserFields.Anything,  NameCase nameCase = NameCase.Nom, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.GetFollowers(
                                userId,fields,nameCase,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <EntityList<User>> GetNearby(
                    double latitude , double longitude , int? accuracy = null, int? timeout = null, byte? radius = null, UserFields fields = UserFields.None,  NameCase nameCase = NameCase.Nom, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.GetNearby(
                                latitude,longitude,accuracy,timeout,radius,fields,nameCase,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <UserSubscriptions> GetSubscriptions(
                     int? userId = null, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.GetSubscriptions(
                                userId,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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

                public async Task <EntityList<User>> Search(
                    string q = "", SearchSortOrder sort = SearchSortOrder.ByRating, UserFields fields = UserFields.None, int? city = null, int? country = null, string hometown = "", int? universityCountry = null, int? university = null, int? universityYear = null, Sex? sex = null, Relation? status = null, byte? ageFrom = null, byte? ageTo = null, byte? birthDay = null, byte? birthMonth = null, ushort? birthYear = null, bool? online = null, bool? hasPhoto = null, int? schoolCountry = null, int? schoolCity = null, int? schoolClass = null, int? school = null, int? schoolYear = null, string religion = "", string interests = "", string company = "", string position = "", int? groupId = null,  FriendshipType? fromList = null, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Users.Search(
                                q,sort,fields,city,country,hometown,universityCountry,university,universityYear,sex,status,ageFrom,ageTo,birthDay,birthMonth,birthYear,online,hasPhoto,schoolCountry,schoolCity,schoolClass,school,schoolYear,religion,interests,company,position,groupId,fromList,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
            }

            public MethodGroup_Utils Utils {get; private set;}

            public partial class MethodGroup_Utils {
                private readonly VKApi _parent;
                internal MethodGroup_Utils(VKApi parent){_parent=parent;}

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

                public async Task <int> GetServerTime(
                    
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Utils.GetServerTime(
                                
                            )
                        ).ConfigureAwait(false)
                    ).Response;
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
            }

            public MethodGroup_Video Video {get; private set;}

            public partial class MethodGroup_Video {
                private readonly VKApi _parent;
                internal MethodGroup_Video(VKApi parent){_parent=parent;}

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
            }

            public MethodGroup_Wall Wall {get; private set;}

            public partial class MethodGroup_Wall {
                private readonly VKApi _parent;
                internal MethodGroup_Wall(VKApi parent){_parent=parent;}

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

                public async Task <EntityList<Post>> Get(
                    int? ownerId = null, string domain = "",  WallPostFilter filter = WallPostFilter.All, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Get(
                                ownerId,domain,filter,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <Post[]> GetById(
                    int copyHistoryDepth = 2, params string[] posts 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.GetById(
                                copyHistoryDepth,posts
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <Post[]> GetById(
                    int copyHistoryDepth = 2, params Tuple<int,int>[] posts 
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.GetById(
                                copyHistoryDepth,posts
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

                public async Task <EntityList<Comment>> GetComments(
                    int postId , string sort , int previewLength , int extended , int? ownerId = null,  bool needLikes = false, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.GetComments(
                                postId,sort,previewLength,extended,ownerId,needLikes,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

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

                public async Task <RepostInfo> Repost(
                    string @object , string message = "",  int? groupId = null
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Wall.Repost(
                                @object,message,groupId
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }

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
            }

            public MethodGroup_Likes Likes {get; private set;}

            public partial class MethodGroup_Likes {
                private readonly VKApi _parent;
                internal MethodGroup_Likes(VKApi parent){_parent=parent;}

                public async Task <EntityList<int>> GetList(
                    string type , string filter , bool friendsOnly , bool skipOwn , bool extended = false, int? ownerId = null, int? itemId = null,  string pageUrl = null, int offset = 0, int count = 100
                ) {
                    return (
                        await _parent.Executor.ExecAsync(
                            _parent._reqapi.Likes.GetList(
                                type,filter,friendsOnly,skipOwn,extended,ownerId,itemId,pageUrl,offset, count
                            )
                        ).ConfigureAwait(false)
                    ).Response;
                }
            }
    }
}