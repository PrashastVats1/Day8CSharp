using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAPpConstructorEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Display();
            Console.WriteLine("Lets go for registration");
            employee.Register();
            employee.Display();
            Console.ReadKey();
        }
    }
}
