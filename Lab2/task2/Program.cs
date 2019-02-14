using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0; //create counter
            string s = System.IO.File.ReadAllText(@"C:\Users\kabyk\Desktop\PP2_2019\Lab2\task2\input.txt"); // path of folder
            string[] ss = s.Split(); //creating new array and split elements of the array
            int[] a = new int[ss.Length]; //creating new array with legth of ss array
            string k = null; // create string k and equal it to null
            for (int i = 0; i < ss.Length; i++) // run through the loop
            {
                a[i] = int.Parse(ss[i]); 
                if (a[i] == 1) // if in array it find the number 1
                {
                    cnt++; // it add 1 to counter
                }
                for (int j = 2; j <= a[i] / 2; j++) //if number is prime, then we need to check whether number is divisible till itself
                {
                    if (a[i] % j == 0) // if it divides to numbers in interval between 1 and itself, then it is not prime
                    {
                        cnt++;
                        break;
                    }
                }
                if (cnt == 0) // if counter equal to 0
                {
                    k = k + a[i] + " "; // it add the numbers which is prime
                }
                else
                {
                    cnt = 0; // it continue to search
                }
            }
            System.IO.File.WriteAllText(@"C:\Users\kabyk\Desktop\PP2_2019\Lab2\task2\output.txt", k); // path of folder where it should write prime numbers
        }
    }
}