using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;

namespace homework
{
    internal class HW7
    {
        static void Main(string[] args)
        {
            const int NUMBER_OF_DIGITS = 3;
            var phoneBook = new Dictionary<string, string>();
            string path = "D:\\programming\\phones.txt";

            using (var filePhone = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                int counter = 1;
                while ((line = filePhone.ReadLine()) != null)
                {
                    string[] parts = line.Split(" ");
                    if (parts[1].Length < NUMBER_OF_DIGITS)
                        throw new Exception($"Check the phone on {counter} line");
                    phoneBook.Add(parts[0], parts[1]);
                    counter++;
                }

            }
            string recordTo = "D:\\programming\\Nphones.txt";

            Hw1(phoneBook, recordTo);
            Hw2(phoneBook);

            recordTo = "D:\\programming\\New.txt";
            Hw3(phoneBook, recordTo);
        }
        static void Hw1(Dictionary<string, string> phoneBook, string writePath)
        {
            using (var file = new StreamWriter(writePath, false))
            {
                foreach (string phone in phoneBook.Values)
                    file.WriteLine(phone);
            }
        }
        static void Hw2(Dictionary<string, string> phoneBook)
        {
            Console.Write("Enter the name: ");
            string nameToFind = Console.ReadLine();
            if(phoneBook.TryGetValue(nameToFind, out string name))
                Console.WriteLine(name);
            else
            {
                Console.WriteLine("This name is abcent in phone book");
            }
        }
        static void Hw3(Dictionary<string, string> phoneBook, string path)
        {
            using(var file = new StreamWriter(path, false))
            {
                foreach (KeyValuePair<string, string> entry in phoneBook)
                {
                    file.Write(entry.Key + " ");
                    string valueNew;
                    if (entry.Value[0] == '8' && entry.Value[1] == '0') 
                        valueNew = "+3" + entry.Value; 
                    else valueNew = entry.Value;
                    file.WriteLine(valueNew);
                }
            }
        }
    }
}

