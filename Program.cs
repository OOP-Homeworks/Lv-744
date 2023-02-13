using System;
using System.IO;
namespace Task_7
{
    class Program
    {
        static void Task11()
        {
            string document = @"C:\Users\judai\source\repos\Task_7\Task_7\Document.txt";
            string newDocument = @"C:\Users\judai\source\repos\Task_7\Task_7\New_Document.txt";
            string documentText = "";
            try
            {
                using (StreamReader sr = new StreamReader(document, System.Text.Encoding.Default))
                {
                    documentText = sr.ReadToEnd();
                }
                using (StreamWriter str = new StreamWriter(newDocument, false, System.Text.Encoding.Default))
                {
                    str.WriteLine(documentText);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Task12()
        {
            string document = @"C:\Users\judai\source\repos\Task_7\Task_7\Document.txt";
            string newDocument = @"C:\Users\judai\source\repos\Task_7\Task_7\New_Document.txt";
            FileInfo fileInfo = new FileInfo(document);
            try
            {
                if (fileInfo.Exists)
                {
                    fileInfo.CopyTo(newDocument);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Task2()
        {
            string dirInfo = @"C:\Users\judai\source\repos\Task_7\Task_7\DirInfo.txt";
            string dir = @"C:\";
            try
            {
                if (Directory.Exists(dir))
                {
                    string[] dirs = Directory.GetDirectories(dir);
                    foreach (var item in dirs)
                    {
                        StreamWriter str = new StreamWriter(dirInfo, true, System.Text.Encoding.Default);
                        str.WriteLine(item);
                        str.Close();
                    }
                    string[] files = Directory.GetFiles(dir);
                    foreach (var item in files)
                    {
                        StreamWriter file = new StreamWriter(dirInfo, true, System.Text.Encoding.Default);
                        file.WriteLine(item);
                        file.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Task3()
        {
            string dir = @"C:\";
            string[] filesTXT = Directory.GetFiles(dir, "*.txt", SearchOption.AllDirectories);
            foreach (var file in filesTXT)
            {
                using (StreamReader streamReader = new StreamReader(file, System.Text.Encoding.Default))
                {
                    string fileLine;
                    while ((fileLine = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(fileLine);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Task11();
            //Task12();
            //Task2();
            Task3();
        }
    }
}
