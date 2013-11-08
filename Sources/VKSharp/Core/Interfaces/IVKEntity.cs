namespace VKSharp.Core.Interfaces {
    public interface IVKEntity<T> where T : IVKEntity<T>, new() {
        IVKEntityParser<T> GetParser();
    }
}