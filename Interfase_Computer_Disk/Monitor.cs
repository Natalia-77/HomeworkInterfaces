using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase_Computer_Disk
{
    class Monitor : IPrintInformation
    {
        public string GetName()
        {
            return "Monitor HP working...";
        }

        public void Print(string info)
        {
            Console.WriteLine($"Monitor displaying {info}");
        }
    }
}
