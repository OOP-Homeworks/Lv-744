using Microsoft.VisualStudio.TestTools.UnitTesting;
using Soft;
using System;
using static Soft.Program;

namespace PointTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestToString()
        {
            Point p = new Point(1, 2);
            Assert.AreEqual("(1,2)", p.ToString());
        }
        [TestMethod]
        public void Perimeter()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 4);
            Point p3 = new Point(3, 0);
            Triangle triangle = new Triangle(p1, p2, p3);

            double expected = 12;
            double actual = triangle.Perimeter();
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        public void Square()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 4);
            Point p3 = new Point(3, 0);
            Triangle triangle = new Triangle(p1, p2, p3);

            double expected = 6;
            double actual = triangle.Square();
            Assert.AreEqual(expected, actual, 0.001);
        }

    }
}
