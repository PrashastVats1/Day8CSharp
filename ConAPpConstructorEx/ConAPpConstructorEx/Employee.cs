using System;

namespace ConAPpConstructorEx
{
    public class Employee
    {
        int id;
        string name;
        public Employee()
        {
            Console.WriteLine("Constructor of Employee");
            id = -1;
            name = "not given";
        }
        public void Register()
        {
            Console.WriteLine("Enter ID");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("ID: \t" + id);
            Console.WriteLine("Name: \t" + name);
        }
    }
}
