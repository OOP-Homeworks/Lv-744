using System;
using System.Collections.Generic;

namespace HW_10_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new(3);
            triangles.Add(new Triangle(new Point(0, 0), new Point(0, 4), new Point(2, 6)));
            triangles.Add(new Triangle(new Point(4, 6), new Point(3, 5), new Point(2, 1)));
            triangles.Add(new Triangle(new Point(0, 0), new Point(3, 4), new Point(6, 0)));
            foreach (var item in triangles)
            {
                item.Print();
            }
        }
    }
}
