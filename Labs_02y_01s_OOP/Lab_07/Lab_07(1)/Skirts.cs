using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    public class Skirts : Costume
    {
        public Skirts(Gender gender, double growth, Type_clothes type, Color color) : base(gender, growth, type, color)
        {
        }
        static public string ShowSkirt(Skirts[] skirts,int index)
        {

            return $"Юбка №{index + 1}" + "\n" +
              "Часть костюма:\t" + "Юбка : " + skirts[index].GetType() + "\n" +
              "Пол:\t\t" + skirts[index].Gender + "\n" +
              "Рост:\t\t" + skirts[index].Growth + "\n" +
              "Тип ткани:\t" + skirts[index].Type + "\n" +
              "Цвет вещи:\t" + skirts[index].Color + "\n";
        }
    }
}
