using VKSharp.Core.Entities;
using VKSharp.Core.EntityFragments;
using VKSharp.Core.ResponseEntities;

namespace VKSharp.Core.EntityParsers.Xml {
    //TODO: заменить созданием DefaultParser<T> в рантайме
    public class RepostInfoParser : DefaultParser<RepostInfo> { }
    public class AuthRestoreParser : DefaultParser<AuthRestore> { }
    public class BanInfoParser : DefaultParser<BanInfo> { }
    public class CommentLikesParser : DefaultParser<CommentLikes> { }
    public class CommentParser : DefaultParser<Comment> { }
    public class ConfirmResultParser : DefaultParser<ConfirmResult> { }
    public class CounterParser : DefaultParser<Counter> { }
    public class DatabaseEntryParser : DefaultParser<DatabaseEntry> { }
    public class DocumentParser : DefaultParser<Document> { }
    public class ExportsParser : DefaultParser<Exports> { }
    public class GeoEntryParser : DefaultParser<GeoEntry> { }
    public class GeoParser : DefaultParser<Geo> { }
    public class GraffityParser : DefaultParser<Graffity> { }
    public class GroupParser : DefaultParser<Group> { }
    public class LinkParser : DefaultParser<Link> { }
    public class LyricsParser : DefaultParser<Lyrics> { }
    public class NoteParser : DefaultParser<Note> { }
    public class OccupationParser : DefaultParser<Occupation> { }
    public class PhotoLikesParser : DefaultParser<PhotoLikes> { }
    public class PhotosUploadServerParser : DefaultParser<PhotosUploadServer> { }
    public class PostCommentsParser : DefaultParser<PostComments> { }
    public class PlaceParser : DefaultParser<Place> { }
    public class PostedPhotoParser : DefaultParser<PostedPhoto> { }
    public class PostLikesParser : DefaultParser<PostLikes> { }
    public class PostRepostsParser : DefaultParser<PostReposts> { }
    public class PostSourceParser : DefaultParser<PostSource> { }
    public class ProfileCountersParser : DefaultParser<ProfileCounters> { }
    public class ProfilePhotosParser : DefaultParser<ProfilePhotos> { }
    public class RelativeParser : DefaultParser<Relative> { }
    public class SchoolParser : DefaultParser<School> { }
    public class SiteProfilesParser : DefaultParser<SiteProfiles> { }
    //TODO:парсинг аудиозаписи
    public class StatusParser : DefaultParser<Status> { }
    public class StorageEntryParser : DefaultParser<StorageEntry> { }
    public class UniversityParser : DefaultParser<University> { }
    public class VideoParser : DefaultParser<Video> { }
    public class GroupCountersParser : DefaultParser<GroupCounters> { }
    public class PrivacyParser : DefaultParser<Privacy> { }
}