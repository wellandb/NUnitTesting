using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Legacy;

namespace NUnitTesting
{
    [TestFixture]
    class CalcTest
    {
        [Test]
        public void AddTest()
        {
            // Arrange
            Calc c = new Calc();
            double x = 4.0;
            double y = 5.0;
            double expectedValue = 9.0;
            // Act
            double actualValue = c.Add(x, y);
            // Assert
            ClassicAssert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void AddTestFail()
        {
            // Arrange
            Calc c = new Calc();
            double x = 4.0;
            double y = 5.0;
            double expectedValue = 9.0;
            // Act
            double actualValue = c.Add(x, y);
            // Assert
            ClassicAssert.AreNotEqual(expectedValue, actualValue);
        }

        [Test]
        public void SubTest()
        {
            // Arrange
            Calc c = new Calc();
            double x = 5.0;
            double y = 4.0;
            double expectedValue = 1.0;
            // Act
            double actualValue = c.Subtract(x, y);
            // Assert
            ClassicAssert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void SubTestFail()
        {
            // Arrange
            Calc c = new Calc();
            double x = 5.0;
            double y = 4.0;
            double expectedValue = 1.0;
            // Act
            double actualValue = c.Subtract(x, y);
            // Assert
            ClassicAssert.AreNotEqual(expectedValue, actualValue);

        }
    }
}
