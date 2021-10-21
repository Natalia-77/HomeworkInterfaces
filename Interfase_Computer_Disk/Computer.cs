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
            disks = new[]
            {
                new Flash("Flash"),
                new Flash("Flash no.2")                
            };   
                      
        }

        public bool CheckDisk(Flash flash)
        {
           return flash.HasDisk? true : false;
            
        }
        public string InsertReject(Flash flash) => flash.HasDisk ? "Can't reject" : "Reject is possible";

        public void ReadInfo()
        {
            Console.WriteLine($"Computer has disk{_countDisk} and {_countPrintDevice} devices");

            foreach (var item in disks)
            {
                Console.WriteLine($"{item.Name}");
            }
        }





    }
}
