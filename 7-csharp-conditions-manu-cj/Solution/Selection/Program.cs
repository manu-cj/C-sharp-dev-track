namespace Selection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.CanEnterInTheCasino());
            Console.WriteLine(Solution.GetValidatedAge("23"));
            Console.WriteLine(Solution.SignOfNumber(20));
            try
            {
                Console.WriteLine(Solution.DiscountPriceCalculator(1, 100));

            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}
