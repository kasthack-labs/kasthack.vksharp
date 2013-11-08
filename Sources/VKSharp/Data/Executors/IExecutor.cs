using System.Threading.Tasks;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Request;

namespace VKSharp.Data.Executors {
    public interface IExecutor {
       Task<VKResponse<T>> ExecAsync<T>(VKRequest<T> request) where T : IVKEntity<T>, new();
       Task<string> ExecRawAsync<T>( VKRequest<T> request ) where T : IVKEntity<T>, new();
    }
}