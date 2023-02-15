using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_SavchenkoOleks_LV744
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
        public void Print()
        {
            Console.WriteLine("Shape is {0:}, area is {1:f2}.", name, Area());
        }

        public int CompareTo(Shape? s)
        {
            Circle circle = s as Circle;
            Square square = s as Square;
            if(circle != null)
            {
                return this.Area().CompareTo(circle.Area());
            }
            else if(square != null)
            {
                return this.Area().CompareTo(square.Area());
            }
            else
            {
                throw new ArgumentException("You're trying to sort not shape elements");
            }
        }
    }
}
