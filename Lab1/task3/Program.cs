using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();
            int[] a = new int[n * 2];
            for (int i = 0; i < n; i++)
            {
                a[i * 2] = int.Parse(arr[i]);
                a[i * 2 + 1] = a[i * 2];
            }
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}