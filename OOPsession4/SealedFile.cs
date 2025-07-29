using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsession4
{
    internal sealed class Parent
    {
        private int Salary;
        public virtual int salary
        {
            get { return Salary; }
            set { Salary = value-1000; }
        }

        public  virtual void Print()
        {
            Console.WriteLine("Parent Salary: " + Salary);
        }

    }
    class Child : Parent
    {
        override public int salary
        {
            get { return base.salary; }
            set { base.salary = value - 1500; } // Adding bonus to the salary
        }
        public override void Print()
        {
            Console.WriteLine("Hellow Child" );
        }
    }

}
