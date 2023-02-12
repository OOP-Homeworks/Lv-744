﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_744
{
    internal class Programmer: IDeveloper
    {
        private string language;
        public string Tool { get; }

        public Programmer(string language)
        {
            this.language = language;
        }

        public void Create()
        {
            Console.WriteLine($"Create language is = {language}");
        }
        public void Destroy()
        {
            language = language.Remove(0);
            Console.WriteLine($"Delete language = {language}");
        }
        public int CompareTo(IDeveloper? otherObj)
        {
            if (otherObj == null) return 1;
            return string.Compare(Tool, otherObj.Tool);
        }

    }
}
