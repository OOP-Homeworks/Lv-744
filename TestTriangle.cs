using HW_10_2023;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTriangle
{
    [TestClass]
    public class TestTriangle
    {
        [TestMethod]
        public void TestDistance_point00point34_return5()
        {
            // Arrange
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 4);

            // Act
            double distance = p1.Distance(p2);

            // Assert
            Assert.AreEqual(distance, 5.0);
        }

        [TestMethod]

        public void TestSquare_point00point34point60_return6()
        {
            // Arrange
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 4);
            Point p3 = new Point(6, 0);
            Triangle t = new Triangle(p1, p2, p3);

            // Act
            double square = t.Square();

            // Assert
            Assert.AreEqual(square, 12.0);
        }

        [TestMethod]

        public void TestPerimeter_point00point34point60_return12()
        {
            // Arrange
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 4);
            Point p3 = new Point(6, 0);
            Triangle t = new Triangle(p1, p2, p3);

            // Act
            double perimeter = t.Perimeter();

            // Assert
            Assert.AreEqual(perimeter, 16.0);
        }
    }
}
