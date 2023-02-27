using Microsoft.VisualStudio.TestPlatform.TestHost;
using HW10;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPerimeter()
        {
            // Arrange
            var p1 = new HW10.Program.Point(0, 0);
            var p2 = new HW10.Program.Point(3, 4);
            var p3 = new HW10.Program.Point(6, 0);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            double perimeter = triangle.Perimeter(p1, p2, p3);

            // Assert
            Assert.AreEqual(16, perimeter);
        }

        [TestMethod]
        public void TestSquare()
        {
            // Arrange
            var p1 = new HW10.Program.Point(0, 0);
            var p2 = new HW10.Program.Point(3, 4);
            var p3 = new HW10.Program.Point(6, 0);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            double square = triangle.Square(p1, p2, p3);

            // Assert
            Assert.AreEqual(12, square);
        }
    }
}