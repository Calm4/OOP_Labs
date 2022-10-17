using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGeometricShapes array = new Square();
            Console.WriteLine(array.Area);
        }
    }
    

    
}
