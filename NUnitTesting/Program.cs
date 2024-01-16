using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            double area = t.Area(3, 4, 5);
            Console.WriteLine(area);
        }
    }
}
