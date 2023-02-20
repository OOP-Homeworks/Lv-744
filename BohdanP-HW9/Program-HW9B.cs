namespace HW9_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = @"C:\Users\B\source\repos\HW9-B\textfile.cs";
            string[] stringsArr = File.ReadAllLines(textFilePath);

            int[] symbolsInLines = new int[stringsArr.Length];
            for (int i = 0; i<stringsArr.Length; i++)
            {
                symbolsInLines[i] = stringsArr[i].Count();
            }
            Console.WriteLine("Longest line {0}, shortest line {1}", Array.IndexOf(symbolsInLines, symbolsInLines.Max()), Array.IndexOf(symbolsInLines, symbolsInLines.Min()));

            string[] selecedStrs = stringsArr.Where(s => s.Contains("var")).ToArray();
            foreach (string str in selecedStrs)
            {
                Console.WriteLine(str);
            }
        }
    }
}