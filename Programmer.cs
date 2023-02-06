using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace _1w
{
    interface IDeveloper
    {
        public string Tool
        {
            get;
        }
        public void Create();
        public void Destroy();


    }
    class Programmer : IDeveloper
    {
        string language;

        public string Tool
        {
            get;
        }
        public Programmer(string language)
        {
            this.language = language;
        }

        public void Create()
        {
            
                Console.WriteLine($"{this.language} created");
           
        }
        public void Destroy()
        {
            language = language.Remove(0);
        }
        


        


    }
    class Builder : IDeveloper, IComparable<Builder>
    {
        string tool;
        public void Create()
        {
            Console.WriteLine($"{this.tool} created");
        }
        public void Destroy()
        {
            tool = tool.Remove(0);
        }
        public string Tool
        {
            get; set;
        }

        public Builder(string tool)
        {
            this.tool = tool;
        }

        public int CompareTo(Builder build)
        {
            if (build.Tool == this.tool)
            {
                return 1;
            }
            else if (build.Tool != this.Tool)
            {
                return 0;
            }
            return -1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer dev = new Programmer("en");
            Programmer dev1 = new Programmer("rus");

            Builder build = new Builder("vs");
            Builder build1 = new Builder("vs code");

            List<IDeveloper> list = new List<IDeveloper>();
            list.Add(dev);
            list.Add(dev1);
            list.Add(build);
            list.Add(build1);
            list[0].Create();
            list[1].Create();
            list[2].Create();
            list[3].Create();





            //task 2
            Dictionary<uint, string> dictionary = new Dictionary<uint, string>();
            Console.Write("Enter pair: ");
            int pairs = int.Parse(Console.ReadLine());
            uint id = 0;
            string Name = "";
            for (int i = 0; i < pairs; i++)
            {
                Console.Write("Enter your ID: ");
                id = uint.Parse(Console.ReadLine());
                Console.Write("Enter your name: ");
                Name = Console.ReadLine();
                dictionary.Add(id, Name);
            }

            Console.Write("Enter your ID: ");
            uint ID = uint.Parse(Console.ReadLine());
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine(id.CompareTo(ID));
            Console.WriteLine(name.CompareTo(Name));








        }
        class Dictionary : IComparable<Dictionary>
        {
            public uint ID;
            public string Name;

            public Dictionary(uint ID, string name)
            {
                this.ID = ID;
                this.Name = name;
            }
            public int CompareTo(Dictionary dictionary)
            {
                if (dictionary.ID == this.ID)
                {
                    return 1;
                }
                else if (dictionary.ID != this.ID)
                {
                    return 0;
                }
                if (dictionary.Name == this.Name)
                {
                    return 1;
                }
                else if (dictionary.Name != this.Name)
                {
                    return 0;
                }
                return -1;


            }
        }
    }
}
