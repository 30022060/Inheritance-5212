using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person FullName = new Person();
            Console.Write("Enter First Name: ");
            FullName.Fname = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            FullName.Lname = Console.ReadLine();

    }   }

    class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }

    }

    class Student : Person
    {
        public int Studentid { get; set; }

        public Student(int _studentid, string _fname, string _lname)
        {
            Fname = _fname;
            Lname = _lname;
            Studentid = _studentid;
        }
        public string StdDeets()
        {
            return $"{Fname}\n{Lname}\n{Studentid}";
        }
    }
    
}
