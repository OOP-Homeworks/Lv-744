using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._02._2023_HomeWork_9
{
    abstract class Shape : IComparable<Shape>
    {
        private string name;

        public string Name { get { return name; } }

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double Area();

        public abstract double Perimeter();

        public int CompareTo(Shape s)
        {
            Circle circle = s as Circle;
            Square square = s as Square;
            if (circle != null)
            {
                return this.Area().CompareTo(circle.Area());
            }
            else if (square != null)
            {
                return this.Area().CompareTo(square.Area());
            }
            else
            {
                throw new ArgumentException("Error");
            }
        }

        public void Print()
        {
            Console.WriteLine("Shape: {0:}, area: {1:f2}, perimeter: {2:f2} ", name, Area(), Perimeter());
        }
    }
}
