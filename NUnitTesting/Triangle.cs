using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    class Triangle
    {

        public double Area(double x, double y, double z)
        {
            double s = (x + y + z)/2;
            return Math.Sqrt(s*(s-x)*(s-y)*(s-z));
        }

        public double Perimeter(double x, double y, double z)
        {
            return x+y+z;
        }
    }

}
