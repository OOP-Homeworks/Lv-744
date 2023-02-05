using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Homework5_SavchenkoOleks_LV744
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            //Homework1();
            Homework2();
        }
        static void Homework1()
        {
            var listOfDevelopers = new List<IDeveloper>();
            listOfDevelopers.Add(new Programmer("C++"));
            listOfDevelopers.Add(new Programmer("C#"));
            listOfDevelopers.Add(new Programmer("C"));
            listOfDevelopers.Add(new Worker("Hammer"));
            listOfDevelopers.Add(new Worker("Drill"));
            listOfDevelopers.Add(new Worker("Screwdriver"));
            foreach (var person in listOfDevelopers)
            {
                person.Create();
                person.Destroy();
                Console.WriteLine();
            }
            listOfDevelopers.Sort();
            foreach (var person in listOfDevelopers)
            {
                Console.WriteLine($"{person.Tool}");
            }

        }
        static void Homework2()
        {
            const int numberOfPeople = 7;
            int i = 0;
            var listOfPeople = new Dictionary<uint, string>();
            while(i < numberOfPeople)
            {
                Console.WriteLine($"Enter name of the person #{i + 1}");
                string name = Console.ReadLine();
                Console.WriteLine("Enter id of this person: ");
                uint idOfThePerson = uint.Parse(Console.ReadLine());
                if (listOfPeople.ContainsKey(idOfThePerson))
                {
                    Console.WriteLine("This id is already occupied");
                }
                else { listOfPeople.Add(idOfThePerson, name); i++; }
                
            }
            Console.WriteLine();
            Console.WriteLine("Enter id of the person whose name you want to know: ");
            uint personId = uint.Parse(Console.ReadLine());
            if (listOfPeople.ContainsKey(personId))
            {
                Console.WriteLine($"Person's name is {listOfPeople.GetValueOrDefault(personId)}");
            }
            else Console.WriteLine("There is no such index in the dictionary!");
        }
    }
    interface IDeveloper : IComparable<IDeveloper>
    {
        public string Tool { get; }
        void Create();
        void Destroy();
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return string.Compare(other.Tool, Tool);
        }

    }
    public class Programmer : IDeveloper
    {
        private string language;
        public string Tool { get { return language; } }
        public Programmer(string language)
        {
            this.language = language;
        }
        public void Create()
        {
            Console.WriteLine("New programmer is created!");
        }
        public void Destroy()
        {
            Console.WriteLine("One programmer is out!");
        }
    }
    public class Worker : IDeveloper
    {
        private string tool;
        public string Tool { get { return tool; } }
        public Worker(string tool)
        {
            this.tool = tool;
        }
        public void Create()
        {
            Console.WriteLine("One worker is created!");
        }
        public void Destroy()
        {
            Console.WriteLine("One worker is out!");
        }
    }
}