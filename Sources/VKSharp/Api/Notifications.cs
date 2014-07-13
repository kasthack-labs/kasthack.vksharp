using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VKSharp.Data.Request;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task NotificationsMarkAsViewedAsync() {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "notifications.markAsViewed",
                Parameters = new Dictionary<string, string> ()
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
    }
}
