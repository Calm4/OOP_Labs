using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class Blazer : Costume
    {
        public Blazer(Gender gender, double growth, Type_clothes type, Color color) : base(gender, growth, type, color)
        {
        }

        static public void ShowBlazers(Blazer[] blazers)
        {
            for (int i = 0; i < blazers.Length; i++)
            {
                Console.WriteLine($"Пиджак №{i + 1}");
                Console.WriteLine("Часть костюма:\t" + "Пиджак : " + blazers[i].GetType());
                Console.WriteLine("Пол:\t\t" + blazers[i].Gender);
                Console.WriteLine("Рост:\t\t" + blazers[i].Growth);
                Console.WriteLine("Тип ткани:\t" + blazers[i].Type);
                Console.WriteLine("Цвет вещи:\t" + blazers[i].Color);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
