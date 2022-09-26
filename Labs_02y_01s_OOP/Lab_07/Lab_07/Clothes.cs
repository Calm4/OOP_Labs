using Lab_07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class Clothes
    {
<<<<<<< HEAD
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
=======
        public ClothesColor ClothesColor = new ClothesColor();
        public FabricType FabricType = new FabricType();
        public int Growth { get; set; }
        public int Width { get; set; }
        public string[] Gender = new string[2] {"Male","Female"}; 

        /*public Clothes(string[] gender,int growth,int width,FabricType fabricType, ClothesColor clothesColor)
        {
            gender = Gender;
            growth = Growth;
            width = Width;
            fabricType = FabricType;
            clothesColor = ClothesColor;
        }*/

       
       
>>>>>>> b6417ed17402e148b0db5026411e9b33823085c5
    }
}
