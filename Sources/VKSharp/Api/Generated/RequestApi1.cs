
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
                                //params
                    string//paramter type
                    name//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "account.setNameInMenu",
                Parameters = new Dictionary<string, string> {
                                            {
                            "name",//key
                            name//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> AccountSetOnline(
                                //params
                    bool//paramter type
                    voip//parameter name
                    = true//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "account.setOnline",
                Parameters = new Dictionary<string, string> {
                                            {
                            "voip",//key
                            (voip?1:0).ToNCString()//value
                        }
                        //element separator
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
                                //params
                    string//paramter type
                    token//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "account.unregisterDevice",
                Parameters = new Dictionary<string, string> {
                                            {
                            "token",//key
                            token//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> AccountSetSilenceMode(
                                //params
                    string//paramter type
                    token//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int//paramter type
                    time//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    chatId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    userId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    int//paramter type
                    sound//parameter name
                    = 0//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "account.setSilenceMode",
                Parameters = new Dictionary<string, string> {
                                            {
                            "token",//key
                            token//value
                        }
                        ,//element separator
                                    {
                            "time",//key
                            time.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "chat_id",//key
                            MiscTools.NullableString(chatId)//value
                        }
                        ,//element separator
                                    {
                            "user_id",//key
                            MiscTools.NullableString(userId)//value
                        }
                        ,//element separator
                                    {
                            "sound",//key
                            sound.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<long>> AccountGetAppPermissions(
                                //params
                    uint?//paramter type
                    userId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<long>>{
                MethodName = "account.getAppPermissions",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            MiscTools.NullableString(userId)//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<StructEntity<long>> AccountBanUser(
                                //params
                    uint//paramter type
                    userId//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<long>>{
                MethodName = "account.banUser",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            userId.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<long>> AccountUnbanUser(
                                //params
                    uint//paramter type
                    userId//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<long>>{
                MethodName = "account.unbanUser",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            userId.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<User> AccountGetBanned(
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 20//default value
                    //parameter separator
            ){
            var req = new VKRequest<User>{
                MethodName = "account.getBanned",
                Parameters = new Dictionary<string, string> {
                                            {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<long>> AccountSetInfo(
                                //params
                    uint?//paramter type
                    intro//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<long>>{
                MethodName = "account.setInfo",
                Parameters = new Dictionary<string, string> {
                                            {
                            "intro",//key
                            MiscTools.NullableString(intro)//value
                        }
                        //element separator
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
                                //params
                    string//paramter type
                    title//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    groupId//parameter name
                    = 0//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<int>>{
                MethodName = "audio.addAlbum",
                Parameters = new Dictionary<string, string> {
                                            {
                            "title",//key
                            title//value
                        }
                        ,//element separator
                                    {
                            "group_id",//key
                            MiscTools.NullableString(groupId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<int>> AudioAdd(
                                //params
                    int//paramter type
                    ownerId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    long//paramter type
                    audioId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    groupId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<int>>{
                MethodName = "audio.add",
                Parameters = new Dictionary<string, string> {
                                            {
                            "owner_id",//key
                            ownerId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "audio_id",//key
                            audioId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "group_id",//key
                            MiscTools.NullableString(groupId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<int>> AudioDeleteAlbum(
                                //params
                    long//paramter type
                    albumId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    groupId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<int>>{
                MethodName = "audio.deleteAlbum",
                Parameters = new Dictionary<string, string> {
                                            {
                            "album_id",//key
                            albumId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "group_id",//key
                            MiscTools.NullableString(groupId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<int>> AudioDelete(
                                //params
                    long//paramter type
                    audioId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<int>>{
                MethodName = "audio.delete",
                Parameters = new Dictionary<string, string> {
                                            {
                            "audio_id",//key
                            audioId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<int>> AudioEdit(
                                //params
                    int//paramter type
                    ownerId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    long//paramter type
                    audioId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    artist//parameter name
                    = ""//default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    title//parameter name
                    = ""//default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    text//parameter name
                    = ""//default value
                    ,//parameter separator
                                //params
                    AudioGenre?//paramter type
                    genreId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    bool?//paramter type
                    noSearch//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<int>>{
                MethodName = "audio.edit",
                Parameters = new Dictionary<string, string> {
                                            {
                            "owner_id",//key
                            ownerId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "audio_id",//key
                            audioId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "artist",//key
                            artist//value
                        }
                        ,//element separator
                                    {
                            "title",//key
                            title//value
                        }
                        ,//element separator
                                    {
                            "text",//key
                            text//value
                        }
                        ,//element separator
                                    {
                            "genre_id",//key
                            (genreId!=null?((int)(genreId)).ToString():String.Empty)//value
                        }
                        ,//element separator
                                    {
                            "no_search",//key
                            (noSearch != null ? ( noSearch.Value ? 1 : 0 ).ToNCString() : "")//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<EntityList<Audio>> AudioGet(
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    long?//paramter type
                    albumId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    ulong[]//paramter type
                    audioIds//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    needUser//parameter name
                    = false//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<Audio>>{
                MethodName = "audio.get",
                Parameters = new Dictionary<string, string> {
                                            {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "album_id",//key
                            MiscTools.NullableString(albumId)//value
                        }
                        ,//element separator
                                    {
                            "audio_ids",//key
                            (audioIds??new ulong[]{}).ToNCStringA()//value
                        }
                        ,//element separator
                                    {
                            "need_user",//key
                            (needUser?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<Audio> AudioGetById(
                                //params
                    bool//paramter type
                    itunes//parameter name
                    = false//default value
                    ,//parameter separator
                                params//params
                    string[]//paramter type
                    audios//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<Audio>{
                MethodName = "audio.getById",
                Parameters = new Dictionary<string, string> {
                                            {
                            "itunes",//key
                            (itunes?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "audios",//key
                            String.Join(",",audios)//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<Audio> AudioGetById(
                                //params
                    bool//paramter type
                    itunes//parameter name
                    = false//default value
                    ,//parameter separator
                                params//params
                    Tuple<int, long>[]//paramter type
                    audios//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<Audio>{
                MethodName = "audio.getById",
                Parameters = new Dictionary<string, string> {
                                            {
                            "itunes",//key
                            (itunes?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "audios",//key
                            String.Join(",",audios.Select(a=>a.Item1 +"_" +a.Item2))//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<StructEntity<int>> AudioGetCount(
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<int>>{
                MethodName = "audio.getCount",
                Parameters = new Dictionary<string, string> {
                                            {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<Lyrics> AudioGetLyrics(
                                //params
                    long//paramter type
                    lyricsId//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<Lyrics>{
                MethodName = "audio.getLyrics",
                Parameters = new Dictionary<string, string> {
                                            {
                            "lyrics_id",//key
                            lyricsId.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<SimpleEntity<string>> AudioGetUploadServer(
                                //params
                    long//paramter type
                    albumId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    groupId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<SimpleEntity<string>>{
                MethodName = "audio.getUploadServer",
                Parameters = new Dictionary<string, string> {
                                            {
                            "album_id",//key
                            albumId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "group_id",//key
                            MiscTools.NullableString(groupId)//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<StructEntity<bool>> AudioReorder(
                                //params
                    long//paramter type
                    audioId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    long?//paramter type
                    before//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    long?//paramter type
                    after//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "audio.reorder",
                Parameters = new Dictionary<string, string> {
                                            {
                            "audio_id",//key
                            audioId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "before",//key
                            MiscTools.NullableString(before)//value
                        }
                        ,//element separator
                                    {
                            "after",//key
                            MiscTools.NullableString(after)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<Audio> AudioRestore(
                                //params
                    long//paramter type
                    audioId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<Audio>{
                MethodName = "audio.restore",
                Parameters = new Dictionary<string, string> {
                                            {
                            "audio_id",//key
                            audioId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<Audio> AudioSave(
                                //params
                    string//paramter type
                    server//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    audio//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    hash//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    artist//parameter name
                    = ""//default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    title//parameter name
                    = ""//default value
                    //parameter separator
            ){
            var req = new VKRequest<Audio>{
                MethodName = "audio.save",
                Parameters = new Dictionary<string, string> {
                                            {
                            "server",//key
                            server//value
                        }
                        ,//element separator
                                    {
                            "audio",//key
                            audio//value
                        }
                        ,//element separator
                                    {
                            "hash",//key
                            hash//value
                        }
                        ,//element separator
                                    {
                            "artist",//key
                            artist//value
                        }
                        ,//element separator
                                    {
                            "title",//key
                            title//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<EntityList<Audio>> AudioSearch(
                                //params
                    string//paramter type
                    q//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    autoComplete//parameter name
                    = true//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    lyrics//parameter name
                    = false//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    performerOnly//parameter name
                    = false//default value
                    ,//parameter separator
                                //params
                    AudioSortOrder//paramter type
                    sort//parameter name
                    = AudioSortOrder.ByRating//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    searchOwn//parameter name
                    = false//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<Audio>>{
                MethodName = "audio.search",
                Parameters = new Dictionary<string, string> {
                                            {
                            "q",//key
                            q//value
                        }
                        ,//element separator
                                    {
                            "auto_complete",//key
                            (autoComplete?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "lyrics",//key
                            (lyrics?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "performer_only",//key
                            (performerOnly?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "sort",//key
                            ((int)sort).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "search_own",//key
                            (searchOwn?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<StructEntity<bool>> AuthCheckPhone(
                                //params
                    string//paramter type
                    phone//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    clientSecret//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    clientId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "auth.checkPhone",
                Parameters = new Dictionary<string, string> {
                                            {
                            "phone",//key
                            phone//value
                        }
                        ,//element separator
                                    {
                            "client_secret",//key
                            clientSecret//value
                        }
                        ,//element separator
                                    {
                            "client_id",//key
                            MiscTools.NullableString(clientId)//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<ConfirmResult> AuthConfirm(
                                //params
                    uint//paramter type
                    clientId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    clientSecret//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    phone//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    code//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    password//parameter name
                    = ""//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    testMode//parameter name
                    = false//default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    intro//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<ConfirmResult>{
                MethodName = "auth.confirm",
                Parameters = new Dictionary<string, string> {
                                            {
                            "client_id",//key
                            clientId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "client_secret",//key
                            clientSecret//value
                        }
                        ,//element separator
                                    {
                            "phone",//key
                            phone//value
                        }
                        ,//element separator
                                    {
                            "code",//key
                            code//value
                        }
                        ,//element separator
                                    {
                            "password",//key
                            password//value
                        }
                        ,//element separator
                                    {
                            "test_mode",//key
                            (testMode?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "intro",//key
                            MiscTools.NullableString(intro)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<AuthRestore> AuthRestore(
                                //params
                    long//paramter type
                    phone//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<AuthRestore>{
                MethodName = "auth.restore",
                Parameters = new Dictionary<string, string> {
                                            {
                            "phone",//key
                            phone.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<StructEntity<bool>> BoardCloseTopic(
                                //params
                    uint//paramter type
                    groupId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    topicId//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "board.closeTopic",
                Parameters = new Dictionary<string, string> {
                                            {
                            "group_id",//key
                            groupId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "topic_id",//key
                            topicId.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> BoardDeleteComment(
                                //params
                    uint//paramter type
                    groupId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    topicId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    commentId//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "board.deleteComment",
                Parameters = new Dictionary<string, string> {
                                            {
                            "group_id",//key
                            groupId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "topic_id",//key
                            topicId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "comment_id",//key
                            commentId.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> BoardDeleteTopic(
                                //params
                    uint//paramter type
                    groupId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    topicId//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "board.deleteTopic",
                Parameters = new Dictionary<string, string> {
                                            {
                            "group_id",//key
                            groupId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "topic_id",//key
                            topicId.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> BoardFixTopic(
                                //params
                    uint//paramter type
                    groupId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    topicId//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "board.fixTopic",
                Parameters = new Dictionary<string, string> {
                                            {
                            "group_id",//key
                            groupId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "topic_id",//key
                            topicId.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> BoardUnfixTopic(
                                //params
                    uint//paramter type
                    groupId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    topicId//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "board.unfixTopic",
                Parameters = new Dictionary<string, string> {
                                            {
                            "group_id",//key
                            groupId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "topic_id",//key
                            topicId.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> BoardRestoreComment(
                                //params
                    uint//paramter type
                    groupId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    topicId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    commentId//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "board.restoreComment",
                Parameters = new Dictionary<string, string> {
                                            {
                            "group_id",//key
                            groupId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "topic_id",//key
                            topicId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "comment_id",//key
                            commentId.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<EntityList<DatabaseEntry>> DatabaseGetCountries(
                                //params
                    string//paramter type
                    code//parameter name
                    = ""//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    needAll//parameter name
                    = false//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<DatabaseEntry>>{
                MethodName = "database.getCountries",
                Parameters = new Dictionary<string, string> {
                                            {
                            "code",//key
                            code//value
                        }
                        ,//element separator
                                    {
                            "need_all",//key
                            (needAll?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<EntityList<DatabaseEntry>> DatabaseGetRegions(
                                //params
                    uint//paramter type
                    countryId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    q//parameter name
                    = ""//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<DatabaseEntry>>{
                MethodName = "database.getRegions",
                Parameters = new Dictionary<string, string> {
                                            {
                            "country_id",//key
                            countryId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "q",//key
                            q//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<DatabaseEntry> DatabaseGetStreetsById(
                                params//params
                    uint[]//paramter type
                    streetIds//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<DatabaseEntry>{
                MethodName = "database.getStreetsById",
                Parameters = new Dictionary<string, string> {
                                            {
                            "street_ids",//key
                            (streetIds??new uint[]{}).ToNCStringA()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<EntityList<DatabaseEntry>> DatabaseGetCountriesById(
                                params//params
                    uint[]//paramter type
                    countryIds//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<DatabaseEntry>>{
                MethodName = "database.getCountriesById",
                Parameters = new Dictionary<string, string> {
                                            {
                            "country_ids",//key
                            (countryIds??new uint[]{}).ToNCStringA()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<DatabaseCity> DatabaseGetCitiesById(
                                params//params
                    uint[]//paramter type
                    cityIds//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<DatabaseCity>{
                MethodName = "database.getCitiesById",
                Parameters = new Dictionary<string, string> {
                                            {
                            "city_ids",//key
                            (cityIds??new uint[]{}).ToNCStringA()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<DatabaseCity> DatabaseGetCities(
                                //params
                    uint//paramter type
                    countryId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    regionId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    q//parameter name
                    = ""//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    needAll//parameter name
                    = false//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<DatabaseCity>{
                MethodName = "database.getCities",
                Parameters = new Dictionary<string, string> {
                                            {
                            "country_id",//key
                            countryId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "region_id",//key
                            MiscTools.NullableString(regionId)//value
                        }
                        ,//element separator
                                    {
                            "q",//key
                            q//value
                        }
                        ,//element separator
                                    {
                            "need_all",//key
                            (needAll?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<DatabaseEntry> DatabaseGetUniversities(
                                //params
                    uint?//paramter type
                    countryId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    cityId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    q//parameter name
                    = ""//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<DatabaseEntry>{
                MethodName = "database.getUniversities",
                Parameters = new Dictionary<string, string> {
                                            {
                            "country_id",//key
                            MiscTools.NullableString(countryId)//value
                        }
                        ,//element separator
                                    {
                            "city_id",//key
                            MiscTools.NullableString(cityId)//value
                        }
                        ,//element separator
                                    {
                            "q",//key
                            q//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<DatabaseEntry> DatabaseGetSchools(
                                //params
                    uint?//paramter type
                    cityId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    q//parameter name
                    = ""//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<DatabaseEntry>{
                MethodName = "database.getSchools",
                Parameters = new Dictionary<string, string> {
                                            {
                            "city_id",//key
                            MiscTools.NullableString(cityId)//value
                        }
                        ,//element separator
                                    {
                            "q",//key
                            q//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<EntityList<DatabaseEntry>> DatabaseGetFaculties(
                                //params
                    uint//paramter type
                    universityId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<DatabaseEntry>>{
                MethodName = "database.getFaculties",
                Parameters = new Dictionary<string, string> {
                                            {
                            "university_id",//key
                            universityId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<EntityList<DatabaseEntry>> DatabaseGetChairs(
                                //params
                    uint//paramter type
                    facultyId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<DatabaseEntry>>{
                MethodName = "database.getChairs",
                Parameters = new Dictionary<string, string> {
                                            {
                            "faculty_id",//key
                            facultyId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<StructEntity<int>> DocsAdd(
                                //params
                    long//paramter type
                    docId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int//paramter type
                    ownerId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    accessKey//parameter name
                    = ""//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<int>>{
                MethodName = "docs.add",
                Parameters = new Dictionary<string, string> {
                                            {
                            "doc_id",//key
                            docId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            ownerId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "access_key",//key
                            accessKey//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> DocsDelete(
                                //params
                    long//paramter type
                    docId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "docs.delete",
                Parameters = new Dictionary<string, string> {
                                            {
                            "doc_id",//key
                            docId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<SimpleEntity<string>> DocsGetUploadServer(
                                //params
                    uint?//paramter type
                    groupId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<SimpleEntity<string>>{
                MethodName = "docs.getUploadServer",
                Parameters = new Dictionary<string, string> {
                                            {
                            "group_id",//key
                            MiscTools.NullableString(groupId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<SimpleEntity<string>> DocsGetWallUploadServer(
                                //params
                    uint?//paramter type
                    groupId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<SimpleEntity<string>>{
                MethodName = "docs.getWallUploadServer",
                Parameters = new Dictionary<string, string> {
                                            {
                            "group_id",//key
                            MiscTools.NullableString(groupId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<EntityList<Document>> DocsGet(
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<Document>>{
                MethodName = "docs.get",
                Parameters = new Dictionary<string, string> {
                                            {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<Document> DocsGetById(
                                params//params
                    Tuple<int,int>[]//paramter type
                    docs//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<Document>{
                MethodName = "docs.getById",
                Parameters = new Dictionary<string, string> {
                                            {
                            "docs",//key
                            String.Join(",",docs.Select(a=>a.Item1 +"_" +a.Item2))//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<Document> DocsSave(
                                //params
                    string//paramter type
                    file//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    title//parameter name
                    //default value
                    ,//parameter separator
                                params//params
                    string[]//paramter type
                    tags//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<Document>{
                MethodName = "docs.save",
                Parameters = new Dictionary<string, string> {
                                            {
                            "file",//key
                            file//value
                        }
                        ,//element separator
                                    {
                            "title",//key
                            title//value
                        }
                        ,//element separator
                                    {
                            "tags",//key
                            String.Join(",",tags)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<EntityList<User>> FriendsGet(
                                //params
                    uint?//paramter type
                    userId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    listId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    UserFields//paramter type
                    fields//parameter name
                    = UserFields.None//default value
                    ,//parameter separator
                                //params
                    UserSortOrder//paramter type
                    order//parameter name
                    = UserSortOrder.ById//default value
                    ,//parameter separator
                                //params
                    NameCase//paramter type
                    nameCase//parameter name
                    = NameCase.Nom//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<User>>{
                MethodName = "friends.get",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            MiscTools.NullableString(userId)//value
                        }
                        ,//element separator
                                    {
                            "list_id",//key
                            MiscTools.NullableString(listId)//value
                        }
                        ,//element separator
                                    {
                            "fields",//key
                            String.Join( ",", MiscTools.GetUserFields( fields ) )//value
                        }
                        ,//element separator
                                    {
                            "order",//key
                            order.ToNClString()//value
                        }
                        ,//element separator
                                    {
                            "name_case",//key
                            nameCase.ToNClString()//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<EntityList<User>> FriendsGetSuggestions(
                                //params
                    FriendSuggestionFilters//paramter type
                    filters//parameter name
                    = FriendSuggestionFilters.Everything//default value
                    ,//parameter separator
                                //params
                    UserFields//paramter type
                    fields//parameter name
                    = UserFields.None//default value
                    ,//parameter separator
                                //params
                    NameCase//paramter type
                    nameCase//parameter name
                    = NameCase.Nom//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<User>>{
                MethodName = "friends.getSuggestions",
                Parameters = new Dictionary<string, string> {
                                            {
                            "filters",//key
                            String.Join( ",", MiscTools.GetFilterFields( filters ) )//value
                        }
                        ,//element separator
                                    {
                            "fields",//key
                            String.Join( ",", MiscTools.GetUserFields( fields ) )//value
                        }
                        ,//element separator
                                    {
                            "name_case",//key
                            nameCase.ToNClString()//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<User> FriendsGetByPhones(
                                //params
                    UserFields//paramter type
                    fields//parameter name
                    = UserFields.None//default value
                    ,//parameter separator
                                //params
                    ulong[]//paramter type
                    phones//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<User>{
                MethodName = "friends.getByPhones",
                Parameters = new Dictionary<string, string> {
                                            {
                            "fields",//key
                            String.Join( ",", MiscTools.GetUserFields( fields ) )//value
                        }
                        ,//element separator
                                    {
                            "phones",//key
                            String.Join( ",", phones.Select( a => "+" + a ) )//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<StructEntity<int>> FriendsAdd(
                                //params
                    uint//paramter type
                    userId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    text//parameter name
                    = ""//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<int>>{
                MethodName = "friends.add",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            userId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "text",//key
                            text//value
                        }
                        //element separator
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
                                //params
                    uint//paramter type
                    count//parameter name
                    = 20//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<int>>{
                MethodName = "friends.getRecent",
                Parameters = new Dictionary<string, string> {
                                            {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<int>> FriendsDelete(
                                //params
                    uint//paramter type
                    userId//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<int>>{
                MethodName = "friends.delete",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            userId.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> FriendsDeleteList(
                                //params
                    uint//paramter type
                    listId//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "friends.deleteList",
                Parameters = new Dictionary<string, string> {
                                            {
                            "list_id",//key
                            listId.ToNCString()//value
                        }
                        //element separator
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
                                //params
                    uint//paramter type
                    targetUid//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    sourceUid//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    order//parameter name
                    = false//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<int>>{
                MethodName = "friends.getMutual",
                Parameters = new Dictionary<string, string> {
                                            {
                            "target_uid",//key
                            targetUid.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "source_uid",//key
                            MiscTools.NullableString(sourceUid)//value
                        }
                        ,//element separator
                                    {
                            "order",//key
                            order ? "random" : ""//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<User> GroupsGetBanned(
                                //params
                    uint//paramter type
                    groupId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<User>{
                MethodName = "groups.getBanned",
                Parameters = new Dictionary<string, string> {
                                            {
                            "group_id",//key
                            groupId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<Group> GroupsGetById(
                                //params
                    string[]//paramter type
                    groupIds//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    GroupFields//paramter type
                    fields//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<Group>{
                MethodName = "groups.getById",
                Parameters = new Dictionary<string, string> {
                                            {
                            "group_ids",//key
                            String.Join(",",groupIds)//value
                        }
                        ,//element separator
                                    {
                            "fields",//key
                            String.Join( ",", MiscTools.GetGroupFields( fields ) )//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<Group> GroupsGetById(
                                //params
                    uint//paramter type
                    groupId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    GroupFields//paramter type
                    fields//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<Group>{
                MethodName = "groups.getById",
                Parameters = new Dictionary<string, string> {
                                            {
                            "group_id",//key
                            groupId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "fields",//key
                            String.Join( ",", MiscTools.GetGroupFields( fields ) )//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<EntityList<User>> GroupsGetMembers(
                                //params
                    uint//paramter type
                    groupId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    UserFields//paramter type
                    fields//parameter name
                    = UserFields.Everything//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<User>>{
                MethodName = "groups.getMembers",
                Parameters = new Dictionary<string, string> {
                                            {
                            "group_id",//key
                            groupId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "fields",//key
                            String.Join( ",", MiscTools.GetUserFields( fields ) )//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<EntityList<User>> GroupsGetMembers(
                                //params
                    string//paramter type
                    groupId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    UserFields//paramter type
                    fields//parameter name
                    = UserFields.None//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<User>>{
                MethodName = "groups.getMembers",
                Parameters = new Dictionary<string, string> {
                                            {
                            "group_id",//key
                            groupId//value
                        }
                        ,//element separator
                                    {
                            "fields",//key
                            String.Join( ",", MiscTools.GetUserFields( fields ) )//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<MemberShip> GroupsIsMember(
                                //params
                    uint//paramter type
                    groupId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    extended//parameter name
                    = false//default value
                    ,//parameter separator
                                params//params
                    uint[]//paramter type
                    userIds//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<MemberShip>{
                MethodName = "groups.isMember",
                Parameters = new Dictionary<string, string> {
                                            {
                            "group_id",//key
                            groupId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "extended",//key
                            (extended?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "user_ids",//key
                            (userIds??new uint[]{}).ToNCStringA()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<StructEntity<bool>> GroupsJoin(
                                //params
                    uint//paramter type
                    groupId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    notSure//parameter name
                    = false//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "groups.join",
                Parameters = new Dictionary<string, string> {
                                            {
                            "group_id",//key
                            groupId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "not_sure",//key
                            (notSure?1:0).ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> GroupsLeave(
                                //params
                    uint//paramter type
                    groupId//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "groups.leave",
                Parameters = new Dictionary<string, string> {
                                            {
                            "group_id",//key
                            groupId.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> GroupsUnbanUser(
                                //params
                    uint//paramter type
                    groupId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    userId//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "groups.unbanUser",
                Parameters = new Dictionary<string, string> {
                                            {
                            "group_id",//key
                            groupId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "user_id",//key
                            userId.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> MessagesAddChatUser(
                                //params
                    uint//paramter type
                    userId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    chatId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "messages.addChatUser",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            userId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "chat_id",//key
                            MiscTools.NullableString(chatId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> MessagesRemoveChatUser(
                                //params
                    uint//paramter type
                    userId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    chatId//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "messages.removeChatUser",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            userId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "chat_id",//key
                            chatId.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> MessagesDelete(
                                params//params
                    int[]//paramter type
                    messageIds//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "messages.delete",
                Parameters = new Dictionary<string, string> {
                                            {
                            "message_ids",//key
                            (messageIds??new int[]{}).ToNCStringA()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> MessagesMarkAsRead(
                                //params
                    uint//paramter type
                    userId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    startMessageId//parameter name
                    = null//default value
                    ,//parameter separator
                                params//params
                    int[]//paramter type
                    messageIds//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "messages.markAsRead",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            userId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "start_message_id",//key
                            MiscTools.NullableString(startMessageId)//value
                        }
                        ,//element separator
                                    {
                            "message_ids",//key
                            (messageIds??new int[]{}).ToNCStringA()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> MessagesRestore(
                                //params
                    int//paramter type
                    messageId//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "messages.restore",
                Parameters = new Dictionary<string, string> {
                                            {
                            "message_id",//key
                            messageId.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> MessagesDeleteDialog(
                                //params
                    uint//paramter type
                    userId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "messages.deleteDialog",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            userId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> MessagesMarkAsImportant(
                                //params
                    bool//paramter type
                    important//parameter name
                    //default value
                    ,//parameter separator
                                params//params
                    int[]//paramter type
                    messageIds//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "messages.markAsImportant",
                Parameters = new Dictionary<string, string> {
                                            {
                            "important",//key
                            (important?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "message_ids",//key
                            (messageIds??new int[]{}).ToNCStringA()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> NewsfeedAddBan(
                                //params
                    uint[]//paramter type
                    userIds//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    uint[]//paramter type
                    groupIds//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "newsfeed.addBan",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_ids",//key
                            (userIds??new uint[]{}).ToNCStringA()//value
                        }
                        ,//element separator
                                    {
                            "group_ids",//key
                            (groupIds??new uint[]{}).ToNCStringA()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> NewsfeedDeleteBan(
                                //params
                    uint[]//paramter type
                    userIds//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    uint[]//paramter type
                    groupIds//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "newsfeed.deleteBan",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_ids",//key
                            (userIds??new uint[]{}).ToNCStringA()//value
                        }
                        ,//element separator
                                    {
                            "group_ids",//key
                            (groupIds??new uint[]{}).ToNCStringA()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> NotesDelete(
                                //params
                    uint//paramter type
                    noteId//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "notes.delete",
                Parameters = new Dictionary<string, string> {
                                            {
                            "note_id",//key
                            noteId.ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> NotesDeleteComment(
                                //params
                    uint//paramter type
                    commentId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "notes.deleteComment",
                Parameters = new Dictionary<string, string> {
                                            {
                            "comment_id",//key
                            commentId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> NotesRestoreComment(
                                //params
                    uint//paramter type
                    commentId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "notes.restoreComment",
                Parameters = new Dictionary<string, string> {
                                            {
                            "comment_id",//key
                            commentId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
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
                                //params
                    string//paramter type
                    url//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "pages.clearCache",
                Parameters = new Dictionary<string, string> {
                                            {
                            "url",//key
                            url//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<StructEntity<bool>> PhotosDeleteComment(
                                //params
                    uint//paramter type
                    commentId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "photos.deleteComment",
                Parameters = new Dictionary<string, string> {
                                            {
                            "comment_id",//key
                            commentId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> PhotosRestoreComment(
                                //params
                    uint//paramter type
                    commentId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "photos.restoreComment",
                Parameters = new Dictionary<string, string> {
                                            {
                            "comment_id",//key
                            commentId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> PhotosReportComment(
                                //params
                    uint//paramter type
                    commentId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    ReportReason?//paramter type
                    reason//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "photos.reportComment",
                Parameters = new Dictionary<string, string> {
                                            {
                            "comment_id",//key
                            commentId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "reason",//key
                            reason == null ? "" : ( (int)reason ).ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> PhotosDeleteAlbum(
                                //params
                    long//paramter type
                    albumId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    groupId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "photos.deleteAlbum",
                Parameters = new Dictionary<string, string> {
                                            {
                            "album_id",//key
                            albumId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "group_id",//key
                            MiscTools.NullableString(groupId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> PhotosDelete(
                                //params
                    long//paramter type
                    photoId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "photos.delete",
                Parameters = new Dictionary<string, string> {
                                            {
                            "photo_id",//key
                            photoId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> PhotosConfirmTag(
                                //params
                    uint//paramter type
                    tagId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    long//paramter type
                    photoId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "photos.confirmTag",
                Parameters = new Dictionary<string, string> {
                                            {
                            "tag_id",//key
                            tagId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "photo_id",//key
                            photoId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> PhotosRemoveTag(
                                //params
                    uint//paramter type
                    tagId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    long//paramter type
                    photoId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "photos.removeTag",
                Parameters = new Dictionary<string, string> {
                                            {
                            "tag_id",//key
                            tagId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "photo_id",//key
                            photoId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> PhotosReport(
                                //params
                    long//paramter type
                    photoId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    ReportReason?//paramter type
                    reason//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "photos.report",
                Parameters = new Dictionary<string, string> {
                                            {
                            "photo_id",//key
                            photoId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "reason",//key
                            reason == null ? "" : ( (int)reason ).ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> PhotosCopy(
                                //params
                    long//paramter type
                    photoId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    accessKey//parameter name
                    = ""//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "photos.copy",
                Parameters = new Dictionary<string, string> {
                                            {
                            "photo_id",//key
                            photoId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "access_key",//key
                            accessKey//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> PhotosEdit(
                                //params
                    long//paramter type
                    photoId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    caption//parameter name
                    = ""//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "photos.edit",
                Parameters = new Dictionary<string, string> {
                                            {
                            "photo_id",//key
                            photoId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "caption",//key
                            caption//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<int>> PhotosGetAlbumsCount(
                                //params
                    uint?//paramter type
                    userId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    groupId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<int>>{
                MethodName = "photos.getAlbumsCount",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            MiscTools.NullableString(userId)//value
                        }
                        ,//element separator
                                    {
                            "group_id",//key
                            MiscTools.NullableString(groupId)//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<PhotoAlbum> PhotosCreateAlbum(
                                //params
                    string//paramter type
                    title//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    description//parameter name
                    = ""//default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    groupId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    PrivacyType?//paramter type
                    privacy//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    PrivacyType?//paramter type
                    commentPrivacy//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<PhotoAlbum>{
                MethodName = "photos.createAlbum",
                Parameters = new Dictionary<string, string> {
                                            {
                            "title",//key
                            title//value
                        }
                        ,//element separator
                                    {
                            "description",//key
                            description//value
                        }
                        ,//element separator
                                    {
                            "group_id",//key
                            MiscTools.NullableString(groupId)//value
                        }
                        ,//element separator
                                    {
                            "privacy",//key
                            MiscTools.NullableString( (byte?)privacy )//value
                        }
                        ,//element separator
                                    {
                            "comment_privacy",//key
                            MiscTools.NullableString( (byte?)commentPrivacy )//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> PhotosEditAlbum(
                                //params
                    long//paramter type
                    albumId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    title//parameter name
                    = ""//default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    description//parameter name
                    = ""//default value
                    ,//parameter separator
                                //params
                    PrivacyType?//paramter type
                    privacy//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    PrivacyType?//paramter type
                    commentPrivacy//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "photos.editAlbum",
                Parameters = new Dictionary<string, string> {
                                            {
                            "album_id",//key
                            albumId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "title",//key
                            title//value
                        }
                        ,//element separator
                                    {
                            "description",//key
                            description//value
                        }
                        ,//element separator
                                    {
                            "privacy",//key
                            MiscTools.NullableString( (byte?)privacy )//value
                        }
                        ,//element separator
                                    {
                            "comment_privacy",//key
                            MiscTools.NullableString( (byte?)commentPrivacy )//value
                        }
                        //element separator
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
                                //params
                    long//paramter type
                    albumId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    groupId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<PhotosUploadServer>{
                MethodName = "photos.getUploadServer",
                Parameters = new Dictionary<string, string> {
                                            {
                            "album_id",//key
                            albumId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "group_id",//key
                            MiscTools.NullableString(groupId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<PhotosUploadServer> PhotosGetChatUploadServer(
                                //params
                    uint//paramter type
                    chatId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    cropX//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    cropY//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    cropWidth//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<PhotosUploadServer>{
                MethodName = "photos.getChatUploadServer",
                Parameters = new Dictionary<string, string> {
                                            {
                            "chat_id",//key
                            chatId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "crop_x",//key
                            MiscTools.NullableString(cropX)//value
                        }
                        ,//element separator
                                    {
                            "crop_y",//key
                            MiscTools.NullableString(cropY)//value
                        }
                        ,//element separator
                                    {
                            "crop_width",//key
                            MiscTools.NullableString(cropWidth)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> PhotosReorderAlbums(
                                //params
                    long//paramter type
                    albumId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    long?//paramter type
                    before//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    long?//paramter type
                    after//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "photos.reorderAlbums",
                Parameters = new Dictionary<string, string> {
                                            {
                            "album_id",//key
                            albumId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "before",//key
                            MiscTools.NullableString(before)//value
                        }
                        ,//element separator
                                    {
                            "after",//key
                            MiscTools.NullableString(after)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> PhotosReorderPhotos(
                                //params
                    long//paramter type
                    photoId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    long?//paramter type
                    before//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    long?//paramter type
                    after//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "photos.reorderPhotos",
                Parameters = new Dictionary<string, string> {
                                            {
                            "photo_id",//key
                            photoId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "before",//key
                            MiscTools.NullableString(before)//value
                        }
                        ,//element separator
                                    {
                            "after",//key
                            MiscTools.NullableString(after)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> PhotosMove(
                                //params
                    long//paramter type
                    targetAlbumId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    long//paramter type
                    photoId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "photos.move",
                Parameters = new Dictionary<string, string> {
                                            {
                            "target_album_id",//key
                            targetAlbumId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "photo_id",//key
                            photoId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> PhotosMakeCover(
                                //params
                    long//paramter type
                    albumId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    long//paramter type
                    photoId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "photos.makeCover",
                Parameters = new Dictionary<string, string> {
                                            {
                            "album_id",//key
                            albumId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "photo_id",//key
                            photoId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<EntityList<Photo>> PhotosGetAll(
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    extended//parameter name
                    = false//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    noServiceAlbums//parameter name
                    = false//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<Photo>>{
                MethodName = "photos.getAll",
                Parameters = new Dictionary<string, string> {
                                            {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "extended",//key
                            (extended?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "no_service_albums",//key
                            (noServiceAlbums?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<EntityList<Photo>> PhotosGet(
                                //params
                    long?//paramter type
                    albumId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    int[]//paramter type
                    photoIds//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    rev//parameter name
                    = true//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    extended//parameter name
                    = false//default value
                    ,//parameter separator
                                //params
                    FeedType?//paramter type
                    feedType//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    feed//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<Photo>>{
                MethodName = "photos.get",
                Parameters = new Dictionary<string, string> {
                                            {
                            "album_id",//key
                            MiscTools.NullableString(albumId)//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "photo_ids",//key
                            (photoIds??new int[]{}).ToNCStringA()//value
                        }
                        ,//element separator
                                    {
                            "rev",//key
                            (rev?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "extended",//key
                            (extended?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "feed_type",//key
                            MiscTools.NullableString( feedType )//value
                        }
                        ,//element separator
                                    {
                            "feed",//key
                            MiscTools.NullableString(feed)//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<EntityList<Photo>> PhotosGet(
                                //params
                    SpecialAlbum//paramter type
                    albumId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    int[]//paramter type
                    photoIds//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    rev//parameter name
                    = true//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    extended//parameter name
                    = false//default value
                    ,//parameter separator
                                //params
                    FeedType?//paramter type
                    feedType//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    feed//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<Photo>>{
                MethodName = "photos.get",
                Parameters = new Dictionary<string, string> {
                                            {
                            "album_id",//key
                            albumId.ToNClString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "photo_ids",//key
                            (photoIds??new int[]{}).ToNCStringA()//value
                        }
                        ,//element separator
                                    {
                            "rev",//key
                            (rev?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "extended",//key
                            (extended?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "feed_type",//key
                            MiscTools.NullableString( feedType )//value
                        }
                        ,//element separator
                                    {
                            "feed",//key
                            MiscTools.NullableString(feed)//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<EntityList<PhotoAlbum>> PhotosGetAlbums(
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    needSystem//parameter name
                    = true//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    needCovers//parameter name
                    = true//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    ,//parameter separator
                                params//params
                    long[]//paramter type
                    albumIds//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<PhotoAlbum>>{
                MethodName = "photos.getAlbums",
                Parameters = new Dictionary<string, string> {
                                            {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "need_system",//key
                            (needSystem?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "need_covers",//key
                            (needCovers?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "album_ids",//key
                            (albumIds??new long[]{}).ToNCStringA()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<Photo> PhotosSave(
                                //params
                    long//paramter type
                    albumId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    server//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    photosList//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    hash//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    groupId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    double?//paramter type
                    latitude//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    double?//paramter type
                    longitude//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    caption//parameter name
                    = ""//default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    description//parameter name
                    = ""//default value
                    //parameter separator
            ){
            var req = new VKRequest<Photo>{
                MethodName = "photos.save",
                Parameters = new Dictionary<string, string> {
                                            {
                            "album_id",//key
                            albumId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "server",//key
                            server//value
                        }
                        ,//element separator
                                    {
                            "photos_list",//key
                            photosList//value
                        }
                        ,//element separator
                                    {
                            "hash",//key
                            hash//value
                        }
                        ,//element separator
                                    {
                            "group_id",//key
                            MiscTools.NullableString(groupId)//value
                        }
                        ,//element separator
                                    {
                            "latitude",//key
                            MiscTools.NullableString(latitude)//value
                        }
                        ,//element separator
                                    {
                            "longitude",//key
                            MiscTools.NullableString(longitude)//value
                        }
                        ,//element separator
                                    {
                            "caption",//key
                            caption//value
                        }
                        ,//element separator
                                    {
                            "description",//key
                            description//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<Status> StatusGet(
                                //params
                    int?//paramter type
                    userId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<Status>{
                MethodName = "status.get",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            MiscTools.NullableString(userId)//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<StructEntity<bool>> StatusSet(
                                //params
                    string//paramter type
                    text//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "status.set",
                Parameters = new Dictionary<string, string> {
                                            {
                            "text",//key
                            text//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StorageEntry> StorageGet(
                                //params
                    uint?//paramter type
                    userId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    global//parameter name
                    = false//default value
                    ,//parameter separator
                                params//params
                    string[]//paramter type
                    keys//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StorageEntry>{
                MethodName = "storage.get",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            MiscTools.NullableString(userId)//value
                        }
                        ,//element separator
                                    {
                            "global",//key
                            (global?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "keys",//key
                            String.Join(",",keys)//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<SimpleEntity<string>> StorageGetKeys(
                                //params
                    uint?//paramter type
                    userId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    global//parameter name
                    = false//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<SimpleEntity<string>>{
                MethodName = "storage.getKeys",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            MiscTools.NullableString(userId)//value
                        }
                        ,//element separator
                                    {
                            "global",//key
                            (global?1:0).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<StorageEntry> StorageSet(
                                //params
                    string//paramter type
                    key//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    value//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    userId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    bool//paramter type
                    global//parameter name
                    = false//default value
                    //parameter separator
            ){
            var req = new VKRequest<StorageEntry>{
                MethodName = "storage.set",
                Parameters = new Dictionary<string, string> {
                                            {
                            "key",//key
                            key//value
                        }
                        ,//element separator
                                    {
                            "value",//key
                            value//value
                        }
                        ,//element separator
                                    {
                            "user_id",//key
                            MiscTools.NullableString(userId)//value
                        }
                        ,//element separator
                                    {
                            "global",//key
                            (global?1:0).ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<StructEntity<bool>> UsersIsAppUser(
                                //params
                    uint?//paramter type
                    userId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "users.isAppUser",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            MiscTools.NullableString(userId)//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<StructEntity<int>> UsersReport(
                                //params
                    uint//paramter type
                    userId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    ComplaintType//paramter type
                    type//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    comment//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<int>>{
                MethodName = "users.report",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            userId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "type",//key
                            type.ToNClString()//value
                        }
                        ,//element separator
                                    {
                            "comment",//key
                            comment//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<UserSubscriptions> UsersGetSubscriptions(
                                //params
                    uint?//paramter type
                    userId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<UserSubscriptions>{
                MethodName = "users.getSubscriptions",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            MiscTools.NullableString(userId)//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<User> UsersGet(
                                //params
                    UserFields//paramter type
                    fields//parameter name
                    = UserFields.None//default value
                    ,//parameter separator
                                //params
                    NameCase//paramter type
                    nameCase//parameter name
                    = NameCase.Nom//default value
                    ,//parameter separator
                                params//params
                    uint[]//paramter type
                    userIds//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<User>{
                MethodName = "users.get",
                Parameters = new Dictionary<string, string> {
                                            {
                            "fields",//key
                            String.Join( ",", MiscTools.GetUserFields( fields ) )//value
                        }
                        ,//element separator
                                    {
                            "name_case",//key
                            nameCase.ToNClString()//value
                        }
                        ,//element separator
                                    {
                            "user_ids",//key
                            (userIds??new uint[]{}).ToNCStringA()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<EntityList<User>> UsersGetFollowers(
                                //params
                    uint?//paramter type
                    userId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    UserFields//paramter type
                    fields//parameter name
                    = UserFields.None//default value
                    ,//parameter separator
                                //params
                    NameCase//paramter type
                    nameCase//parameter name
                    = NameCase.Nom//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<User>>{
                MethodName = "users.getFollowers",
                Parameters = new Dictionary<string, string> {
                                            {
                            "user_id",//key
                            MiscTools.NullableString(userId)//value
                        }
                        ,//element separator
                                    {
                            "fields",//key
                            String.Join( ",", MiscTools.GetUserFields( fields ) )//value
                        }
                        ,//element separator
                                    {
                            "name_case",//key
                            nameCase.ToNClString()//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<EntityList<User>> UsersGetNearby(
                                //params
                    double//paramter type
                    latitude//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    double//paramter type
                    longitude//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    accuracy//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    timeout//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    byte?//paramter type
                    radius//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    UserFields//paramter type
                    fields//parameter name
                    = UserFields.None//default value
                    ,//parameter separator
                                //params
                    NameCase//paramter type
                    nameCase//parameter name
                    = NameCase.Nom//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<User>>{
                MethodName = "users.getNearby",
                Parameters = new Dictionary<string, string> {
                                            {
                            "latitude",//key
                            latitude.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "longitude",//key
                            longitude.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "accuracy",//key
                            MiscTools.NullableString(accuracy)//value
                        }
                        ,//element separator
                                    {
                            "timeout",//key
                            MiscTools.NullableString(timeout)//value
                        }
                        ,//element separator
                                    {
                            "radius",//key
                            MiscTools.NullableString(radius)//value
                        }
                        ,//element separator
                                    {
                            "fields",//key
                            String.Join( ",", MiscTools.GetUserFields( fields ) )//value
                        }
                        ,//element separator
                                    {
                            "name_case",//key
                            nameCase.ToNClString()//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<LinkCheckResult> UtilsCheckLink(
                                //params
                    string//paramter type
                    url//parameter name
                    = ""//default value
                    //parameter separator
            ){
            var req = new VKRequest<LinkCheckResult>{
                MethodName = "utils.checkLink",
                Parameters = new Dictionary<string, string> {
                                            {
                            "url",//key
                            url//value
                        }
                        //element separator
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
                                //params
                    uint//paramter type
                    commentId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "video.deleteComment",
                Parameters = new Dictionary<string, string> {
                                            {
                            "comment_id",//key
                            commentId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> VideoRestoreComment(
                                //params
                    uint//paramter type
                    commentId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "video.restoreComment",
                Parameters = new Dictionary<string, string> {
                                            {
                            "comment_id",//key
                            commentId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> VideoReportComment(
                                //params
                    uint//paramter type
                    commentId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    ReportReason?//paramter type
                    reason//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "video.reportComment",
                Parameters = new Dictionary<string, string> {
                                            {
                            "comment_id",//key
                            commentId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "reason",//key
                            reason == null ? "" : ( (int)reason ).ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<int>> VideoDeleteAlbum(
                                //params
                    long//paramter type
                    albumId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    groupId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<int>>{
                MethodName = "video.deleteAlbum",
                Parameters = new Dictionary<string, string> {
                                            {
                            "album_id",//key
                            albumId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "group_id",//key
                            MiscTools.NullableString(groupId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<int>> VideoDelete(
                                //params
                    ulong//paramter type
                    videoId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<int>>{
                MethodName = "video.delete",
                Parameters = new Dictionary<string, string> {
                                            {
                            "video_id",//key
                            videoId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<int>> VideoRemoveTag(
                                //params
                    ulong//paramter type
                    videoId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    tagId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<int>>{
                MethodName = "video.removeTag",
                Parameters = new Dictionary<string, string> {
                                            {
                            "video_id",//key
                            videoId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "tag_id",//key
                            tagId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<int>> VideoReport(
                                //params
                    ulong//paramter type
                    videoId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    ReportReason?//paramter type
                    reason//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    comment//parameter name
                    = ""//default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    searchQuery//parameter name
                    = ""//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<int>>{
                MethodName = "video.report",
                Parameters = new Dictionary<string, string> {
                                            {
                            "video_id",//key
                            videoId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "reason",//key
                            reason == null ? "" : ( (int)reason ).ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "comment",//key
                            comment//value
                        }
                        ,//element separator
                                    {
                            "search_query",//key
                            searchQuery//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> WallDelete(
                                //params
                    uint//paramter type
                    postId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "wall.delete",
                Parameters = new Dictionary<string, string> {
                                            {
                            "post_id",//key
                            postId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> WallRestore(
                                //params
                    uint//paramter type
                    postId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "wall.restore",
                Parameters = new Dictionary<string, string> {
                                            {
                            "post_id",//key
                            postId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> WallDeleteComment(
                                //params
                    uint//paramter type
                    commentId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "wall.deleteComment",
                Parameters = new Dictionary<string, string> {
                                            {
                            "comment_id",//key
                            commentId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> WallRestoreComment(
                                //params
                    uint//paramter type
                    commentId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "wall.restoreComment",
                Parameters = new Dictionary<string, string> {
                                            {
                            "comment_id",//key
                            commentId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> WallReportPost(
                                //params
                    uint//paramter type
                    postId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    ReportReason?//paramter type
                    reason//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "wall.reportPost",
                Parameters = new Dictionary<string, string> {
                                            {
                            "post_id",//key
                            postId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "reason",//key
                            reason == null ? "" : ( (int)reason ).ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> WallReportComment(
                                //params
                    uint//paramter type
                    commentId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    ReportReason?//paramter type
                    reason//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "wall.reportComment",
                Parameters = new Dictionary<string, string> {
                                            {
                            "comment_id",//key
                            commentId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "reason",//key
                            reason == null ? "" : ( (int)reason ).ToNCString()//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<Post> WallGetById(
                                //params
                    uint//paramter type
                    copyHistoryDepth//parameter name
                    = 2//default value
                    ,//parameter separator
                                params//params
                    string[]//paramter type
                    posts//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<Post>{
                MethodName = "wall.getById",
                Parameters = new Dictionary<string, string> {
                                            {
                            "copy_history_depth",//key
                            copyHistoryDepth.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "posts",//key
                            String.Join(",",posts)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<Post> WallGetById(
                                //params
                    uint//paramter type
                    copyHistoryDepth//parameter name
                    = 2//default value
                    ,//parameter separator
                                params//params
                    Tuple<int,uint>[]//paramter type
                    posts//parameter name
                    //default value
                    //parameter separator
            ){
            var req = new VKRequest<Post>{
                MethodName = "wall.getById",
                Parameters = new Dictionary<string, string> {
                                            {
                            "copy_history_depth",//key
                            copyHistoryDepth.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "posts",//key
                            String.Join(",",posts.Select(a=>a.Item1 +"_" +a.Item2))//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<EntityList<Post>> WallGet(
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    domain//parameter name
                    = ""//default value
                    ,//parameter separator
                                //params
                    WallPostFilter//paramter type
                    filter//parameter name
                    = WallPostFilter.All//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    offset//parameter name
                    = 0//default value
                    ,//parameter separator
                                //params
                    uint//paramter type
                    count//parameter name
                    = 100//default value
                    //parameter separator
            ){
            var req = new VKRequest<EntityList<Post>>{
                MethodName = "wall.get",
                Parameters = new Dictionary<string, string> {
                                            {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        ,//element separator
                                    {
                            "domain",//key
                            domain//value
                        }
                        ,//element separator
                                    {
                            "filter",//key
                            filter.ToNClString().ToSnake()//value
                        }
                        ,//element separator
                                    {
                            "offset",//key
                            offset.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "count",//key
                            count.ToNCString()//value
                        }
                        //element separator
                }
            };
            if (IsLogged){
                req.Token = CurrentToken;
            }
            return req;
        }
        public VKRequest<StructEntity<bool>> WallPin(
                                //params
                    uint//paramter type
                    postId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "wall.pin",
                Parameters = new Dictionary<string, string> {
                                            {
                            "post_id",//key
                            postId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<StructEntity<bool>> WallUnpin(
                                //params
                    uint//paramter type
                    postId//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    int?//paramter type
                    ownerId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<StructEntity<bool>>{
                MethodName = "wall.unpin",
                Parameters = new Dictionary<string, string> {
                                            {
                            "post_id",//key
                            postId.ToNCString()//value
                        }
                        ,//element separator
                                    {
                            "owner_id",//key
                            MiscTools.NullableString(ownerId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
        public VKRequest<RepostInfo> WallRepost(
                                //params
                    string//paramter type
                    @object//parameter name
                    //default value
                    ,//parameter separator
                                //params
                    string//paramter type
                    message//parameter name
                    = ""//default value
                    ,//parameter separator
                                //params
                    uint?//paramter type
                    groupId//parameter name
                    = null//default value
                    //parameter separator
            ){
            var req = new VKRequest<RepostInfo>{
                MethodName = "wall.repost",
                Parameters = new Dictionary<string, string> {
                                            {
                            "object",//key
                            @object//value
                        }
                        ,//element separator
                                    {
                            "message",//key
                            message//value
                        }
                        ,//element separator
                                    {
                            "group_id",//key
                            MiscTools.NullableString(groupId)//value
                        }
                        //element separator
                }
            };
                req.Token = CurrentToken;
            
            return req;
        }
    }
}