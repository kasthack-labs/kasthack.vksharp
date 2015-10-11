using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKSharp.Core.Entities;

namespace VKSharp.Core.EntityFragments
{
    public class CropPhoto {
        public Photo Photo { get; set; }
        public Rect Crop { get; set; }
        public Rect Rect { get; set; }
    }
}
