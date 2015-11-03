using kasthack.vksharp.DataTypes.Enums;
using kasthack.vksharp.DataTypes.Interfaces;

namespace kasthack.vksharp.DataTypes.Entities {
    public class Audio : OwnedEntity {
        public AudioGenre GenreId { get; set; }
        public int AlbumId { get; set; }
        public int LyricsId { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int Duration { get; set; }

        public override string ToString() => Artist + " - " + Title;
        public static explicit operator ObjectContentId(Audio audio) => new ObjectContentId( ContentType.Audio, audio.Id, audio.OwnerId );
        public static implicit operator ContentId(Audio audio) => (ObjectContentId)audio;
    }
}
