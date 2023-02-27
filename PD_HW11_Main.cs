using homework.h_w;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace homework
{
    internal class HW11
    {
        static void Main(string[] args)
        {
            var list = new List<List<object>>();
            PD_Accountancy accountancy = new PD_Accountancy();

            for (int i = 0; i < 8; i++)
            {
                PD_Student student = new PD_Student();
                PD_Parent parent = new PD_Parent();
                
                student.MarkChange += parent.OnMarkChange;
                student.MarkChange += accountancy.PayingFellowship;
                student.AddMark(new Random().Next(0, 100));
                list.Add(new List<object>());
                list[i].Add(student);
                list[i].Add(parent);
            }
        }
    }
}

