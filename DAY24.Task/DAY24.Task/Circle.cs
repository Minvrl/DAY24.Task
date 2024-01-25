using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY24.Task
{
    internal class Circle:Shape
    {
        public double Radius;

        public override double CalculateArea()
        {
            double pi = 3.14;

            return Radius * Radius * pi;
        }
    }
}
