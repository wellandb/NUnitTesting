using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    class Circle
    {
        public double Area(double rad)
        {
            return Math.PI * Math.Pow(rad,2);
        }

        public double Perimeter(double rad) {
            return 2 * Math.PI * rad;
        }
    }
}
