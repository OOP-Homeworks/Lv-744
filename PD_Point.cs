using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.h_w
{
    public class PD_Point
    {
        double x, y;
        public PD_Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return string.Format("({0:F3}, {1:F3})", x, y);
        }
        public double Distance(PD_Point other)
        {
            return Math.Sqrt(Math.Pow((x - other.x), 2) + Math.Pow(( y - other.y), 2));
        }
        public static double Distance(PD_Point first, PD_Point second)
        {
            return Math.Sqrt(Math.Pow((first.x - second.x), 2) + Math.Pow((first.y - second.y), 2));
        }
    }
}
