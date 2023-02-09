using System;
using System.IO;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();

            try
            {
                string testdev = @"D:\phones\phones.txt";
                
                string[] lines = File.ReadAllLines(testdev);
                foreach (string line in lines)
                {
                    string[] text = line.Split(' ');
                    PhoneBook.Add(text[0], text[1]);
                }

                
                List<string> phoneNumbers = new List<string>(PhoneBook.Values);
                File.WriteAllLines("phones.txt", phoneNumbers);

                
                Console.WriteLine("Enter the person name: ");
                string name = Console.ReadLine();
                if (PhoneBook.ContainsKey(name))
                {
                    Console.WriteLine("The phone number is: " + PhoneBook[name]);
                }
                else
                {
                    Console.WriteLine("Person not found.");
                }

                
                List<string> newPhoneNumbers = new List<string>();
                foreach (string phoneNumber in phoneNumbers)
                {
                    if (phoneNumber.StartsWith("80"))
                    {
                        string newPhoneNumber = "+380" + phoneNumber.Substring(2);
                        newPhoneNumbers.Add(newPhoneNumber);
                    }
                    else
                    {
                        newPhoneNumbers.Add(phoneNumber);
                    }
                }

                
                File.WriteAllLines("new.txt", newPhoneNumbers);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
