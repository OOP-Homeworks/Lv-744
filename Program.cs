using System;

namespace HW_4_2023
{
    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person[6];
            for (int i = 0; i < person.Length; i++)
            {
                person[i] = Person.Input();
            }

            for (int i = 0; i < person.Length; i++)
            {
                if (person[i].Age() < 16)
                {
                    person[i].ChangeName("Very young");
                    Console.WriteLine("\nAfter change : ");
                    person[i].Output();
                }

            }
            for (int i = 0; i < person.Length; i++)
            {
                for (int x = i + 1; x < person.Length; x++)
                {
                    if (person[i] == person[x])
                    {

                        Console.WriteLine($"person{i+1} == person {x+1}");
                    }
                }
            }
        }
    }
}
