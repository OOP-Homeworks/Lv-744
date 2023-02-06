using System;

namespace homework
{
    internal class HW4
    {
        static void Main(string[] args)
        {
            Hw1();
            Hw2();
        }

        static void Hw1()
        {
            //interface - line 57, class Programmer - line 67, Builder - line 88
            var workers = new List<IDeveloper>();
            workers.Add(new Programmer("Java"));
            workers.Add(new Builder("hummer"));
            workers.Add(new Programmer("C#"));
            workers.Add(new Builder("screwdriver"));
            workers.Sort();
            for(int i = 0; i < workers.Count; i++)
            {
                workers[i].Create();
                workers[i].Destroy();
                Console.WriteLine();
            }
            foreach (var worker in workers) Console.WriteLine(worker.Tool); 
        }

        static void Hw2()
        {
            const int Size = 7;
            var idPerson = new Dictionary<uint, string>();
            uint enteredId;
            for (int i = 0; i < Size; i++)
            {
                while(true)
                {
                    enteredId = Convert.ToUInt32(Console.ReadLine());
                    if (idPerson.ContainsKey(enteredId))
                        Console.WriteLine("This ID belongs to another person");
                    else break;
                }
                idPerson.Add(enteredId, Console.ReadLine());
            }
            Console.Write("Enter ID to check the name: ");
            enteredId = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(idPerson.ContainsKey(enteredId)? 
                                    idPerson[enteredId] : 
                                    "This ID is abscent in dictionary"
            );
        }

    }

    interface IDeveloper : IComparable<IDeveloper>
    {
        public string Tool{ get;}
        public void Create(){}
        public void Destroy(){}
        public int CompareTo(IDeveloper other)
        {
            return string.Compare(Tool, other.Tool);
        }
    }
    class Programmer : IDeveloper
    {
        string language;
        public string Tool { get { return language; }}
        public Programmer(string language) 
        {
            this.language = language;
        }
        public void Create() 
        { 
            Console.WriteLine($"I am writing code on {language}"); 
        }
        public void Destroy()
        {
            Console.WriteLine("I have deleted files");
        }
        public int CompareTo(IDeveloper other)
        {
            return string.Compare(Tool, other.Tool);
        }
    }
    class Builder : IDeveloper
    {
        string tool;
        public string Tool { get { return tool;} }
        public Builder(string tool)
        {
            this.tool = tool;
        }
        public void Create()
        {
            Console.WriteLine($"I build using {tool}");
        }
        public void Destroy()
        {
            Console.WriteLine("I have destroyed house");
        }
        public int CompareTo(IDeveloper other)
        {
            return string.Compare(Tool, other.Tool);
        }
    }
}

