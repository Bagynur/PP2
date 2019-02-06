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
            int a = int.Parse(Console.ReadLine());
            int [] bk = new int[a];

            List<int> BB = new List<int>();

            for (int i = 0; i < a; i++) 
            {
                bk[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < a; i++) 
            {
                int c = 0;
                if ((bk[i] != 1) && (bk[i] != 0)) 
                {
                    for (int j = 2; j < bk[i]; j++) 
                    {
                        if (bk[i]%j==0) 
                        {
                            c++;
                        }
                    }
                    if (c == 0) 
                    cnt++;
                    BB.Add(bk[i]);
                }
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < BB.Count(); i++)
            {
                Console.Write(BB[i] + " ");
            }

        }

    }
}
