namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: Calculator with overloaded Add methods
            Calculator calculator = new Calculator();
            Console.WriteLine("Add two integers: " + calculator.Add(5, 10)); // Output: 15
            Console.WriteLine("Add three integers: " + calculator.Add(5, 10, 15)); // Output: 30
            Console.WriteLine("Add two doubles: " + calculator.Add(5.5, 10.5)); // Output: 16.0
            #endregion
        }
    }
}
