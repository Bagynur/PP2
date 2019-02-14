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
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Users\kabyk\Desktop\PP2_2019"); //path of folder
            Director(dirinfo, 0); //use the function
        }
    }
        public static void Director(DirectoryInfo dir, int space) //fuction to output list of directories and files
        {
            foreach(DirectoryInfo y in dir.GetDirectories())
            {
                addspace(space); //use the addspace func
                Console.WriteLine(y.Name);  //output names of folders
                Director(y,space + 1); //using recursion repeat while the directories ends
            }
            foreach(FileInfo x in dir.GetFiles())
            {
                addspace(space); //adds spaces to file
                Console.WriteLine(x.Name); // outputs names of files
            }
        }
        public static void addspace(int space) //function to add spaces
        {
            for(int i=0; i<space; i++)
            {
                Console.Write("    ");
            }
        }
    }
}
