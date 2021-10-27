using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listint = new();
            List<bool> listbool = new();
            List<double> listdouble = new();

            ArrayList arrayList = new ArrayList();
            
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                if (i == 2 || i == 5 || i == 8)
                {
                    arrayList.Add(Math.Round((random.NextDouble() * (10 - 1) + 1), 2));
                }
                if (i == 1 || i == 6)
                {
                    arrayList.Add(random.Next(2) == 1);
                }
                arrayList.Add(random.Next(1, 90));
            }

            foreach (var item in arrayList)
            {
                Console.Write(item + "   ");
            }
            Console.WriteLine("-------------------\n");

            for (int i = 0; i < arrayList.Count; i++)
            {

                if (arrayList[i] is int )
                {
                    listint.Add((int)arrayList[i]);
                    //Console.WriteLine(arrayList[i]);                   
                }
                if (arrayList[i] is bool)
                {
                    listbool.Add((bool)arrayList[i]);
                    //Console.WriteLine("Boollll:"+arrayList[i]);
                }
                if (arrayList[i] is double)
                {
                    listdouble.Add((double)arrayList[i]);
                    //Console.WriteLine("Boollll:"+arrayList[i]);
                }

            }

            Console.WriteLine("List of int:");
            foreach (var ints in listint)
            {
                Console.Write(ints+"  ");
            }
            Console.WriteLine();

            Console.Write("List of boll:");
            foreach (var bools in listbool)
            {
                Console.Write(bools+"  ");
            }
            Console.WriteLine();

            Console.WriteLine("List of double:");
            foreach (var doubles in listdouble)
            {
                Console.Write(doubles+"  ");
            }

        }
    }
}
