using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Lab_05
{
    internal class Program
    {
        // раскидать по методам
        static void Main(string[] args)
        {
            string[] newFile = File.ReadAllLines($"Examples/1.txt");
            for (int i = 0; i < newFile.Length; i++)
            {
                Console.WriteLine(newFile[i]);
            }
            Console.WriteLine("==================================");
            Match[] match = new Match[newFile.Length];
            for (int i = 0; i < newFile.Length; i++)
            {
                match[i] = Regex.Match(newFile[i], "\\((.*?)\\+(.*?)\\)\\*(.*?)\\-\\((.*)\\)");
            }
            int number1, number2, number3, number4, result = 0;

            for (int i = 0; i < newFile.Length; i++)
            {

                number1 = Convert.ToInt32(match[i].Groups[1].ToString());
                number2 = Convert.ToInt32(match[i].Groups[2].ToString());
                number3 = Convert.ToInt32(match[i].Groups[3].ToString());
                number4 = Convert.ToInt32(match[i].Groups[4].ToString());
                result = (number1 + number2) * number3 - number4;
                Console.WriteLine(result);
            }

        }
    }
}
