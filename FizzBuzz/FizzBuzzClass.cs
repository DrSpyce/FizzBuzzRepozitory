using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    static class FizzBuzzClass
    { 
        private enum FizzBuzzConstants
        {
            Fizz,
            Buzz,
            Whizz
        }

        public static string GetFizzBuzz(int number)
        {
            string result = string.Empty;

            if (IsDivisibleByThree(number))
                result += FizzBuzzConstants.Fizz;
            if (IsDivisibleByFive(number))
                result += FizzBuzzConstants.Buzz;
            if (IsDivisibleBySeven(number))
                result += FizzBuzzConstants.Whizz;
            if (result.Length == 0)
                result += number.ToString();

            return result;
        }

        private static bool IsDivisibleByThree(int num) => num % 3 == 0;

        private static bool IsDivisibleByFive(int num) => num % 5 == 0;

        private static bool IsDivisibleBySeven(int num) => num % 7 == 0;
    }
}
