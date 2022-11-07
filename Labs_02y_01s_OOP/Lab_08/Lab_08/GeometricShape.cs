using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Lab_08
{
    internal class GeometricShape
    {
        public double Area { get; set; }

        static string[] textFile = File.ReadAllLines($"Shapes/shapes.txt");
        public int[,] squareCoordinates = new int[textFile.Length, 8];
        public int[,] circleCoordinates = new int[textFile.Length, 3];
        public string[,] circleColor = new string[textFile.Length, 1];
        public double[,] ShapesArea = new double[textFile.Length, 1];
        public double[,] SquarePerimetr = new double[textFile.Length, 1];
        public double[,] CirclesLength = new double[textFile.Length, 1];


        string[] stringWithSquareCoordinates;
        string[] stringWithCircleCoordinates;
        string[] stringWithCircleColor;

        public GeometricShape[] Shapes = new GeometricShape[textFile.Length];
        ConsoleColor[] consoleColor = new ConsoleColor[5] { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Blue, ConsoleColor.Magenta };


        // находит все фигуры в файле и создает новые объекты
        public void FindAllShapesInTextFile()
        {


            for (int i = 0; i < textFile.Length; i++)
            {
                if (textFile[i].StartsWith("Square:"))
                {
                    Shapes[i] = new Square(squareCoordinates[i, 0], squareCoordinates[i, 1], squareCoordinates[i, 2], squareCoordinates[i, 3], squareCoordinates[i, 4], squareCoordinates[i, 5], squareCoordinates[i, 6], squareCoordinates[i, 7]);

                }
                else if (textFile[i].StartsWith("Circle:"))
                {
                    Shapes[i] = new Circle(circleCoordinates[i, 0], circleCoordinates[i, 1], circleCoordinates[i, 2], circleColor[i, 0]);

                }


            }
        }
        public void CloseInputSphereCoordinates()
        {
            for (int i = 0; i < textFile.Length; i++)
            {
                if (textFile[i].StartsWith("Square:"))
                {
                    stringWithSquareCoordinates = textFile[i].Substring(8).Split(',');
                    for (int j = 0; j < squareCoordinates.GetLength(1); j++)
                    {
                        squareCoordinates[i, j] = Int32.Parse(stringWithSquareCoordinates[j]);
                    }

                }
                if (textFile[i].StartsWith("Circle:"))
                {
                    stringWithCircleColor = textFile[i].Substring(8).Split(',');
                    circleColor[i, 0] = stringWithCircleColor[3];
                    for (int k = 0; k < consoleColor.Length; k++)
                    {
                        if (circleColor[i, 0].ToString() == consoleColor[k].ToString())
                        {

                            stringWithCircleCoordinates = textFile[i].Substring(8).Split(',');

                            for (int j = 0; j < circleCoordinates.GetLength(1); j++)
                            {
                                circleCoordinates[i, j] = Int32.Parse(stringWithCircleCoordinates[j]);

                            }
                        }
                    }
                    for (int j = 0; j < circleColor.GetLength(1); j++)
                    {
                        circleColor[i, j] = stringWithCircleColor[3];
                    }
                }
            }
        }
        // вывод квадратов из текстового файла
        public void OutPutSquare()
        {

            for (int i = 0; i < textFile.Length; i++)
            {
                if (textFile[i].StartsWith("Square:"))
                {

                    Console.WriteLine("square");
                    for (int j = 0; j < squareCoordinates.GetLength(1); j++)
                    {

                        Console.Write(squareCoordinates[i, j] + "|");
                    }

                    Console.WriteLine();
                }

            }
        }

        // вывод кругов из текстового файла
        public void OutPutCircle()
        {
            for (int i = 0; i < textFile.Length; i++)
            {
                if (textFile[i].StartsWith("Circle:"))
                {
                    for (int k = 0; k < consoleColor.Length; k++)
                    {
                        if (circleColor[i, 0].ToString() == consoleColor[k].ToString())
                        {
                            Console.ForegroundColor = consoleColor[k];
                            Console.WriteLine("circle:");
                            for (int j = 0; j < circleCoordinates.GetLength(1); j++)
                            {
                                Console.Write(circleCoordinates[i, j] + "/");
                            }
                        }
                    }
                    for (int j = 0; j < circleColor.GetLength(1); j++)
                    {
                        Console.Write(circleColor[i, 0]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine();
                }

            }
        }
        // Получить площади фигур 
        public void GetArea()
        {
            const double pi = 3.1415926535;
            for (int i = 0; i < Shapes.Length; i++)
            {
                if (Shapes[i] is Circle)
                {
                    Area = pi * circleCoordinates[i, 2];
                    ShapesArea[i, 0] = Area;
                    Console.WriteLine(Area);
                }
                if (Shapes[i] is Square)
                {
                    Area = (squareCoordinates[i, 3] - squareCoordinates[i, 1]) * (squareCoordinates[i, 3] - squareCoordinates[i, 1]);
                    ShapesArea[i, 0] = Area;
                    Console.WriteLine(Area);
                }

            }

        }
        // Отсортировать фигуры по площади 
        public void SortByArea()
        {
            double temp = 0;
            for (int i = 0; i < ShapesArea.Length - 1; i++)
            {

                if (ShapesArea[i, 0] > ShapesArea[i + 1, 0])
                {
                    temp = ShapesArea[i, 0];
                    ShapesArea[i, 0] = ShapesArea[i + 1, 0];
                    ShapesArea[i + 1, 0] = temp;

                }

            }
        }
        //  Получить периметр квадратов которые лежат больше чем в одной четверти
        public void GetSquarePerimetrerMoreThanOneQuater()
        {

            double perimetr = 0;
            for (int i = 0, j = 0; i < Shapes.Length && j < SquarePerimetr.GetLength(0); i++, j++)
            {
                if (Shapes[i] is Square)
                {
                    if (((squareCoordinates[i, 4] > 0 && squareCoordinates[i, 5] > 0) && ((squareCoordinates[i, 0] < 0) && (squareCoordinates[i, 1] > 0))) || (((squareCoordinates[i, 4] > 0) && (squareCoordinates[i, 5] > 0)) && (squareCoordinates[i, 0] > 0) && (squareCoordinates[i, 1] < 0)) || ((squareCoordinates[i, 4] > 0 && squareCoordinates[i, 5] < 0) && ((squareCoordinates[i, 0] < 0) && (squareCoordinates[i, 0] < 0))) || ((squareCoordinates[i, 4] < 0 && squareCoordinates[i, 5] > 0) && ((squareCoordinates[i, 0] < 0) && (squareCoordinates[i, 0] < 0))) || ((squareCoordinates[i, 4] > 0 && squareCoordinates[i, 5] > 0) && ((squareCoordinates[i, 0] < 0) && (squareCoordinates[i, 0] < 0))))
                    {

                        perimetr = Math.Abs((squareCoordinates[i, 4] - squareCoordinates[i, 2]) * 4);
                        SquarePerimetr[i, 0] = perimetr;
                        Console.WriteLine($"Квадрат {i} с периметром {perimetr}");
                    }
                }
            }

        }
        public void GetCircleLength()
        {
            const double pi = 3.1415926535;
            double length = 0;
            for (int i = 0; i < Shapes.Length; i++)
            {
                if (Shapes[i] is Circle)
                {
                    length = 2 * pi * circleCoordinates[i, 2];
                    CirclesLength[i, 0] = length;
                    Console.WriteLine(length);
                }
            }
        }
    }
}
