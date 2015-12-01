using System.IO;
using System.Threading.Tasks;

namespace kasthack.vksharp.Implementation {
    public interface IExecutor {
        Task<VkResponse<T>> ExecAsync<T>( Request<T> request );
        Task<string> ExecRawAsync<T>( Request<T> request );
        VkResponse<T> Parse<T>( string input );
        Task<Stream> ExecRawStreamAsync<T>( Request<T> request );
        VkResponse<T> ParseStream<T>( Stream input );
    }
}