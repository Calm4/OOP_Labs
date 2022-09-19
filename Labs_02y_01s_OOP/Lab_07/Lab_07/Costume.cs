using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class Costume : Clothes
    {
        public Costume(string[] gender, int growth, int width, FabricType fabricType, ClothesColor clothesColor) : base(gender, growth, width, fabricType, clothesColor)
        {
        }
    }
}
