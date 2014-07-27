using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VKSharp.Core.Entities;

namespace VKSharp.Core.EntityParsers.Xml
{
    public class OnlinesParser : DefaultParser<Onlines> {
        public override bool UpdateFromFragment( XElement node, Onlines entity ) {
            if ( base.UpdateFromFragment( node, entity ) )
                return true;
            switch ( node.Name.LocalName.ToLowerInvariant() ) {
                case "ids":
                    { 
                    var nodes = node.Elements().ToArray();
                    var cnt = nodes.Count();
                    entity.Ids = new int?[cnt];
                    for ( int i = 0; i < cnt; i++ ) {
                        int tmp;
                        if ( int.TryParse( nodes[ i ].Value, out tmp ) )
                            entity.Ids[ i ] = tmp;
                    }
                    }
                    break;
                case "time":
                    { 
                    var nodes = node.Elements().ToArray();
                    var cnt = nodes.Count();
                    entity.Time = new int?[cnt];
                    for (int i = 0; i < cnt; i++)
                    {
                        int tmp;
                        if (int.TryParse(nodes[i].Value, out tmp))
                            entity.Time[i] = tmp;
                    }
                    }
                    break;
                default:
                    return false;
            }
            return true;
        }
    }
}
