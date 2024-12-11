using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.OOP
{
    public record class OwnDescriptionClass
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public OwnDescriptionClass()
        {
            Name = "Egor";
            Surname = "Salakhov";
            Age = 18;
        }
    }

    public record struct OwnDescriptionStruct
    {
        public int DotaMMR { get; set; }
        public Color HairColor { get; set; }

        public OwnDescriptionStruct(int mmr, Color color)
        {
            DotaMMR = mmr;
            HairColor = color;
        }
    }
}
