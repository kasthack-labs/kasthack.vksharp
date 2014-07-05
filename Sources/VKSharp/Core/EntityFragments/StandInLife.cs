using System;
using VKSharp.Core.Interfaces;
using VKSharp.Core.Enums;

namespace VKSharp.Core.EntityFragments {
    public class StandInLife : IVKEntity<StandInLife> {
        public PoliticalPreferences Political { get; set; }
        public string[] Langs { get; set; }
        public string Religion { get; set; }
        public string InspiredBy { get; set; }
        public PeopleMain PeopleMain { get; set; }
        public LifeMain LifeMain { get; set; }
        public Attitude Smoking { get; set; }
        public Attitude Alcohol { get; set; }
        public VKApi Context { get; set;}
    }
}

