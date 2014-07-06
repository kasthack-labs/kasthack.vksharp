using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityFragments
{
    public class GeoEntry : IVKEntity<GeoEntry> {
        public uint Id { get; set; }
        public string Title { get; set; }
        public VKApi Context { get; set; }
    }
}
