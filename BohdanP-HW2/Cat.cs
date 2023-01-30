using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW2
{
    internal class Cat
    {
        private byte fullness_level;
        public void EatSomething()
        {
            Console.WriteLine("Feed the cat with EAT keyword\r\n /\\_/\\\r\n( o.o )\r\n > ^ <");
            string keyword = Console.ReadLine();
            if (keyword == "EAT")
            {
                Array values = Enum.GetValues(typeof(Food));
                Random random = new();
                Food randomFood = (Food)values.GetValue(random.Next(values.Length));
                fullness_level += (byte)randomFood;
                Console.WriteLine("The cat got some " + randomFood);
            }
        }
        public byte catFullness
        {
            get { return fullness_level; }
            set { fullness_level = value; }
        }

        enum Food : byte
        {
            Fish = 25,
            Milk = 10,
            Mice = 30,
            Rat = 50
        }
    }
}
