namespace hw_5_Taranko
{
    interface IDeveloper {
        string Tool { get; set; }
        void Create(string instrument);
        void Destroy();
    }
    class Programer : IDeveloper , IComparable
    {
        string language;
        public Programer(string language) { 
            this.language = language;
        }
        ~Programer() {
            Console.WriteLine("1");
        }
        public string Tool
        {
            get { return language; }
            set { language = value; }
        }
        public void Create(string language)
        {
            this.language = language;
        }
        public void Destroy() {
            this.language = null;
        }
        public override string ToString()
        {
            return language;
        }
        public int CompareTo(object obj)
        {
            return String.Compare(this.language, obj.ToString());

        }
    }
    class Builder : IDeveloper, IComparable
    {
        string tool;
        public Builder(string tool)
        {
            this.tool = tool;
        }
        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }
        public void Create(string tool)
        {
            this.tool = tool;
        }
        public void Destroy()
        {
            this.tool = null;
        }
        public override string ToString()
        {
            return tool;
        }
        public int CompareTo(object obj)
        {            
            return String.Compare(this.tool, obj.ToString());
        }
    }
    internal class Program
    {
        const int COUNTOFDEVELOPERS = 6;
        const int COUNTOFPERSONS = 7;
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>(6);
            developers.Add(new Programer("C#"));
            developers.Add(new Builder("Hammer"));
            developers.Add(new Programer("Java"));
            developers.Add(new Builder("Sledgehammer"));
            developers.Add(new Programer("C++"));
            developers.Add(new Builder("Bolt"));
            Console.WriteLine("List:\n");
            foreach (IDeveloper i in developers){ 
                Console.WriteLine(i.ToString());
                string temp = i.ToString();
                i.Destroy();
                i.Create(temp);
            }
            developers.Sort();
            Console.WriteLine("\n\n\nSorted:\n");
            foreach (IDeveloper i in developers)
            {
                Console.WriteLine(i.ToString());
            }

            ///Task2
            
            Console.WriteLine("\n\n\nTask2\n\n\n");
            Dictionary<uint, string> persons = new Dictionary<uint, string>();
            for (int i = 0; i < COUNTOFPERSONS; i++)
            {
                Console.Write("Enter name of person : ");
                string name = Console.ReadLine();
                Console.Write("Enter id of person : ");
                uint id;
                while (!uint.TryParse(Console.ReadLine(), out id)) {
                    Console.Write("Enter correct id of person : ");
                }
                while (!persons.TryAdd(id, name)) {
                    do
                    {
                        Console.Write("Enter correct and unique id of person : ");
                    } while (!uint.TryParse(Console.ReadLine(), out id));
                }
                Console.WriteLine("\nPerson added\n");
                
            }

            Console.Write("Enter id to find person :");
            uint idToFind;
            while (!uint.TryParse(Console.ReadLine(), out idToFind))
            {
                Console.Write("Enter correct id of person : ");
            }
            string resName;
            if (persons.TryGetValue(idToFind, out resName))
            {
                Console.WriteLine($"Person you asked for : {resName}");
            }
            else 
            {
                Console.WriteLine("No person with id {0}", idToFind);
            }
            

        }
    }
}