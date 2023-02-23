using hw_9_Taranko_A;
namespace SquareUnitTestsTaranko
{
    [TestClass]
    public class Sqare_UnitTest_Taranko10
    {

        

        //WRITED BY CHAT GPT)
        [TestMethod]
        public void Square_Taranko9_Area_CalculatesCorrectly()
        {
            // Arrange
            double side = 3.5;
            Square_Taranko9_10 square = new Square_Taranko9_10(side, "Square 1");
            double expectedArea = Math.Pow(side, 2);

            // Act
            double actualArea = square.Area();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [TestMethod]
        public void Square_Taranko9_Perimeter_CalculatesCorrectly()
        {
            // Arrange
            double side = 4.2;
            Square_Taranko9_10 square = new Square_Taranko9_10(side, "Square 1");
            double expectedPerimeter = 4 * side;

            // Act
            double actualPerimeter = square.Perimeter();

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.001);
        }

        [TestMethod]
        public void Square_Taranko9_ToString_FormatsCorrectly()
        {
            // Arrange
            string name = "Square 1";
            double side = 3.0;
            Square_Taranko9_10 square = new Square_Taranko9_10(side, name);
            string expectedString = $"Shape : {name}\t\tArea : {Math.Pow(side, 2):f3}\t\tPerimeter : {4 * side:f3}";

            // Act
            string actualString = square.ToString();

            // Assert
            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void Square_Taranko9_CompareTo_Returns1ForLargerArea()
        {
            // Arrange
            double largerSide = 5.0;
            double smallerSide = 3.0;
            Square_Taranko9_10 largerSquare = new Square_Taranko9_10(largerSide, "Square 1");
            Square_Taranko9_10 smallerSquare = new Square_Taranko9_10(smallerSide, "Square 2");

            // Act
            int result = largerSquare.CompareTo(smallerSquare);

            // Assert
            Assert.AreEqual(1, result);
        }
        //WRITED BY CHAT GPT)
    }
}