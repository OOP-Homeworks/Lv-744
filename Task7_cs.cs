using System.Runtime.Intrinsics.X86;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string readPath1 = "C:\\Users\\1\\Desktop\\Task7_Files\\data.txt";
            string writePath1 = "C:\\Users\\1\\Desktop\\Task7_Files\\rez.txt";
            task11(readPath1, writePath1);


            string writePath2 = "C:\\Users\\1\\Desktop\\Task7_Files\\DirectoyC.txt";
            task2(writePath2);

            string readPath3 = "C:\\Users\\1\\Desktop\\Task7_Files";
            task3(readPath3);
            Console.ReadLine();
        }

        static void task11(string readPath , string writePath)
        {
            string text = "";
            try {

                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default)) {
                    text = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default)) {
                    sw.Write(text);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine ("\n\n{0}\n\n",ex.Message);
            }
        }
        static void task12(string readPath, string writePath)
        {
            string text = "";
            try
            {
                text = File.ReadAllText(readPath, System.Text.Encoding.Default);
                File.WriteAllText(writePath, text , System.Text.Encoding.Default);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\n{0}\n\n", ex.Message);
            }
        }

        static void task2(string writePath)
        {
            string diskName = "C:\\";
            try {
                using (StreamWriter sw = new StreamWriter(writePath,false,System.Text.Encoding.Default))
                {
                    if (Directory.Exists(diskName))
                    {
                        
                        string[] dirs = Directory.GetDirectories(diskName);
                        string[] files = Directory.GetFiles(diskName);
                        sw.WriteLine("\n\nDirs:\n\n");
                        foreach (string dir in dirs)
                        {
                            DirectoryInfo di = new DirectoryInfo(dir);
                            sw.WriteLine($"Name : {di.Name}\nType : {di.GetType}\nCreation Time : {di.CreationTime}\n");

                        }
                        sw.WriteLine("\n\nFiles:\n\n");
                        foreach (string file in files)
                        {
                            FileInfo fi = new FileInfo(file);
                            sw.WriteLine($"Name : {fi.Name}\nType : {fi.GetType}\nSize : {fi.Length} bytes\n");

                        }
                    }
                }
                    
            }
            catch(Exception ex) {
                Console.WriteLine("\n\n{0}\n\n", ex.Message);
            }
        }
        static void task3(string readPath)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(readPath);
                FileInfo[] textFiles = di.GetFiles("*.txt");
                foreach (FileInfo file in textFiles)
                {
                    using (StreamReader sr = new StreamReader(file.FullName, System.Text.Encoding.Default))
                    {
                        string line = "";
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine($"{line}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\n{0}\n\n", ex.Message);
            }

        }
    }
}