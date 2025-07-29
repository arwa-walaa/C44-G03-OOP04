using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsession4.PolyMorphismOverriding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }
        public  new  void func01()
        {
            Console.WriteLine("child class");
        }
        public override void func02()
        {
            //base.func02();
            Console.WriteLine($"typeB: A: {A} B: {B}");
        }
    }
}
