using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace hw_10._1_Taranko
{
    public class Triangle
    {
        private Point vertex1, vertex2, vertex3;

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
        }
        public Triangle()
        {
            this.vertex1 = default;
            this.vertex2 = default;
            this.vertex3 = default;
        }

        public Point Vertex1 {
            get { return vertex1; }
            set { vertex1 = value; }
        }
        public Point Vertex2
        {
            get { return vertex2; }
            set { vertex2 = value; }
        }
        public Point Vertex3
        {
            get { return vertex3; }
            set { vertex3 = value; }
        }
        public static double Distance(Point p1, Point p2) {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2.0) + Math.Pow(p2.Y - p1.Y, 2.0));
        }
        public double Side1()
        {
            return Math.Sqrt(Math.Pow(vertex2.X - vertex1.X, 2.0) + Math.Pow(vertex2.Y - vertex1.Y, 2.0));
        }
        public double Side2()
        {
            return Math.Sqrt(Math.Pow(vertex2.X - vertex3.X, 2.0) + Math.Pow(vertex2.Y - vertex3.Y, 2.0));
        }
        public double Side3()
        {
            return Math.Sqrt(Math.Pow(vertex1.X - vertex3.X, 2.0) + Math.Pow(vertex1.Y - vertex3.Y, 2.0));
        }
        public double Perimeter()
        {           
            return this.Side1() + this.Side2() + this.Side3();
        }
        public double Square()
        {          
            return Math.Sqrt(this.Perimeter()/2 * (this.Perimeter() / 2 - this.Side1()) * (this.Perimeter() / 2 - 
                this.Side2()) * (this.Perimeter() / 2 - this.Side3()));
        }
        public void Print()
        {
            Console.WriteLine($"Triangle : ({vertex1.X},{vertex1.Y}),({vertex2.X},{vertex2.Y}),({vertex3.X}," +
                $"{vertex3.Y})\n\tPerimeter: {this.Perimeter():f2}\n\tSquare: " +
                $"{this.Square():f2}\n\tSides length: {this.Side1():f2} , " +
                $"{this.Side2():f2} , 3{this.Side3():f2}\n\n");
        }
    }
}
