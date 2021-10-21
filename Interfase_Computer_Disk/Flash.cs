using System;

namespace Interfase_Computer_Disk
{
    class Flash:Disk,IRemoveableDisk
    {
        bool _hasDisk;
        public bool HasDisk { get => _hasDisk; }

      
        public void Insert()
        {
            Console.WriteLine("Insert from class Flash");
        }

        public void Reject()
        {
            Console.WriteLine("Reject from class Flash");
        }
        public  string GetName()
        {
            return base.GetName();
        }
    }
}
