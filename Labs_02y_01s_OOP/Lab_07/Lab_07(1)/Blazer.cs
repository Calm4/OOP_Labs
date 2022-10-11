using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    public class Blazer : Costume
    {
        public Blazer(Gender gender, double growth, Type_clothes type, Color color) : base(gender, growth, type, color)
        {
        }

        static public string ShowBlazers(Blazer[] blazers, int index)
        {

            return $"Юбка №{index + 1}" + "\n" +
           "Часть костюма:\t" + "Пиджак : " + blazers[index].GetType() + "\n" +
           "Пол:\t\t" + blazers[index].Gender + "\n" +
           "Рост:\t\t" + blazers[index].Growth + "\n" +
           "Тип ткани:\t" + blazers[index].Type + "\n" +
           "Цвет вещи:\t" + blazers[index].Color + "\n";
        }       
    }
}
