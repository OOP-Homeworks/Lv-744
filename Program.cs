using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft
{
    public class Program
    {
        public struct Point
        {
            public double x;
            public double y;

            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public override string ToString()
            {
                return $"({x},{y})";
            }
        }
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();

            Point v1 = new Point(0, 0);
            Point v2 = new Point(0, 4);
            Point v3 = new Point(3, 0);
            Triangle t1 = new Triangle(v1, v2, v3);
            triangles.Add(t1);

            v1 = new Point(0, 0);
            v2 = new Point(0, 3);
            v3 = new Point(4, 0);
            Triangle t2 = new Triangle(v1, v2, v3);
            triangles.Add(t2);

            v1 = new Point(0, 0);
            v2 = new Point(0, 5);
            v3 = new Point(5, 0);
            Triangle t3 = new Triangle(v1, v2, v3);
            triangles.Add(t3);

            foreach (Triangle t in triangles)
            {
                t.Print();
                Console.WriteLine();
            }
        }
    }
}
