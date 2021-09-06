using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            i += 10;

            while (i < 100)
            {
                i++;
            }

            AddNumbers(5, 15);
            AddNumbers(20);

            string[] myItems = { "Hej", "hopp", "hejsan" };
            PrintItems(5, "hej", "hejsan", "sdfsd");
            Console.WriteLine();
        }
        static void AddNumbers(int a = 5, int b = 100)
        {
            Console.WriteLine(a + b);
        }

        static void PrintItems(int i, params string[] items)
        {
            foreach (string s in items)
            {
                Console.WriteLine(s);
            }
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


        static byte MultiplyNumbers(int a, int b)
        {
            int myInt = 500;
            return (byte)myInt;
        }
    }
}
