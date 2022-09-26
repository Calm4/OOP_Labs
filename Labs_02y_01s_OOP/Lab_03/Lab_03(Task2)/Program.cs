using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_Task_2_
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

                Console.SetCursorPosition(0, 9);
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
                        Console.Write("Сумма отрицательных элементов |5*A + C|: ");
                        int Sum1 = D.Sum() + C.Sum();
                        Console.WriteLine(Sum1);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("Сумма отрицательных элементов |2*B + (-A) + C*4|: ");
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


}

