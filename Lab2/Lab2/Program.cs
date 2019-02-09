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
            string s = System.IO.File.ReadAllText(@"C:\Users\kabyk\Desktop\PP2_2019\Lab2\Lab2\text.txt.txt");
            bool ok = true;
            int k = s.Length;
            for (int i=0; i<k/2; i++)
            {
                if (s[i] != s[k - 1 - i])
                {
                    ok = false;
                    break;
                }

            }
             if (ok == true){
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
