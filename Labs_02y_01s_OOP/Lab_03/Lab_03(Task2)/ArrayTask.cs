using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_Task_2_
{
    class ArrayTask
    {
        public int Length { get { return _array.Length; } }
        public static int counter = 1;
        private int[] _array;
        public ArrayTask(int length) => _array = new int[length];

        public void InputArray()
        {
            for (int i = 0; i < _array.Length; i++)
            {

                Console.Write($"Введите {i + 1} элемент массива");
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
        public int Sum()
        {
            int Sum = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] < 0)
                    Sum += _array[i];
            }
            return Sum;

        }
        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < _array.Length) return _array[i];
                else throw new Exception("Плохой индекс " + i);
            }
            set
            {
                if (i >= 0 && i < _array.Length) _array[i] = value;
                else throw new Exception("Плохой индекс " + i);
            }
        }
        public static ArrayTask operator +(ArrayTask array1, ArrayTask array2)
        {
            int Length1, Length2, k;
            if (array1.Length > array2.Length)
            { Length1 = array1.Length; Length2 = array2.Length; k = 1; }
            else { Length1 = array2.Length; Length2 = array1.Length; k = 2; }
            ArrayTask TemporaryArray = new ArrayTask(Length1);
            for (int i = 0; i < Length1; ++i)
            {
                if (i < Length2) TemporaryArray[i] = array1[i] + array2[i];
                else TemporaryArray[i] = (k == 1) ? array1[i] : array2[i];
            }
            return TemporaryArray;
        }
        public static ArrayTask operator *(int number, ArrayTask array1)
        {
            ArrayTask TemporaryArray = new ArrayTask(array1.Length);
            for (int i = 0; i < array1.Length; ++i)
                TemporaryArray[i] = array1[i] * number;
            return TemporaryArray;
        }
        public static ArrayTask operator *(ArrayTask array1, int number)
        {
            ArrayTask TemporaryArray = new ArrayTask(array1.Length);
            for (int i = 0; i < array1.Length; ++i)
                TemporaryArray[i] = array1[i] * number;
            return TemporaryArray;
        }
        public static ArrayTask operator -(ArrayTask array1)
        {
            ArrayTask TemporaryArray = new ArrayTask(array1.Length);
            for (int i = 0; i < array1.Length; ++i)
                TemporaryArray[i] = -array1[i];
            return TemporaryArray;
        }
    }
}
