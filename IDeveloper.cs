using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    interface IDeveloper
    {
        public string Tool { get; set; }

        public void Create() { }
        public void Destroy() { }

    }
}
