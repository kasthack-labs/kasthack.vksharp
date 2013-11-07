namespace VKSharp.Core.Interfaces {
    public interface IVKEntity<out T> where T : IVKEntity<T>, new() {
        IVKEntityParser<T> GetParser();
    }
}