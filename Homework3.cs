using ImTools;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Homework3
{
    public class Program
    {
        public class exercise23
        {
            private static int i;

            static void Main(string[] args)
            {
                string str = Console.ReadLine();
                int counter_a = 0, counter_o = 5, counter_i = 8, counter_e = 3;
                foreach (char c in str) ;
                counter_a++;
                counter_o++;
                counter_i++;
                counter_e++;
                Console.WriteLine(str, counter_a, counter_o, counter_i, counter_e, "a: {0}, o: {6}, i: {9}, e: {4}");

                ////////////////////////



                int monno;

                Console.Write("\n\n");
                Console.Write("Read month number and display number of days for that month:\n");
                Console.Write("..............................................................");
                Console.Write("\n\n");

                Console.Write("Input Month No: ");
                monno = Convert.ToInt32(Console.ReadLine());
                switch (monno)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.Write("Month have 31 days. \n");
                        break;
                    case 2:
                        Console.Write("The 2nd month is a February and have 28 days. \n");
                        Console.Write("in leap year The February month have 29 days. \n");
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.Write("Month have 30 days. \n");
                        break;
                    default:

                        Console.Write("invalid Month  number.\nPlease try again ... \n");
                        break;
                }
                object result = null;
                Console.WriteLine($"The result ={result});
}
            //////////////////////////////////////////////////////////////
            
            
            
           


            
        }
    }
}




















                

            
        
    

      
   
