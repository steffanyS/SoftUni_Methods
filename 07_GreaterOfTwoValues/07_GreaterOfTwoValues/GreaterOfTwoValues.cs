using System;

namespace _07_GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        //You are given two values of the same type as input. 
        //The values can be of type int, char of string. 
        //Create a method GetMax() that returns the greater of the two values

        public static int GetMax(int firstNumber, int secondNumber)
        {
            int greater = Math.Max(firstNumber, secondNumber);
            return greater;
        }

        public static char GetMax(char firstChar, char secondChar)
        {
            char greater = firstChar;
            if (secondChar > firstChar)
            {
                greater = secondChar;
            }
            return greater;
        }

        public static string GetMax(string firstString, string secondString)
        {
            string greater = string.Empty;

            if (firstString.CompareTo(secondString) >= 0)
            {
                greater = firstString;
            }
            else
            {
                greater = secondString;
            }

            return greater;
        }

        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    int greaterInt = GetMax(firstInt, secondInt);
                    Console.WriteLine(greaterInt);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    char greaterChar = GetMax(firstChar, secondChar);
                    Console.WriteLine(greaterChar);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string greaterString = GetMax(firstString, secondString);
                    Console.WriteLine(greaterString);
                    break;
            }

        }
    }
}
