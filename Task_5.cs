using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    interface IFlyable
    {
        void Fly();
    }

    interface IComparable<Plane>
    {
        Int32 CompareTo(Plane other);
    }

    class Bird : IFlyable
    {
        string nameBird;
        bool canFly;

        public void Fly()
        {
            if (canFly)
            {
                Console.WriteLine("{0} fly", nameBird);
            }
            else
            {
                Console.WriteLine("{0} can't fly", nameBird);
            }
        }

        public Bird(string nameBird, bool canFly)
        {
            this.nameBird = nameBird;
            this.canFly = canFly;
        }
    }

    class Plane : IFlyable, IComparable<Plane>
    {
        int IComparable<Plane>.CompareTo(Plane other)
        {
            return highFly-other.highFly;
        }
    
    
        string mark;
        int highFly;

        public void Fly()
        {
            Console.WriteLine("{0} fly high {1}", mark, highFly);
        }

        public Plane(string mark, int highFly)
        {
            this.mark = mark;
            this.highFly = highFly;
        }

        public int CompareTO(Plane plane1)
        {
            if (plane1.highFly < this.highFly)
            {
                return 1;
            }
            else if (plane1.highFly == this.highFly)
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
            Bird bird1 = new Bird("Voron", false);
            IFlyable bird2 = new Bird("Leleka", true);

            Plane plane1 = new Plane("Mria", 8888);
            IFlyable plane2 = new Plane("Bayractar", 5555);

            List<IFlyable> flights = new List<IFlyable>();

            flights.Add(bird1);
            flights.Add(bird2);
            flights.Add(plane1);
            flights.Add(plane2);
            flights[0].Fly();
            flights[1].Fly();
            flights[2].Fly();
            flights[3].Fly();

            if (plane1 == null)
            {
                flights[0].Fly();
            }

            Console.WriteLine();
            foreach (IFlyable aFlyyable in flights)
            {
                Console.WriteLine(aFlyyable);
            }

            Plane[] plains = new Plane[3];
            Array.Sort(plains);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
