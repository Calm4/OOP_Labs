using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Lab_08
{
    public class GeometricShape
    {
        public double Area { get; set; }
        static private int _squareCounter;
        static private int _circleCounter;



        static readonly string[] textFile = File.ReadAllLines($"Shapes/shapes.txt");
        private readonly int[,] squareCoordinates = new int[textFile.Length, 8];
        private readonly int[,] circleCoordinates = new int[textFile.Length, 3];
        private readonly string[] circleColor = new string[textFile.Length];
        private readonly double[] ShapesArea = new double[CountOfSquares() + CountOfCircles()];
        private readonly double[] SquarePerimetr = new double[CountOfSquares()];
        private readonly double[] CirclesLength = new double[CountOfCircles()];

        // Временные массивы для выборки информации из текстового файла
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
                    Shapes[i] = new Circle(circleCoordinates[i, 0], circleCoordinates[i, 1], circleCoordinates[i, 2], circleColor[i]);

                }
            }

        }
        public static int CountOfCircles()
        {
            for (int i = 0; i < textFile.Length; i++)
            {
                if (textFile[i].StartsWith("Circle:"))
                {
                    _circleCounter++;
                }
            }
            return _circleCounter;
        }
        public static int CountOfSquares()
        {
            for (int i = 0; i < textFile.Length; i++)
            {
                if (textFile[i].StartsWith("Square:"))
                {
                    _squareCounter++;
                }
            }
            return _squareCounter;
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
                    circleColor[i] = stringWithCircleColor[3];
                    for (int k = 0; k < consoleColor.Length; k++)
                    {
                        if (circleColor[i].ToString() == consoleColor[k].ToString())
                        {

                            stringWithCircleCoordinates = textFile[i].Substring(8).Split(',');

                            for (int j = 0; j < circleCoordinates.GetLength(1); j++)
                            {
                                circleCoordinates[i, j] = Int32.Parse(stringWithCircleCoordinates[j]);

                            }
                        }
                    }

                    circleColor[i] = stringWithCircleColor[3];

                }
            }
        }
        // вывод квадратов из текстового файла
        public string OutPutSquare()
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
            return " ";
        }

        // вывод кругов из текстового файла
        public string OutPutCircle()
        {
            for (int i = 0; i < textFile.Length; i++)
            {
                if (textFile[i].StartsWith("Circle:"))
                {
                    for (int k = 0; k < consoleColor.Length; k++)
                    {
                        if (circleColor[i].ToString() == consoleColor[k].ToString())
                        {
                            Console.ForegroundColor = consoleColor[k];
                            Console.WriteLine("circle:");
                            for (int j = 0; j < circleCoordinates.GetLength(1); j++)
                            {
                                Console.Write(circleCoordinates[i, j] + "/");
                            }
                        }
                    }

                    Console.Write(circleColor[i]);
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine();
                }

            }
            return "";
        }
        // Получить площади фигур 
        public void GetArea()
        {
            const double pi = 3.1415926535;
            for (int i = 0; i < Shapes.Length; i++)
            {
                if (Shapes[i] is Circle)
                {
                    ShapesArea[i] = pi * circleCoordinates[i, 2] * circleCoordinates[i, 2];
                    //Console.WriteLine(Area);

                }
                if (Shapes[i] is Square)
                {
                    ShapesArea[i] = (squareCoordinates[i, 3] - squareCoordinates[i, 1]) * (squareCoordinates[i, 3] - squareCoordinates[i, 1]);
                    //Console.WriteLine(Area);

                }

            }


        }
        // Отсортировать фигуры по площади 
        public void SortByArea()
        {
            Array.Sort(ShapesArea);
        }
        public void OutPutSortedAreas()
        {
            Console.WriteLine("Отсортированные фигуры по их площади");
            for (int i = 0; i < ShapesArea.Length; i++)
            {
                Console.WriteLine(ShapesArea[i] + ": ");
            }
        }
        //  Получить периметр квадратов которые лежат больше чем в одной четверти
        public void GetSquarePerimetrerMoreThanOneQuater()
        {

            double perimetr;
            int k = 0;

            for (int i = 0; i < Shapes.Length; i++)
            {
                if (Shapes[i] is Square)
                {
                    if (((squareCoordinates[i, 4] > 0 && squareCoordinates[i, 5] > 0) && ((squareCoordinates[i, 0] < 0) && (squareCoordinates[i, 1] > 0))) || (((squareCoordinates[i, 4] > 0) && (squareCoordinates[i, 5] > 0)) && (squareCoordinates[i, 0] > 0) && (squareCoordinates[i, 1] < 0)) || ((squareCoordinates[i, 4] > 0 && squareCoordinates[i, 5] < 0) && ((squareCoordinates[i, 0] < 0) && (squareCoordinates[i, 0] < 0))) || ((squareCoordinates[i, 4] < 0 && squareCoordinates[i, 5] > 0) && ((squareCoordinates[i, 0] < 0) && (squareCoordinates[i, 0] < 0))) || ((squareCoordinates[i, 4] > 0 && squareCoordinates[i, 5] > 0) && ((squareCoordinates[i, 0] < 0) && (squareCoordinates[i, 0] < 0))))
                    {

                        perimetr = Math.Abs((squareCoordinates[i, 4] - squareCoordinates[i, 2]) * 4);
                        SquarePerimetr[k] = perimetr;
                        Console.WriteLine($"Квадрат {i + 1} в текстовом файле находится больше чем в 1ой четверти и имеет периметр {perimetr}");
                        k++;
                    }
                }
            }

        }
        public void GetCircleLength()
        {
            const double pi = 3.1415926535;
           
            int k = 0;
            for (int i = 0; i < Shapes.Length; i++)
            {
                if (Shapes[i] is Circle)
                {
                    CirclesLength[k] = 2 * pi * circleCoordinates[i, 2];
                    k++;
                }
            }
          
            Array.Sort(CirclesLength);
            for (int i = 0; i < CirclesLength.Length; i++)
            {
                if (CirclesLength[i] != 0)
                {
                    Console.WriteLine(CirclesLength[i]);
                }
            }
        }
    }
}
