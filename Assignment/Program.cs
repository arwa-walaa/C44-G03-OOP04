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
            Rectangle rect1 = new Rectangle(); 
            Rectangle rect2 = new Rectangle(5, 10);
            Rectangle rect3 = new Rectangle(7); 
            Console.WriteLine($"Rect1: Width = {rect1.Width}, Height = {rect1.Height}");
            Console.WriteLine($"Rect2: Width = {rect2.Width}, Height = {rect2.Height}"); 
            Console.WriteLine($"Rect3: Width = {rect3.Width}, Height = {rect3.Height}");
            #endregion


        }
    }
}
