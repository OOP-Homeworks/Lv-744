using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20230216_HomeWork_8
{
    internal class Square : Shape
    {
        private double side;

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Area()

        public override double GetArea()

        {
            return side * side;
        }


        public override double Perimeter()
        {
            return 4 * side;

        public override string GetName()
        {
            return "Square";

        }
    }
}
