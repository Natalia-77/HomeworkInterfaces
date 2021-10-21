using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase_Computer_Disk
{
    class Printer : IPrintInformation
    {
        public string GetName()
        {
            return "Printer Samsung working...";
        }

        public void Print(string info)
        {
            Console.WriteLine($"Printer printing {info}");
        }
    }
}
