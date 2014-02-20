using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
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

        public virtual void FillFromXml( IEnumerable<XmlNode> nodes, T entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public virtual T ParseFromXml( XmlNode node ) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public virtual T[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public virtual T ParseFromXmlFragments( IEnumerable<XmlNode> nodes ) {
            var sc = new T();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public virtual bool UpdateFromFragment( XmlNode node, T entity ) {
            Action<T, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }
    }
}
