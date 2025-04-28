using System;

namespace Methods
{
    public class Solution
    {
      public static int Sum(int firstNumber, int secondNumber)
       {
          return firstNumber + secondNumber;
       }

       public static string Whos(string firstname, string lastname, int age)
       {
        return $"Firstname : {firstname}\nLastname : {lastname}\nAge : {age}";
       }

      public static string SumAndProduct(int firstNumber, int secondNumber, out int sum, out int product)
      {
          sum = firstNumber + secondNumber;
          product = firstNumber * secondNumber;
          return $"Sum: {sum}, Product: {product}";
      }

      public static (int quotient, int remainder) QuotientAndRemainder(int firstNumber, int secondNumber) 
      {
        return (
          firstNumber / secondNumber,
          firstNumber % secondNumber
        );
      }

      public static int MethodWithDefaultValue(int value = 10)
      {
        return value * 2; 
      }


    }
}
