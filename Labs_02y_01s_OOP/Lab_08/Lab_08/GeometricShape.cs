using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    internal class GeometricShape
    {
        int[] squareCoordinates = new int[8];
        int[] circleCoordinates = new int[2];
        
        public GeometricShape(int leftBotX, int leftBotY, int leftTopX, int leftTopY, int rightTopX, int rightTopY, int rightBotX, int rightBotY)
        {
            circleCoordinates[0] = leftBotX;
            circleCoordinates[1] = leftBotY;
            circleCoordinates[2] = leftTopX;
            circleCoordinates[3] = leftTopY;
            circleCoordinates[4] = rightTopX;
            circleCoordinates[5] = rightTopY;
            circleCoordinates[6] = rightBotX;
            circleCoordinates[7] = rightBotY;
        }
        public GeometricShape(int x, int y)
        {
            squareCoordinates[0] = x;
            squareCoordinates[1] = y;

        }
    }
}
