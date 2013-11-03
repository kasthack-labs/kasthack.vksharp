using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class Attachment:IVKEntity<Attachment> {
        public IVKEntityParser<Attachment> GetParser() {
            throw new NotImplementedException();
        }
    }
}
