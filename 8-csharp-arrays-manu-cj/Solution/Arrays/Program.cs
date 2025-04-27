namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution.ArrayInteger();
            int[] numbers = { 41, 51, 17, 45, 12 };
            Console.WriteLine(Solution.Sum(numbers));
            Console.WriteLine(Solution.Average(numbers));
            int max, min;
            Solution.MaxAndMin(numbers, out max, out min);
            Console.WriteLine($"Max: {max}, Min: {min}");
            Console.WriteLine(Solution.SortAndArray(numbers));
        }
    }
}
