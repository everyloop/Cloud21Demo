using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            SaySomething("Fredrik");
            AddNumbers(5, 3);
            AddNumbers(7, 13);
        }

        static void SayHello()
        {
            Console.WriteLine("Hello!");
        }
        
        static void SaySomething(string text)
        {
            Console.WriteLine(text);
        }

        static void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
