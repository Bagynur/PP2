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
            string[] arr = Console.ReadLine();
            int[] a = new int[n * 3];
            for (int i = 0; i < n; i++)
            {
                a[i * 3] = int.Parse(arr[i]);
                a[i * 3 + 1] = a[i * 3];
                a[i * 3 + 2] = a[i * 3];
            }
            for (int i = 0; i < n * 3; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }
    }
}