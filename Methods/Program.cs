using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
         { /*
            PrintNumbersFiveTimes();
            Console.WriteLine();
            PrintText("Kalle");
            Console.WriteLine();
            PrintNumbersFiveTimes();
            */

            //int result = MultiplyNumbers(3, 4);
            Console.WriteLine(MultiplyNumbers(3, 4));
        }

        static void PrintNumbersFiveTimes()
        {
            for (int i = 0; i < 5; i++)
            {
                AddNumbers(10, i);
            }
        }

        static void PrintText(string text)
        {
            Console.WriteLine(text);
        }

        static void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static int MultiplyNumbers(int a, int b)
        {
            return a * b;
        }
    }
}
