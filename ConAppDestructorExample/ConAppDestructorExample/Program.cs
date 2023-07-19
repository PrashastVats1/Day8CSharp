using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDestructorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp obj = new Emp("Sam");
            //obj = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.ReadKey();
        }
    }
}
