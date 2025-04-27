using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    public class Solution
    {
         public static int SumOfNumbers() {
            int sum = 0;
            for (int i = 0; i <= 99; i++)
            {
                sum ++;
            }
            return sum;
            
         }

         public static int Factorial(int n) {
            if (n < 0)
            {
                throw new ArgumentException("Need positive number");
            }

            int result = 1;
            int i = 1;
            while (i <= n)
            {
                result *= i;
                i++;
            }
            
            return result;
         }

         public static string Multiplicate()
         {
             StringBuilder result = new StringBuilder();
             for (int i = 1; i <= 10; i++)
             {
                 for (int j = 1; j <= 10; j++)
                 {
                     result.AppendLine($"{j} * {i} = {j * i}");
                 }
             }
             return result.ToString();
         }

         public static bool WhatIsANumber() {
            bool flag;
            do {
                Console.WriteLine("Please, enter a number between 1 and 10");

                string? number = Console.ReadLine();

                flag = int.TryParse(number, out int x) && x >= 1 && x <= 10;

            } while (!flag);

            return flag;
         }

         public static int LittleNumber()
         {
             int smallest = int.MaxValue;
             int number;

             Console.WriteLine("Enter number continuously enter 0 to stop:");
             while (int.TryParse(Console.ReadLine(), out number) && number != 0)
             {
                 smallest = number < smallest ? number : smallest;
             }

             return smallest == int.MaxValue ? 0 : smallest;
         }




    }
}
