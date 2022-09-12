using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trapezoid trapezoid = new Trapezoid();


            byte choiceMenuPunct = 0;
            while (choiceMenuPunct != 7)
            {
                Console.WriteLine("=====================================================");
                Console.WriteLine("Список пунктов:");
                Console.WriteLine("1)Задать координаты фигуры");
                Console.WriteLine("2)Проверка на возможность существования данной фигуры");
                Console.WriteLine("3)Вычисление длин сторон фигуры");
                Console.WriteLine("4)Вычисление площади фигуры");
                Console.WriteLine("5)Вычисление периметра");
                Console.WriteLine("6)Проверка на принадлежность определенной точки {X,Y} к какой-либо области");
                Console.WriteLine("7)Выход");
                choiceMenuPunct = Convert.ToByte(Console.ReadLine());
                Console.Clear();
                switch (choiceMenuPunct)
                {
                    case 1:
                        Console.WriteLine("Введите координату X левой верхней вершины");
                        trapezoid.X_lt = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите координату Y левой верхней вершины");
                        trapezoid.Y_lt = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите координату X правой верхней вершины");
                        trapezoid.X_rt = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите координату Y правой верхней вершины");
                        trapezoid.Y_rt = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите координату X левой нижней вершины");
                        trapezoid.X_lb = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите координату Y левой нижней вершины");
                        trapezoid.Y_lb = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите координату X правой нижней вершины");
                        trapezoid.X_rb = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите координату Y правой нижней вершины");
                        trapezoid.Y_rb = Convert.ToInt32(Console.ReadLine());


                        double checkX;
                        double checkY;

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        trapezoid.isExists();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        trapezoid.GetLine();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine($"Площадь трапеции:{trapezoid.GetArea()}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine($"Периметр трапеции:{trapezoid.GetPerimetr()}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Введите X для сравнения:");
                        checkX = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Введите Y для сравнения:");
                        checkY = Convert.ToDouble(Console.ReadLine());


                        trapezoid.isBelongs(ref checkX, ref checkY);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        //Выход
                        break;

                    default:

                        break;
                }
            }



        }
    }
    
}
