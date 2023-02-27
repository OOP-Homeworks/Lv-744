using hw_10._1_Taranko;
namespace TrianglesUnitTests
{
    [TestClass]
    public class TriangleUnitTestsTaranko
    {
        [TestMethod]
        public void DistanceBeetwenPoints_X0Y0_X0Y5_Exepted5()
        {
            //Arrange
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 5);
            double exepted = 5.0;

            //Act
            double result = Triangle.Distance(p1, p2);

            //Assert
            Assert.AreEqual(exepted, result);

        }

        [TestMethod]
        public void Side1Length_X0Y0_X0Y5_Exepted5()
        {
            //Arrange
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 5);
            Point p3 = new Point(1, 8);
            Triangle t1 = new Triangle(p1, p2, p3);
            double exepted = 5.0;

            //Act
            double result = t1.Side1();

            //Assert
            Assert.AreEqual(exepted, result);
        }
        [TestMethod]
        public void Side2Length_X0Y0_X0Y5_Exepted5()
        {
            //Arrange
            Point p1 = new Point(1, 8);
            Point p2 = new Point(0, 0);
            Point p3 = new Point(0, 5);
            Triangle t1 = new Triangle(p1, p2, p3);
            double exepted = 5.0;

            //Act
            double result = t1.Side2();

            //Assert
            Assert.AreEqual(exepted, result);
        }
        [TestMethod]
        public void Side3Length_X0Y0_X0Y5_Exepted5()
        {
            //Arrange
            Point p1 = new Point(0, 0);
            Point p2 = new Point(1, 8);
            Point p3 = new Point(0, 5);
            Triangle t1 = new Triangle(p1, p2, p3);
            double exepted = 5.0;

            //Act
            double result = t1.Side3();

            //Assert
            Assert.AreEqual(exepted, result);
        }
        [TestMethod]
        public void Perimeter_X0Y0_X0Y4_X3Y0_Exepted12()
        {
            //Arrange
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 4);
            Point p3 = new Point(3, 0);
            Triangle t1 = new Triangle(p1, p2, p3);
            double exepted = 12.0;

            //Act
            double result = t1.Perimeter();

            //Assert
            Assert.AreEqual(exepted, result);
        }

        [TestMethod]
        public void Square_X0Y0_X0Y4_X3Y0_Exepted4()
        {
            //Arrange
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 8);
            Point p3 = new Point(1, 0);
            Triangle t1 = new Triangle(p1, p2, p3);
            double exepted = 4.0;

            //Act
            double result = t1.Square();

            //Assert
            Assert.AreEqual(exepted, result);
        }
    }
}