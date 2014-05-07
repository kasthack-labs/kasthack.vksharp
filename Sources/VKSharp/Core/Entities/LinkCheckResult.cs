using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class LinkCheckResult :IVKEntity<LinkCheckResult> {
        public VKApi Context { get; set; }

        public string Link { get; set; }
        public LinkCheckStatus Status{ get; set; }
    }
}
