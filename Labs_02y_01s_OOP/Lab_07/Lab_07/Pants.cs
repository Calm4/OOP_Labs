using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_07
{
    internal class Pants : Clothes
    {
        public Pants(string[] gender, int growth, int width, FabricType fabricType, ClothesColor clothesColor) : base(gender, growth, width, fabricType, clothesColor)
        {
        }
    }
}
