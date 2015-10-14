namespace VKSharp.Core.Entities {
    public class Tag {
        public int UserId { get; set; }
        public int TagId { get; set; }
        public int PlacerId { get; set; }
        public string TaggedName { get; set; }
        public bool Viewed { get; set; }
    }

    public class PhotoTag : Tag {

        public double X { get; set; }
        public double Y { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
    }
}
