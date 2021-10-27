using System;
using System.Collections.Generic;
using System.Linq;

namespace ListString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> liststrings = new() {"Window","Api","Action","Redux","Reload" };
            List<string> sort = new(0);
            string max = string.Empty;

            for (int i = 0; i < liststrings.Count; i++)
            {
                if(max.Length<liststrings[i].Length|| max.Length == liststrings[i].Length)
                {                   
                    max = liststrings[i];
                    sort.Add(max);
                }               
            }   
            
            for (int i = 0; i < sort.Count-1; i++)
            {
                for (int j = i+1; j < sort.Count; j++)
                {
                   sort.Sort((i,j)=>string.Compare(i,j));
                }
            }

            Console.WriteLine("Sorted list in alphabetical order:");

            foreach (var item in sort)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("First element:");
            Console.WriteLine(sort.First());

        }
    }
}
