using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project8
{
    internal interface IHuman
    {
        string Name { get; set; }
        string Lastname { get; set; }
        int Age { get; set; }
        int StudentID { get; set; }

    }
}
