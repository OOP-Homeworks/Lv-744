using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal abstract class Shape : IComparable<Shape>
    {
        string name;
        public string Name { get { return name;} set { name = value;} }
        public Shape(string name) { this.name = name;}
        public abstract double Area();
        public abstract double Perimetr();
        public int CompareTo(Shape other)
        {
            return  (int) (Area() - other.Area());
        }
        public override string ToString()
        {
            return string.Format(
                "The {0} named {1}, area = {2}, perimetr = {3}",
                this is Square ? "square" : "circle",
                Name, Area(), Perimetr()); 
        }
    }
}
