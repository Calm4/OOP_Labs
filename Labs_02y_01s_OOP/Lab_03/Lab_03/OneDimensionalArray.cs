using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    class OneDimensionalArray
    {


        private int _numberOfMultiply;
        //сделать диномическим количество элементов массива
        private int[] _array;
        public int ArrayLength { get => _array.Length; }

        public int this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }
        public OneDimensionalArray(int numberOfMultiply, int arrayLength)
        {
            _numberOfMultiply = numberOfMultiply;
            _array = new int[arrayLength];
        }
        public void InputArray()
        {
            for (int i = 0; i < ArrayLength; i++)
            {
                Console.Write($"Введите {i + 1} элемент массива: ");
                _array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void OutputArray()
        {
            Console.Write($"Вывод массива: ");
            foreach (var element in _array)
            {
                Console.Write($"{element}, ");
            }
            Console.WriteLine();

        }
        public static void SumMinusElements(OneDimensionalArray array1, OneDimensionalArray array2)
        {
            int Sum = 0;
            for (int i = 0; i < array1.ArrayLength; i++)
            {
                if (array1[i] < 0)
                {
                    Sum += array1[i];
                }
            }
            for (int i = 0; i < array2.ArrayLength; i++)
            {

                if (array2[i] < 0)
                {
                    Sum += array2[i];
                }

            }
            Console.WriteLine($"Сумма отрицательных элементов в нескольких массивах(2): {Sum}");
        }
        public static void SumMinusElements(OneDimensionalArray array1, OneDimensionalArray array2, OneDimensionalArray array3)
        {
            int Sum = 0;
            for (int i = 0; i < array1.ArrayLength; i++)
            {
                if (array1[i] < 0)
                {
                    Sum += array1[i];
                }
            }
            for (int i = 0; i < array2.ArrayLength; i++)
            {

                if (array2[i] < 0)
                {
                    Sum += array2[i];
                }

            }
            for (int i = 0; i < array3.ArrayLength; i++)
            {

                if (array3[i] < 0)
                {
                    Sum += array3[i];
                }

            }
            Console.WriteLine($"Сумма отрицательных элементов в нескольких массивах(3): {Sum}");
        }
        public void MultiplyArray()
        {
            for (int i = 0; i < ArrayLength; i++)
            {
                _array[i] = _array[i] * _numberOfMultiply;
            }
            Console.Write($"Массив после умножения: ");

            for (int i = 0; i < ArrayLength; i++)
            {
                Console.Write(_array[i] + ", ");
            }
            Console.WriteLine();


        }

        // Умножение массива на число ( Как сделать умножение числа на массив?)
        public static OneDimensionalArray operator -(OneDimensionalArray a1)
        {
            OneDimensionalArray rez = new OneDimensionalArray(a1.ArrayLength, a1.ArrayLength);
            for (int i = 0; i < a1.ArrayLength; ++i)
                rez[i] = -a1[i];
            return rez;
        }


    }
}
