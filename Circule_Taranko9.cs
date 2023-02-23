using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_9_Taranko_A
{
    internal class Circule_Taranko9 : Shape_Taranko9 , IComparable
    {
        double radious;
        public Circule_Taranko9(double radious , string name) : base(name)
        {
            this.radious = radious;
        }

        public double Radious {
            get { return radious; }
            set { radious = value; }
        }

        public override double Area() {
            return Math.PI * Math.Pow(radious, 2);
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * radious;
        }

        public override string ToString()
        {
            return $"Shape : {this.Name}\t\tArea : {this.Area():f3}\t\tPerimeter : {this.Perimeter():f3}";
        }

        public int CompareTo(object o)
        {
            if (o.GetType() == this.GetType())
            {
                Circule_Taranko9 temp = (Circule_Taranko9)o;
                if (temp.Area() < this.Area())
                {
                    return 1;
                }
                return -1;
            }
            else
            {
                Square_Taranko9 temp = (Square_Taranko9)o;
                if (temp.Area() < this.Area())
                {
                    return 1;
                }
                return -1;
            }          
        }
    }
}
