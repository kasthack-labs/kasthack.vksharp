using System;
using System.Collections.Generic;

namespace kasthack.vksharp {
    public partial class RequestApi {
        private readonly List<Token> _tokens = new List<Token>();
        private uint _reqCounter;
        public uint ReqCounter => _reqCounter++;

        public RequestApi() {
            InitializeMethodGroups();
        }

        public Token CurrentToken {
            get {
                if ( _tokens.Count == 0 )
                    throw new InvalidOperationException("This method requires auth!");
                return _tokens[ (int) ( ReqCounter % _tokens.Count ) ];

            }
        }
        public void AddToken( Token token ) {
            _tokens.Add( token );
            IsLogged = true;
        }
        public bool IsLogged { get; set; }
        public int TokenCount => _tokens.Count;
    }
}
