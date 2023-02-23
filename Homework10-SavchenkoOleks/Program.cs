using System.Runtime.CompilerServices;

namespace Homework10_SavchenkoOleks_LV744
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NUMBEROFTRIANGLES = 3, NUMBEROFVERTECES = 3;
            double MinlengthTo00 = double.MaxValue;
            List<Triangle> triangles = new List<Triangle>();
            int counter = 0;
            int numberOfTriange = 0;
            Point p = new Point(0, 0);
            double lengthTo00 = 0;
            while (counter < NUMBEROFTRIANGLES)
            {
                List<Point> vertices = new List<Point>();
                Random random = new Random();
                for (int j = 0; j < NUMBEROFVERTECES; j++)
                {
                    var dot = new Point(random.Next(-10, 10), random.Next(-10, 10));
                    vertices.Add(dot);
                    if (dot.Distance(p) < MinlengthTo00)
                    {
                        numberOfTriange = counter;
                        lengthTo00 = Math.Round(dot.Distance(p), 2);
                    }
                }
                var triangle = new Triangle(vertices[0], vertices[1], vertices[2]);
                if (triangle.IsTriangleCorrect())
                {
                    triangles.Add(triangle);
                    counter++;
                }
            }
            foreach(Triangle triangle in triangles)
            {
                triangle.Print();
            }

            Console.WriteLine("Triangle with the vertex closest to (0,0) is: ");
            triangles[numberOfTriange].Print();
            Console.WriteLine($"Length to (0,0) is {lengthTo00}");
        }
    }
}