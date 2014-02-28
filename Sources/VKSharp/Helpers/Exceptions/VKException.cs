using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKSharp.Helpers.Exceptions {
    public class VKException:Exception {
        public VKException( string message ):base(message) {
        }
    }
}
