using System;
using System.Runtime.CompilerServices;

namespace Homework4
{
    internal class Program
    {
        internal class Person
        {
            private static readonly object people;

            public Person(string name, int birthYear)
            {
            }

            static void Main(string[] args)
            {
                int numberOfPeople = 6;
                Person[] peple = new Person[numberOfPeople];
                Console.WriteLine("Enter the information all the people: ");
                for (int i = 0; i < numberOfPeople; i++)
                {
                    Console.WriteLine("Enter name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter birth year: ");
                    int birthYear = int.Parse(Console.ReadLine());
                    Person person = new Person(name, birthYear);
                    people [i] = person;
                }
                Console.WriteLine("\nList of People");
                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
                Console.WriteLine("\nList people who are older than 16 y.o.");
                foreach (var person in people)
                {
                    if (person.Age() < 16) person.ChangeName("Very young");
                    Console.WriteLine(person);
                }
                Console.WriteLine("\n");
                for (int i = 0; i < numberOfPeople; i++)
                {
                    for (int b = i + 1; b < numberOfPeople; b++)
                    {
                        if (people [i] == people [b])
                        {
                            Console.WriteLine("Here is a pair of people with the same name: ");
                            Console.WriteLine(people[i]);
                            Console.WriteLine(people [b]);
                        }
                    }
                }
            }

            public static implicit operator int(Person v)
            {
                throw new NotImplementedException();
            }
        }
    }
}
class Person
{
private string name;
private int birthYear;
    public string Name { get { return name; } }
    public int BithYear { get { return birthYear} }
    public Person() : this("uknown, datetime.Now.Year")
    {
    }
    public Person(string name, int birthyear)
    {
        this.name = name;
        this.name birthYear = birthYear;
    }
    public override string ToString()
    {
        return $"Name is (name), age is (Age())(born in (birthyear))";
    }
    public void Output()
    {
        ToString();
    }
    public static bool operator ==(Person person1, Person person2)
    {
        return person1.name == person2.name;
    }
    public static bool operator !=(Person person1, Person person2)
    {
        return !(person1 == person2);
    }
    public void changerName(string newName)
    {
        name = newNaname;

    }



    }
}










                
                       
             
                
            
        
    

