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
            Vector vector3 = new Vector() { VectorX = 3, VectorY = 5, VectorZ = 7 };
            Vector vectorAddition = vector1 + vector2;
            Vector vectorSubtraction = vector1 - vector2;
            Vector vectorVectorMultiplication = vector1 * vector2;
            Vector vectorSmeshennoeMultiplication = vector1 * vector2 * vector3;
            int choice = 0;
            
            while (choice != 5)
            {
               
                Console.WriteLine("1)Сумма векторов");
                Console.WriteLine("2)Разность векторов");
                Console.WriteLine("3)Произведение векторов");
                Console.WriteLine("5)Выход");
                Console.Write("Введите пункт меню: ");
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
                    case 4:
                        Console.WriteLine($"Результат скалярного произведения двух трёхмерных векторов: {{}}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        choice = 5;
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Выход!");
                        break;
                }
                
            }


        }
    }
    class Vector
    {
        public int VectorX { get; set; }
        public int VectorY { get; set; }
        public int VectorZ { get; set; }
        
       
        public static void ShowResult()
        {     
        }

        public static Vector operator +(Vector vector1, Vector vector2)
        {

            return new Vector
            {
                VectorX = vector1.VectorX + vector2.VectorX,
                VectorY = vector1.VectorY + vector2.VectorY,
                VectorZ = vector1.VectorZ + vector2.VectorZ
            };
        }
        public static Vector operator -(Vector vector1, Vector vector2)
        {

            return new Vector
            {
                VectorX = vector1.VectorX - vector2.VectorX,
                VectorY = vector1.VectorY - vector2.VectorY,
                VectorZ = vector1.VectorZ - vector2.VectorZ
            };
        }
        public static Vector operator *(Vector vector1, Vector vector2)
        {
            return new Vector
            {
                VectorX = vector1.VectorY * vector2.VectorZ - vector1.VectorZ * vector2.VectorY,
                VectorY = -(vector1.VectorX * vector2.VectorZ - vector1.VectorZ * vector2.VectorX),
                VectorZ = vector1.VectorX * vector2.VectorY - vector1.VectorY * vector2.VectorX
            };
        }
        /*public static  operator *(Vector vector1,Vector vector2,Vector vector3)
        {
            return vector1.VectorX * vector2.VectorX + vector1.VectorY * vector2.VectorY + vector1.VectorZ * vector2.VectorZ;
        }*/
    }
}

