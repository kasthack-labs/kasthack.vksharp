using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Enums;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;
using VKSharp.Core.Entities;

namespace VKSharp
{
    public enum WallPostFilter
	{
        All,
        Suggests,
        Postponded,
        Owner,
        Others,
	}
}