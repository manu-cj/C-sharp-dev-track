using System;
using System.Security.Cryptography;

namespace Variables
{
    public class Solution
    {
        public static string SayHello(string name)
        {
            return $"Hello {name}";
        }

        public static float AgeToFloat(int age) {
            return (float)age / 2;
        }

        public static double CelciusToFarenheit(double degrer) {
            return degrer * 1.8 + 32;
        }

        public static double KilometersToMiles(int km) {
            return Math.Round(km / 1.6, 1);
        }

        public static int RandomNumber() {
            Random random = new Random();
            int number = random.Next(1, 100);
            return number;
        }
    }


}
