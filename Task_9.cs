using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            /*Create a collection(array) of 10 integers numbers */

            int[] numbers = new int[11];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-200, 201);
            }

            Console.WriteLine("Random numbers:");
            foreach (int i in numbers)
            {
                Console.Write(" {0},", i);
            }

            // Get and display only negative numbers on the console

            Console.WriteLine("\n\nNegative numbers:");
            IEnumerable<int> negative = numbers.Where(i => i < 0);
            foreach (int i in negative)
            {
                Console.Write(" {0},", i);
            }

            // Get and display only positive numbers on the console

            Console.WriteLine("\n\nPositive numbers:");
            IEnumerable<int> positive = numbers.Where(i => i > 0);
            foreach (int i in positive)
            {
                Console.Write(" {0},", i);
            }

            // Get the largest and smallest elements from the array, and find the sum of all elements of the array.

            Console.WriteLine("\n\nLargest num: {0}\n Smallest num: {1}\n Sum: {2}", numbers.Max(), numbers.Min(), numbers.Sum());

            // Get the first largest element in array that is smaller than the Average of elements in array 

            Console.WriteLine("\n\nFirst small num: {0}", numbers.Where(i => i< numbers.Average()).Max());

            // Sort the array using OrderBy

            Console.WriteLine("\n\nSort OrderBy:");
            IEnumerable<int> sortedNum = numbers.OrderBy(i => i);
            foreach (int i in sortedNum)
            {
                Console.Write(" {0},", i);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
