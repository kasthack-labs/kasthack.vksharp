using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public abstract class DefaultParser<T> : IXmlVKEntityParser<T> where T : IVKEntity<T>, new() {
        public IExecutor Executor { get; set; }

        protected static readonly Lazy<Dictionary<string, Action<T, string>>> GeneratedParsersLazy = new Lazy<Dictionary<string, Action<T, string>>>( ParserHelper.GetStringParsers<T> );
        protected static Dictionary<string, Action<T, string>> GeneratedParsers {
            get {
                return GeneratedParsersLazy.Value;
            }
        }

        public virtual void FillFromXml( IEnumerable<XElement> nodes, T entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public virtual T ParseFromXml( XElement node ) {
            return this.ParseFromXmlFragments( node.Elements() );
        }

        public virtual T[] ParseAllFromXml( IEnumerable<XElement> nodes ) {
            var list = new List<T>();
            foreach (var node in nodes) {
                var a = this.ParseFromXml( node );
                if ( a != null )
                    list.Add( a );
            }
            return list.ToArray();
        }

        public virtual T ParseFromXmlFragments( IEnumerable<XElement> nodes ) {
            var sc = new T();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public virtual bool UpdateFromFragment( XElement node, T entity ) {
            Action<T, string> parser;
            var nodeName = node.Name.ToString();
            if ( !GeneratedParsers.TryGetValue( nodeName, out parser ) ) return false;
            try {
                parser( entity, node.Value );
            }
            catch (Exception ex) {
                //if (ex is FormatException || ex is OverflowException)
                throw new Exception(String.Format("Parser error: field {0} at entity {1}\r\nXml:\r\n{2}", node.Name, typeof(T), node.Document.ToString()), ex);
            }
            return true;
        }
    }
}
