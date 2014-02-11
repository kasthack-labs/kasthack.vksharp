namespace VKSharp.Core.Interfaces {
    public interface IVKEntity<T> where T : IVKEntity<T> {
        VKApi Context { get; set; }
        //IXmlVKEntityParser<T> GetParser();
    }
}