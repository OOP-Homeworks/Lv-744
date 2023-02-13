using _20230202_HomeWork_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230202_HomeWork_5
{
    /*  1. Create interface IDeveloper with property Tool, methods Create() and Destroy()
       
        2. Create two classes Programmer (with field language) and 
           Builder (with field tool), which implement this interface.

        3. Create array or list of IDeveloper.
            Add some Programmers and Builders to it. 
            Call Create() and Destroy() methods for all of it

        4. Implement interface IComparable for clases and sort array or list of IDeveloper 

        5. Create Console Application project in VS. 
             In the Main() method declare Dictionary<uint,string>. 

        6. Add to Dictionary from Console 7 pairs (ID, Name) of some persons. 

        7. Ask user to enter ID, then find and write corresponding Name from your Dictionary. 
            If you can't find this ID - say about it to user. */

    interface IDeveloper
    {
        string Tool { get; }
        void Create();
        void Destroy();
    }

    class Programmer : IDeveloper
    {
        private string language;

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

            Console.WriteLine("Created languge {0}", this.language);

        }

        public void Destroy()
        {
            language = language.Remove(0);
        }
    }

    class Builder : IDeveloper, IComparable<Builder>
    {
        private string tool;
        public void Create()
        {
            Console.WriteLine("Created tool {0}", this.tool);
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

    internal class Program
    {
        static void Main(string[] args)
        {
        Programmer person1 = new Programmer("C#");
        Programmer person2 = new Programmer("JS");

        Builder builder1 = new Builder("VS");
        Builder builder2 = new Builder("VSCode");

        List<IDeveloper> list = new List<IDeveloper>();
        list.Add(person1);
        list.Add(person2);
        list.Add(builder1);
        list.Add(builder2);
        list[0].Create();
        list[1].Create();
        list[2].Create();
        list[3].Create();

        Console.WriteLine();
        Console.ReadLine();
        Console.Clear();


        Dictionary<uint, string> dictionary = new Dictionary<uint, string>();
        Console.Write("Enter the number of people: ");
        int people = int.Parse(Console.ReadLine());
        uint id = 0;
        string Name = string.Empty;
        int ok = 0;

        while (ok != people)
            {
                Console.Write("Enter your ID: ");
                id = uint.Parse(Console.ReadLine());
            
                Console.Write("Enter your name: ");
                Name = Console.ReadLine();
                
                dictionary.Add(id, Name);
                ok++;
                Console.Clear();
           }

        Console.WriteLine("{0} your ID {1}", Name.CompareTo(Name), id.CompareTo(id));
        Console.WriteLine("{0} your ID {1}", Name.ToString(), id.ToString());
        Console.ReadLine();
        Console.Clear();

    }
}

