namespace hw_10._1_Taranko
{
    public struct Point
    {
        private int x, y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return string.Format($"({x},{y})");
        }
    }
    internal class Program
    {
        const int COUNTOFTRIENGLES = 3; 
        static void Main(string[] args)
        {

            List<Triangle> triangles = new List<Triangle>();
            for (int i = 0; i < COUNTOFTRIENGLES; i++) {
                int x = 0;
                int y = 0;
                Triangle t1 = new Triangle();
                for (int b = 0; b < 3; b++) {
                    Console.WriteLine($"Enter x of {b + 1} point, triangle: {i+1}: ");
                    while (!Int32.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine($"Enter correct x of {i + 1} point, triangle: {i + 1}: ");
                    }
                    Console.WriteLine($"Enter y of {b + 1} point, triangle: {i + 1}: ");
                    while (!Int32.TryParse(Console.ReadLine(), out y))
                    {
                        Console.WriteLine($"Enter correct x of {b + 1} point, triangle: {i + 1}: ");
                    }
                    Point p1 = new Point(x, y);
                    if (b == 0)
                    {
                        t1.Vertex1 = p1;
                    }
                    else if (b == 1)
                    {
                        t1.Vertex2 = p1;
                    }
                    else 
                    {
                        t1.Vertex3 = p1;
                    }
                    Console.WriteLine("\n");
                }
                triangles.Add(t1);
                Console.WriteLine("\n\n");
            }
            foreach (Triangle tr in triangles) {
                tr.Print();
            }

            Console.WriteLine("\n\nTwo point to calculate distance:\n");
            Point pp1 = new Point();
            Point pp2 = new Point();
            for (int b = 0; b < 2; b++)
            {
                int x = 0,y = 0;
                Console.WriteLine($"Enter x of {b + 1} point: ");
                while (!Int32.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine($"Enter correct x of {b + 1} point: ");
                }
                Console.WriteLine($"Enter y of {b + 1} point: ");
                while (!Int32.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine($"Enter correct x of {b + 1} point: ");
                }
                if (b == 0)
                {
                    pp1.X = x;
                    pp1.Y = y;
                }
                else 
                {
                    pp2.X = x;
                    pp2.Y = y;
                }
            }
            Console.WriteLine($"Distance : {Triangle.Distance(pp1,pp2)}");

            Console.WriteLine("\n\nTriangle with erex clother to (0,0):\n");

            double minPoint = Triangle.Distance(triangles[0].Vertex1,new Point(0,0));
            int minTry = 0;
            for (int i = 0; i < triangles.Count; i++) {
                if (Triangle.Distance(triangles[i].Vertex1, new Point(0, 0)) < minPoint) {
                    minPoint = Triangle.Distance(triangles[i].Vertex1, new Point(0, 0));
                    minTry = i;
                }
                if (Triangle.Distance(triangles[i].Vertex2, new Point(0, 0)) < minPoint)
                {
                    minPoint = Triangle.Distance(triangles[i].Vertex2, new Point(0, 0));
                    minTry = i;
                }
                if (Triangle.Distance(triangles[i].Vertex3, new Point(0, 0)) < minPoint)
                {
                    minPoint = Triangle.Distance(triangles[i].Vertex3, new Point(0, 0));
                    minTry = i;
                }
            }
            Console.WriteLine($"Result :\n");
            triangles[minTry].Print();
        }
    }
}