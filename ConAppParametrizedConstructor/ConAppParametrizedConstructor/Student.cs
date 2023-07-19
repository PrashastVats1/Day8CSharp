using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppParametrizedConstructor
{
    public class Student
    {
        readonly int id;
        readonly string name;
        readonly DateTime dob;

        //constructor overloading example-> when 2 or more
        //constructors of same name are called having different parameters
        public Student()
        {
            Console.WriteLine("Default Constructor");
            id = -1;
            name = "not given";
            dob = DateTime.Now;
        }
        public Student(int id, string name, DateTime dob)
        {
            Console.WriteLine("Parameterized constructor of Student");
            this.id = id;
            this.name = name;
            this.dob = dob;
        }
        public void Display()
        {
            Console.WriteLine("Student details are as follows!!");
            Console.WriteLine("ID -> " + id + "\t Name -> " + name + "\t Date of Birth -> " + dob);
        }
    }
}
