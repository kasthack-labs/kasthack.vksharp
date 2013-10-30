using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKSharp.VK.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class Privacy:IVKEntity<Privacy> {
        public PrivacyType PrivacyType { get; set; }
        public uint[] Lists { get; set; }
        public uint[] ExceptLists { get; set; }
        public uint[] Users { get; set; }
        public uint[] ExceptUsers { get; set; }
        public IVKEntityParser<Privacy> GetParser() {
            return PrivacyParser.Instanse;
        }
    }

    public enum PrivacyType {
        Nobody,
        All,
        Friends,
        FriendsOfFriends,
        Users
    }
}
