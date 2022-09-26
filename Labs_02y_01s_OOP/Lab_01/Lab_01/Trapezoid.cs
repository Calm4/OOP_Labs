using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    class Trapezoid
    {
        // lt - left-top
        // rt - rigth-top
        // lb - left-bot
        // rb - right-bot
        public double X_lt;
        public double Y_lt;

        public double X_rt;
        public double Y_rt;

        public double X_lb;
        public double Y_lb;

        public double X_rb;
        public double Y_rb;



        public void DoesExists()
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
                Console.WriteLine("Данная фигура не трапеция, так как линии образуют другую фигуру");


            }
            else
            {
                Console.WriteLine("Данная фигура может существовать");
            }
            //прямоугольник не трапеция, x1 = x2 , но y1 != y2
        }

        public double GetArea()
        {
            // нахождение катета(нижнего катета)
            double katet = (GetLineBot() - GetLineTop()) / 2;
            // нахождение высоты(второго катета с помощью теоремы пифагора
            double height = Math.Sqrt((GetLineLeft() * GetLineLeft()) - (katet * katet));
            // площадь = (сторона_нижняя*сторона_верхняя/2)*высоту
            double area = ((GetLineTop() + GetLineBot()) / 2) * height;
            return area;
        }

        public double GetPerimetr()
        {
            return GetLineLeft() + GetLineRight() + GetLineTop() + GetLineBot();
        }
        // Нахождение длины прямой с помощью формулы длины прямой
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

            else if (((X_rt > checkX && X_lt < checkX) && (Y_lt > checkY && Y_lb < checkY)))
                Console.WriteLine("V");

            else if (X_lt == checkX || X_rt == checkX || Y_lt == checkY || Y_lb == checkY)
                Console.WriteLine("NA");

            // баг с нижней прямой, что я считаю только прямоугольник а y_lb идет как трапеция дальше влево не как прямоугольник
        }


    }
}
 