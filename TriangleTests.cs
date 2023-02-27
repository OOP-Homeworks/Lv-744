using _23022023_HomeWork_10;

namespace TestTriangle
{
    [TestClass]
    public class TriangleTest
    {
        Point first = new Point(0, 0);
        Point second = new Point(3, 0);
        Point third = new Point(0, 4);

        [TestMethod]
        public void Perimeter_3_4_5_Result_12()
        {
            Triangle triangle = new Triangle(first, second, third);
            double expected = 12;
            Assert.AreEqual(expected, triangle.GetPerimeter());
        }

        [TestMethod]
        public void Area_3_4_5_Result_6()
        {
            Triangle triangle = new Triangle(first, second, third);
            double expected = 6;
            Assert.AreEqual(expected, triangle.GetArea());
        }

        [TestMethod]
        public void InvalidTriangle_VerticesOnOneLine_ThrowsArgumentException()
        {
            Point[] points = new Point[] { new Point(0, 1), new Point(0, 2), new Point(0, 3) };
            Assert.ThrowsException<ArgumentException>(() => new Triangle(points[0],
                points[1], points[2]), "Triangle with vertices on one line should throw ArgumentException");
        }
    }
}

