using System.Threading.Tasks;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Request;

namespace VKSharp.Data.Executors {
    public class SimpleXMLExecutor<T>:IExecutor<T> where T : IVKEntity<T> {
        public async Task<VKResponse<T>> ExecAsync(VKRequest<T> request) {
            if ()
        }
    }
}
