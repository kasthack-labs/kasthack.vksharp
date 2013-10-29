using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VKSharp {
    public class VKApi {
        #region Vars
        private uint _reqCounter;
        private List<VKToken> _tokens = new List<VKToken>(); //tokens
        #endregion

        #region Properties & propfuncs
        private uint ReqCounter {
            get {
                return _reqCounter++;
            }
        }

        private VKToken CurrenToken {
            get {
                return _tokens[ (int) ( ReqCounter % _tokens.Count ) ];
            }
        }

        public void AddToken( VKToken token ) {
            _tokens.Add( token );
            IsLogged = true;
        }
        public bool IsLogged { get; private set; }
        #endregion
        #region Constructors
        public VKApi() { }
        #endregion
        #region Public functions
        #endregion

        #region Engine
        #endregion
    }
}
