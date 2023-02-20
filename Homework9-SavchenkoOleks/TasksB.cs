using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_SavchenkoOleks_LV744
{
    internal class TasksB
    {
        public static void TaskB()
        {
            string[] arrayOfLines = Task1();
            Task2(arrayOfLines);
            Task3(arrayOfLines);
            Task4(arrayOfLines);
        }

        private static string[] Task1()
        {
            List<string> listOfLines = new List<string>();
            const string path = @"C:\Users\oleks\source\repos\Homework9-SavchenkoOleks-LV744\LongText.txt";
            string line;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null) 
                { 
                    listOfLines.Add(line); 
                }
            }

            string[] arrayOfLines = listOfLines.ToArray();
            return arrayOfLines;
        }

        private static void Task2(string[] arrayOfLines)
        {
            foreach(string line in arrayOfLines)
            {
                Console.Write($"{line.Length} ");
            }
            Console.WriteLine();
        }

        private static void Task3(string[] arrayOfLines)
        {
            Console.WriteLine();
            Console.WriteLine("Max length is {0}", arrayOfLines.Max(o => o.Length));
            Console.WriteLine("Min length is {0}", arrayOfLines.Min(o => o.Length));
        }

        private static void Task4(string[] arrayOfLines)
        {
            Console.WriteLine();
            Console.WriteLine("Lines with word \"var\"");
            foreach (string line in arrayOfLines.Where(o => o.Contains("var")))
            {
                Console.WriteLine(line.Trim());
            }
        }

    }
} 
