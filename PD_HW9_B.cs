using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace homework
{
    internal class HW_B
    {
        public static void General()
        {
            string path = "lotsoftext.txt";
            var listOfLines = new List<string>();
            using (var text = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = text.ReadLine()) != null)
                    listOfLines.Add(line);
            }
            string[] arrayOfLines = listOfLines.ToArray<string>();

            foreach (string line in listOfLines)
                Console.Write(line.Length + " ");
            Console.WriteLine();

            Hw_B2(arrayOfLines);

            Hw_B3(arrayOfLines);
        }

        static void Hw_B2(string[] arrayOfLines)
        {
            int max = arrayOfLines.Max(x => x.Length);
            int min = arrayOfLines.Min(x => x.Length);
            foreach (string line in arrayOfLines.Where
                (a => a.Length == max || a.Length == min))
            {
                Console.WriteLine
                (
                    "The " +
                    (line.Length == min ? "min" : "max") +
                    "line: "
                );
                Console.WriteLine(line);
            }
        }
        
        static void Hw_B3(string[] arrayOfLines)
        {
            Regex myRegex = new Regex(@"var+");
            foreach (string line in arrayOfLines.Where(a => myRegex.IsMatch(a)))
                Console.WriteLine(line);
        }
    }
}

