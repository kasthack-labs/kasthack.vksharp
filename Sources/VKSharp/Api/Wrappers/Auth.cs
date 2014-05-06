using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EpicMorg.Net;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public StructEntity<bool> AuthCheckPhone(
            string phone,
            string clientSecret,
            int? clientId = null) {
            return Helper.SyncTask(this.AuthCheckPhoneAsync(phone, clientSecret, clientId));
        }
    }
}
