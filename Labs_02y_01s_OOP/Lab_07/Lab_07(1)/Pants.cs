using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class Pants : Costume
    {
        public Pants(Gender gender, double growth, Type_clothes type, Color color) : base(gender, growth, type, color)
        {
        }
        static public void ShowPants(Pants[] pants)
        {
            for (int i = 0; i < pants.Length; i++)
            {
                Console.WriteLine($"Брюки №{i + 1}");
                Console.WriteLine("Часть костюма:\t" + "Брюки : " + pants[i].GetType());
                Console.WriteLine("Пол:\t\t" + pants[i].Gender);
                Console.WriteLine("Рост:\t\t" + pants[i].Growth);
                Console.WriteLine("Тип ткани:\t" + pants[i].Type);
                Console.WriteLine("Цвет вещи:\t" + pants[i].Color);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
