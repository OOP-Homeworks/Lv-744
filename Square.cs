﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_8_Taranko
{
    internal class Square : Shape , IComparable
    {
        double side;
        public Square(double side, string name) : base(name)
        {
            this.side = side;
        }
        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public override double Area()
        {
            return Math.Pow(side, 2);
        }
        public override double Perimeter()
        {
            return 4 * side;
        }

        public override string ToString()
        {
            return $"Shape : {this.Name}\t\tArea : {this.Area():f3}\t\tPerimeter : {this.Perimeter():f3}";
        }
        public int CompareTo(object o)
        {
            if (o.GetType() == this.GetType())
            {
                Square temp = (Square)o;
                if (temp.Area() < this.Area())
                {
                    return 1;
                }
                return -1;
            }
            else
            {
                Circule temp = (Circule)o;
                if (temp.Area() < this.Area())
                {
                    return 1;
                }
                return -1;
            }
        }
    }
}
