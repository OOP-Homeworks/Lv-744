using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.h_w
{
    internal class PD_Student
    {
        public delegate void MyDel(int m);
        public event MyDel MarkChange;
        string name;
        List<int> marks = new List<int>();
        public void AddMark(int mark)
        {
            marks.Add(mark);
            MarkChange(mark);
        }

    }
}
