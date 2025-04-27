using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Solution
    {
        public static string IsAdult(int age) {
            
            return age > 18 ? "You are an adult" : "You are a child";
        }

        public static string EvenOrOdd(int number) {
            return number % 2 == 0 ? "Even" : "Odd";
        }

        public static int Add(int firstNumber, int secondNumber) {
            return firstNumber + secondNumber;
        }

        public static int Max(int firstNumber, int secondNumber) {
            return firstNumber > secondNumber ? firstNumber : secondNumber;
        }
    }
}
