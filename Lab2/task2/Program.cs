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
            int cnt = 0;
            string s = System.IO.File.ReadAllText(@"C:\Users\kabyk\Desktop\PP2_2019\Lab2\task2\input.txt");
            string[] ss = s.Split();
            int[] a = new int[ss.Length];
            string k = null;

            for (int i = 0; i < ss.Length; i++)
            {
                a[i] = int.Parse(ss[i]);
                if (a[i] == 1)
                {
                    cnt++;
                }
                for (int j = 2; j <= a[i] / 2; j++)
                {
                    if (a[i] % j == 0)

                    {
                        cnt++;
                    }
                }
                if (cnt == 0)
                {
                    k = k + a[i] + " ";
                }
                else
                {
                    cnt = 0;
                }
            }

            System.IO.File.WriteAllLines(@"C:\Users\kabyk\Desktop\PP2_2019\Lab2\task2\output.txt", k);

        }
    }
}
