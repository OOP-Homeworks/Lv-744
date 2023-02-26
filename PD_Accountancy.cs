using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.h_w
{
    internal class PD_Accountancy
    {
        static int minimalMark = 85;
        public void PayingFellowship(int mark)
        {
            Console.WriteLine("Fellowship will " + (mark > minimalMark ?"":"not ") + "be paid");
        }
    }
}
