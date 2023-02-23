using System;
using System.IO;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*B) Create Console Application project.
               Prepare txt file with a lot of text inside (for example take you .cs file from previos homework)
               Read all lines of text from file into array of strings.
               Each array item contains one line from file.
            */

            string filePath = @"C:\Users\fedor\source\repos\18.02.2023_HomeWork_9\file.txt";
            string[] lines = File.ReadAllLines(filePath);

            // 1) Count and write the number of symbols in every line.
            foreach (string line in lines)
            {
                Console.WriteLine($"Line {Array.IndexOf(lines, line) + 1} contains {line.Length} symbols.");
            }

            // 2) Find the longest and the shortest line.
            string longestLine = lines.OrderByDescending(l => l.Length).First();
            string shortestLine = lines.OrderBy(l => l.Length).First();

            Console.WriteLine($"\nThe longest line is:\n {longestLine}");
            Console.WriteLine($"\nThe shortest line is:\n {shortestLine}");

            // 3) Find and write only lines, which consist of word "var".
            var varLines = lines.Where(line => line.Contains("shape"));

            Console.WriteLine($"\nLines containing the word 'shape':\n");
            foreach (string line in varLines)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}

