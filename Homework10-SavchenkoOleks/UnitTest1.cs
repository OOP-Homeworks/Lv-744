using Homework10_SavchenkoOleks_LV744;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Distance_2and0to0and0_2returned()
        {
            double firstNumber = 2;
            double secondNumber = 0;
            Point p = new Point(0, 0);
            double expected = 2;

            double actual = p.Distance(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Square_3and4_5and12_8and6_18returned()
        {
            Point p1 = new Point(3, 4);
            Point p2 = new Point(5, 12);
            Point p3 = new Point(8, 6);
            Triangle tr = new Triangle(p1, p2, p3);
            double expected = 18;

            double actual = tr.Square();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Perimeter_3and4_6and8_9and4_returned18()
        {
            Point p1 = new Point(3, 4);
            Point p2 = new Point(6, 8);
            Point p3 = new Point(9, 4);
            Triangle tr = new Triangle(p1, p2, p3);
            double expected = 16;

            double actual = tr.Perimeter();

            Assert.AreEqual(expected, actual);
        }
    }
}