﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student
    {
        public string name; 
        public string id; 
        public int yearOfStudy; 

        public Student(string name, string id, int yearOfStudy)
        {
            this.name = name; 
            this.id = id; 
            this.yearOfStudy = yearOfStudy; 
        }

        public Student() 
        {
            name = Console.ReadLine();
            id = Console.ReadLine(); 
            yearOfStudy = Convert.ToInt32(Console.ReadLine()); 
        }

        public void PrintInfo()
        {
            Console.WriteLine(name); 
            Console.WriteLine(id); 
            Console.WriteLine(yearOfStudy+1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.PrintInfo();
            Console.ReadKey(); 
        }
    }
}