using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppParametrizedConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student stud1 = new Student(12, "Sam", new DateTime(day: 12, month: 09, year: 2023));
            //Student stud2 = new Student(12, "Raina", new DateTime(day: 07, month: 09, year: 2000));
            //Console.WriteLine("**** Student 1 ****");
            //stud1.Display();
            //Console.WriteLine("**** Student 2 ****");
            //stud2.Display();

            Student student = new Student();
            student.Display();
            Student stud1 = new Student(12, "Sam", new DateTime(day: 12, month: 09, year: 2023));
            Console.WriteLine("**** Student 1 ****");
            stud1.Display();
            Console.ReadKey();
        }
    }
}
