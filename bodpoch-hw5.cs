using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HW5
{
    internal class HW5
    {
        static void Main(string[] args)
        {
            //Task 1
            List<IDeveloper> dev_list = new List<IDeveloper>()
            {new Programmer("C#"), new Programmer("C"), new Programmer("Assembly"), new Builder("Shovel"), new Builder ("3d printer"),
            new Builder ("Concrete mixer")};
            for (int i = 0; i < dev_list.Count; i++)
            {
                dev_list[i].Create();
                dev_list[i].Destroy();
            }
            dev_list.Sort();

            //Task 2
            Dictionary<uint,string> idDictionary = new Dictionary<uint, string>();
            const int DICT_PAIRS = 7;
            Console.WriteLine("Fill in IDs and NAMEs");
            for (int i = 0; i < DICT_PAIRS; i++)
            {
                idDictionary.Add(uint.Parse(Console.ReadLine()), Console.ReadLine().ToUpper());
            }
            Console.WriteLine("Input ID you wanna check: ");
            uint input_ID = uint.Parse(Console.ReadLine());
            if (idDictionary.ContainsKey(input_ID))
                Console.WriteLine(idDictionary[input_ID]);
            else
                Console.WriteLine("Person with this ID has not been found");
        }
    }

    interface IDeveloper
    {
        public string Tool { get; set; }
        public void Create() { }
        public void Destroy() { }
    }
    class Programmer : IDeveloper, IComparable
    {
        string language;
        public string Tool { 
            get { return language; } 
            set { language = value; } }
        public Programmer(string lang)
        {
            language = lang;
        }
        public void Create()
        {
            Console.WriteLine("Created a thing with {0} lang", language);
        }
        public void Destroy()
        {
            Console.WriteLine("Destroyed a thing with {0} lang", language);
        }
        public int CompareTo(object? obj)
        {
            return string.Compare(Tool.ToString(), obj.ToString());
        }
    }
    class Builder : IDeveloper, IComparable
    {
        string tool;
        public string Tool { 
            get { return tool; } 
            set { tool = value; } }
        public Builder(string tool)
        {
            this.tool = tool;
        }
        public void Create()
        {
            Console.WriteLine("Created a thing with " + tool);
        }
        public void Destroy()
        {
            Console.WriteLine("Destroyed a thing with " + tool);
        }
        public int CompareTo(object? obj)
        {
            return string.Compare(Tool.ToString(), obj.ToString());
        }
    }
}