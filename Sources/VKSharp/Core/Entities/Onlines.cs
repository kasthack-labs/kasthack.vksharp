using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities
{
    public class Onlines : IVKEntity<Onlines> {
        public VKApi Context { get; set; }
        public int?[] Time { get; set; }
        public int?[] Ids { get; set; }
    }
}
