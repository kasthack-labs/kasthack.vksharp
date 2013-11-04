namespace VKSharp.VK.Interfaces {
    public interface IVKEntity<out T> where T : IVKEntity<T> {
        IVKEntityParser<T> GetParser();
    }
}