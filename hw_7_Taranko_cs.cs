using static System.Net.Mime.MediaTypeNames;

namespace hw_7_Taranko
{
    internal class Program
    {
        static void Main()
        {
            const int COUNTOFPERSONSINBOOK = 9;
            string readFromPath = "C:\\Users\\1\\Desktop\\hw_7_Files\\phones.txt";
            string writeToPath = "C:\\Users\\1\\Desktop\\hw_7_Files\\Phones2.txt";
            string writeNewToPath = "C:\\Users\\1\\Desktop\\hw_7_Files\\New.txt";
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            try {
                using (StreamReader sr = new StreamReader(readFromPath, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < COUNTOFPERSONSINBOOK; i++)
                    {
                        string[] lines = sr.ReadLine().Split(",");
                        if (lines.Length != 2)
                        {
                            Console.WriteLine($"Invalid data in you file : {readFromPath}");
                            return;
                        }
                        else if (lines[0].Length != 13 && lines[0][0] == '+') {
                            Console.WriteLine($"Invalid data in you file : {readFromPath} , in Line { i + 1}");
                            return;
                        }
                        else if (lines[0].Length != 12 && lines[0][0] != '+')
                        {
                            Console.WriteLine($"Invalid data in you file : {readFromPath} , in Line {i + 1}");
                            return;
                        }
                        if (!PhoneBook.TryAdd(lines[0], lines[1]))
                        {
                            PhoneBook.Add(i.ToString(), lines[1]);
                        }
                    }
                }
                using (StreamWriter sw = new StreamWriter(writeToPath, false, System.Text.Encoding.Default))
                {
                    foreach (var key in PhoneBook)
                    {
                        sw.WriteLine(key.Key);
                    }
                }

                Console.WriteLine("Enter name : ");
                string name = Console.ReadLine();
                foreach (var Pers in PhoneBook)
                {
                    if (Pers.Value == name)
                    {
                        Console.WriteLine($"Number : {Pers.Key}");
                    }
                }

                using (StreamWriter sw = new StreamWriter(writeNewToPath, false, System.Text.Encoding.Default))
                {
                    foreach (var key in PhoneBook)
                    {
                        if (key.Key[0] == '+')
                        {
                            sw.WriteLine(key.Key);
                        }
                        else
                        {
                            sw.WriteLine("+" + key.Key);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}