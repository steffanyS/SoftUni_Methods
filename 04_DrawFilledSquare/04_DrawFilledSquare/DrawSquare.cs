using System;

namespace _04_DrawFilledSquare
{
    class DrawSquare
    {
        public static void DrawFrame(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        public static void DrawBody(int n)
        {
            Console.Write('-');

            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine('-');
        }

        public static void Square(int n)
        {
            DrawFrame(n);

            for (int i = 0; i < n-2; i++)
            {
                DrawBody(n);
            }

            DrawFrame(n);
        }

        static void Main(string[] args)
        {
            //Draw at the console a filled square of size n

            int n = int.Parse(Console.ReadLine());
            Square(n);
        }
    }
}
