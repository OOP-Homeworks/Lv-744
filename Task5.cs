using System.Drawing;

namespace Task_5
{
    
    interface IFlyable
    {
        void Fly();
    }
    class Bird : IFlyable
    {
        string name;
        bool canFly;
        public void Fly()
        {
            if (canFly)
            {
                Console.WriteLine($"{this.name} flying");
            }
            else
            {
                Console.WriteLine($"{this.name} cant flying");
            }

        }
        public Bird(string name, bool canFly)
        {
            this.name = name;
            this.canFly = canFly;
        }
    }
    class Plane : IFlyable
    {
        string mark;
        int hightFly;
        public void Fly()
        {
            Console.WriteLine($"{this.mark} flying in hight : {this.hightFly}");
        }
        public Plane(string mark, int hightFly)
        {
            this.mark = mark;
            this.hightFly = hightFly;
        }
    }
    internal class Program
    {
        const int LISTCOUNT = 10;
        static void Main(string[] args)
        {
            Bird b1 = new Bird("Solowey", true);
            IFlyable b2 = new Bird("Eagle", false);

            Plane p1 = new Plane("Boing", 10000);
            IFlyable p2 = new Plane("Mria", 99999);

            List<IFlyable> fliers = new List<IFlyable>();

            fliers.Add(b1);
            fliers.Add(b2);
            fliers.Add(p1);
            fliers.Add(p2);
            foreach (IFlyable i in fliers)
            {
                i.Fly();
            }

            //Task2

            List<int> myColl = new List<int>();
            for (int i = 0; i < LISTCOUNT; i++) {
                Console.WriteLine("Enter integer :");
                myColl.Add(Int32.Parse(Console.ReadLine())); ;
            }
            Console.WriteLine("\n\nYour Collection: \n");
            foreach (int i in myColl) {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n\n\n");
            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] == -10) {
                    Console.WriteLine($"Index of -10 is : {i + 1}");
                }
            }
            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] > 20)
                {
                    myColl.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Your Collection without >20 : \n");
            foreach (int i in myColl)
            {
                Console.WriteLine(i);
            }
            if (myColl.Count > 2)
                myColl.Insert(2, 1);
            if (myColl.Count > 8)
                myColl.Insert(8, -3);
            if (myColl.Count > 5)
                myColl.Insert(5, -4);
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Your Collection with added elements: \n");
            foreach (int i in myColl)
            {
                Console.WriteLine(i);
            }
            myColl.Sort();
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Your sorted Collection: \n");
            foreach (int i in myColl)
            {
                Console.WriteLine(i);
            }
        }
    }
}