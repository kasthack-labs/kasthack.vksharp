namespace kasthack.vksharp.Implementation {
    public class VkResponse<T> {
        public T Response { get; set; }
        public Error Error { get; set; }
    }

    public class Error {
        public int ErrorCode { get; set; }
        public string ErrorMsg { get; set; }
    }
}