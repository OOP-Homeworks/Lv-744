using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    internal abstract class Shape : IComparable
    {
        protected string name;
        protected double parameter;

        public string Name { get { return name; } }

        public Shape(double shapeParam)
        {
            //this.name = shapeName;
            this.parameter = shapeParam;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public abstract double GetArea { get; }
        public abstract double GetPerimeter { get; }

        public virtual int CompareTo(object obj)
        {
            Shape sh1 = obj as Shape;
            if (sh1 != null)
            {
                return Name.CompareTo(sh1.Name);
            }
            else
            {
                throw new ArgumentException("Object is not Shape");
            }
        }
    }
}
