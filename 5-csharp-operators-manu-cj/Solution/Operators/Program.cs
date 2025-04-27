namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine($"You entered: {age}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }
            Console.WriteLine(Solution.IsAdult(age));

            Console.WriteLine(Solution.EvenOrOdd(6));
            Console.WriteLine(Solution.Add(1,5));
            Console.WriteLine(Solution.Max(1,6));
        }
    }
}
