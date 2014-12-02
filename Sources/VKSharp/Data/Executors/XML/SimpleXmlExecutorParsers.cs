using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using VKSharp.Core.Interfaces;
using VKSharp.Helpers;

namespace VKSharp.Data.Executors{
    //public partial class SimpleXMLExecutor {
    //    #region Types & methodInfos
    //    //Current type 
    //    private static readonly Lazy<Type> CurrentTypeLazy = new Lazy<Type>(()=>typeof(SimpleXMLExecutor));
    //    private static Type CurrentType => CurrentTypeLazy.Value;
    //    //getParsers
    //    private static readonly Lazy<MethodInfo> GetPropertiesParserTypedMethodLazy = new Lazy<MethodInfo>( () =>CurrentType.GetMethod( nameof(GetPropertiesParserTyped) ));
    //    private static MethodInfo GetPropertiesParserTypedMethod => GetPropertiesParserTypedMethodLazy.Value;
    //    //nullable
    //    private static readonly Lazy<Type> NullableTypeLazy = new Lazy<Type>(()=>typeof(Nullable<>));
    //    private static Type NullableType => NullableTypeLazy.Value;

    //    private static readonly Lazy<Type> VkentityTypeLazy = new Lazy<Type>(()=>typeof(IVKEntity<>));
    //    private static Type VkentityType => VkentityTypeLazy.Value;
    //    #endregion

    //    /// <summary>
    //    /// Dictionary of property parsers
    //    /// key: target type
    //    /// value: tryparse delegate
    //    /// </summary>
    //    private static readonly Dictionary<Type, object> PropertyParsers = new Dictionary<Type, object> {
    //        {typeof(string), new Func<string,string>(s=>s.Trim('\r','\n','\t', ' ')) },
    //        {typeof(bool), new Func<string,bool>(s=>{int r; return int.TryParse( s, out r) && (r==1);})},
    //        {typeof(bool?), new Func<string,bool?>(s=>{int r; return int.TryParse( s, out r)?(bool?)(r==1):null;})},
    //    };

    //    private static readonly object ParsersLocker = new object();

    //    /// <summary>
    //    /// returns parser for T
    //    /// </summary>
    //    /// <typeparam name="T">type to parse</typeparam>
    //    /// <returns>parser</returns>
    //    internal IXmlVKEntityParser<T> GetParser<T>() where T : IVKEntity<T> {
    //        throw new NotImplementedException();
    //    }
    //    /// <summary>
    //    /// Generate parsers for T.
    //    /// </summary>
    //    /// <typeparam name="T"></typeparam>
    //    /// <returns>dictionary where key is property node name and value is func that takes node value and updates target entity</returns>
    //    internal static Dictionary<string, Action<T, string>> GetStringParsers<T>() {
    //        var tt = typeof( T );
    //        //todo: flatmapattribute
    //        var props = tt.GetProperties( BindingFlags.Instance | BindingFlags.Public ).Where( a => a.CanWrite );
    //        var dic = new Dictionary<string, Action<T, string>>();
    //        foreach ( var prop in props.GroupBy( a=>a.PropertyType ).ToArray() ) {
    //            var propertyInfos = prop.ToArray();
    //            GetPropertiesParser( propertyInfos, dic );
    //        }
    //        return dic;
    //    }
    //    /// <summary>
    //    /// Add parsers for properties to parser dictionary
    //    /// </summary>
    //    /// <typeparam name="T">entity type</typeparam>
    //    /// <param name="props">properties</param>
    //    /// <param name="dic">output dictionary</param>
    //    private static void GetPropertiesParser<T>( PropertyInfo[] props, Dictionary<string, Action<T, string>> dic ) {
    //        if ( !props.Any() ) return;

    //        var proptype = props.First().PropertyType;
    //        if (props.Any(a=>a.PropertyType!=proptype))//different types
    //            throw new InvalidOperationException("Properties must be all the same type");
    //        GetPropertiesParserTypedMethod.MakeGenericMethod( typeof( T ), proptype ).Invoke( null, new object[] { props, dic } );
    //    }
    //    /// <summary>
    //    /// Add parsers for properties to parser dictionary
    //    /// </summary>
    //    /// <typeparam name="TEntity">entity types</typeparam>
    //    /// <typeparam name="TProperties">property type</typeparam>
    //    /// <param name="properties">properties to add</param>
    //    /// <param name="dic">output dictionary</param>
    //    private static void GetPropertiesParserTyped<TEntity, TProperties>( PropertyInfo[] properties, Dictionary<string, Action<TEntity, string>> dic ) {
    //        var ptype = typeof( TProperties );
    //        var etype = typeof( TEntity );
    //        { 
    //            object parser;
    //            if ( PropertyParsers.TryGetValue( etype, out parser ) ) {
    //                AddPropertiesParser( properties, dic, (Func<string, TProperties>) parser );
    //                return;
    //            }
    //        }
    //        {
    //            if (!BuildParser<TProperties>())
    //                throw new NotSupportedException("Failed to build");
    //            throw new NotImplementedException();
    //        }
    //    }

    //    private static bool BuildParser<T>() {
    //        var basetype = GetBaseType<T>( typeof( T ) );

    //        if ( basetype.GetInterface( VkentityType.Name ) != null ) {
    //            //PropertyParsers.Add( basetype,  );
    //        }
    //        return false;
    //    }
    //    /// <summary>
    //    /// Gets base type for parsing
    //    /// </summary>
    //    /// <typeparam name="T"></typeparam>
    //    /// <param name="maintype"></param>
    //    /// <returns></returns>
    //    private static Type GetBaseType<T>( Type maintype ) {
    //        var basetype = maintype;
    //        if ( basetype.IsArray ) basetype = maintype;
    //        if ( basetype.IsGenericType
    //             && basetype.GetGenericTypeDefinition() == NullableType ) basetype = basetype.GetGenericArguments()[ 0 ];
    //        return basetype;
    //    }

    //    /// <summary>
    //    /// Apply parser to properties
    //    /// </summary>
    //    /// <typeparam name="TEntity"></typeparam>
    //    /// <typeparam name="TProperty"></typeparam>
    //    /// <param name="properties"></param>
    //    /// <param name="dic"></param>
    //    /// <param name="parser"></param>
    //    private static void AddPropertiesParser<TEntity, TProperty>(
    //        PropertyInfo[] properties,
    //        Dictionary<string, Action<TEntity, string>> dic,
    //        Func<string, TProperty> parser ) {
    //        foreach ( var property in properties )
    //            AddPropertyParser( property, dic, parser );
    //    }

    //    private static void AddPropertyParser<TEntity, TProperty>(
    //        PropertyInfo property,
    //        Dictionary<string, Action<TEntity, string>> dic,
    //        Func<string, TProperty> parser ) {
    //        dic.Add( GetPropertyNodeName(property), GetPropertyUpdater<TEntity, TProperty>(property, parser));
    //    }
    //    /// <summary>
    //    /// Get underlying xml node for property
    //    /// </summary>
    //    /// <param name="property">property</param>
    //    /// <returns>node name</returns>
    //    private static string GetPropertyNodeName( PropertyInfo property ) => property.Name.ToSnake();
    //    /// <summary>
    //    /// Generates updater delegate from parser
    //    /// </summary>
    //    /// <typeparam name="TEntity">entity type</typeparam>
    //    /// <typeparam name="TProperty">property type</typeparam>
    //    /// <param name="property">target property</param>
    //    /// <param name="parser">parser delegate</param>
    //    /// <returns>delegate which parses string and updates spicified property</returns>
    //    private static Action<TEntity, string> GetPropertyUpdater<TEntity, TProperty>( PropertyInfo property, Func<string, TProperty> parser ) {
    //        var updater = (Action<TEntity, TProperty>)Delegate.CreateDelegate( typeof(Action<TEntity, TProperty>), null, property.GetSetMethod() );
    //        return ( entity, value ) => updater( entity, parser( value ) );
    //    }
    //}
    public partial class SimpleXMLExecutor {
        private static class Ser<T> {
            private static readonly Lazy<XmlSerializer> ser = new Lazy<XmlSerializer>(()=>new XmlSerializer( typeof(T) ));
            internal static XmlSerializer Serializer => ser.Value;
        }

        public static T ParseXml<T>( string input ) {
            var doc = XDocument.Parse( input );
            foreach ( var descendant in doc.Descendants() ) {
                descendant.Name = ToMeth( descendant.Name.ToString() );
            }
            var cs = doc.ToString();
            using ( var sr = new StringReader( cs ) ) {
                return (T) Ser<T>.Serializer.Deserialize( sr );
            }
        }

        public static string ToMeth( string name, bool p = false ) {
            var t = new StringBuilder();
            t.Append( p ? Char.ToLower( name[ 0 ] ) : Char.ToUpper( name[ 0 ] ) );
            for ( var index = 1; index < name.Length; index++ ) {
                var c = name[ index ];
                //add '_' before numbers and capitals 
                if ( c == '.' || c == '_' ) t.Append( Char.ToUpper( name[ ++index ] ) );
                else t.Append( c );
            }
            return t.ToString();
        }
    }
}
