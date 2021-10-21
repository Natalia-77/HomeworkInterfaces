using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase_Computer_Disk
{
    class Computer
    {
        int _countDisk;
        int _countPrintDevice;
        public Disk[] disks;
        public IPrintInformation[] prints;

        public Computer(int countDisk,int countPrintDevice)
        {
            _countDisk = countDisk;
            _countPrintDevice = countPrintDevice;
        }

        public void AddDevicePrinter(int index,IPrintInformation information)
        {           
            Console.WriteLine($"Now you create printer with index{index}");           
            information.Print("I am new printer device...");
        }

        public void AddDeviceMonitor(int index, IPrintInformation information)
        {
            Console.WriteLine($"Now you create monitor with index{index}");
            information.Print("I am new monitor device...");
        }

        public void AddDisk(int index)
        {
            Console.WriteLine($"Now you create Disk with index{index}");
            Disk disk = new();
            disk.Memory = "4.7Gb";
            disk.MemSize = 4;
        }

        public bool CheckDisk(string device)
        {
          
            return true;
        }


    }
}
