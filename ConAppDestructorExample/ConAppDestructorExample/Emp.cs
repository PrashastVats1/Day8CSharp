using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDestructorExample
{
    public class Emp
    {
        string name;
        public Emp(string name)
        {
            this.name = name;
            Console.WriteLine("employee Constructor called");
            Console.WriteLine("Stored name: \t" + name);
        }
        ~Emp()
        {
            Console.WriteLine("Destructor called");
            Console.WriteLine("Name is: \t" + name);
        }
    }
}
