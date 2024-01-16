using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    [TestFixture]
    class ShapeTests
    {
        [Test]
        public void CircleAreaSuccessTest()
        {
            Circle c = new Circle();
            double radius = 1.0;
            double expectedArea = Math.PI;
            double actualArea = c.Area(radius);
            ClassicAssert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void CircleAreaFailTest()
        {
            Circle c = new Circle();
            double radius = 1.0;
            double expectedArea = Math.PI;
            double actualArea = c.Area(radius);
            ClassicAssert.AreNotEqual(expectedArea, actualArea);
        }

        [Test]
        public void CirclePerimeterSucessTest()
        {
            Circle c = new Circle();
            double radius = 1.0;
            double expectedPerimeter = Math.PI*radius*2;
            double actualPerimeter = c.Perimeter(radius);
            ClassicAssert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [Test]
        public void CirclePerimeterFailTest()
        {
            Circle c = new Circle();
            double radius = 1.0;
            double expectedPerimeter = Math.PI * radius * 2;
            double actualPerimeter = c.Perimeter(radius);
            ClassicAssert.AreNotEqual(expectedPerimeter, actualPerimeter);
        }

        [Test]
        public void RectangleAreaSuccessTest()
        {
            Rectangle r = new Rectangle();
            double a = 1.0;
            double b = 2.0;
            double expectedArea = 2.0;
            double actualArea = r.Area(a, b);
            ClassicAssert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void RectangleAreaFailTest()
        {
            Rectangle r = new Rectangle();
            double a = 1.0;
            double b = 2.0;
            double expectedArea = 2.0;
            double actualArea = r.Area(a, b);
            ClassicAssert.AreNotEqual(expectedArea, actualArea);
        }

        [Test]
        public void RectanglePerimeterSuccessTest()
        {
            Rectangle r = new Rectangle();
            double a = 1.0;
            double b = 2.0;
            double expectedPerimeter = 6.0;
            double actualPerimeter = r.Perimeter(a, b);
            ClassicAssert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [Test]
        public void RectanglePerimeterFailTest()
        {
            Rectangle r = new Rectangle();
            double a = 1.0;
            double b = 2.0;
            double expectedPerimeter = 6.0;
            double actualPerimeter = r.Perimeter(a, b);
            ClassicAssert.AreNotEqual(expectedPerimeter, actualPerimeter);
        }

        [Test]
        public void TriangleAreaSuccessTest()
        {
            Triangle r = new Triangle();
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            double expectedArea = 6.0;
            double actualArea = r.Area(a, b, c);
            Console.WriteLine(expectedArea);
            ClassicAssert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void TriangleAreaFailTest()
        {
            Triangle r = new Triangle();
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            double expectedArea = 6.0;
            double actualArea = r.Area(a, b, c);
            ClassicAssert.AreNotEqual(expectedArea, actualArea);
        }

        [Test]
        public void TrianglePerimeterSuccessTest()
        {
            Triangle r = new Triangle();
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            double expectedPerimeter = 12.0;
            double actualPerimeter = r.Perimeter(a, b, c);
            ClassicAssert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [Test]
        public void TrianglePerimeterFailTest()
        {
            Triangle r = new Triangle();
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            double expectedPerimeter = 12.0;
            double actualPerimeter = r.Perimeter(a, b, c);
            ClassicAssert.AreNotEqual(expectedPerimeter, actualPerimeter);
        }
    }
}
