﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    internal sealed class Circle : Shape
    {
        private double radius;
        private readonly string shapeName = "Circle";

        public Circle(double radius) : base(radius)
        {
            this.radius = radius;
            base.name = shapeName;
            
            Console.WriteLine("Circle area is {0} and perimeter is {1}", Math.Round(Area(), 2), Math.Round(Perimeter(), 2));
        }

        public override double Area()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public override double Perimeter()
        {
            double perimeter = 2 * Math.PI * radius;
            return perimeter;
        }

        public override double GetArea { get { return Area(); } }
        public override double GetPerimeter { get { return Perimeter(); } }

        public override int CompareTo(object obj)
        {
            Shape sh1 = obj as Shape;
            if (sh1 != null)
            {
                return GetArea.CompareTo(sh1.GetArea);
            }
            else
            {
                throw new ArgumentException("Object is not Shape");
            }
        }
    }
}