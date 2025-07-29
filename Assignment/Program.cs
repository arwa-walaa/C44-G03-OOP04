namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: Calculator with overloaded Add methods
            //Calculator calculator = new Calculator();
            //Console.WriteLine("Add two integers: " + calculator.Add(5, 10)); // Output: 15
            //Console.WriteLine("Add three integers: " + calculator.Add(5, 10, 15)); // Output: 30
            //Console.WriteLine("Add two doubles: " + calculator.Add(5.5, 10.5)); // Output: 16.0
            #endregion

            #region Q2: Rectangle with multiple constructors
            //Rectangle rect1 = new Rectangle(); 
            //Rectangle rect2 = new Rectangle(5, 10);
            //Rectangle rect3 = new Rectangle(7); 
            //Console.WriteLine($"Rect1: Width = {rect1.Width}, Height = {rect1.Height}");
            //Console.WriteLine($"Rect2: Width = {rect2.Width}, Height = {rect2.Height}"); 
            //Console.WriteLine($"Rect3: Width = {rect3.Width}, Height = {rect3.Height}");
            #endregion

            #region Q3: Complex Number with operator overloading
            //Complex c1 = new Complex(3, 4);
            //Complex c2 = new Complex(1, 2);
            //Console.WriteLine(c1 + c2);
            //Console.WriteLine(c1 - c2);
            #endregion

            #region Q4: Employee and Manager with method overriding
            //Employee emp = new Employee();
            //emp.Work(); 
            //Manager mgr = new Manager();
            //mgr.Work();
            #endregion

            #region Q5: BaseClass with override vs new
            //BaseClass baseObj = new BaseClass();
            //baseObj.DisplayMessage(); // Output: Message from BaseClass
            //DerivedClass1 derivedObj1 = new DerivedClass1();
            //derivedObj1.DisplayMessage(); // Output: Message from DerivedClass1 (override)
            //DerivedClass2 derivedObj2 = new DerivedClass2();
            //derivedObj2.DisplayMessage(); // Output: Message from DerivedClass2 (new)

            /*
             Difference between override and new
                - `override` allows a derived class to provide a specific implementation of a method that is already defined in its base class.
                - `new` hides a method in the base class with a new implementation in the derived class, but does not override it.
             
             */

            #endregion

            #region part2 Q3

           // Duration D1 = new Duration(1, 10, 15);
           //Console.WriteLine( D1.ToString());

           // Duration D4 = new Duration(3600);
           // Console.WriteLine(D4.ToString());

           // Duration D2 = new Duration(7800);
           // Console.WriteLine(D2.ToString());

           // Duration D3 = new Duration(666);
           // Console.WriteLine(D3.ToString());


            #endregion

        }
    }
}
