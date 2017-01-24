﻿using System;

namespace _03_PrintingTriangle
{
    class Triangle
    {
        public static void PrintTriangle(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }

            for (int row = number; row >= 1; row--)
            {
                for (int col = 1; col < row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }
    }
}
