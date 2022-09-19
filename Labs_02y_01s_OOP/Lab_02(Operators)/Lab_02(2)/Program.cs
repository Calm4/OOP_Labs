using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector() { VectorX = 1, VectorY = 3, VectorZ = 5 };
            Vector vector2 = new Vector() { VectorX = 2, VectorY = 4, VectorZ = 6 };

            Vector vectorAddition = vector1 + vector2;
            Vector vectorSubtraction = vector1 - vector2;
            Vector vectorVectorMultiplication = vector1 * vector2;

            int choice = 0;

            while (choice != 4)
            {
                Console.WriteLine("====================");
                Console.WriteLine($"Векторы равны: {{{vector1.VectorX}:{vector1.VectorY}:{vector1.VectorZ}}} и {{{vector2.VectorX}:{vector2.VectorY}:{vector2.VectorZ}}} ");
                Console.WriteLine("====================");

                Console.WriteLine("1)Сумма векторов");
                Console.WriteLine("2)Разность векторов");
                Console.WriteLine("3)Произведение векторов");
                Console.WriteLine("4)Выход");

                Console.WriteLine();
                Console.WriteLine("====================");
                Console.Write("Введите пункт меню: ");

                Console.ReadKey();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Результат суммы двух трёхмерных векторов: {{{vectorAddition.VectorX}:{vectorAddition.VectorY}:{vectorAddition.VectorZ}}}");

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine($"Результат разности двух трёхмерных векторов: {{{vectorSubtraction.VectorX}:{vectorSubtraction.VectorY}:{vectorSubtraction.VectorZ}}}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine($"Результат векторного произведения двух трёхмерных векторов: {{{vectorVectorMultiplication.VectorX}:{vectorVectorMultiplication.VectorY}:{vectorVectorMultiplication.VectorZ}}}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        choice = 4;
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Выход!");
                        break;
                }

            }


        }
    }

}

