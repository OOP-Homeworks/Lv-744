namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();

            int repeats = 10;
            try
            {
                //Task 1-2
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();
                Console.WriteLine(Div(s1, s2));

                int[] ints = new int[repeats];
                
                    for (int i = 0; i < repeats; i++)
                    {
                    try
                    {
                        ints[i] = pr.ReadNumber(1, 100);
                    
                        if (i > 0)
                            if (ints[i] <= ints[i - 1])
                            {
                                throw new ArgumentOutOfRangeException("Number doesn't fit in");
                            }
                    }
                    catch (ArgumentOutOfRangeException e)
                        {
                        Console.WriteLine(e.Message);
                        continue;
                        }
                    }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        internal static int Div(string a, string b)
        {
            try
            {
                bool isInt = true;
                double a_dnum , b_dnum;
                int a_inum, b_inum;
                if (a.Contains(','))
                {
                    a_dnum = double.Parse(a);
                    isInt = false;
                }
                if (b.Contains(','))
                {
                    b_dnum = double.Parse(b);
                    isInt = false;
                }

                if (isInt == false)
                {
                    throw new FormatException("***ERROR***\n You probably have entered double numbers (not acceptable)");
                }
                else
                {
                    a_inum = int.Parse(a);
                    b_inum = int.Parse(b);

                    return a_inum / b_inum;
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        internal int ReadNumber(int start, int end)
        {
            try { 
            int testnum = Convert.ToInt32(Console.ReadLine());
                if ((testnum >= start) && testnum <= end)
                {
                    return testnum;
                }
                else
                    throw new ArgumentOutOfRangeException("Numbers are out of range");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}