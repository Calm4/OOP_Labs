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
                Console.WriteLine("5)Вычисление пириметра");
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
    class Trapezoid
    {
        public double X_lt;
        public double Y_lt;

        public double X_rt;
        public double Y_rt;

        public double X_lb;
        public double Y_lb;

        public double X_rb;
        public double Y_rb;



        public void isExists()
        {
            if (((X_lt == X_rt) && (Y_lt == Y_rt)) || ((X_lt == X_lb) && (Y_lt == Y_lb)) || ((X_lt == X_rb) && (Y_lt == Y_rb)) || ((X_rt == X_lb) && (Y_rt == Y_lb)) || ((X_rt == X_rb) && (Y_rt == Y_rb)) || ((X_lb == X_rb) && (Y_lb == Y_rb)))
            {
                Console.WriteLine("Данная фигура не может существовать, она имеет три вершины");

            }
            else if (((X_lt == X_lb) && (X_rt == X_rb)) /*|| ((Y_lt == Y_rt) && (Y_lb == Y_rb))*/)
            {
                Console.WriteLine("Данная фигура является прямоугольником, а не трапецией");
            }
            else if (((Y_lt != Y_rt) || (Y_lb != Y_rb)) && ((Y_lt != Y_lb) || (Y_rt != Y_rb)))
            {
                Console.WriteLine("Данная фигура не трапеция, так как никакие две её линии не параллельны");


            }
            else
            {
                Console.WriteLine("Данная фигура может существовать");
            }
            //прямоугольник не трапеция, x1 = x2 , но y1 != y2
        }

        public double GetArea()
        {
            double katet = (GetLineBot() - GetLineTop()) / 2;
            double height = Math.Sqrt((GetLineLeft() * GetLineLeft()) - (katet * katet));
            double area = ((GetLineTop() + GetLineBot()) / 2) * height;
            return area;
        }

        public double GetPerimetr()
        {
            return GetLineLeft() + GetLineRight() + GetLineTop() + GetLineBot();
        }
        public double GetLineLeft()
        {
            double line_left = Math.Sqrt(Math.Pow(X_lt - X_lb, 2) + Math.Pow(Y_lt - Y_lb, 2));
            return line_left;
        }
        public double GetLineRight()
        {
            double line_right = Math.Sqrt(Math.Pow(X_rt - X_rb, 2) + Math.Pow(Y_rt - Y_rb, 2));
            return line_right;
        }
        public double GetLineTop()
        {
            double line_top = Math.Sqrt(Math.Pow(X_rt - X_lt, 2) + Math.Pow(Y_rt - Y_lt, 2));
            return line_top;
        }
        public double GetLineBot()
        {
            double line_bot = Math.Sqrt(Math.Pow(X_rb - X_lb, 2) + Math.Pow(Y_rb - Y_lb, 2));
            return line_bot;
        }
        public void GetLine()
        {
            Console.WriteLine("Длину какой линии вы хотите получить?");
            Console.WriteLine("1)Левой.\n2)Правой.\n3)Верхней.\n4)Нижней.\n5)Выйти.");
            byte choice = 0;
            while (choice != 5)
            {
                choice = Convert.ToByte(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Длина левой стороны: {GetLineLeft()}");
                        break;
                    case 2:
                        Console.WriteLine($"Длина правой стороны: {GetLineRight()}");
                        break;
                    case 3:
                        Console.WriteLine($"Длина верхней стороны: {GetLineTop()}");
                        break;
                    case 4:
                        Console.WriteLine($"Длина нижней стороны: {GetLineBot()}");
                        break;
                    case 5: break;

                    default:
                        Console.WriteLine("Пункт выбран неверно!");
                        break;
                }
            }

        }
        public void isBelongs(ref double checkX, ref double checkY)
        {
            Console.WriteLine(checkX + "||" + checkY);
            if (X_rt < checkX || X_lt > checkX || Y_lt < checkY || Y_lb > checkY)
                Console.WriteLine("ZA");
            else
                Console.WriteLine("111");
            if (((X_rt > checkX && X_lt < checkX) && (Y_lt > checkY && Y_lb < checkY)))
                Console.WriteLine("V");
            else
                Console.WriteLine("222");
            if (X_lt == checkX || X_rt == checkX || Y_lt == checkY || Y_lb == checkY) 
                Console.WriteLine("NA");
            else
                Console.WriteLine("333");
            // баг с нижней прямой, что я считаю только прямоугольник а y_lb идет как трапеция дальше влево не как прямоугольник
        }


    }
}
