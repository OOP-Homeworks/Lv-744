using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task_5_2_2023
{
    class Program
    {



        static void Main(string[] args)
        {
            List<int> myColl = new List<int> { -10, 10, -10, 10, 24, -20, -10, 6, 10, 55 };

            for (int i = 0; i < myColl.Count; i++)
            {
                    
                if (i == myColl.IndexOf(-10))
                {
                    Console.WriteLine($"Integer -10 at position :{i} ");
                    myColl.Remove(myColl[i]);
                    myColl.Insert(i, 10);
                }
            }            
            //myColl = myColl.Select((value, index) => new { value, index }).Where(x => x.value == -10).Select(x => x.index).ToList();
            myColl.Insert(2, 1);
            myColl.Insert(8, -3);
            myColl.Insert(5, -4);
            myColl.RemoveAll(x => x > 20);
            myColl.Sort();
            foreach (int item in myColl)
            {
                Console.Write(" | " + item);
            }
          

        }
    }
}
