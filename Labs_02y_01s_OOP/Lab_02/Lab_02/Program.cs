using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector();
            Vector vector2 = new Vector();

            vector1.InputVector();
            Console.Clear();
            vector2.InputVector();
            Console.Clear();

            Console.WriteLine($"Вектор 1: {{{vector1.VectorX}:{vector1.VectorY}:{vector1.VectorZ}}}");
            Console.WriteLine($"Вектор 2: {{{vector2.VectorX}:{vector2.VectorY}:{vector2.VectorZ}}}");

            Vector.Addition(vector1.VectorX, vector1.VectorY, vector1.VectorZ, vector2.VectorX, vector2.VectorY, vector2.VectorZ);

            Vector.Subtraction(vector1.VectorX, vector1.VectorY, vector1.VectorZ, vector2.VectorX, vector2.VectorY, vector2.VectorZ);

            Vector.ScalarMultiply(vector1.VectorX, vector1.VectorY, vector1.VectorZ, vector2.VectorX, vector2.VectorY, vector2.VectorZ);

            Vector.VectorMultiply(vector1.VectorX, vector1.VectorY, vector1.VectorZ, vector2.VectorX, vector2.VectorY, vector2.VectorZ);
        }
    }
    class Vector
    {
        

        public double VectorX { get; private set; }
        public double VectorY { get; private set; }
        public double VectorZ { get; private set; }

      

        private static double x;
        private static double y;
        private static double z;
        private int number = 1;
        public void InputVector()
        {
            Console.WriteLine($"Введите X:Y:Z для {number} вектора");

            Console.WriteLine($"Введите X для {number} вектора:");
            VectorX = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Введите Y для {number} вектора:");
            VectorY = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Введите Z для {number} вектора:");
            VectorZ = Convert.ToDouble(Console.ReadLine());

            number++;
    
        }
        public static void Addition(double VectorX_1, double VectorY_1, double VectorZ_1, double VectorX_2, double VectorY_2, double VectorZ_2)
        {
             x = VectorX_1 + VectorX_2;
             y = VectorY_1 + VectorY_2;
             z = VectorZ_1 + VectorZ_2;
            Console.WriteLine($"Сумма векторов в трёхмерном пространстве: {{{x}:{y}:{z}}}");
        }
        public static void Subtraction(double VectorX_1, double VectorY_1, double VectorZ_1, double VectorX_2, double VectorY_2, double VectorZ_2)
        {
             x = VectorX_1 - VectorX_2;
             y = VectorY_1 - VectorY_2;
             z = VectorZ_1 - VectorZ_2;
            Console.WriteLine($"Разность векторов в трёхмерном пространстве: {{{x}:{y}:{z}}}");
        }
        public static void ScalarMultiply(double VectorX_1, double VectorY_1, double VectorZ_1, double VectorX_2, double VectorY_2, double VectorZ_2)
        {
            double ScalarMultiply = VectorX_1 * VectorX_2 + VectorY_1 * VectorY_2 + VectorZ_1 * VectorZ_2;
            Console.WriteLine($"Скаларное произведение векторов в трёхмерном пространстве: {ScalarMultiply}");
        }

        public static void VectorMultiply(double VectorX_1, double VectorY_1, double VectorZ_1, double VectorX_2, double VectorY_2, double VectorZ_2)
        {
             x = VectorY_1 * VectorZ_2 - VectorZ_1 * VectorY_2;
             y = -(VectorX_1 * VectorZ_2 - VectorZ_1 * VectorX_2);
             z = VectorX_1 * VectorY_2 - VectorY_1 * VectorX_2;
            Console.WriteLine($"Векторное произведение векторов в трёхмерном пространстве: {{{x}:{y}:{z}}}");
        }

    }
}
