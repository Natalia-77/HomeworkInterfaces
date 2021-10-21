using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase_Computer_Disk
{
    class DVD:Disk,IRemoveableDisk
    {
        bool _hasDisk;
        public bool HasDisk { get => _hasDisk; }


        public void Insert()
        {
            Console.WriteLine("Insert from class DVD");
        }

        public void Reject()
        {
            Console.WriteLine("Reject from class DVD");
        }
        public string GetName()
        {
            return base.GetName();
        }
    }
}
