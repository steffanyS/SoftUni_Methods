using System;

namespace _08_MultiplyEvensByOdds
{
    class Multiply
    {
        public static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (Math.Abs(number) > 0)
            {
                int lastDigit = number%10;
                if (lastDigit%2 != 0)
                {
                    sum += lastDigit;
                }
                number/=10;
            }
            return sum;
        }

        public static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (Math.Abs(number) > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }

        public static int MultiplyOddAndEvenDigits(int number)
        {
            int oddSum = GetSumOfOddDigits(number);
            int evenSum = GetSumOfEvenDigits(number);
            int result = oddSum*evenSum;

            return result;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiply = MultiplyOddAndEvenDigits(number);
            Console.WriteLine(multiply);
        }
    }
}
