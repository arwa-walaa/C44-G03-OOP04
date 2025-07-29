using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsession4.PolyMorphismOverriding
{
    internal class TypeA
    {
        public int A {  get; set; }
       public TypeA(int a) { A = a; }

        public void func01() {
            Console.WriteLine("paernrt class");
        }
        public virtual void func02()
        {
            Console.WriteLine($"type A:  {A}");
        }

    }
}
