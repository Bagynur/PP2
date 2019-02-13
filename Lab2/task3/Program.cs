using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Users\kabyk\Desktop\PP2_2019");
            Director(dirinfo, 0);
        }
        public static void Director(DirectoryInfo dir, int space)
        {
            foreach(DirectoryInfo y in dir.GetDirectories())
            {
                addspace(space);
                Console.WriteLine(y.Name);
                Director(y,space + 1);
            }
            foreach(FileInfo x in dir.GetFiles())
            {
                addspace(space);
                Console.WriteLine(x.Name);
            }
        }
        public static void addspace(int space)
        {
            for(int i=0; i<space; i++)
            {
                Console.Write("    ");
            }
        }
    }
}
