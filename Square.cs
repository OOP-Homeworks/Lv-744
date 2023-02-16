using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8_2023
{
    class Square : Shapes
    {
        private int side;
        private string size;
        public int Side { get { return side; } }
        public string Size { get { return size; } }

        public Square(string name, int side, string size) : base(name)
        {
            this.size = size;
            this.side = side;
        }
        public override  double Area()
        {
            return side * side;   
        }

        public override  double Perimeter()
        {
            return 4 * side;    
        }
        public override void Print()
        {
            Console.WriteLine("Square method Print :\n{0} have Area : {1:###.##} and Perimeter :{2:###.##} Size : {3}",name,Area(),Perimeter(),size);
        }
    }
}
