using System.IO;

namespace HW8
{
    internal class Program
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("Enter radius of the circle:");
                shapes.Add(new Circle(double.Parse(Console.ReadLine())));
                Console.WriteLine("Enter side of the square:");
                shapes.Add(new Square(double.Parse(Console.ReadLine())));
            }

            double[] perimeterList = new double[shapes.Count];
            for (int i = 0; i< shapes.Count; i++)
            {
                perimeterList[i] = shapes[i].GetPerimeter;
            }
            Console.WriteLine(perimeterList.Max() + " is the largest perimeter.");

            ////SORT WITH LINQ
            /*
            List<Shape> SortedList = shapes.OrderBy(o => o.GetArea).ToList();
            for (int i = 0; i < SortedList.Count; i++)
            {
                Console.WriteLine(SortedList[i].ToString().Substring(SortedList[i].ToString().IndexOf('.') + 1) + " " + SortedList[i].GetArea);
            }
            */
            ////SORT by utilizing CompareTo()
            shapes.Sort();
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetArea);
            }
        }
    }
}