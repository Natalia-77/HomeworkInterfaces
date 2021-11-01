using System;
using System.Collections;

namespace Hanoi
{
    class Program
    {
        static Stack stack1 = new Stack();
        static Stack stack2 = new Stack();
        static Stack stack3 = new Stack();

        static void Main(string[] args)
        {
            stack1.Push(4);
            stack1.Push(3);
            stack1.Push(2);
            stack1.Push(1);
            State();
            ChangePos(4, stack1, stack3, stack2);

        }

        public static void ChangePos(int disks,Stack start,Stack end,Stack temp)
        {
            if (disks > 0)
            {
                ChangePos(disks - 1, start, temp, end);
                end.Push(start.Pop());
                State();
                ChangePos(disks - 1, temp, end, start);
            }

        }

        public static void State()
        {
            Console.Write("1:");
            foreach (var item in stack1)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
           

            Console.Write("2:");
            foreach (var item in stack2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
          
            Console.Write("3:");
            foreach (var item in stack3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------");
        }
    }
}
