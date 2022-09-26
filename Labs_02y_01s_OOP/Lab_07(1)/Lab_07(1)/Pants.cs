using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07_1_
{
    internal class Pants : Costume
    {
        public Pants(Gender gender, double growth, Type_clothes type, Color color) : base(gender, growth, type, color)
        {
        }
    }
}
