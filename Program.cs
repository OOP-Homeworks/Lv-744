using System;
using System.Collections.Generic;

namespace HW_5_D
{
    class Program
    {
        static void Main(string[] args)
        {
            uint input;
            Dictionary<uint, string> people = new Dictionary<uint, string>();
            people.Add(11, "Nancy");
            people.Add(6, "Dino");
            people.Add(3, "Kola");
            people.Add(1, "Krab");
            people.Add(0, "Name");
            people.Add(2, "Mistery");
            people.Add(5, "Petr");
            Console.Write("Enter user ID to find : ");
            input = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine((people.ContainsKey(input) ? $"Key was found : \n{input} - {people[input]}" :
                $"Key {input} wasn't found "));
        }
    }
}
