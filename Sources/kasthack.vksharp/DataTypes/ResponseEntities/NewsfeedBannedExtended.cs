using kasthack.vksharp.DataTypes.Entities;
using Group = System.Text.RegularExpressions.Group;

namespace kasthack.vksharp.DataTypes.ResponseEntities {

    public class NewsfeedBannedExtended {

        public Group[] Groups { get; set; }
        public User[] Profiles { get; set; }

    }

}