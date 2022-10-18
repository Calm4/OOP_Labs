using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Lab_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] newFile = File.ReadAllLines($"Shapes/shapes.txt");
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
           
            Console.WriteLine(geometricShape[0]);

        }
    }
    

    
}
