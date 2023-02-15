using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class ReadNumber
    {
        public static double Double()
        {
        a: double res = 0;
            try
            {
                res = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a number");
                goto a;
            }
            return res;
        }
        public static double Double(string output)
        {
        a: Console.Write(output);
            double res = 0;
            try
            {
                res = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a number");
                goto a;
            }
            return res;
        }
    }
}
