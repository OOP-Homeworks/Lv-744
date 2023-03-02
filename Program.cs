using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lecture7_744
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /// Task 7
            ///
            Task7();

            /// Homework 7
            ///

            var phoneBook = new Dictionary<string, string>();
            string pathFrom = "C:\\SoftServe_Lectures\\MyPhones.txt";
            string pathTo_OnlyNumbers = "C:\\SoftServe_Lectures\\Nphones.txt";
            string pathTo_NewFormat = "C:\\SoftServe_Lectures\\New.txt";
            Homework7(phoneBook, pathFrom, pathTo_OnlyNumbers, pathTo_NewFormat);

            Console.ReadKey();

        }

        static void Task7()
        {

            string pathFrom = "D:\\";

            if(Directory.Exists(pathFrom)) 
            {

                ///2
                ///

                string pathTo = "D:\\DirectoryC.txt";
                using (StreamWriter writer = new StreamWriter(pathTo))
                {

                    string[] directories = Directory.GetDirectories(pathFrom);
                    foreach (string directory in directories)
                    {
                        Console.WriteLine(directory);
                        writer.WriteLine(directory);
                        
                        DirectoryInfo infoDir = new DirectoryInfo(directory);
                        writer.WriteLine("   -> " + infoDir.Name);
                        writer.WriteLine("   -> " + infoDir.GetType());

                        try
                        {
                            string[] filesFromDirectory = Directory.GetFiles(directory);
                            foreach (string file in filesFromDirectory)
                            {
                                Console.WriteLine(file);
                                writer.WriteLine(file);

                                FileInfo infoFile = new FileInfo(file);
                                writer.WriteLine("   -> " + infoFile.Name);
                                writer.WriteLine("   -> " + infoFile.GetType());
                                writer.WriteLine("   -> " + infoFile.Length);

                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error in dir = " + ex.Message);
                        }

                    }

                }

                /// 3
                /// 
                string[] files = Directory.GetFiles(pathFrom,"*.txt");
                foreach(string file in files) 
                {
                    Console.WriteLine(file);
                }
            }
        }

        static void Homework7(Dictionary<string, string>  phoneBook, string pathFrom, string pathTo_OnlyNumbers, string pathTo_NewFormat)
        {
            using (var filePhone = new StreamReader(pathFrom, System.Text.Encoding.Default))
            {

                string line;
                int i = 1;
                while ((line = filePhone.ReadLine()) != null)
                {
                    string[] parts = line.Split(" ");
                    phoneBook.Add(parts[0], parts[1]);
                    i++;
                }

            }

            Console.Write("Enter name to get number = ");
            string name = Console.ReadLine();
            if (name != string.Empty)
            {
                string findNumber;
                phoneBook.TryGetValue(name, out findNumber);
                if (findNumber != null)
                {
                    Console.WriteLine($"{name} = {findNumber}");
                }
                else
                {
                    Console.WriteLine("Number is not found :(");
                }
            }

            using(var file = new StreamWriter(pathTo_OnlyNumbers, false))
            {
                foreach (string phone in phoneBook.Values)
                    file.WriteLine(phone);
            }
            Console.WriteLine($"File {pathTo_OnlyNumbers} save!");

            Regex regex = new Regex(@"^80[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]");
            foreach (var phone in phoneBook.Values) 
            {
                if (regex.IsMatch(phone))
                {
                    var myKey = phoneBook.FirstOrDefault(x => x.Value == phone).Key;
                    phoneBook[myKey] = "+3" + phone;
                }
            }

            using (var file = new StreamWriter(pathTo_NewFormat, false))
            {
                foreach (var dictionary in phoneBook)
                    file.WriteLine(dictionary.Key + " = " + dictionary.Value);
            }
            Console.WriteLine($"File {pathTo_NewFormat} save!");

        }

    }
}