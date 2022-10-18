using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    internal class Square : GeometricShape,IGeometricShapes
    {
        public int[] coordinates = new int[8];
        
        public double Area { get; set; }
        public Square(int leftBotX, int leftBotY, int leftTopX, int leftTopY, int rightTopX, int rightTopY, int rightBotX, int rightBotY) : base(leftBotX,leftBotY,leftTopX,leftTopY,rightTopX,rightTopY,rightBotX,rightBotY)
        {
          

        }

        public double GetArea()
        {
            Area = 1;
            return Area;
        }
        public double Perimetr()
        {
            return 1;
        }
        public void ShowInformation()
        {

        }

        public int this[int index]
        {
            get => coordinates[index];
            set => coordinates[index] = value;

        }

    }
}
