using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    internal class Comperer : IComparer<IGeometricShapes>
    {
        public int Compare(IGeometricShapes shape1,IGeometricShapes shape2)
        {
            if (shape1.Area == shape2.Area)
            {
                return 1;
            }
            else
            {
                return -1;  
            }
           
        }
    }
}
