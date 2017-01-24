using System;

namespace _02_IntegerSign
{
    class Program
    {
        public static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.",number);
            }
            else if(number<0)
            {
                Console.WriteLine("The number {0} is negative.",number);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.",number);
            }
        }

        static void Main(string[] args)
        {
            //Create a method that prints the sign of an integer number n.

            int number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }
    }
}
