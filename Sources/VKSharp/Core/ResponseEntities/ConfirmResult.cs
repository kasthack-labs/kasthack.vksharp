using System;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.ResponseEntities {
    public class ConfirmResult : IVKEntity<ConfirmResult>{
        public uint Uid { get; set;}
        public bool Success { get; set; }
        public VKApi Context { get; set; }
    }
}

