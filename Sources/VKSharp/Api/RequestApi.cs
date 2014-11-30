using System;
using System.Collections.Generic;
using VKSharp.Data.Api;

namespace VKSharp {
    public partial class RequestApi {
        private readonly List<VKToken> _tokens = new List<VKToken>();
        private uint _reqCounter;
        public uint ReqCounter => _reqCounter++;

        public VKToken CurrentToken {
            get {
                if ( _tokens.Count == 0 )
                    throw new InvalidOperationException("This method requires auth!");
                return _tokens[ (int) ( ReqCounter % _tokens.Count ) ];
            }
        }

        public void AddToken( VKToken token ) {
            _tokens.Add( token );
            IsLogged = true;
        }
        public bool IsLogged { get; set; }
        public int TokenCount => _tokens.Count;
    }
}
