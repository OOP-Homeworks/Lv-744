using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Lecture5_744
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("\nTask#5");
            //showTask5();

            Console.WriteLine("\nHomework#5");
            showHomework5();

        }

        static void showTask5() 
        {
            
            /// task1
            /// 
            Bird myBird1 = new Bird("Vorona",true);
            IFlyable myBird2 = new Bird("Aist", false);

            Plane myPlane1 = new Plane("Airbus", 20);
            IFlyable myPlane2 = new Plane("Stels",30);

            List<IFlyable> flyables = new List<IFlyable>();
            flyables.Add(myBird1);
            flyables.Add(myBird2);
            flyables.Add(myPlane1);
            flyables.Add(myPlane2);
            foreach(IFlyable item in flyables) 
            {
                item.Fly();
            }

            /// task2
            /// 
            List<int> myColl = new List<int>();
            int myCollIndex = 10;
            Random rnd = new Random();
            Console.WriteLine("\nEnter collection of 10 int:");
            for(int i = 0; i < myCollIndex; i++) 
            {
                int k = rnd.Next(-10, 100);
                Console.WriteLine($"{i+1}. ={k}");
                //myColl.Add(Convert.ToInt32(Console.ReadLine()));
                myColl.Add(k);
            }

            Console.WriteLine("\nAll -10");
            var allEqulsMinus10 = myColl.FindAll( p => p == -10);
            //foreach (int findEquals in allEqulsMinus10)
            //{
            //    Console.WriteLine($"{findEquals}");
            //}
            Console.WriteLine(String.Join(", ", allEqulsMinus10));

            Console.WriteLine("\nReplease");
            myColl.Insert(2, 1);
            myColl.Insert(8, -3);
            myColl.Insert(5, -4);
            Console.WriteLine(String.Join(", ", myColl));

            Console.WriteLine("\nWithout greater 20");
            myColl.RemoveAll( p => p > 20 );
            Console.WriteLine(String.Join(", ",myColl));

            Console.WriteLine("\nSort");
            myColl.Sort();
            Console.WriteLine(String.Join(", ", myColl));

        }
        static void showHomework5()
        {

            /// hw1
            /// 
            List<IDeveloper> developer_builder_list = new List<IDeveloper>();
            developer_builder_list.Add(new Programmer("Python"));
            developer_builder_list.Add(new Programmer("C#"));
            developer_builder_list.Add(new Builder("Hammer"));
            developer_builder_list.Add(new Builder("Screwdriver"));
            foreach (IDeveloper item in developer_builder_list)
            {
                item.Create();
                item.Destroy();
            }
            developer_builder_list.Sort();

            /// hw2
            /// 
            Dictionary<uint, string> myDictionary = new Dictionary<uint, string>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter ID:");
                uint o = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Enter Name:");
                string l = Console.ReadLine();

                myDictionary.Add(o,l);

            }

            Console.WriteLine("\nEnter ID:");
            uint k = Convert.ToUInt32(Console.ReadLine());
            string m = string.Empty;
            if (myDictionary.TryGetValue(k, out m))
            {
                Console.WriteLine($"Yor name by ID is = {m}");
            }
            else
            {
                Console.WriteLine("Wrong ID!");
            }

        }

    }
}