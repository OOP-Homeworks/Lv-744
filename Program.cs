using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sofserve
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberfirst = int.Parse(Console.ReadLine());
            int numbersecond = int.Parse(Console.ReadLine());
            ReadNumber(numberfirst, numbersecond);
        }
        static void Div(int n, int d) 
        {
            try
            {
               
               int s = n / d;

                Console.WriteLine(s);
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e.Message);
                
            }
            catch(FormatException e) 
            {
                Console.WriteLine(e.Message);
            }
            
        }
        static public int ReadNumber(int start, int end)
        {
            Console.WriteLine("Enter integer : ");
            int num = 1;

            for (int i = 0; i < 9; i++)
            {
                Console.Write("Enter correct integer : ");
            }
            
            if (num < start)
            {
                throw new Exception("Your number less than previous");
            }
            else if (num == start)
            {
                throw new Exception("Your number same to previous");
            }
            else if (num > end)
            {
                throw new Exception("Your number bigger than max");
            }
            else if (num == end)
            {
                throw new Exception("Your same to max");
            }
            return num;
        }

    }
 }

