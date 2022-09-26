using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_2_
{
    internal class Vector
    {
        
        
        public double VectorX { get; set; }
        public double VectorY { get; set; }
        public double VectorZ { get; set; }  

        public static Vector operator +(Vector vector1, Vector vector2)
        {

            return new Vector
            {
                VectorX = vector1.VectorX + vector2.VectorX,
                VectorY = vector1.VectorY + vector2.VectorY,
                VectorZ = vector1.VectorZ + vector2.VectorZ
            };
        }
        public static Vector operator -(Vector vector1, Vector vector2)
        {

            return new Vector
            {
                VectorX = vector1.VectorX - vector2.VectorX,
                VectorY = vector1.VectorY - vector2.VectorY,
                VectorZ = vector1.VectorZ - vector2.VectorZ
            };
        }
        public static Vector operator *(Vector vector1, Vector vector2)
        {
            return new Vector
            {
                VectorX = vector1.VectorY * vector2.VectorZ - vector1.VectorZ * vector2.VectorY,
                VectorY = -(vector1.VectorX * vector2.VectorZ - vector1.VectorZ * vector2.VectorX),
                VectorZ = vector1.VectorX * vector2.VectorY - vector1.VectorY * vector2.VectorX
            };
        }
        /*public static  operator *(Vector vector1,Vector vector2,Vector vector3)
        {
            return vector1.VectorX * vector2.VectorX + vector1.VectorY * vector2.VectorY + vector1.VectorZ * vector2.VectorZ;
        }*/
    }
}
