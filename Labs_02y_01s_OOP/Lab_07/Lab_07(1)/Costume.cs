using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    public class Costume : Clothes
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
        static public string ShowCostumeWithPants(Costume[] costumesWithPants,int index)
        {
            //costumesWithPants.Length

            return $"Costume №{index + 1}" + "\n" +
            "Часть костюма:\t" + "Брюки : " + costumesWithPants[index].Pants.GetType() + "\n" +
            "Полa:\t\t" + costumesWithPants[index].Pants.Gender + "\n" +
            "Рост:\t\t" + costumesWithPants[index].Pants.Growth + "\n" +
            "Тип ткани:\t" + costumesWithPants[index].Pants.Type + "\n" +
            "Цвет вещи:\t" + costumesWithPants[index].Pants.Color + "\n" +
            "=========================" + "\n" + 
            "Часть костюма:\t" + "Пиджак : " + costumesWithPants[index].Blazer.GetType() + "\n" +
            "Пол:\t\t" + costumesWithPants[index].Blazer.Gender + "\n" +
            "Рост:\t\t" + costumesWithPants[index].Blazer.Growth + "\n" +
            "Тип ткани:\t" + costumesWithPants[index].Blazer.Type + "\n" +
            "Цвет вещи:\t" + costumesWithPants[index].Blazer.Color + "\n" +
            "=================================================" + "\n";



        }
        static public string ShowCostumeWithSkirts(Costume[] costumesWithSkirts,int index)
        {
            return $"Costume №{index + costumesWithSkirts.Length + 1}" + "\n" +
                "Часть костюма:\t" + "Юбка : " + costumesWithSkirts[index].Skirt.GetType() + "\n" +
                "Пол:\t\t" + costumesWithSkirts[index].Skirt.Gender + "\n" +
                "Рост:\t\t" + costumesWithSkirts[index].Skirt.Growth + "\n" +
                "Тип ткани:\t" + costumesWithSkirts[index].Skirt.Type + "\n" +
                "Цвет вещи:\t" + costumesWithSkirts[index].Skirt.Color + "\n" +
                "=========================" + "\n" +
                "Часть костюма:\t" + "Пиджак : " + costumesWithSkirts[index].Blazer.GetType() + "\n" +
                "Пол:\t\t" + costumesWithSkirts[index].Blazer.Gender + "\n" +
                "Рост:\t\t" + costumesWithSkirts[index].Blazer.Growth + "\n" +
                "Тип ткани:\t" + costumesWithSkirts[index].Blazer.Type + "\n" +
                "Цвет вещи:\t" + costumesWithSkirts[index].Blazer.Color + "\n" +
                "=================================================" + "\n";


        }
        static public string ShowClothesAssortment(Pants[] pants, Skirts[] skirts, Blazer[] blazers, Costume[] costumesWithPants, Costume[] costumesWithSkirts)
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
            return $"Кол-во мужских ЮБОК: {skirtsCountMan}" + "\n" +
            $"Кол-во женских ЮБОК: {skirtsCountWoMan}" + "\n" +
            $"Кол-во мужских БРЮК: {skirtsCountMan}" + "\n" +
            $"Кол-во женских БРЮК: {skirtsCountWoMan}" + "\n" +
            $"Кол-во мужских ПИДЖАКОВ: {blazersCountMan}" + "\n" +
            $"Кол-во женских ПИДЖАКОВ: {blazersCountWoMan}" + "\n";
            
        }
       /* static public string ShowManCostumes(Costume[] costumesWithPants, Costume[] costumesWithSkirts)
        {
            for (int i = 0; i < costumesWithPants.Length; i++)
            {
                if (costumesWithPants[i].Pants.Gender == Gender.Man) ;
                 Costume.ShowCostumeWithPants(costumesWithPants,i);


            }
            for (int i = 0; i < costumesWithSkirts.Length; i++)
            {
                if (costumesWithSkirts[i].Skirt.Gender == Gender.Man) ;
                  Costume.ShowCostumeWithSkirts(costumesWithSkirts,i);

            }
        }*/

    }
}
