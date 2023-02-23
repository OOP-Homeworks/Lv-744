using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace hw_9_Taranko_A
{
    internal class hw_9_Taranko_A
    {
        const int COUNTOFSHAPES = 6;
        static void Main(string[] args)
        {
            List<Shape_Taranko9> shapeList = new List<Shape_Taranko9>();

            for (int i = 0; i < COUNTOFSHAPES / 2; i++)
            {
                Console.WriteLine($"Enter name of {i + 1} circle : ");
                string tempName = Console.ReadLine();

                double tempRadious = 0;
                Console.WriteLine($"Enter radious of {i + 1} circle : ");

                while (!Double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Float,
                    CultureInfo.InvariantCulture, out tempRadious))
                {
                    Console.WriteLine($"Enter correct radious of {i + 1} circle : ");
                }
                shapeList.Add(new Circule_Taranko9(tempRadious, tempName));
                Console.WriteLine("\n\n");
            }

            for (int i = 0; i < COUNTOFSHAPES / 2; i++)
            {
                Console.WriteLine($"Enter name of {i + 1} square : ");
                string tempName = Console.ReadLine();

                double tempSide = 0;
                Console.WriteLine($"Enter side of {i + 1} square : ");

                while (!Double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Float,
                    CultureInfo.InvariantCulture, out tempSide))
                {
                    Console.WriteLine($"Enter correct side of {i + 1} square : ");
                }
                shapeList.Add(new Square_Taranko9(tempSide, tempName));
                Console.WriteLine("\n\n");
            }

            string pathTask2 = "C:\\Users\\1\\source\\repos\\hw_9_Taranko_A\\hw_9_Taranko_A\\Task2.txt";
            string pathTask3 = "C:\\Users\\1\\source\\repos\\hw_9_Taranko_A\\hw_9_Taranko_A\\Task3.txt";

            Task2(shapeList, pathTask2);
            Task3(shapeList, pathTask3);
            Console.WriteLine("\n\nFigures with perimeter wich bigger than 5 :\n\n");
            for (int i = 0; i < shapeList.Count; i++) {
                if (shapeList[i].Perimeter() < 5)
                {
                    shapeList.Remove(shapeList[i]);
                }
                else {
                    Console.WriteLine(shapeList[i]);
                }
            }     

        }
        static void Task2(List<Shape_Taranko9> shapeList , string path) {
            var items = from s in shapeList
                        where s.Area() <= 100 && s.Area() >= 10
                        select s;
            try {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    foreach (var item in items)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        static void Task3(List<Shape_Taranko9> shapeList, string path)
        {
            Regex rg = new Regex(@"a");
            try {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < shapeList.Count; i++)
                    {
                        MatchCollection matches = rg.Matches(shapeList[i].Name);
                        if (matches.Count > 0)
                        {
                            sw.WriteLine(shapeList[i].ToString());
                        }
                    }
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
                       
        }
    }
}