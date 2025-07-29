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
            Console.WriteLine(sum(1, 2));
            Console.WriteLine(sum(2, 3,4));
            Console.Write(sum(3.5, 4.5));
            #endregion
        }
    }
}
