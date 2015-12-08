using System;
using System.Globalization;
using kasthack.vksharp.DataTypes.Enums;
using kasthack.vksharp.Internal;

namespace kasthack.vksharp.DataTypes  {

    public abstract class ContentId : IFormattable {

        public abstract string ToIdString( IFormatProvider info = null );

        public abstract string ToAttachmentString( IFormatProvider info = null );

        public abstract string ToString( string format, IFormatProvider formatProvider );

    }

    public class StringContentId : ContentId {

        public string Value { get; set; }

        public StringContentId( string value ) {
            Value = value;
        }

        public override string ToIdString( IFormatProvider info = null ) => Value;//todo: trim type?

        public override string ToAttachmentString( IFormatProvider info = null ) => Value;

        public override string ToString( string format, IFormatProvider formatProvider ) => Value;

        public static implicit operator StringContentId(string source) => new StringContentId( source );

    }
    public class ObjectContentId : ContentId, IFormattable, IEquatable<ObjectContentId> {

        public ObjectContentId( ContentType type, long id, int ownerId, string accessKey = "" ) {
            Type = type;
            Id = id;
            OwnerId = ownerId;
            AccessKey = accessKey;
        }

        public ContentType Type { get; set; }

        public long Id { get; set; }

        public int OwnerId { get;}

        public string AccessKey { get; }

        public override string ToIdString(IFormatProvider info = null) => string.Format(info ?? CultureInfo.InvariantCulture, AccessKey != "" ? "{0}_{1}_{2}" : "{0}_{1}", OwnerId, Id, AccessKey );

        public override string ToAttachmentString(IFormatProvider info = null) => string.Format( info??CultureInfo.InvariantCulture, AccessKey != "" ? "{3}{0}_{1}_{2}" : "{3}{0}_{1}", OwnerId, Id, AccessKey, GetTypeString( Type ) );

        public override string ToString( string format, IFormatProvider formatProvider ) => ToIdString( formatProvider );

        public static bool operator ==( ObjectContentId a, ObjectContentId b ) {
            if ( ReferenceEquals( a, b ) ) return true;
            if ( ReferenceEquals( a, null ) || ReferenceEquals(b, null)) return false;
            return a.Type == b.Type && a.Id == b.Id && a.OwnerId == b.OwnerId && a.AccessKey == b.AccessKey;
        }

        public static bool operator !=( ObjectContentId a, ObjectContentId b ) => !( a == b );

        public bool Equals( ObjectContentId other ) => this == other;

        private static string GetTypeString( ContentType type ) {
            switch ( type ) {
                case ContentType.Photo:
                case ContentType.PostedPhoto:
                    return "photo";
                case ContentType.Video:
                    return "video";
                case ContentType.Audio:
                    return "audio";
                case ContentType.Doc:
                    return "doc";
                case ContentType.Graffiti:
                    return "graffiti";
                case ContentType.Note:
                    return "note";
                case ContentType.App:
                    return "app";
                case ContentType.Poll:
                    return "poll";
                case ContentType.Page:
                    return "page";
                case ContentType.Album:
                    return "album";
                case ContentType.Wall:
                    return "wall";
                case ContentType.WallReply:
                    return "wall_reply";
                default:
                    throw new ArgumentOutOfRangeException( nameof( type ), type, null );
            }
        }

    }

}
