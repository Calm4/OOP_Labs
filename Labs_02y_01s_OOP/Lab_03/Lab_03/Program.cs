using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // СДЕЛАТЬ МЕНЮ ЧЕРЕЗ SWITCH CASE С ПУНКТАМИ ЛАБ РАБОТЫ 
            // OneDimensionalArray - Одномерный массив
            OneDimensionalArray array1 = new OneDimensionalArray(2, 2);
            OneDimensionalArray array2 = new OneDimensionalArray(3, 3);
            OneDimensionalArray array3 = new OneDimensionalArray(4, 4);

            int choose = 0;
            while (choose != 6)
            {
                Console.WriteLine("1)Заполнение массивов");
                Console.WriteLine("2)Вывод массивов");
                Console.WriteLine("3)Вычесление суммы отрицательных элементов в нескольнких массивах");
                Console.WriteLine("4)Умножение массива на целое число");
                Console.WriteLine("5)Унарная операция -(знаки элементов меняются на противоположные)");
                Console.WriteLine("6)Выход");
                Console.SetCursorPosition(0, 25);
                array1.OutputArray();
                array2.OutputArray();
                array3.OutputArray();
                Console.SetCursorPosition(0, 7);
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Введите массив для заполнения от 1 до 3");
                        int chooseArray1 = Convert.ToInt32(Console.ReadLine());
                        switch (chooseArray1)
                        {
                            case 1:
                                array1.InputArray();
                                break;
                            case 2:
                                array2.InputArray();
                                break;
                            case 3:
                                array3.InputArray();
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
                                array1.OutputArray();
                                Console.ReadKey();
                                break;
                            case 2:
                                array2.OutputArray();
                                Console.ReadKey();
                                break;
                            case 3:
                                array3.OutputArray();
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Такого массива нет!");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите каличество массивов 2 или 3");
                        int chooseArray3 = Convert.ToInt32(Console.ReadLine());
                        switch (chooseArray3)
                        {
                            case 2:
                                Console.WriteLine("Введите 2 массива от 1 до 3");
                                int ar1 = Convert.ToInt32(Console.ReadLine());
                                int ar2 = Convert.ToInt32(Console.ReadLine());
                                if ((ar1 == 1 && ar2 == 2) || (ar2 == 1 && ar1 == 2))
                                {
                                    OneDimensionalArray.SumMinusElements(array1, array2);
                                    Console.ReadKey();
                                }
                                if ((ar1 == 1 && ar2 == 3) || (ar2 == 1 && ar1 == 3))
                                {
                                    OneDimensionalArray.SumMinusElements(array1, array3);
                                    Console.ReadKey();
                                }
                                if ((ar1 == 2 && ar2 == 3) || (ar2 == 2 && ar1 == 3))
                                {
                                    OneDimensionalArray.SumMinusElements(array2, array3);
                                    Console.ReadKey();
                                }
                                break;
                            case 3:
                                OneDimensionalArray.SumMinusElements(array1, array2, array3);
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Такой пары массивов нет!");
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Введите номер массива для умножения массива на число");
                        int chooseArray4 = Convert.ToInt32(Console.ReadLine());
                        switch (chooseArray4)
                        {
                            case 1:
                                array1.MultiplyArray();
                                Console.ReadKey();
                                break;
                            case 2:
                                array2.MultiplyArray();
                                Console.ReadKey();
                                break;
                            case 3:
                                array3.MultiplyArray();
                                Console.ReadKey();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Введите номер массива для унарного оперирования");
                        int chooseArray5 = Convert.ToInt32(Console.ReadLine());
                        switch (chooseArray5)
                        {
                            case 1:
                                array1 = -array1;
                                break;
                            case 2:
                                array2 = -array2;
                                break;
                            case 3:
                                array3 = -array3;
                                break;
                            default:
                                break;
                        }
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

