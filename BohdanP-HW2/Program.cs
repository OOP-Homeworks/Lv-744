using System.Reflection;
using System.Security.AccessControl;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            float[] floaties = new float[3];
            floaties[0] = float.Parse(Console.ReadLine());
            floaties[1] = float.Parse(Console.ReadLine());
            floaties[2] = float.Parse(Console.ReadLine());
            bool in_range = true;

            foreach (float floatie in floaties) 
            {
                if ((floatie > 5.0) || (floatie < -5.0))
                {
                    in_range = false;
                    break;
                }
            }
            if (in_range == true)
                Console.WriteLine("ALL ARE IN RANGE [-5..5]");
            else
                Console.WriteLine("SOME ARE NOT IN RANGE");

            //2
            int[] inties = new int[3];
            inties[0] = int.Parse(Console.ReadLine());
            inties[1] = int.Parse(Console.ReadLine());
            inties[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Max is " + inties.Max() + "." + " Min is " + inties.Min());
            //3

            int num_error = int.Parse(Console.ReadLine());
            HTTPError curr_error = (HTTPError)num_error;
            Console.WriteLine(curr_error);
            //4

            Dog myDog;
            myDog.name = Console.ReadLine();
            myDog.mark = Console.ReadLine();
            myDog.age = byte.Parse(Console.ReadLine());

            Console.WriteLine(myDog.ToString());

            //5 additional
            Cat catthings = new();
            catthings.EatSomething();
            Console.WriteLine("Cat is " + catthings.catFullness + "% full.");
        }

        enum HTTPError : ushort
        {
            Bad_Request = 400,
            Unauthorized = 401,
            Payment_Required = 402,
            Forbidden = 403,
            Not_Found = 404
        }

        struct Dog
        {
            public string name;
            public string mark;
            public byte age;

            public override string ToString()
            {
                return (name + " " + mark + " " + age.ToString());
            }
        }
    }
}