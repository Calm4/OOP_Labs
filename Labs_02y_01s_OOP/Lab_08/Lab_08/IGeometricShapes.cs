using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    internal interface IGeometricShapes
    {
        double Area { get; set; }
        void ShowInformation();

        int this[int index] { get;set; }

    }
}
