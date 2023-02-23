using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_SavchenkoOleks_LV744
{
    internal class TasksA
    {
        const int LISTLENGTH = 6;
        public static void TaskA()
        {
            List<Shape> listOfShapes = Task1();
            Task2(listOfShapes);
            Task3(listOfShapes);
            Task4(listOfShapes);
        }
        private static List<Shape> Task1()
        {
            List<Shape> listOfShapes = new List<Shape>();

            for (int i = 0; i < LISTLENGTH; i++)
            {

                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                int length = 10;

                string randomName = new string(Enumerable.Repeat(chars, length)
                                                 .Select(s => s[random.Next(s.Length)])
                                                 .ToArray())
                                                 .ToLower();

                int randomNumber = random.Next(1, 21);

                int randomShape = random.Next(0, 2);

                if (randomShape == 0) listOfShapes.Add(new Circle(randomName, randomNumber));
                else listOfShapes.Add(new Square(randomName, randomNumber));
            }

            return listOfShapes;
        }
        private static void Task2(List<Shape> listOfShapes)
        {
            const string path = @"C:\Users\oleks\source\repos\Homework9-SavchenkoOleks-LV744\ShapesInRange10-100.txt";
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
            {
                foreach (Shape shape in listOfShapes.Where(o => o.Area() >= 10 && o.Area() <= 100))
                {
                    sw.WriteLine(shape);
                }
            }
        }
        private static void Task3(List<Shape> listOfShapes)
        {
            const string path = @"C:\Users\oleks\source\repos\Homework9-SavchenkoOleks-LV744\ShapesWithA.txt";
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
            {
                foreach (Shape shape in listOfShapes.Where(o => o.Name.Contains("a")))
                {
                    sw.WriteLine(shape.Name);
                }
            }
        }

        private static void Task4(List<Shape> listOfShapes)
        {
            foreach (Shape shape in listOfShapes.Where(o => o.Perimeter() <= 5))
            {
                listOfShapes.Remove(shape);
            }
            foreach (Shape shape in listOfShapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
