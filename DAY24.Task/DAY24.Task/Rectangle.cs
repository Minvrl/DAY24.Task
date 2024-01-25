using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY24.Task
{
    internal class Rectangle:Shape
    {
        public double Length;
        public double Width;
        public override double CalculateArea()
        {
            return Width*Length;
        }
    }
}
