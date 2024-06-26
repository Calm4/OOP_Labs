﻿using System;
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
        public Square(int leftBotX, int leftBotY, int leftTopX, int leftTopY, int rightTopX, int rightTopY, int rightBotX, int rightBotY)
        {
            coordinates[0] = leftBotX;
            coordinates[1] = leftBotY;
            coordinates[2] = leftTopX;
            coordinates[3] = leftTopY;
            coordinates[4] = rightTopX;
            coordinates[5] = rightTopY;
            coordinates[6] = rightBotX;
            coordinates[7] = rightBotY;
        }

        public double GetArea()
        {
            Area = (coordinates[3] - coordinates[1]) * (coordinates[3] - coordinates[1]);
            return Area;
        }
        public double Perimetr()
        {
            
            return 1;
        }
        public void ShowInformation()
        {
            Console.WriteLine("Координата квадрата: " + coordinates[0]);
            Console.WriteLine("Координата квадрата: " + coordinates[1]);
            Console.WriteLine("Координата квадрата: " + coordinates[2]);
            Console.WriteLine("Координата квадрата: " + coordinates[3]);
            Console.WriteLine("Координата квадрата: " + coordinates[4]);
            Console.WriteLine("Координата квадрата: " + coordinates[5]);
            Console.WriteLine("Координата квадрата: " + coordinates[6]);
            Console.WriteLine("Координата квадрата: " + coordinates[7]);
        }

        public int this[int index]
        {
            get => coordinates[index];
            set => coordinates[index] = value;

        }

    }
}
