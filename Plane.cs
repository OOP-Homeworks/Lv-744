using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_1_2023
{
    class Plane : IFlyable
    {
        string mark;
        uint highFly;
        public Plane(string mark, uint highFly)
        {
            this.mark = mark;
            this.highFly = highFly;
        }
        public void Fly()
        {
            Console.WriteLine($"Plane {mark} flying on {highFly} meters");
        }

    }
}
