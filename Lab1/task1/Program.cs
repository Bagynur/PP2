using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int cnt = 0;
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            string s = Console.ReadLine();
            string[] ss = s.Split();

            for (int i = 0; i < n; i++) 
            {
                a[i] = int.Parse(ss[i]);
                if (a[i] == 1)
                {
                    c++;
                }
                for (int j = 2; j <= a[i] / 2; j++) 
                {
                    if (a[i] % j == 0)
                    {
                        c++;
                    }
                }
                if (c == 0)
                {
                    b[cnt] = a[i];
                    cnt++;
                }
                else
                {
                    c = 0;
                }
            }
            Console.WriteLine(cnt);
            for (int i=0;i<cnt;i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.ReadKey();
        }
            

    }
}
