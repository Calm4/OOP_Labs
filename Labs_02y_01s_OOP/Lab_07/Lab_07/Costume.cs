using Lab_07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class Costume : Clothes
    {

        public Pants Pants { get; set; }
        public Blazer Blazer { get; set; }
        public Skirts Skirt { get; set; }
        protected Costume(Gender gender, double growth, Type_clothes type, Color color) : base(gender, growth, type, color)
        {

        }
        public Costume(Pants pants, Blazer blazer) : base(pants, blazer)
        {
            Pants = pants;
            Blazer = blazer;
        }
        public Costume(Skirts skirt, Blazer blazer) : base(skirt, blazer)
        {
            Skirt = skirt;
            Blazer = blazer;
        }
        static public void ShowCostumeWithPants(Costume[] costumesWithPants)
        {
            for (int i = 0; i < costumesWithPants.Length; i++)
            {
                Console.WriteLine($"Costume №{i + 1}");
                Console.WriteLine("Часть костюма:\t" + "Брюки : " + costumesWithPants[i].Pants.GetType());
                Console.WriteLine("Пол:\t\t" + costumesWithPants[i].Pants.Gender);
                Console.WriteLine("Рост:\t\t" + costumesWithPants[i].Pants.Growth);
                Console.WriteLine("Тип ткани:\t" + costumesWithPants[i].Pants.Type);
                Console.WriteLine("Цвет вещи:\t" + costumesWithPants[i].Pants.Color);
                Console.WriteLine("=========================");
                Console.WriteLine("Часть костюма:\t" + "Пиджак : " + costumesWithPants[i].Blazer.GetType());
                Console.WriteLine("Пол:\t\t" + costumesWithPants[i].Blazer.Gender);
                Console.WriteLine("Рост:\t\t" + costumesWithPants[i].Blazer.Growth);
                Console.WriteLine("Тип ткани:\t" + costumesWithPants[i].Blazer.Type);
                Console.WriteLine("Цвет вещи:\t" + costumesWithPants[i].Blazer.Color);
                Console.WriteLine("=================================================");
            }
        }
        static public void ShowCostumeWithSkirts(Costume[] costumesWithSkirts)
        {
            for (int i = 0; i < costumesWithSkirts.Length; i++)
            {
                Console.WriteLine($"Costume №{i + costumesWithSkirts.Length + 1}");
                Console.WriteLine("Часть костюма:\t" + "Юбка : " + costumesWithSkirts[i].Skirt.GetType());
                Console.WriteLine("Пол:\t\t" + costumesWithSkirts[i].Skirt.Gender);
                Console.WriteLine("Рост:\t\t" + costumesWithSkirts[i].Skirt.Growth);
                Console.WriteLine("Тип ткани:\t" + costumesWithSkirts[i].Skirt.Type);
                Console.WriteLine("Цвет вещи:\t" + costumesWithSkirts[i].Skirt.Color);
                Console.WriteLine("=========================");
                Console.WriteLine("Часть костюма:\t" + "Пиджак : " + costumesWithSkirts[i].Blazer.GetType());
                Console.WriteLine("Пол:\t\t" + costumesWithSkirts[i].Blazer.Gender);
                Console.WriteLine("Рост:\t\t" + costumesWithSkirts[i].Blazer.Growth);
                Console.WriteLine("Тип ткани:\t" + costumesWithSkirts[i].Blazer.Type);
                Console.WriteLine("Цвет вещи:\t" + costumesWithSkirts[i].Blazer.Color);
                Console.WriteLine("=================================================");
            }
        }

    }
}
