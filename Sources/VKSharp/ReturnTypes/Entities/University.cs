namespace VKSharp.Core.Entities {
    public class University  {
        public string ChairName { get; set; }
        public string FacultyName { get; set; }
        public string Name { get; set; }
        public string EducationForm { get; set; }
        public string EducationStatus { get; set; }
        public int City { get; set; }
        public int Country { get; set; }
        public int Id { get; set; }
        public int? Chair { get; set; }
        public int? Faculty { get; set; }
        public ushort? Graduation { get; set; }
    }
}
