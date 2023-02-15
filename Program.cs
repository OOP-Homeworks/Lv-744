
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>();
            Console.WriteLine("Enter 10 times: ");
            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine($"Enter Shape {i}: ");
                Console.Write("Enter shape name: ");
                string name = Console.ReadLine();

                Console.Write("Enter shape type (Circle/Square): ");
                string type = Console.ReadLine();

                if (type == "Circle")
                {
                    Console.Write("Enter radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(name, radius));
                }
                else if (type == "Square")
                {
                    Console.Write("Enter side: ");
                    double side = double.Parse(Console.ReadLine());
                    shapes.Add(new Square(name, side));
                }
            }
            Console.WriteLine("\nShape info: ");
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}, Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
            }

            Shape TheBiggest = shapes[0];
            foreach (var shape in shapes)
            {
                if (shape.Perimeter() > TheBiggest.Perimeter())
                {
                    TheBiggest = shape;
                }
            }

            Console.WriteLine("\nShape with largest perimeter: ");
            Console.WriteLine($"Name: {TheBiggest.Name}, Perimeter: {TheBiggest.Perimeter()}");

            shapes.Sort();

            Console.WriteLine("\nSorted by area: ");
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }


            List <IDeveloper> developers = new List<IDeveloper>();
            Builder builder1 = new Builder("John", "1C");
            Builder builder2 = new Builder("Mark", "C#");
            developers.Add(builder1);
            developers.Add(builder2);
            Programmer programmer1 = new Programmer("Ben","MacBook");
            Programmer programmer2 = new Programmer("Filip","Acer");
            developers.Add(programmer1);
            developers.Add(programmer2);
            foreach (IDeveloper devel in developers)
            {
                devel.Create();
                devel.Destroy();
            }
            developers.Sort();

        }
    }
}