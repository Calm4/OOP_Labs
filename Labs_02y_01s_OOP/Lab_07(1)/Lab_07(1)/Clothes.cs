using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07_1_
{
    internal class Clothes
    {
        public Gender Gender { get; set; }
        public double Growth { get; set; }
        public Type_clothes Type { get; set; }
        public Color Color { get; set; }
        public Pants Pants { get; set; }
        public Blazer Blazer { get; set; }
        public Skirts Skirt { get; set; }
        protected Clothes(Gender gender, double growth, Type_clothes type, Color color)
        {
            Gender = gender;
            Growth = growth;
            Type = type;
            Color = color;
        }
        public Clothes(Pants pants, Blazer blazer)
        {
            Pants = pants;
            Blazer = blazer;
        }
        public Clothes(Skirts skirt, Blazer blazer)
        {
            Skirt = skirt;
            Blazer = blazer;
        }
    }
}
