using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Gender = new string[2] { "Male", "Female" };
            Clothes Look_01 = new Clothes(Gender,180,32,FabricType.Wool,ClothesColor.Orange);
            Pants pants_01 = new Pants(Gender,180,32,FabricType.Leather,ClothesColor.White);
            Pants jacket_01 = new Pants(Gender, 180, 32, FabricType.Leather, ClothesColor.White);
            Clothes Look_02 = new Clothes(pants_01,jacket_01);
            Console.WriteLine(Look_02);
            
        }
    }
    enum ClothesColor
    {
        Black,
        White,
        Orange,
        Blue,
        Green,
        Red
    }
    enum FabricType
    {
        Leather, // кожа
        Synthetic, // синтетика
        Сotton, // хлопок
        Wool, // шерсть

    }
   
}
