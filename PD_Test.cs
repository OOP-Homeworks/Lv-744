using homework;
using System.Runtime.ExceptionServices;

namespace HW10ProdTest
{
    [TestClass]
    public class PointTest
    {
        PD_Point first = new PD_Point(0, 0);
        PD_Point second = new PD_Point(0, 1);
        [TestMethod]
        public void Distance1overload_Point_0_0_and_Point_0_1_result_1()
        {
            int expected = 1;
            Assert.AreEqual(expected, first.Distance(second));
        }
        [TestMethod]
        public void Distance2overload_Point_0_0_and_Point_0_1_result_1()
        {
            int expected = 1;
            Assert.AreEqual(expected, PD_Point.Distance(first, second));
        }
    }

    public class TriangleTest
    {
        PD_Point first = new PD_Point(0, 3);
        PD_Point second = new PD_Point(0, 4);
        PD_Point third = new PD_Point(0, 0);
        [TestMethod]
        public void Perimetr_3_4_5_result_12()
        {
            PD_Triangle triangle = new PD_Triangle(first, second, third);
            int expected = 12;
            Assert.AreEqual(expected, triangle.Perimetr());
        }
        [TestMethod]
        public void Square_3_4_5_result_6()
        {
            PD_Triangle triangle = new PD_Triangle(first, second, third);
            int expected = 6;
            Assert.AreEqual(expected, triangle.Perimetr());
        }
    }
}