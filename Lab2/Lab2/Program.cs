using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = System.IO.File.ReadAllText(@"C:\Users\kabyk\Desktop\PP2_2019\Lab2\Lab2\text.txt.txt"); // choose a file where we will read numbers
            bool ok = true; // create bool ok and write that it equal to true
            int k = s.Length; // int k equal to length of string s, to run cycle for
            for (int i=0; i<k/2; i++) // start of cycle
            {
                if (s[i] != s[k - 1 - i]) // if first half of the number is not equal to another part
                {
                    ok = false; // ok will be equal to the false
                    break; // it stop working further
                }

            }
             if (ok == true) // if ok is equal to true 
            { 
                Console.WriteLine("Yes"); // then print yes
            }
            else
            {
                Console.WriteLine("No"); // else no
            }
        }
    }
}
