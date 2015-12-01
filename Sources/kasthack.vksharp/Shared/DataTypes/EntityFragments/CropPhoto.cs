using kasthack.vksharp.DataTypes.Entities;

namespace kasthack.vksharp.DataTypes.EntityFragments
{
    public class CropPhoto {
        public Photo Photo { get; set; }
        public Rect Crop { get; set; }
        public Rect Rect { get; set; }
    }
}
