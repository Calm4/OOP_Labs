using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class Clothes 
    {
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

       
       
    }
}
