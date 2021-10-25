using System;

namespace Interfase_Computer_Disk
{
    class Program
    {
        static void Main(string[] args)
        {

            //Computer computer = new Computer(2, 4);
            //computer.AddDisk(3);
            //computer.ReadInfo();

            Flash flash = new Flash()
            {
                Memory = "4.9",
                MemSize = 4,
                Name = "Flash no.3"
            };

            IRemoveableDisk removeable = flash;
            removeable.Reject();

            Printer printer = new Printer();

            IPrintInformation printInformation = printer;
            printInformation.Print(" some text ");



        }
    }
}
