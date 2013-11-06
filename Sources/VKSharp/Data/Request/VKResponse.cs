namespace VKSharp.Data.Request {
    public class VKResponse<T> {
        public T[] Data { get; set; }
        public ResponseStatus Status { get; set; }
    }
}