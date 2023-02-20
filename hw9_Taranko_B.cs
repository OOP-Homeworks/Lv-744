using System.Text;
using System.Text.RegularExpressions;

namespace hw_9_Taranko_B
{
    internal class hw9_Taranko_B
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\1\\source\\repos\\hw_9_Taranko_B\\hw_9_Taranko_B\\TEST.txt";
            string[] text = default;
            try
            {
                text = File.ReadAllLines(path, System.Text.Encoding.Default);
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }

            for (int i = 0; i < text.Length; i++) {
                Console.WriteLine($"Line {i + 1} Symbols : {text[i].Length}");
            }
            Console.WriteLine($"Longest : {text.OrderByDescending(l => l.Length).First()} \n\nShortest : {text.OrderBy(l => l.Length).First()}");
            Console.WriteLine("\n\nLines wich include word var :\n\n");
            Regex rg = new Regex(@"var");
            for (int i = 0; i < text.Length; i++) { 
                MatchCollection matches = rg.Matches(text[i]);
                if (matches.Count > 0) {
                    Console.WriteLine(text[i]);
                }
            }
        }
    }
}