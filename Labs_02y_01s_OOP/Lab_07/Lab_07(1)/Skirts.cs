using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class Skirts : Costume
    {
        public Skirts(Gender gender, double growth, Type_clothes type, Color color) : base(gender, growth, type, color)
        {
        }
        static public void ShowSkirt(Skirts[] skirts)
        {
           
            for (int i = 0; i < skirts.Length; i++)
            {
                Console.WriteLine($"Юбка №{i + 1}");
                Console.WriteLine("Часть костюма:\t" + "Юбка : " + skirts[i].GetType());
                Console.WriteLine("Пол:\t\t" + skirts[i].Gender);
                Console.WriteLine("Рост:\t\t" + skirts[i].Growth);
                Console.WriteLine("Тип ткани:\t" + skirts[i].Type);
                Console.WriteLine("Цвет вещи:\t" + skirts[i].Color);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
