using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Solution
    {
        public static void ArrayInteger() 
        {
            int[] array = new int[10];
            Random random = new Random();
            int number = random.Next(1, 11); 

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 11);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }
        }

        public static int Sum(int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static double Average(int[] numbers)
        {
            int sum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return (double)sum / numbers.Length;
        }

        public static void MaxAndMin(int[] numbers, out int max, out int min)
        {
            max = numbers[0];
            min = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                else if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
        }

        public static int[] SortAndArray(int[] numbers) {
            Array.Sort(numbers);
            return numbers;
        }

        public static string Palindrome(int[] numbers) 
        {
            int[] numbersNotRevesed = (int[])numbers.Clone();
            Array.Reverse(numbers);
            if (numbers.SequenceEqual(numbersNotRevesed))
            {
                return "The array is a palindrome";
            } 
            else 
            {
                return "The array is not a palindrome";
            }
        }
    }
}
