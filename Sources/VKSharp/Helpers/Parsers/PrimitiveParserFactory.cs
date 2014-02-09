using System;
using System.Collections.Generic;
using VKSharp.Core.Interfaces;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp.Helpers.Parsers {
    public static class PrimitiveParserFactory {
        private static readonly Lazy<Dictionary<Type, object>> ParserLazy = new Lazy<Dictionary<Type, object>>( () => new Dictionary<Type, object> {
            {
                typeof(int),
                new PrimitiveParser<int>(int.Parse)
            },
            {
                typeof(uint),
                new PrimitiveParser<uint>(uint.Parse)
            },
            {
                typeof(long),
                new PrimitiveParser<long>(long.Parse)
            },
            {
                typeof(ulong),
                new PrimitiveParser<ulong>(ulong.Parse)
            },
            {
                typeof(short),
                new PrimitiveParser<short>(short.Parse)
            },
            {
                typeof(ushort),
                new PrimitiveParser<ushort>(ushort.Parse)
            },
            {
                typeof(byte),
                new PrimitiveParser<byte>(byte.Parse)
            },
            {
                typeof(sbyte),
                new PrimitiveParser<sbyte>(sbyte.Parse)
            },
            {
                typeof(bool),
                new PrimitiveParser<bool>(s => int.Parse(s)==1)
            }
        } );
        private static Dictionary<Type, object> Parsers {
            get {
                return ParserLazy.Value;
            }
        }
        public static IXmlVKEntityParser<T> GetParser<T,T2>() where T : StructEntity<T2> where T2 : struct {
            return GetParserFor<T,T2>(typeof (T));
        }
        public static IXmlVKEntityParser<T> GetParserFor<T,T2>( Type ti ) where T : StructEntity<T2> where T2 : struct {
            return (IXmlVKEntityParser<T>) Parsers[ ti ];
        }
    }
}