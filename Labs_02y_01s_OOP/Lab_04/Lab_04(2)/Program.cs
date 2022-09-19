using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            string primer = a + " ~ " + b;

            StringBuilder[] sb = new StringBuilder[4];

            for (int i = 0; i < sb.Length; i++)
            {
                sb[i] = new StringBuilder(primer);
            }
            string[] ugu = { "+", "-", "*", "/" };
            for (int i = 0; i < sb.Length; i++)
            {
                sb[i].Replace("~", ugu[i]);
            }
            Console.WriteLine(primer);
            Console.WriteLine("----------------");

            foreach (var item in sb)
            {
                Console.WriteLine(item);
            }
        }
    }
}
