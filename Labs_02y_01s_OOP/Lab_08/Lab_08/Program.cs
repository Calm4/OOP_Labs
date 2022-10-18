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
           
            string[] newFile = File.ReadAllLines($"Shapes/shapes.txt");
            Match[] match = new Match[newFile.Length];
            int[] coordinates = new int[8];
            IGeometricShapes[] array =
            {
                new Square(2,2,2,5,5,5,5,2),
            };
            Square[] squares =
            {
                 new Square(2,2,2,5,5,5,5,2),
            };
            GeometricShape[] geometricShape =
            {
                new Square(2,2,2,5,5,5,5,2),
            };



            for (int i = 0; i < newFile.Length; i++)
            {
                match[i] = Regex.Match(newFile[i], "Square: leftBotX :(.*?)\\| leftBotY :(.*?)\\| leftTopX:(.*?)\\| leftTopY:(.*?)\\| rightTopX:(.*?)\\| rightTopY:(.*?)\\| rightBotX:(.*?)\\| rightBotY:(.*?)\\| \r\n");
            }

            coordinates[0] = Convert.ToInt32(match[0].Groups[1].ToString()) ;
            Console.WriteLine(coordinates[0]);

            /*for (int i = 0; i < newFile.Length; i++)
            {
                for (int j  = 0; j < coordinates.Length; j++)
                {
                    coordinates[j] = Convert.ToInt32(match[i].Groups[j+1].ToString());

                }
            }*/
            for (int i = 0; i < coordinates.Length; i++)
            {
                Console.WriteLine(coordinates[i]);
            }
        }
    }


    //Circle: centerOfCircleX : 3 \\| centerOfCircle : 3 \\| radius : 5 \\| color : Red \\|



}
