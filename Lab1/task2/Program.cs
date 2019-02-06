using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public string id;
        public int yos;

        public Student()
        {
            name = Console.ReadLine();
            id = Console.ReadLine();
            yos = Convert.ToInt16(Console.ReadLine());

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine(s);
        }
    }

}