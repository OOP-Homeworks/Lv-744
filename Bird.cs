using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_744
{
    internal class Bird: IFlyable
    {
        string name;
        bool canFly;

        public void Fly()
        {
            Console.WriteLine($"Info about Bird. Name={name} canFly={canFly}");
        }

        public Bird(string name, bool canFly)
        {
            this.name = name;
            this.canFly = canFly;
        }   

    }
}
