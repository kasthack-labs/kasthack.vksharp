namespace VKSharp.Core.Interfaces {
    public interface IVKEntity<T> where T : IVKEntity<T>, new() {
        VKApi Context { get; set; }
        //IXmlVKEntityParser<T> GetParser();
    }
}