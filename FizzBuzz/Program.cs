using System;

class FizzBuzz
{
    enum FizzBuzzConstants
    {
        Fizz,
        Buzz,
        Whizz
    }

    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(GetFizzBuzz(i));
        }
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

    public static bool IsDivisibleByThree(int num) => num % 3 == 0;

    public static bool IsDivisibleByFive(int num) => num % 5 == 0;

    public static bool IsDivisibleBySeven(int num) => num % 7 == 0;
}
