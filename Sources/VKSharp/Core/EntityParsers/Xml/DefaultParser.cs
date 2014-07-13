using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public abstract class DefaultParser<T> : IXmlVKEntityParser<T> where T : IVKEntity<T>, new() {
        private SimpleXMLExecutor _executor;

        public IExecutor Executor {
            get {
                return _executor;
            }
            set {
                _executor = value as SimpleXMLExecutor;
            }
        }

        //primitives
        protected static readonly Lazy<Dictionary<string, Action<T, string>>> GeneratedParsersLazy =
            new Lazy<Dictionary<string, Action<T, string>>>( ParserHelper.GetStringParsers<T> );
        //subentities
        protected Dictionary<string, Action<T, XElement>> SubentityParsers;

        protected static Dictionary<string, Action<T, string>> GeneratedParsers {
            get {
                return GeneratedParsersLazy.Value;
            }
        }

        public virtual void FillFromXml( IEnumerable<XElement> nodes, T entity ) {
            foreach ( var cn in nodes )
                UpdateFromFragment( cn, entity );
        }

        public virtual T ParseFromXml( XElement node ) {
            return ParseFromXmlFragments( node.Elements() );
        }

        public virtual T[] ParseAllFromXml( IEnumerable<XElement> nodes ) {
            return nodes.Select( ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public virtual T ParseFromXmlFragments( IEnumerable<XElement> nodes ) {
            var sc = new T();
            FillFromXml( nodes, sc );
            return sc;
        }

        public virtual bool UpdateFromFragment( XElement node, T entity ) {
            Action<T, string> parser;
            var nodeName = node.Name.ToString();
            if ( !GeneratedParsers.TryGetValue( nodeName, out parser ) ) return false;
            try {
                parser( entity, node.Value );
            }
            catch ( Exception ex ) {
                throw new Exception(
                    String.Format(
                        "Parser error: field {0} at entity {1}\r\nXml:\r\n{2}",
                        node.Name,
                        typeof( T ),
                        node.Document
                    ),
                    ex
                );
            }
            return true;
        }

        public virtual void Attach() {
            var simpleXMLExecutor = Executor as SimpleXMLExecutor;
            if ( simpleXMLExecutor != null ) simpleXMLExecutor.AttachParser( this );
        }


        protected IXmlVKEntityParser<TEntity> GetP<TEntity>() where TEntity : IVKEntity<TEntity>
        {
            return ((SimpleXMLExecutor)Executor).GetParser<TEntity>();
        }
    }
}
