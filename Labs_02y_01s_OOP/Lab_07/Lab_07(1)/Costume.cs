using System;
using System.Collections.Generic;
using System.IO;
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
        static public void ShowClothesAssortment(Pants[] pants,Skirts[] skirts,Blazer[] blazers,Costume[] costumesWithPants,Costume[] costumesWithSkirts)
        {
            int pantsCountMan = 0;
            int skirtsCountMan = 0;
            int blazersCountMan = 0;

            int pantsCountWoMan = 0;
            int skirtsCountWoMan = 0;
            int blazersCountWoMan = 0;
            for (int i = 0; i < pants.Length; i++)
            {
                if (pants[i].Gender == Gender.Man)
                {
                    pantsCountMan++;
                }
                if (pants[i].Gender == Gender.Woman)
                {
                    pantsCountWoMan++;
                }
            }
            for (int i = 0; i < skirts.Length; i++)
            {
                if (skirts[i].Gender == Gender.Man)
                {
                    skirtsCountMan++;
                }
                if (pants[i].Gender == Gender.Woman)
                {
                    skirtsCountWoMan++;
                }
            }
            for (int i = 0; i < blazers.Length; i++)
            {
                if (blazers[i].Gender == Gender.Man)
                {
                    blazersCountMan++;
                }
                if (blazers[i].Gender == Gender.Woman)
                {
                    blazersCountWoMan++;
                }
            }
            for (int i = 0; i < costumesWithPants.Length; i++)
            {
                if (costumesWithPants[i].Pants.Gender == Gender.Man)
                {
                    pantsCountMan++;
                    blazersCountMan++;
                }
                if (costumesWithPants[i].Pants.Gender == Gender.Woman)
                {
                    pantsCountWoMan++;
                    blazersCountWoMan++;
                }
            }
            for (int i = 0; i < costumesWithSkirts.Length; i++)
            {
                if (costumesWithSkirts[i].Skirt.Gender == Gender.Man)
                {
                    skirtsCountMan++;
                    blazersCountMan++;
                }
                if (costumesWithSkirts[i].Skirt.Gender == Gender.Woman)
                {
                    skirtsCountWoMan++;
                    blazersCountWoMan++;
                }
            }
            Console.WriteLine($"Кол-во мужских ЮБОК: {skirtsCountMan}");
            Console.WriteLine($"Кол-во женских ЮБОК: {skirtsCountWoMan}");
            Console.WriteLine($"Кол-во мужских БРЮК: {skirtsCountMan}");
            Console.WriteLine($"Кол-во женских БРЮК: {skirtsCountWoMan}");
            Console.WriteLine($"Кол-во мужских ПИДЖАКОВ: {blazersCountMan}");
            Console.WriteLine($"Кол-во женских ПИДЖАКОВ: {blazersCountWoMan}");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
