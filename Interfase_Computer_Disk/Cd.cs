using System;

namespace Interfase_Computer_Disk
{
    class Cd : Disk, IRemoveableDisk
    {
        bool _hasDisk;
        public bool HasDisk {get=>_hasDisk;}

       
        public void Insert()
        {
            Console.WriteLine("Insert from class CD");
        }

        public void Reject()
        {
            Console.WriteLine("Reject from class CD");
        }
        public new string GetName()
        {
            return base.GetName();
        }

    }
}
