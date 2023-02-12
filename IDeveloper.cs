using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_744
{
    internal interface IDeveloper : IComparable<IDeveloper>
    {
        public string Tool { get; }

        public void Create() { }
        public void Destroy() { }
    }
}
