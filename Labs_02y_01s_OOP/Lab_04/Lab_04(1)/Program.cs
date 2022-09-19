using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string String = "кот шалаш луна поле кок кровосток небо апельсин сосок";

            string[] Words = String.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Список ваших слов");
            foreach (var item in Words)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Условие: Первая и последняя буква слова совподают");
            Console.WriteLine("Если слово подсвечено ЗЕЛЕНЫМ значит оно подходит под ваше условие");
            Console.WriteLine("Если слово подсвечено КРАСНЫМ значит оно НЕ подходит под ваше условие");
            for (int i = 0; i < Words.Length; i++)
            {

                char[] Letters = Words[i].ToCharArray();
                for (int j = 0; j < Letters.Length; j++)
                {
                    if (Letters[0] == Letters[Letters.Length - 1])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Letters[j]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(Letters[j]);
                    }
                }
                Console.WriteLine();




            }
            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}
