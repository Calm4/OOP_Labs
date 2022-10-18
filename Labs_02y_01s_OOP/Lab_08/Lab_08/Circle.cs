using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    internal class Circle : GeometricShape,IGeometricShapes
    {
        private int[] coordinates = new int[2];
       
        private int _radius;
        private string _CircleColor;
        public double Area { get; set; }

        public Circle(int x,int y,int radius,string color)
        {
            coordinates[0] = x;
            coordinates[1] = y;
            _radius = radius;
            _CircleColor = color;
        }
        public void ShowInformation()
        {

        }
        public double CircleLength()
        {
            return 1;
        }
        public int this[int index]
        {
            get => coordinates[index]; 
            set => coordinates[index] = value; 
        }

    }
}
