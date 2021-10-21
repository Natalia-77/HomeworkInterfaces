using System;

namespace Interfase_Computer_Disk
{
    class Disk : IDisk
    {
        private string _memory;

        public string Memory { get => _memory; set => _memory = value; }

        private int _memSize;
        public int MemSize { get => _memSize; set => _memSize = value; }

        public Disk()
        {

        }

        public Disk(string memory,int memSize)
        {
            Memory = memory;
            MemSize = memSize;
        }

        public string GetName()
        {
            return Memory;
        }
        public string Read()
        {
            return "I read you everyday.";
        }

        public void Write(string text)
        {
            Console.WriteLine($"I wrote to you this :{text}");
        }
    }
}
