using System;

namespace Selection
{
    public class Solution
    {

        public static String CanEnterInTheCasino()
        {
            Console.WriteLine("Please enter your age: ");


            string input = Console.ReadLine() ?? string.Empty;

            try
            {
                int.TryParse(input, out int age);
                if (age >= 18)
                {
                    return "You can enter! Be welcome!";
                }
                else
                {
                    return "Sorry, you can't enter! Be patient!";
                }
            }
            catch (FormatException ex)
            {
                return ex.Message;
            }

        }


        public static int GetValidatedAge(string input)
        {
            if (!int.TryParse(input, out int age))
            {
                throw new FormatException("Invalid Age");
            }

            if (age < 0 || age > 110)
            {
                throw new FormatException("Invalid Age");
            }

            return age;
        }



        public static string SignOfNumber(int number)
        {
            if (number > 0)
            {
                return "The number is positive.";
            }
            else if (number < 0)
            {
                return "The number is negative.";
            }
            else
            {
                return "The number is zero.";
            }
        }

        public static double DiscountPriceCalculator(int discount, double price)
        {
            if (price < 0)
            {
                throw new FormatException("Invalid Price");
            }
            else
            {
                switch (discount)
                {
                    case 0:
                        return price;
                    case 1:
                        return price - (price * 0.10);
                    case 2:
                        return price - (price * 0.05);
                    case 3:
                        return price - (price * 0.20);
                    default:
                        if (discount < 0)
                        {
                            throw new ArgumentException("Invalid choice. Please enter a number between 1 and 3.");
                        }
                        else
                        {

                            throw new ArgumentException("Invalid choice. Please enter a number between 1 and 3.");
                        }
                }

            }
        }

        public static String TriangleClassification(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "Invalid triangle";
            }
            else if (a == b && b == c)
            {
                return "The triangle is equilateral.";
            }
            else if (a == b || b == c || a == c)
            {
                return "The triangle is isosceles.";
            }
            else
            {
                return "The triangle is scalene.";
            }
        }
    }
}
