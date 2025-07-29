using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Manager: Employee
    {
        public override void Work()
        {
            base.Work(); // Call base class method
            Console.WriteLine("Manager is managing");
        }
    }
}
