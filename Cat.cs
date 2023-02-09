using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_744
{
    enum Food { Fish, Mouse }

    internal class Cat
    { 

        public string name;
        private int fullnessLevel;

        public Cat(string name)
        {
            this.name = name;
        }

        public Food FullnessLevel
        {
            set
            {
                if (value == Food.Mouse)
                {
                    this.fullnessLevel = 50;
                }
                else if (value == Food.Fish)
                {
                    this.fullnessLevel = 90;
                }
                else
                {
                    this.fullnessLevel = 0;
                }
            }
        }
        public override string ToString()
        {
            return string.Format($"Cat's name={name} fullnessLevel={fullnessLevel}");
        }

    }
}
