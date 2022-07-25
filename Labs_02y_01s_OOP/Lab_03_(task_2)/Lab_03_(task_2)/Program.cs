using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03__task_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayTask A = new ArrayTask(3);
            ArrayTask B = new ArrayTask(4);
            ArrayTask C = new ArrayTask(5);
            ArrayTask D = 5 * A;
            ArrayTask E = 2 * B;
            ArrayTask F = -A;
            ArrayTask G = C * 4;
            int choose = 0;

            

            int SumA = A.Sum();
            int SumB = B.Sum();
            

           

            while (choose != 6)
            {
                SumA = A.Sum();
                SumB = B.Sum();
                Console.WriteLine(A.Sum());
                Console.WriteLine(B.Sum());
                Console.ReadKey();
                D = 5 * A;
                E = 2 * B;
                F = -A;
                G = C * 4;
                Console.WriteLine("1)Заполнение массивов");
                Console.WriteLine("2)Вывод массивов");
                Console.WriteLine("3)Сумма 5*A и C");
                Console.WriteLine("4)Сумма 2*B, -A, C*4");
                Console.WriteLine("5)Замена всех одинаковых элементов в массиве A на сумму этого массива,\nесли массив A>B(только отрицательные элементы)");
                Console.WriteLine("6)Выход");
                Console.SetCursorPosition(0, 25);

                Console.Write("A: "); A.OutputArray();
                Console.Write("B: "); B.OutputArray();
                Console.Write("C: "); C.OutputArray();
                Console.SetCursorPosition(40, 25);
                Console.Write("(5*A)D: "); D.OutputArray();
                Console.SetCursorPosition(40, 26);
                Console.Write("(2*B)E: "); E.OutputArray();
                Console.SetCursorPosition(40, 27);
                Console.Write("(-A )F: "); F.OutputArray();
                Console.SetCursorPosition(40, 28);
                Console.Write("(C*4)G: "); G.OutputArray();

                Console.SetCursorPosition(0,9);
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Введите массив для заполнения от 1 до 3");
                        int chooseArray1 = Convert.ToInt32(Console.ReadLine());
                        switch (chooseArray1)
                        {
                            case 1:
                                A.InputArray();
                               
                                break;
                            case 2:
                                B.InputArray();
                                break;
                            case 3:
                                C.InputArray();
                                break;
                            default:
                                Console.WriteLine("Такого массива нет!");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Введите массив для вывода от 1 до 3");
                        int chooseArray2 = Convert.ToInt32(Console.ReadLine());
                        switch (chooseArray2)
                        {
                            case 1:
                                A.OutputArray();
                                Console.ReadKey();
                                break;
                            case 2:
                                B.OutputArray();
                                Console.ReadKey();
                                break;
                            case 3:
                                C.OutputArray();
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Такого массива нет!");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case 3:
                        Console.Write("Сумма |5*A + C|: ");
                        int Sum1 = D.Sum() + C.Sum();
                        Console.WriteLine(Sum1);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("Сумма |2*B + (-A) + C*4|: ");
                        int Sum2 = E.Sum() + F.Sum() + G.Sum();
                        Console.WriteLine(Sum2);
                        Console.ReadKey();
                        break;
                    case 5: 
                        // брал по модулю т.е |-10|<|-16|
                        if (SumA < SumB)
                        {
                            for (int i = 0; i < A.Length; i++)
                            {
                                for (int j = i + 1; j <= A.Length; j++)
                                {
                                    if (A[j - 1] < 0)
                                        A[j - 1] = SumA;
                                }
                            }
                        }
                        Console.Write("Массив после последнего задания: ");
                        for (int i = 0; i < A.Length; i++)
                        {
                            Console.Write(A[i] + ", ");
                        }
                        Console.WriteLine();
                        break;
                    case 6:
                        break;
                    default:
                        break;

                }
                Console.Clear();
            }

        }
    }
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

                Console.Write($"Введите {i+1} элемент массива");
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

