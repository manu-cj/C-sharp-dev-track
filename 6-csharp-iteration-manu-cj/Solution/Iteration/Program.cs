namespace Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(Solution.SumOfNumbers());

            try
            {
                Console.WriteLine(Solution.Factorial(5));
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(Solution.Multiplicate());
            Console.WriteLine(Solution.WhatIsANumber());
            Console.WriteLine(Solution.LittleNumber());
        }
    }
}
