using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;

namespace Lab_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometricShape geometricShape = new GeometricShape();
            bool isWork = true;
            int punctOfMenu = 0;
            while (isWork)
            {
                geometricShape.FindAllShapesInTextFile();
                Console.WriteLine("1)Вывести информацию о фигурах");
                Console.WriteLine("2)Сортирует фигуры в порядке возрастания по их площадям");
                Console.WriteLine("3)Вывести периметр всех квадратов, полностью расположенных больше чем в 1 четверти координатной плоскости");
                Console.WriteLine("4)Вывести длины всех окружностей в порядке убывания длин окружностей");
                Console.WriteLine("5)Выход");
                punctOfMenu = Convert.ToInt32(Console.ReadLine());

                switch (punctOfMenu)
                {
                    case 1:
                        geometricShape.OutPutSquare();
                        geometricShape.OutPutCircle();
                        break;
                    case 2:
                        geometricShape.SortByArea();
                        geometricShape.OutPutSquare();
                        geometricShape.OutPutCircle();
                        break;
                    case 3:
                        geometricShape.GetSquarePerimetrerMoreThanOneQuater();
                        break;
                    case 4:
                        geometricShape.GetCircleLength();
                        break;
                    case 5:
                        isWork = false;
                        break;
                    default:
                        Console.Clear();
                        continue;

                }
                Console.ReadKey();
                Console.Clear();
            }

            /* Console.WriteLine();
             geometricShape.OutPutSquare();
             Console.WriteLine("++++++++++++++++++++++++");
             geometricShape.OutPutCircle();
             geometricShape.GetArea();
             geometricShape.SortByArea();
             geometricShape.OutPutSquare();
             geometricShape.OutPutCircle();
             Console.WriteLine("..//./././../././././/,./,");
             geometricShape.GetSquarePerimetrerMoreThanOneQuater();
             Console.WriteLine("+___________________++++++++++++__________+=");
             geometricShape.GetCircleLength();*/

        }
    }

    //Square: leftBotX :2Q, leftBotY :2Q. leftTopX:2Q. leftTopY:5Q, rightTopX:8Q, rightTopY:5Q, rightBotX:8Q, rightBotY:2Q, 

    //Circle: centerOfCircleX : 3 \\| centerOfCircle : 3 \\| radius : 5 \\| color : Red \\|


    //"Square: leftBotX :(.*?), leftBotY :(.*?), leftTopX:(.*?), leftTopY:(.*?), rightTopX:(.*?), rightTopY:(.*?), rightBotX:(.*?), rightBotY:(.*?)"
}
