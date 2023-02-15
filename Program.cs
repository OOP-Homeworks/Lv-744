
using System;
using System.Collections.Generic;
using System.IO;

namespace HomeWork_7_Kydalov
{

    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\judai\source\repos\HomeWork_7_Kydalov\HomeWork_7_Kydalov\phones.txt";
            string phoneBookPath = @"C:\Users\judai\source\repos\HomeWork_7_Kydalov\HomeWork_7_Kydalov\PhoneBook.txt";
            string newPath = @"C:\Users\judai\source\repos\HomeWork_7_Kydalov\HomeWork_7_Kydalov\New.txt";
            Dictionary<string, string> PhoneBook = new(10);
            string readString;
            try

            {
                using (StreamReader sr = new(phoneBookPath))
                {
                    while ((readString = sr.ReadLine()) != null)
                    {
                        PhoneBook.Add(readString.Split('-')[0].Trim(), readString.Split('-')[1].Trim());
                    }
                }
                using StreamWriter sw = new(path);
                foreach (var item in PhoneBook.Keys)
                {
                    sw.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            foreach (var item in PhoneBook)
            {
                Console.WriteLine($"Number {item.Key} have {item.Value}");
            }
            Console.WriteLine("Enter person name :");
            string nameToFound = Console.ReadLine();
            try
            {
                foreach (var value in PhoneBook)
                {
                    if (nameToFound == value.Value)
                    {
                        Console.WriteLine($"{value.Value} have #tel {value.Key}");
                    }
                }
                foreach (string key in PhoneBook.Keys)
                {
                    using StreamWriter writeNumber = new(newPath, true);
                    if (key.StartsWith("80"))
                    {
                        writeNumber.WriteLine($"+3{key}");
                    }
                    else
                    {
                        writeNumber.WriteLine($"{key}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
}