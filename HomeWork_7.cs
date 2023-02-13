using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _20230211HomeWork_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* In Main() method declare Dictionary PhoneBook for keeping pairs PersonName-PhoneNumber. 
                1) From file "phones.txt" read 9 pairs into PhoneBook. Write only PhoneNumbers into file "Phones.txt". */

            string path = @"C:\Users\fedor\source\repos\20230211HomeWork_7\";
            string text = string.Empty;
            bool ok = false;

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            try
            {
                using (StreamReader sw = new StreamReader(path + "PhoneBook.txt"))
                {
                    while ((text = sw.ReadLine()) != null)
                    {
                        string[] s = text.Split(',');
                        phoneBook.Add(s[0], s[1].ToUpper());
                    }
                }

                using (StreamWriter sw = new StreamWriter(path + "newPhoneBook.txt", false, System.Text.Encoding.Default))
                {
                    foreach (KeyValuePair<string, string> sd in phoneBook)
                    {
                        sw.WriteLine(sd.Key);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // 2) Find and print phone number by the given name (name input from console)

            while (!ok)
            {
                try
                {
                    Console.Write("Enter Name: ");
                    text = Console.ReadLine().ToUpper();
                    Console.Clear();

                    foreach (KeyValuePair<string, string> st in phoneBook)
                    {
                        if (st.Value.ToString() == text)
                        {
                            Console.WriteLine("{0}, {1}", st.Key, st.Value);
                            ok = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // 3) Change all phone numbers, which are in format 80######### into new format +380#########. The result write into file «New.txt» 

            try
            {
                using (StreamWriter sw = new StreamWriter(path + "Newformat.txt", false, System.Text.Encoding.Default))
                {
                    foreach (KeyValuePair<string, string> sx in phoneBook)
                    {
                        if (sx.Key.ToString().Length == 10)
                        {
                            sw.WriteLine("{0}, {1}", "+38" + sx.Key, sx.Value);
                        }
                        else if (sx.Key.ToString().Length == 11)
                        {
                            sw.WriteLine("{0}, {1}", "+3" + sx.Key, sx.Value);
                        }
                        else
                        {
                            sw.WriteLine("{0}, {1}", "+" + sx.Key, sx.Value);
                        }
                    }
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
