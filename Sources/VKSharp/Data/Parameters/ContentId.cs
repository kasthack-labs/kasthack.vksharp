using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKSharp.Data.Parameters {
    public class ContentId {
        public ContentId( long id, int ownerId, string accessKey = "" ) {
            Id = id;
            OwnerId = ownerId;
            AccessKey = accessKey;
        }

        public long Id { get; set; }

        public int OwnerId { get;}

        public string AccessKey { get; }

        public override string ToString() { return String.Format( AccessKey != "" ? "{0}_{1}_{2}" : "{0}_{1}", OwnerId, Id, AccessKey ); }
    }
}
