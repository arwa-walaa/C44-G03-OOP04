using OOPsession4.PolyMorphismOverriding;
using OOPsession4.OpertaorOverloading;
namespace OOPsession4
{
    internal class Program
    {
        #region Methods overloading
        public static int sum(int a, int b)
        {
            return a + b;
        }

        public static double sum(double a, double b)
        {
            return a + b;
        }
        public static int sum(int a, int b,int d)
        {
            return a + b+d;
        }
        #endregion

        static void Main(string[] args)
        {
            #region Polymorphism
            //Console.WriteLine(sum(1, 2));
            //Console.WriteLine(sum(2, 3,4));
            //Console.Write(sum(3.5, 4.5));
            #endregion

            #region Overriding

            //TypeB typeB = new TypeB(1, 2);
            //typeB.func01();
            //typeB.func02();

            #endregion

            #region Operator Overloading
            Complex c1=new Complex() { Real=2,Imaginary = 3 };
            Complex c2 = new Complex() { Real = 2, Imaginary = 5 };
            Complex c3 = default;
            c3 = c1 + c2;
            Complex c4 = default;
            //c4 = c1 - c2;
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine("=================");
            //Console.WriteLine(c3);
            //Console.WriteLine("=================");
            //Console.WriteLine(c4);
            //c3++;
            //Console.WriteLine(c3);
            //if(c1>c2)
            //{
            //    Console.WriteLine("c1 is greater than c2");
            //}
            //else if(c1<c2)
            //{
            //    Console.WriteLine("c2 is greater than c1");
            //}
            //else
            //{
            //    Console.WriteLine("c1 is equal to c2");
            //}

            #endregion
            #region Casting Operator Overloading
            //Complex c5 = new Complex() { Real = 2, Imaginary = 3 };

            //int Y = (int)c5 ; // Implicit conversion from Complex to int
            ////recomended to use explicit conversion
            //string str =c5;
            //Console.WriteLine( str);
            #endregion

            #region static Class

            //Console.WriteLine(Helper.CmToInch(30));
            //Console.WriteLine(Helper.calacCircleArea(20));
            //Helper helper = new Helper(10, 20);
            //Console.WriteLine( helper.CmToInch(12));
            //Console.WriteLine(helper.calacCircleArea(5));

            #endregion
            #region Sealed Class
            //Parent parent = new Parent();
            ////parent.salary = 1000;
            //parent.Print();

            #endregion



        }

    }
}
