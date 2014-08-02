using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities
{
    public class Status : IVKEntity<Status> {
        public VKApi Context { get; set; }
        public string Text { get; set; }
    }
}
