using System;

namespace Lab_08
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            GeometricShape geometricShape = new GeometricShape();



            bool isWork = true;
            int punctOfMenu = 0;
            while (isWork)
            {
                GeometricShape.CountOfCircles();
                geometricShape.FindAllShapesInTextFile();
                geometricShape.CloseInputSphereCoordinates();
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

                        geometricShape.GetArea();
                        geometricShape.SortByArea();
                        geometricShape.OutPutSortedAreas();
                        //geometricShape.OutPutSquare();
                        //geometricShape.OutPutCircle();
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



        }
    }
}