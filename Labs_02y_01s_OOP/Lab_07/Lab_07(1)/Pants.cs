using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    public class Pants : Costume
    {
        public Pants(Gender gender, double growth, Type_clothes type, Color color) : base(gender, growth, type, color)
        {
        }
        static public string ShowPants(Pants[] pants,int index)
        {
            return $"Брюки №{index + 1}" + "\n" +
              "Часть костюма:\t" + "Брюки : " + pants[index].GetType() + "\n" +
              "Пол:\t\t" + pants[index].Gender + "\n" +
              "Рост:\t\t" + pants[index].Growth + "\n" +
              "Тип ткани:\t" + pants[index].Type + "\n" +
              "Цвет вещи:\t" + pants[index].Color + "\n";
        }
    }
}
