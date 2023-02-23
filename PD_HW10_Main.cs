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
    internal class HW10
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            const int Size = 3;
            PD_Point start = new PD_Point(0, 0);
            int min_triangle = 0;
            int min_global = int.MaxValue;
            var list = new List<PD_Triangle>();
            for(int i = 0; i < Size; i++)
            {
                double min = double.MaxValue;
                
                PD_Point[] vertexes = new PD_Point[3];
                for (int j = 0; j < 3; j++)
                {
                    vertexes[j] = new PD_Point(rnd.NextDouble(), rnd.NextDouble());
                    if (vertexes[j].Distance(start) < min)
                        min = vertexes[j].Distance(start);
                }
                    

                list.Add(new PD_Triangle(vertexes[0], vertexes[1], vertexes[2]));
                try
                {
                    if (list[i].CheckValidness())
                    {
                        if (min < min_global)
                        {
                            min = min_global;
                            min_triangle = i;
                        }
                    }
                }
                catch(ArgumentException) 
                    { i--;}
            }

            list[min_triangle].Print();
        }
    }
}

