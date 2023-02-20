using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230216_HomeWork_8
{
    internal class Circle : Shape
    {
        private double radius;

        public Circle(string name, double radius) : base(name)

        {
            this.radius = radius;
        }


        public override double Area()
        {
            return Math.PI * radius * radius;

        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;

        }

        public override double GetArea()
        {

            return 2 * Math.PI * radius;

        }

        public override string GetName()
        {
            return "Circle";

        }
    }
}
