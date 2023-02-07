using System;

namespace HW_6_2023
{
    class Program
    {
        public static int Div(int i1, int i2)
        {
            return i1 / i2;
        }
        public static double DivD(double i, double j)
        {
            return i / j;
        }
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter two int numbers");
                Console.Write(" Enter first int : ");
                int inp1 = Int32.Parse(Console.ReadLine());
                Console.Write("Enter second int : ");
                int inp2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine(Div(inp1, inp2));
                if (inp1 % inp2 == 1 && inp2 > inp1)
                {
                    throw new Exception("input exeption");
                }
                Console.WriteLine("Enter two double numbers");
                Console.Write(" Enter first double : ");
                double in1 = Double.Parse(Console.ReadLine());
                Console.Write("Enter second int : ");
                double in2 = Double.Parse(Console.ReadLine());
                Console.WriteLine(DivD(in1, in2));
                if (in2 > in1)
                {
                    throw new Exception("input exeption");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exeption. Enter integer number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException");
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            ReadNumber(1, 100);
            Mein();

        }
        public static int ReadNumber(int start, int end)
        {
            Console.WriteLine("//////////   Method ReadNumber   //////////");
            try
            {  
                Console.Write("Enter New Integer to check it in the renge : ");
                int input = Int32.Parse(Console.ReadLine());
                if (input < start && input > end)
                {
                    throw new ArgumentOutOfRangeException("Argument is out of renge!");
                }
                else
                {
                Console.WriteLine($"Your integer {input} is in the renge {start} - {end}");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ApplicationException ap)
            {
                Console.WriteLine(ap.Source);
            }
            finally
            {
                Console.WriteLine($"End of Method ReadNumber");
            }
            return start + '-' + end;


        }
        public static int Mein()
        {
            const int maxInt = 10;
            Random rand = new Random();
            Console.WriteLine("//////////   Method Main   //////////");
            for (int i = 0; i < maxInt; i++)
            {
                Console.WriteLine(rand.Next(1,100));
            }
            return maxInt;

        }
    }
}
