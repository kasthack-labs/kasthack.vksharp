﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Data.Request;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<StructEntity<bool>> PagesClearCacheAsync(string url) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "pages.clearCache",
                Parameters =
                    new Dictionary<string, string> {
                        { "url", url },
                    }
            };
            if (IsLogged)
                req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        
    }
}