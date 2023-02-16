namespace Homework8_SavchenkoOleks_LV744
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of shapes:");
            List<Shape> shapeList = Task1();
            Console.WriteLine();
            Console.WriteLine("Shape with the biggest area:");
            Task2(shapeList);
            Console.WriteLine();
            Console.WriteLine("Sorted list:");
            Task3(shapeList);
        }
        static List<Shape> Task1()
        {
            var random = new Random();
            const int numberOfShapes = 10;
            List<Shape> listOfShapes = new List<Shape>();
            for (int i = 0; i < numberOfShapes; i++)
            {
                int randomShape = random.Next(0, 2);
                int shapeSize = random.Next(1, 100);
                if (randomShape == 0)
                {
                    listOfShapes.Add(new Circle("Circle", shapeSize));
                }
                else
                {
                    listOfShapes.Add(new Square("Square", shapeSize));
                }
            }
            foreach (Shape shape in listOfShapes)
            {
                shape.Print();
            }
            return listOfShapes;
        }
        static void Task2(List<Shape> shapeList)
        {
            shapeList.Sort();
            shapeList.Last().Print();
        }
        static void Task3(List<Shape> shapeList)
        {
            shapeList.Sort();
            foreach(Shape shape in shapeList)
            {
                shape.Print();
            }
        }
    }
}