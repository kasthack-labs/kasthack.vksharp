using System.Threading.Tasks;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Request;

namespace VKSharp.Data.Executors {
    public interface IExecutor<T> where T:IVKEntity<T> {
        Task<VKResponse<T>> ExecAsync(VKRequest<T> request);
    }
}