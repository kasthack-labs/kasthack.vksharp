namespace VKSharp.Data.Request {
    public class VKResponse<T> {
        public T Response { get; set; }
        public VKError Error { get; set; }
    }

    public class VKError {
        public int ErrorCode { get; set; }
        public string ErrorMsg { get; set; }
    }
}