using System;

namespace kasthack.vksharp.DataTypes {
    public class ContentId : IFormattable{
        public ContentId( long id, int ownerId, string accessKey = "" ) {
            Id = id;
            OwnerId = ownerId;
            AccessKey = accessKey;
        }

        public long Id { get; set; }

        public int OwnerId { get;}

        public string AccessKey { get; }

        public override string ToString() { return String.Format( AccessKey != "" ? "{0}_{1}_{2}" : "{0}_{1}", OwnerId, Id, AccessKey ); }

        public string ToString( string format, IFormatProvider formatProvider ) { return String.Format(format, AccessKey != "" ? "{0}_{1}_{2}" : "{0}_{1}", OwnerId, Id, AccessKey); }

    }
}
