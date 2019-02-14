using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // create int which will be length of an array
            for (int i = 1; i <= n; i++) // run through n
            {
                for (int j = 1; j <= i; j++) // run through columns
                {
                    Console.Write("[*]"); // print out symbols
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}