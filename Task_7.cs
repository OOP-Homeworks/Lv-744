using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Read and write all data from data.txt into rez.txt files, by using (Catch appropriative exceptions):
                StreamReader StreamWriter
                File.WriteAllText */

            string path = @"C:\Users\fedor\source\repos\20230211HomeWork_7\";
            string text = string.Empty;

            try
            {
                using (StreamReader sw = new StreamReader(path + "data.txt", System.Text.Encoding.Default))
                {
                    text = sw.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(path + "rez.txt", false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Write into file ‘DirectoryC.txt’ information (e.g. name, type, size) about all directories and files from disc D on your computer. Catch appropriative exceptions.

            try
            {
                string[] files = Directory.GetFiles(path, ".", SearchOption.AllDirectories);

                FileInfo te = new FileInfo(path + "dirC.txt");

                if (te.Exists)
                {
                    te.Delete();
                }

                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    
                    using (StreamWriter sw = new StreamWriter(path + "dirC.txt", true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("Name: {0}", fileInfo.Name);
                        sw.WriteLine("Date: {0}", fileInfo.CreationTime);
                        sw.WriteLine("Size: {0}\n", fileInfo.Length);
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Select from directory D only .txt files and print the text from it into console. Catch appropriative exceptions.

            int found = 0;

            try
            {
                string[] files = Directory.GetFiles(path, ".", SearchOption.AllDirectories);

                FileInfo te = new FileInfo(path + "newFile.txt");

                if (te.Exists)
                {
                    te.Delete();
                }

                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file); 

                    using (StreamWriter sw = new StreamWriter(path + "newFile.txt", true, System.Text.Encoding.Default))
                    {
                        found = fileInfo.Name.IndexOf(".");
                        text = fileInfo.Name.Substring(found + 1);

                        if (text == "txt")
                        {
                            using (StreamReader sf = new StreamReader(file, System.Text.Encoding.Default))
                            {
                                text = sf.ReadToEnd();
                            }
                            sw.WriteLine("Name: {0}", fileInfo.Name);
                            sw.WriteLine("Date: {0}", fileInfo.CreationTime);
                            sw.WriteLine("Size: {0}\n", fileInfo.Length);
                            sw.WriteLine("{0}\n", text);
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Try how it works

            try
            {
                using (StreamReader sw = new StreamReader(path + "data.txt", System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sw.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.ReadLine();

            try
            {
                using (StreamReader sw = new StreamReader(path + "data.txt", System.Text.Encoding.Default))
                {
                    char[] array = new char[15];
                    sw.Read(array, 0, array.Length);
                    Console.WriteLine(array);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
